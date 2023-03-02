using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Text;

namespace OperationLogDisplay
{
    static class CommonModule
    {
        /// <summary>
        /// フォルダの末尾の「\」を保証する
        /// </summary>
        /// <param name="strCheckFolder">チェック対象のフォルダ名称</param>
        /// <returns>チェック後のフォルダ名称</returns>
        /// <remarks></remarks>
        public static string IncludeTrailingPathDelimiter(string strCheckFolder)
        {
            string IncludeTrailingPathDelimiter;
            try
            {
                if (strCheckFolder.Substring(strCheckFolder.Length - 1, 1) == @"\")
                    IncludeTrailingPathDelimiter = strCheckFolder;
                else
                    IncludeTrailingPathDelimiter = strCheckFolder + @"\";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "【IncludeTrailingPathDelimiter】", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            return IncludeTrailingPathDelimiter;
        }

        /// <summary>
        /// 操作履歴ログの書込処理
        /// </summary>
        /// <param name="strOutPutData">操作履歴メッセージ</param>
        /// <remarks></remarks>
        public static void OutPutLogFile(string strOutPutData)
        {
            string strOutPutFolder;
            string strOutPutFileName;
            string strYYYYMMDDvalue;
            string strHHMMSSvalue;
            string strPutMessage;

            lock (PubConstClass.objSyncHist)
            {
                try
                {
                    DateTime dtNow = DateTime.Now;

                    // 指定した書式で日付を文字列に変換する
                    string strNowFormat = dtNow.ToString("yyyy/MM/dd HH:mm:ss");

                    {
                        var withBlock = DateTime.Now;
                        strYYYYMMDDvalue = string.Format("{0:D4}{1:D2}{2:D2}", withBlock.Year, withBlock.Month, withBlock.Day);
                        strHHMMSSvalue = string.Format("{0:D2}{1:D2}{2:D2}", withBlock.Hour, withBlock.Minute, withBlock.Second);
                    }

                    // 格納フォルダ名の設定
                    strOutPutFolder = IncludeTrailingPathDelimiter(Application.StartupPath) + @"OPHISTORYLOG\";
                    // 格納ファイル名の設定
                    strOutPutFileName = "操作履歴ログ_" + strYYYYMMDDvalue + ".LOG";

                    if (Directory.Exists(strOutPutFolder) == false)
                    {
                        // フォルダの作成
                        Directory.CreateDirectory(strOutPutFolder);
                        strPutMessage = strNowFormat + "【" + strOutPutFolder + "】フォルダを作成しました。";
                        // 追記モードで書き込む
                        using StreamWriter sw = new(strOutPutFolder + strOutPutFileName, true, Encoding.Default);
                        sw.WriteLine(strPutMessage);
                    }

                    // 操作履歴ログに操作ログ内容を書き込む
                    strPutMessage = strNowFormat + "：" + strOutPutData;
                    // 追記モードで書き込む
                    using (StreamWriter sw = new(strOutPutFolder + strOutPutFileName, true, Encoding.Default))
                    {
                        sw.WriteLine(strPutMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, "【OutPutLogFile】", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// システム定義ファイルの読込処理
        /// </summary>
        /// <remarks></remarks>
        public static void GetSystemDefinition()
        {
            string strReadDataPath;
            string[] strArray;

            try
            {
                strReadDataPath = IncludeTrailingPathDelimiter(Application.StartupPath) + PubConstClass.DEF_FILENAME;

                using StreamReader sr = new(strReadDataPath, Encoding.UTF8);
                while (!sr.EndOfStream)
                {
                    strArray = sr.ReadLine().Split(',');
                    switch (strArray[0])
                    {
                        // 1号機IPアドレス
                        case PubConstClass.DEF_IP_ADDRESS1:
                            {
                                PubConstClass.pblIpAddress1 = strArray[1];
                                break;
                            }
                        // 2号機IPアドレス
                        case PubConstClass.DEF_IP_ADDRESS2:
                            {
                                PubConstClass.pblIpAddress2 = strArray[1];
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "【getSystemDefinition】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// システム定義ファイルの書込処理
        /// </summary>
        /// <remarks></remarks>
        public static void PutSystemDefinition()
        {
            string strPutDataPath;

            try
            {
                strPutDataPath = IncludeTrailingPathDelimiter(Application.StartupPath) + PubConstClass.DEF_FILENAME;

                // 上書モードで書き込む
                using StreamWriter sw = new(strPutDataPath, false, Encoding.Default);

                // 1号機IPアドレス
                sw.WriteLine(PubConstClass.DEF_IP_ADDRESS1 + "," + PubConstClass.pblIpAddress1);
                // 2号機IPアドレス
                sw.WriteLine(PubConstClass.DEF_IP_ADDRESS2 + "," + PubConstClass.pblIpAddress2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "【putSystemDefinition】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        //[System.Runtime.InteropServices.DllImport("netapi32")]
        //private static extern int NetRemoteTOD([MarshalAs(UnmanagedType.LPWStr)] string ServerName, ref IntPtr BufferPtr);
        //[System.Runtime.InteropServices.DllImport("netapi32")]
        //private static extern int NetApiBufferFree(IntPtr Buffer);

        //struct TIME_OF_DAY_INFO
        //{
        //    public int tod_elapsedt;
        //    public int tod_msecs;
        //    public int tod_hours;
        //    public int tod_mins;
        //    public int tod_secs;
        //    public int tod_hunds;
        //    public int tod_timezone;
        //    public int tod_tinterval;
        //    public int tod_day;
        //    public int tod_month;
        //    public int tod_year;
        //    public int tod_weekday;
        //}

        //public DateTime GetNetRemoteTOD(string strServerName)
        //{
        //    try
        //    {
        //        int iRet;
        //        IntPtr ptodi;
        //        TIME_OF_DAY_INFO todi;
        //        DateTime dDate;
        //        strServerName = strServerName + Constants.vbNullChar;
        //        iRet = NetRemoteTOD(strServerName, ptodi);
        //        if (iRet == 0)
        //        {
        //            todi = (TIME_OF_DAY_INFO)Marshal.PtrToStructure(ptodi, typeof(TIME_OF_DAY_INFO));
        //            NetApiBufferFree(ptodi);
        //            dDate = DateSerial(todi.tod_year, todi.tod_month, todi.tod_day) + " " + TimeSerial(todi.tod_hours, todi.tod_mins - todi.tod_timezone, todi.tod_secs);
        //            GetNetRemoteTOD = dDate;
        //        }
        //        else
        //            Interaction.MsgBox("Error retrieving time");
        //    }
        //    catch
        //    {
        //        Interaction.MsgBox("Error in GetNetRemoteTOD: " + Information.Err.Description);
        //    }
        //}


    }
}
