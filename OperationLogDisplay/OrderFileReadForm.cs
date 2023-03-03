using OperationLogDisplay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace プロジェクト名_OperationLogDisplay
{
    public partial class OrderFileReadForm : Form
    {
        public OrderFileReadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderFileReadForm_Load(object sender, EventArgs e)
        {
            try
            {
                LblSelectFilePath.Text = "";                
                LblDateTimeLocal.Text = "";
                // 日付表示用タイマーのセット
                TimDateTime.Interval = 1000;
                TimDateTime.Enabled = true;
                // オーダーファイル表示用リストビューのヘッダー表示
                DisplayHeaderForOrder();
                // 取込結果表示用リストビューのヘッダー表示
                DisplayHeaderForResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【OrderFileReadForm_Load】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 「閉じる」ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        /// <summary>
        /// オーダーファイル表示用リストビューのヘッダー表示
        /// </summary>
        private void DisplayHeaderForOrder()
        {
            try
            {
                LstOrderFile.View = View.Details;
                #region 列の新規作成
                ColumnHeader col01 = new();
                ColumnHeader col02 = new();
                ColumnHeader col03 = new();
                ColumnHeader col04 = new();
                ColumnHeader col05 = new();
                ColumnHeader col06 = new();
                ColumnHeader col07 = new();
                ColumnHeader col08 = new();
                ColumnHeader col09 = new();
                ColumnHeader col10 = new();
                ColumnHeader col11 = new();
                ColumnHeader col12 = new();
                ColumnHeader col13 = new();                
                ColumnHeader col14 = new();
                ColumnHeader col15 = new();
                ColumnHeader col16 = new();
                ColumnHeader col17 = new();
                ColumnHeader col18 = new();
                ColumnHeader col19 = new();
                ColumnHeader col20 = new();
                ColumnHeader col21 = new();
                ColumnHeader col22 = new();
                ColumnHeader col23 = new();
                ColumnHeader col24 = new();
                ColumnHeader col25 = new();
                ColumnHeader col26 = new();
                ColumnHeader col27 = new();
                ColumnHeader col28 = new();
                ColumnHeader col29 = new();
                ColumnHeader col30 = new();                
                ColumnHeader col31 = new();
                ColumnHeader col32 = new();
                ColumnHeader col33 = new();
                ColumnHeader col34 = new();
                ColumnHeader col35 = new();
                ColumnHeader col36 = new();
                ColumnHeader col37 = new();
                ColumnHeader col38 = new();
                ColumnHeader col39 = new();
                ColumnHeader col40 = new();
                ColumnHeader col41 = new();
                ColumnHeader col42 = new();
                ColumnHeader col43 = new();
                ColumnHeader col44 = new();
                ColumnHeader col45 = new();
                ColumnHeader col46 = new();
                ColumnHeader col47 = new();
                ColumnHeader col48 = new();
                ColumnHeader col49 = new();
                ColumnHeader col50 = new();
                ColumnHeader col51 = new();
                ColumnHeader col52 = new();
                ColumnHeader col53 = new();
                ColumnHeader col54 = new();
                ColumnHeader col55 = new();
                ColumnHeader col56 = new();
                ColumnHeader col57 = new();
                ColumnHeader col58 = new();
                ColumnHeader col59 = new();
                ColumnHeader col60 = new();
                ColumnHeader col61 = new();
                ColumnHeader col62 = new();
                ColumnHeader col63 = new();
                ColumnHeader col64 = new();
                ColumnHeader col65 = new();
                ColumnHeader col66 = new();
                ColumnHeader col67 = new();
                ColumnHeader col68 = new();
                ColumnHeader col69 = new();
                ColumnHeader col70 = new();
                ColumnHeader col71 = new();
                ColumnHeader col72 = new();
                ColumnHeader col73 = new();
                ColumnHeader col74 = new();
                ColumnHeader col75 = new();
                ColumnHeader col76 = new();
                ColumnHeader col77 = new();
                ColumnHeader col78 = new();
                ColumnHeader col79 = new();
                ColumnHeader col80 = new();
                ColumnHeader col81 = new();
                ColumnHeader col82 = new();
                ColumnHeader col83 = new();
                ColumnHeader col84 = new();
                ColumnHeader col85 = new();
                #endregion
                #region 列名称設定
                col01.Text = "レコード識別";
                col02.Text = "データ区分";
                col03.Text = "物流センターコード";
                col04.Text = "出荷No";
                col05.Text = "作業識別";
                col06.Text = "出荷予定日";
                col07.Text = "ピッキングNo";
                col08.Text = "リスト区分";
                col09.Text = "リストパターン名";
                col10.Text = "ピッキング区分";
                col11.Text = "作業区分";
                col12.Text = "相手カテゴリ使用区分";
                col13.Text = "引当倉庫コード";
                col14.Text = "ピッキング作業保留フラグ";
                col15.Text = "配送コースNo";
                col16.Text = "配送コース名";
                col17.Text = "出荷識別";
                col18.Text = "得意先センターコード";
                col19.Text = "得意先企業コード";
                col20.Text = "得意先名";
                col21.Text = "社店コード";
                col22.Text = "得意先センター名";
                col23.Text = "荷降順";
                col24.Text = "得意先センタ内荷降順";
                col25.Text = "横持ち先センターコード";
                col26.Text = "横持ち先倉庫コード";
                col27.Text = "横持ち先センター名";
                col28.Text = "オリコン総数";
                col29.Text = "便区分";
                col30.Text = "便名";
                col31.Text = "かご車No";
                col32.Text = "得意先伝票No";
                col33.Text = "得意先伝票行No";
                col34.Text = "得意先伝票行No枝番";
                col35.Text = "取引先コード";
                col36.Text = "納品年月日";
                col37.Text = "発注No";
                col38.Text = "発注行No";
                col39.Text = "受入倉庫コード";
                col40.Text = "メーカーコード";
                col41.Text = "デポコード";
                col42.Text = "発注先名";
                col43.Text = "入荷予定年月日";
                col44.Text = "入荷予定時刻";
                col45.Text = "ブロック（ＤＰ位置）";
                col46.Text = "ＳＥＱ（ＤＰ位置）";
                col47.Text = "JANコード";
                col48.Text = "JANコード枝番";
                col49.Text = "商品名";
                col50.Text = "ロケーションアドレス";
                col51.Text = "引当在庫区分";
                col52.Text = "商品出荷区分";
                col53.Text = "鮮度基準日区分";
                col54.Text = "鮮度対象フラグ";
                col55.Text = "引当鮮度年月日";
                col56.Text = "前回出荷鮮度日";
                col57.Text = "不定貫識別";
                col58.Text = "ケース入数";
                col59.Text = "バラ数量";
                col60.Text = "商品名表示区分";
                col61.Text = "相手商品カテゴリ";
                col62.Text = "相手カテゴリ名";
                col63.Text = "鮮度日表示区分";
                col64.Text = "店舗引当優先順位";
                col65.Text = "ＤＰ号機";
                col66.Text = "ＳＣＭ検品対象区分";
                col67.Text = "相手伝票区分";
                col68.Text = "特売区分";
                col69.Text = "通路区分";
                col70.Text = "ケースラベル発行区分";
                col71.Text = "相手商品コード";
                col72.Text = "パック入数";
                col73.Text = "期限区分";
                col74.Text = "期限日数";
                col75.Text = "ケース貼付区分";
                col76.Text = "売価";
                col77.Text = "内容量";
                col78.Text = "売価２";
                col79.Text = "自由使用欄１";
                col80.Text = "保存方法";
                col81.Text = "内容量（漢字）";
                col82.Text = "自由使用欄２";
                col83.Text = "デポコード";
                col84.Text = "保存方法２";
                col85.Text = "フォーマットNo";
                #endregion
                #region 列揃え指定
                col01.TextAlign = HorizontalAlignment.Center;
                col02.TextAlign = HorizontalAlignment.Center;
                col03.TextAlign = HorizontalAlignment.Center;
                col04.TextAlign = HorizontalAlignment.Center;
                col05.TextAlign = HorizontalAlignment.Center;
                col06.TextAlign = HorizontalAlignment.Center;
                col07.TextAlign = HorizontalAlignment.Center;
                col08.TextAlign = HorizontalAlignment.Center;
                col09.TextAlign = HorizontalAlignment.Center;
                col10.TextAlign = HorizontalAlignment.Center;
                col11.TextAlign = HorizontalAlignment.Center;
                col12.TextAlign = HorizontalAlignment.Center;
                col13.TextAlign = HorizontalAlignment.Center;
                col14.TextAlign = HorizontalAlignment.Center;
                col15.TextAlign = HorizontalAlignment.Center;
                col16.TextAlign = HorizontalAlignment.Center;
                col17.TextAlign = HorizontalAlignment.Center;
                col18.TextAlign = HorizontalAlignment.Center;
                col19.TextAlign = HorizontalAlignment.Center;
                col20.TextAlign = HorizontalAlignment.Center;
                col21.TextAlign = HorizontalAlignment.Center;
                col22.TextAlign = HorizontalAlignment.Center;
                col23.TextAlign = HorizontalAlignment.Center;
                col24.TextAlign = HorizontalAlignment.Center;
                col25.TextAlign = HorizontalAlignment.Center;
                col26.TextAlign = HorizontalAlignment.Center;
                col27.TextAlign = HorizontalAlignment.Center;
                col28.TextAlign = HorizontalAlignment.Center;
                col29.TextAlign = HorizontalAlignment.Center;
                col30.TextAlign = HorizontalAlignment.Center;
                col31.TextAlign = HorizontalAlignment.Center;
                col32.TextAlign = HorizontalAlignment.Center;
                col33.TextAlign = HorizontalAlignment.Center;
                col34.TextAlign = HorizontalAlignment.Center;
                col35.TextAlign = HorizontalAlignment.Center;
                col36.TextAlign = HorizontalAlignment.Center;
                col37.TextAlign = HorizontalAlignment.Center;
                col38.TextAlign = HorizontalAlignment.Center;
                col39.TextAlign = HorizontalAlignment.Center;
                col40.TextAlign = HorizontalAlignment.Center;
                col41.TextAlign = HorizontalAlignment.Center;
                col42.TextAlign = HorizontalAlignment.Center;
                col43.TextAlign = HorizontalAlignment.Center;
                col44.TextAlign = HorizontalAlignment.Center;
                col45.TextAlign = HorizontalAlignment.Center;
                col46.TextAlign = HorizontalAlignment.Center;
                col47.TextAlign = HorizontalAlignment.Center;
                col48.TextAlign = HorizontalAlignment.Center;
                col49.TextAlign = HorizontalAlignment.Center;
                col50.TextAlign = HorizontalAlignment.Center;
                col51.TextAlign = HorizontalAlignment.Center;
                col52.TextAlign = HorizontalAlignment.Center;
                col53.TextAlign = HorizontalAlignment.Center;
                col54.TextAlign = HorizontalAlignment.Center;
                col55.TextAlign = HorizontalAlignment.Center;
                col56.TextAlign = HorizontalAlignment.Center;
                col57.TextAlign = HorizontalAlignment.Center;
                col58.TextAlign = HorizontalAlignment.Center;
                col59.TextAlign = HorizontalAlignment.Center;
                col60.TextAlign = HorizontalAlignment.Center;
                col61.TextAlign = HorizontalAlignment.Center;
                col62.TextAlign = HorizontalAlignment.Center;
                col63.TextAlign = HorizontalAlignment.Center;
                col64.TextAlign = HorizontalAlignment.Center;
                col65.TextAlign = HorizontalAlignment.Center;
                col66.TextAlign = HorizontalAlignment.Center;
                col67.TextAlign = HorizontalAlignment.Center;
                col68.TextAlign = HorizontalAlignment.Center;
                col69.TextAlign = HorizontalAlignment.Center;
                col70.TextAlign = HorizontalAlignment.Center;
                col71.TextAlign = HorizontalAlignment.Center;
                col72.TextAlign = HorizontalAlignment.Center;
                col73.TextAlign = HorizontalAlignment.Center;
                col74.TextAlign = HorizontalAlignment.Center;
                col75.TextAlign = HorizontalAlignment.Center;
                col76.TextAlign = HorizontalAlignment.Center;
                col77.TextAlign = HorizontalAlignment.Center;
                col78.TextAlign = HorizontalAlignment.Center;
                col79.TextAlign = HorizontalAlignment.Center;
                col80.TextAlign = HorizontalAlignment.Center;
                col81.TextAlign = HorizontalAlignment.Center;
                col82.TextAlign = HorizontalAlignment.Center;
                col83.TextAlign = HorizontalAlignment.Center;
                col84.TextAlign = HorizontalAlignment.Center;
                col85.TextAlign = HorizontalAlignment.Center;
                #endregion
                #region 列幅指定
                col01.Width = 90;
                col02.Width = 90;
                col03.Width = 90;
                col04.Width = 90;
                col05.Width = 90;
                col06.Width = 90;
                col07.Width = 90;
                col08.Width = 90;
                col09.Width = 90;
                col10.Width = 90;
                col11.Width = 90;
                col12.Width = 90;
                col13.Width = 90;
                col14.Width = 90;
                col15.Width = 90;
                col16.Width = 90;
                col17.Width = 90;
                col18.Width = 90;
                col19.Width = 90;
                col20.Width = 90;
                col21.Width = 90;
                col22.Width = 90;
                col23.Width = 90;
                col24.Width = 90;
                col25.Width = 90;
                col26.Width = 90;
                col27.Width = 90;
                col28.Width = 90;
                col29.Width = 90;
                col30.Width = 90;
                col31.Width = 90;
                col32.Width = 90;
                col33.Width = 90;
                col34.Width = 90;
                col35.Width = 90;
                col36.Width = 90;
                col37.Width = 90;
                col38.Width = 90;
                col39.Width = 90;
                col40.Width = 90;
                col41.Width = 90;
                col42.Width = 90;
                col43.Width = 90;
                col44.Width = 90;
                col45.Width = 90;
                col46.Width = 90;
                col47.Width = 90;
                col48.Width = 90;
                col49.Width = 90;
                col50.Width = 90;
                col51.Width = 90;
                col52.Width = 90;
                col53.Width = 90;
                col54.Width = 90;
                col55.Width = 90;
                col56.Width = 90;
                col57.Width = 90;
                col58.Width = 90;
                col59.Width = 90;
                col60.Width = 90;
                col61.Width = 90;
                col62.Width = 90;
                col63.Width = 90;
                col64.Width = 90;
                col65.Width = 90;
                col66.Width = 90;
                col67.Width = 90;
                col68.Width = 90;
                col69.Width = 90;
                col70.Width = 90;
                col71.Width = 90;
                col72.Width = 90;
                col73.Width = 90;
                col74.Width = 90;
                col75.Width = 90;
                col76.Width = 90;
                col77.Width = 90;
                col78.Width = 90;
                col79.Width = 90;
                col80.Width = 90;
                col81.Width = 90;
                col82.Width = 90;
                col83.Width = 90;
                col84.Width = 90;
                col85.Width = 90;
                #endregion
                #region 列表示
                ColumnHeader[] colHeader = new[] { col01, col02, col03, col04, col05, col06, col07, col08, col09, col10,
                                                   col11, col12, col13, col14, col15, col16, col17, col18, col19, col20,
                                                   col21, col22, col23, col24, col25, col26, col27, col28, col29, col30,
                                                   col31, col32, col33, col34, col35, col36, col37, col38, col39, col40,
                                                   col41, col42, col43, col44, col45, col46, col47, col48, col49, col50,
                                                   col51, col52, col53, col54, col55, col56, col57, col58, col59, col60,
                                                   col61, col62, col63, col64, col65, col66, col67, col68, col69, col70,
                                                   col71, col72, col73, col74, col75, col76, col77, col78, col79, col80,
                                                   col81, col82, col83, col84, col85
                                                  };
                LstOrderFile.Columns.AddRange(colHeader);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【DisplayHeaderForOrder】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 取込結果表示用リストビューのヘッダー表示
        /// </summary>
        private void DisplayHeaderForResult()
        {
            try
            {
                LstViewResult.View = View.Details;
                #region 列の新規作成
                ColumnHeader col01 = new();
                ColumnHeader col02 = new();
                ColumnHeader col03 = new();
                #endregion
                #region 列名称設定
                col01.Text = "日付";
                col02.Text = "項目";
                col03.Text = "内容";
                #endregion
                #region 列揃え指定
                col01.TextAlign = HorizontalAlignment.Center;
                col02.TextAlign = HorizontalAlignment.Center;
                col03.TextAlign = HorizontalAlignment.Left;
                #endregion
                #region 列幅指定
                col01.Width = 250;
                col02.Width = 200;
                col03.Width = 2000;
                #endregion
                #region 列表示
                ColumnHeader[] colHeader = new[] { col01, col02, col03 };
                LstViewResult.Columns.AddRange(colHeader);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【DisplayHeaderForResult】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 「オーダーファイル選択」ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectOrderFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new();
                try
                {
                    CommonModule.OutPutLogFile("「オーダーファイル選択」ボタンクリック");

                    // 「ファイルの種類」に表示される選択肢の指定
                    ofd.Filter = "TXTファイル(*.txt;*.TXT)|*.txt;*.TXT|すべてのファイル(*.*)|*.*";
                    // 「ファイルの種類」ではじめに「すべてのファイル(*.*)|*.*」を選択
                    ofd.FilterIndex = 2;
                    // タイトルを設定
                    ofd.Title = "オーダーファイルを選択してください";
                    // ダイアログボックスを閉じる前に現在のディレクトリを復元
                    ofd.RestoreDirectory = true;
                    // 存在しないファイルの名前が指定されたとき警告を表示
                    ofd.CheckFileExists = true;
                    // 存在しないパスが指定されたとき警告を表示
                    ofd.CheckPathExists = true;
                    // ダイアログを表示する
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        // 「OK」ボタンがクリック（選択されたファイル名を表示）
                        LblSelectFilePath.Text = ofd.FileName;
                        // オーダーファイル読込処理
                        ReadOrderData(LblSelectFilePath.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "オーダーファイル選択時のエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【BtnSelectOrderFile_Click】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// オーダーファイルの読込と表示
        /// </summary>
        /// <param name="filePath"></param>
        private void ReadOrderData(string filePath)
        {
            string sReadData;
            int iReadRecNumber = 0;
            string[] col = new string[85];
            ListViewItem itm;

            try
            {
                DisplayViewResult("取込日付", dTimPickerImportDate.Value.ToString("yyyy/MM/dd"));
                DisplayViewResult("データ読込", filePath);

                LstOrderFile.Items.Clear();
                // Windowsのシステムが提供するエンコーディングの全てを利用可能とする
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                using (StreamReader sr = new(filePath, Encoding.GetEncoding("shift_jis")))
                {
                    while (!sr.EndOfStream)
                    {
                        iReadRecNumber++;
                        sReadData = sr.ReadLine();
                        CommonModule.OutPutLogFile("【読込レコード長】" + sReadData.Length.ToString());
                        if (sReadData.Length >= 517)
                        {
                            #region 読込データの分解
                            col[0] = sReadData.Substring(1 - 1, 2);     // レコード識別
                            col[1] = sReadData.Substring(3 - 1, 1);     // データ区分
                            col[2] = sReadData.Substring(4 - 1, 5);     // 物流センターコード
                            col[3] = sReadData.Substring(9 - 1, 8);     // 出荷No
                            col[4] = sReadData.Substring(17 - 1, 1);    // 作業識別
                            col[5] = sReadData.Substring(18 - 1, 8);    // 出荷予定日
                            col[6] = sReadData.Substring(26 - 1, 4);
                            col[7] = sReadData.Substring(30 - 1, 1);
                            col[8] = sReadData.Substring(31 - 1, 20);
                            col[9] = sReadData.Substring(51 - 1, 1);
                            col[10] = sReadData.Substring(52 - 1, 1);
                            col[11] = sReadData.Substring(53 - 1, 1);
                            col[12] = sReadData.Substring(54 - 1, 4);
                            col[13] = sReadData.Substring(58 - 1, 1);
                            col[14] = sReadData.Substring(59 - 1, 5);
                            col[15] = sReadData.Substring(64 - 1, 10);
                            col[16] = sReadData.Substring(74 - 1, 1);
                            col[17] = sReadData.Substring(75 - 1, 8);
                            col[18] = sReadData.Substring(83 - 1, 6);
                            col[19] = sReadData.Substring(89 - 1, 20);
                            col[20] = sReadData.Substring(109 - 1, 7);
                            col[21] = sReadData.Substring(116 - 1, 20);
                            col[22] = sReadData.Substring(136 - 1, 3);
                            col[23] = sReadData.Substring(139 - 1, 2);
                            col[24] = sReadData.Substring(141 - 1, 5);
                            col[25] = sReadData.Substring(146 - 1, 4);
                            col[26] = sReadData.Substring(150 - 1, 10);
                            col[27] = sReadData.Substring(160 - 1, 7);
                            col[28] = sReadData.Substring(167 - 1, 1);
                            col[29] = sReadData.Substring(168 - 1, 3);
                            col[30] = sReadData.Substring(171 - 1, 17);
                            col[31] = sReadData.Substring(188 - 1, 15);
                            col[32] = sReadData.Substring(203 - 1, 3);
                            col[33] = sReadData.Substring(206 - 1, 2);
                            col[34] = sReadData.Substring(208 - 1, 8);
                            col[35] = sReadData.Substring(216 - 1, 8);
                            col[36] = sReadData.Substring(224 - 1, 8);
                            col[37] = sReadData.Substring(232 - 1, 2);
                            col[38] = sReadData.Substring(234 - 1, 4);
                            col[39] = sReadData.Substring(238 - 1, 9);
                            col[40] = sReadData.Substring(247 - 1, 3);
                            col[41] = sReadData.Substring(250 - 1, 20);
                            col[42] = sReadData.Substring(270 - 1, 8);
                            col[43] = sReadData.Substring(278 - 1, 4);
                            col[44] = sReadData.Substring(282 - 1, 2);
                            col[45] = sReadData.Substring(284 - 1, 3);
                            col[46] = sReadData.Substring(287 - 1, 13);
                            col[47] = sReadData.Substring(300 - 1, 2);
                            col[48] = sReadData.Substring(302 - 1, 24);
                            col[49] = sReadData.Substring(326 - 1, 7);
                            col[50] = sReadData.Substring(333 - 1, 2);
                            col[51] = sReadData.Substring(335 - 1, 1);
                            col[52] = sReadData.Substring(336 - 1, 1);
                            col[53] = sReadData.Substring(337 - 1, 1);
                            col[54] = sReadData.Substring(338 - 1, 8);
                            col[55] = sReadData.Substring(346 - 1, 8);
                            col[56] = sReadData.Substring(354 - 1, 1);
                            col[57] = sReadData.Substring(355 - 1, 7);
                            col[58] = sReadData.Substring(362 - 1, 11);
                            col[59] = sReadData.Substring(373 - 1, 1);
                            col[60] = sReadData.Substring(374 - 1, 10);
                            col[61] = sReadData.Substring(384 - 1, 10);
                            col[62] = sReadData.Substring(394 - 1, 1);
                            col[63] = sReadData.Substring(395 - 1, 5);
                            col[64] = sReadData.Substring(400 - 1, 1);
                            col[65] = sReadData.Substring(401 - 1, 1);
                            col[66] = sReadData.Substring(402 - 1, 5);
                            col[67] = sReadData.Substring(407 - 1, 1);
                            col[68] = sReadData.Substring(408 - 1, 10);
                            col[69] = sReadData.Substring(418 - 1, 1);
                            col[70] = sReadData.Substring(419 - 1, 16);
                            col[71] = sReadData.Substring(435 - 1, 7);
                            col[72] = sReadData.Substring(442 - 1, 1);
                            col[73] = sReadData.Substring(443 - 1, 2);
                            col[74] = sReadData.Substring(445 - 1, 1);
                            col[75] = sReadData.Substring(446 - 1, 9);
                            col[76] = sReadData.Substring(455 - 1, 8);
                            col[77] = sReadData.Substring(463 - 1, 9);
                            col[78] = sReadData.Substring(472 - 1, 13);
                            col[79] = sReadData.Substring(485 - 1, 9);
                            col[80] = sReadData.Substring(494 - 1, 8);
                            col[81] = sReadData.Substring(502 - 1, 3);
                            col[82] = sReadData.Substring(505 - 1, 2);
                            col[83] = sReadData.Substring(507 - 1, 9);
                            col[84] = sReadData.Substring(516 - 1, 2);
                            #endregion

                            // データの表示
                            itm = new ListViewItem(col);
                            LstOrderFile.Items.Add(itm);
                            LstOrderFile.Items[^1].UseItemStyleForSubItems = false;

                            if (col[5] != dTimPickerImportDate.Value.ToString("yyyyMMdd"))
                            {
                                string sMessage = "";
                                sMessage += "取込日付（" + dTimPickerImportDate.Value.ToString("yyyyMMdd");
                                sMessage += "）と出荷予定日（" + col[5] + "）が異なる";
                                DisplayViewResult("ERROR", sMessage);
                            }

                            if (LstOrderFile.Items.Count % 2 == 0)
                            {
                                // 偶数行の色反転
                                for (var intLoopCnt = 0; intLoopCnt < col.Length; intLoopCnt++)
                                {
                                    LstOrderFile.Items[^1].SubItems[intLoopCnt].BackColor = Color.FromArgb(200, 200, 230);
                                }
                            }

                            string sCsvData = "";
                            // CSVデータを操作ログに残す
                            foreach(string sData in col)
                            {
                                sCsvData += sData + ",";
                            }
                            CommonModule.OutPutLogFile("【表示データ】" + sCsvData);
                        }
                        else
                        {
                            DisplayViewResult("ERROR", "既定レコード長未満：" + sReadData.Length.ToString());
                            DisplayViewResult("ERROR", iReadRecNumber.ToString() + "行目：" + sReadData);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "【ReadOrderData】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sItem"></param>
        /// <param name="sContent"></param>
        private void DisplayViewResult(string sItem, string sContent)
        {
            string[] col = new string[3];
            ListViewItem itm;

            try
            {
                // データのセット
                col[0] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                col[1] = sItem;
                col[2] = sContent;

                // データの表示
                itm = new ListViewItem(col);
                LstViewResult.Items.Add(itm);
                LstViewResult.Items[^1].UseItemStyleForSubItems = false;
                LstViewResult.Select();
                LstViewResult.Items[LstViewResult.Items.Count - 1].EnsureVisible();

                if (LstViewResult.Items.Count % 2 == 0)
                {
                    // 偶数行の色反転
                    for (var intLoopCnt = 0; intLoopCnt < col.Length; intLoopCnt++)
                    {
                        LstViewResult.Items[^1].SubItems[intLoopCnt].BackColor = Color.FromArgb(200, 200, 230);
                    }
                }

                if (sItem=="ERROR")
                {
                    for (var intLoopCnt = 0; intLoopCnt < col.Length; intLoopCnt++)
                    {
                        LstViewResult.Items[^1].SubItems[intLoopCnt].ForeColor = Color.FromArgb(255, 0, 0);
                    }
                    //LstViewResult.Items[LstViewResult.Items.Count - 1].SubItems[1].BackColor = Color.FromArgb(230, 200, 200);
                }
                CommonModule.OutPutLogFile("【" + col[1] + "】" + col[2]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "【DisplayViewResult】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimDateTime_Tick(object sender, EventArgs e)
        {
            LblDateTimeLocal.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}
