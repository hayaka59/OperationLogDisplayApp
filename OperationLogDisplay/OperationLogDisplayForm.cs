//using Microsoft.VisualBasic;
//using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
//using System.Diagnostics;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Drawing;

namespace OperationLogDisplay
{
    public partial class OperationLogDisplayForm : Form
    {

        public OperationLogDisplayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperationLogDisplayForm_Load(object sender, EventArgs e)
        {
            try
            {
                PubConstClass.objSyncHist = new object();

                LblVersion.Text = PubConstClass.DEF_VERSION;
                CommonModule.OutPutLogFile("稼動ログ表示アプリ起動：" + PubConstClass.DEF_VERSION);
                LblResult1.Text = "";
                LblResult2.Text = "";
                LblResult3.Text = "";
                LblResult4.Text = "";

                SetCmpComp(CmbComp1);
                SetCmpComp(CmbComp2);

                DisplayHeader(LstViewResult1);
                DisplayHeader(LstViewResult2);

                DisplayHeaderForHistory(LstViewResult3);
                DisplayHeaderForHistory(LstViewResult4);

                CommonModule.GetSystemDefinition();
                TxtIpAddress1.Text = PubConstClass.pblIpAddress1;
                TxtIpAddress2.Text = PubConstClass.pblIpAddress2;
                CommonModule.OutPutLogFile(PubConstClass.DEF_IP_ADDRESS1 + "：" + PubConstClass.pblIpAddress1);
                CommonModule.OutPutLogFile(PubConstClass.DEF_IP_ADDRESS2 + "：" + PubConstClass.pblIpAddress2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【OperationLogDisplayForm_Load】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 取付日付検索条件コンボ設定
        /// </summary>
        /// <param name="comboBox"></param>
        private void SetCmpComp(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("より後");
            comboBox.Items.Add("等しい");
            comboBox.Items.Add("より前");
            comboBox.SelectedIndex = 1;
        }

        /// <summary>
        /// オーダーテーブルのテーブルヘッダー表示
        /// </summary>
        /// <param name="LstViewResult"></param>
        private static void DisplayHeader(ListView LstViewResult)
        {
            try
            {
                LstViewResult.View = View.Details;

                #region 列の新規作成
                ColumnHeader col01 = new();
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
                ColumnHeader col02 = new();
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
                #endregion

                #region 列名称設定
                col01.Text = "id";
                col02.Text = "取込日時";                // import_time
                col03.Text = "import_index"; 
                col04.Text = "状況";                  // status
                col05.Text = "is_retried";
                col06.Text = "record_id";
                col07.Text = "data_category";
                col08.Text = "logistics_center_code";
                col09.Text = "shipment_no";
                col10.Text = "process_id";
                col11.Text = "出荷予定日時";          // planed_shipping_date
                col12.Text = "picking_no";
                col13.Text = "list_pattern_name";
                col14.Text = "作業区分";        // process_category
                col15.Text = "customer_center_code";
                col16.Text = "customer_company_code";
                col17.Text = "customer_name";
                col18.Text = "customer_center_name";
                col19.Text = "商品コード";            // product_code
                col20.Text = "product_sub_code";
                col21.Text = "商品名";                 // product_name
                col22.Text = "count_per_case";
                col23.Text = "piece_count";
                col24.Text = "count_per_pack";
                col25.Text = "limit_type";
                col26.Text = "limit_days";
                col27.Text = "case_paste_category";
                col28.Text = "selling_price";
                col29.Text = "storage_method";
                col30.Text = "予定数";        // planed_count
                col31.Text = "skipped_count";
                col32.Text = "printed_count";
                col33.Text = "貼付枚数";        // pasted_count
                col34.Text = "passed_count";
                col35.Text = "rejected_count";
                #endregion

                #region 列揃え指定
                col01.TextAlign = HorizontalAlignment.Center;
                col02.TextAlign = HorizontalAlignment.Left;
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
                col21.TextAlign = HorizontalAlignment.Left;     // 商品名
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
                #endregion

                #region 列幅指定
                col01.Width = 00;       // id
                col02.Width = 205;      // import_time
                col03.Width = 00;       // import_index
                col04.Width = 00;       // status
                col05.Width = 00;       // is_retried
                col06.Width = 00;       // record_id
                col07.Width = 00;       // data_category
                col08.Width = 00;       // logistics_center_code
                col09.Width = 00;       // shipment_no
                col10.Width = 00;       // process_id
                col11.Width = 205;      // planed_shipping_date
                col12.Width = 00;       // picking_no
                col13.Width = 00;       // list_pattern_name
                col14.Width = 00;       // process_category
                col15.Width = 00;       // customer_center_code
                col16.Width = 00;       // customer_company_code
                col17.Width = 00;       // customer_name
                col18.Width = 00;       // customer_center_name
                col19.Width = 120;      // product_code
                col20.Width = 00;       // product_sub_code
                col21.Width = 220;      // product_name
                col22.Width = 00;       // count_per_case
                col23.Width = 00;       // piece_count
                col24.Width = 00;       // count_per_pack
                col25.Width = 00;       // limit_type
                col26.Width = 00;       // limit_days
                col27.Width = 00;       // case_paste_category
                col28.Width = 00;       // selling_price
                col29.Width = 00;       // storage_method
                col30.Width = 70;       // planed_count
                col31.Width = 00;       // skipped_count
                col32.Width = 00;       // printed_count
                col33.Width = 70;       // pasted_count
                col34.Width = 00;       // passed_count
                col35.Width = 00;       // rejected_count
                #endregion

                #region 列表示
                ColumnHeader[] colHeader = new[] { col01, col02, col03, col04, col05, col06, col07, col08, col09, col10,
                                                   col11, col12, col13, col14, col15, col16, col17, col18, col19, col20,
                                                   col21, col22, col23, col24, col25, col26, col27, col28, col29, col30,
                                                   col31, col32, col33, col34, col35};
                LstViewResult.Columns.AddRange(colHeader);
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【DisplayHeader】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 履歴テーブルのテーブルヘッダー表示
        /// </summary>
        /// <param name="LstViewResult"></param>
        private static void DisplayHeaderForHistory(ListView LstViewResult)
        {
            try
            {
                LstViewResult.View = View.Details;

                #region 列の新規作成
                ColumnHeader col01 = new();
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
                ColumnHeader col02 = new();
                ColumnHeader col14 = new();
                ColumnHeader col15 = new();
                ColumnHeader col16 = new();
                ColumnHeader col17 = new();
                #endregion

                #region 列名称設定
                col01.Text = "id";
                col02.Text = "start_count";
                col03.Text = "予定数";                 // planed_count 
                col04.Text = "skipped_count";
                col05.Text = "printed_count";           
                col06.Text = "貼付枚数";            // pasted_count
                col07.Text = "passed_count";
                col08.Text = "rejected_count";
                col09.Text = "process_date_start";
                col10.Text = "process_date_end";
                col11.Text = "user_code";
                col12.Text = "device_id";
                col13.Text = "is_offline";
                col14.Text = "is_retried";
                col15.Text = "中止理由";            // cancel_reason
                col16.Text = "productivity_time";
                col17.Text = "order_id";
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
                col15.TextAlign = HorizontalAlignment.Left;
                col16.TextAlign = HorizontalAlignment.Center;
                col17.TextAlign = HorizontalAlignment.Center;
                #endregion

                #region 列幅指定
                col01.Width = 50;       // id
                col02.Width = 80;       // start_count
                col03.Width = 80;       // planed_count
                col04.Width = 80;       // skipped_count
                col05.Width = 80;       // printed_count
                col06.Width = 80;       // pasted_count
                col07.Width = 80;       // passed_count
                col08.Width = 80;       // rejected_count
                col09.Width = 200;      // process_date_start
                col10.Width = 200;      // process_date_end
                col11.Width = 100;      // user_code
                col12.Width = 100;      // device_id
                col13.Width = 100;      // is_offline
                col14.Width = 100;      // is_retried
                col15.Width = 200;      // cancel_reason
                col16.Width = 100;      // productivity_time
                col17.Width = 100;      // order_id
                #endregion

                #region 列表示
                ColumnHeader[] colHeader = new[] { col01, col02, col03, col04, col05, col06, col07, col08, col09, col10,
                                                   col11, col12, col13, col14, col15, col16, col17};
                LstViewResult.Columns.AddRange(colHeader);
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【DisplayHeaderForHistory】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        /// <summary>
        /// オーダーデータ読込
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private List<OrderData> ExecuteReader(string query, string sServer)
        {
            // 検索条件に一致したレコードを格納するコレクション
            List<OrderData> Datas = new();

            // MySQLへの接続情報を設定
            var server = sServer;               // ホスト名
            var port = 3306;                    // ポート
            var user = "devuser";               // ユーザー名
            var pass = "Pf6QfXcQ";              // パスワード
            var charset = "utf8";               // エンコード
            var database = "srobo";             // データベース
            var connectionString = $"Server={server};Port={port};Username={user};Password={pass};Charset={charset};Database={database}";

            try
            {
                using MySqlConnection connection = new(connectionString);
                using var commnad = connection.CreateCommand();
                // MySQLへ接続
                connection.Open();

                // クエリーの実行処理
                commnad.CommandText = query;
                using var reader = commnad.ExecuteReader();
                while (reader.Read())
                {
                    Datas.Add(new OrderData
                    {
                        Id = reader.GetInt32("id"),
                        Import_time = reader.GetInt64("import_time"),
                        Import_index = reader.GetInt32("import_index"),
                        Status = reader.GetInt32("status"),
                        Is_retried = reader.GetInt32("is_retried"),
                        Record_id = reader.GetString("record_id"),
                        Data_category = reader.GetInt32("data_category"),
                        Logistics_center_code = reader.GetInt32("logistics_center_code"),
                        Shipment_no = reader.GetInt32("shipment_no"),
                        Process_id = reader.GetString("process_id"),
                        Planed_shipping_date = reader.GetInt64("planed_shipping_date"),
                        Picking_no = reader.GetInt32("picking_no"),
                        List_pattern_name = reader.GetString("list_pattern_name"),
                        Process_category = reader.GetInt32("process_category"),
                        Customer_center_code = reader.GetString("customer_center_code"),
                        Customer_company_code = reader.GetInt32("customer_company_code"),
                        Customer_name = reader.GetString("customer_name"),
                        Customer_center_name = reader.GetString("customer_center_name"),
                        Product_code = reader.GetString("product_code"),
                        Product_sub_code = reader.GetString("product_sub_code"),
                        Product_name = reader.GetString("product_name"),
                        Count_per_case = reader.GetInt32("count_per_case"),
                        Piece_count = reader.GetInt32("piece_count"),
                        Count_per_pack = reader.GetInt32("count_per_pack"),
                        Limit_type = reader.GetInt32("limit_type"),
                        Limit_days = reader.GetInt32("limit_days"),
                        Case_paste_category = reader.GetInt32("case_paste_category"),
                        Selling_price = reader.GetInt32("selling_price"),
                        Storage_method = reader.GetString("storage_method"),
                        Planed_count = reader.GetInt32("planed_count"),
                        Skipped_count = reader.GetInt32("skipped_count"),
                        Printed_count = reader.GetInt32("printed_count"),
                        Pasted_count = reader.GetInt32("pasted_count"),
                        Passed_count = reader.GetInt32("passed_count"),
                        Rejected_count = reader.GetInt32("rejected_count"),
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【ExecuteReader1】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Datas;
        }

        /// <summary>
        /// 履歴データ読込
        /// </summary>
        /// <param name="query"></param>
        /// <param name="sServer"></param>
        /// <returns></returns>
        private List<HistoryData> ExecuteReaderForHistory(string query, string sServer)
        {
            // 検索条件に一致したレコードを格納するコレクション
            List<HistoryData> Datas = new();

            // MySQLへの接続情報を設定
            var server = sServer;               // ホスト名
            var port = 3306;                    // ポート
            var user = "devuser";               // ユーザー名
            var pass = "Pf6QfXcQ";              // パスワード
            var charset = "utf8";               // エンコード
            var database = "srobo";             // データベース
            var connectionString = $"Server={server};Port={port};Username={user};Password={pass};Charset={charset};Database={database}";

            try
            {
                using MySqlConnection connection = new(connectionString);
                using var commnad = connection.CreateCommand();
                // MySQLへ接続
                connection.Open();

                // クエリーの実行処理
                commnad.CommandText = query;
                using var reader = commnad.ExecuteReader();
                while (reader.Read())
                {
                    Datas.Add(new HistoryData
                    {
                        Id = reader.GetInt32("id"),
                        Start_count = reader.GetInt32("start_count"),
                        Planed_count = reader.GetInt32("planed_count"),
                        Skipped_count = reader.GetInt32("skipped_count"),
                        Printed_count = reader.GetInt32("printed_count"),
                        Pasted_count = reader.GetInt32("pasted_count"),
                        Passed_count = reader.GetInt32("passed_count"),
                        Rejected_count = reader.GetInt32("rejected_count"),
                        Process_date_start = reader.GetInt64("process_date_start"),
                        Process_date_end = reader.GetInt64("process_date_end"),
                        User_code = reader.GetString("user_code"),
                        Device_id = reader.GetString("device_id"),
                        Is_offline = reader.GetInt32("is_offline"),
                        Is_retried = reader.GetInt32("is_retried"),
                        Cancel_reason = reader.GetString("cancel_reason"),
                        Productivity_time = reader.GetString("productivity_time"),
                        Order_id = reader.GetInt32("order_id"),
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【ExecuteReaderForHistory】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Datas;
        }

        /// <summary>
        /// 履歴データ
        /// </summary>
        class HistoryData
        {
            public int Id { get; set; }
            public int Start_count { get; set; }
            public int Planed_count { get; set; }
            public int Skipped_count { get; set; }
            public int Printed_count { get; set; }
            public int Pasted_count { get; set; }
            public int Passed_count { get; set; }
            public int Rejected_count { get; set; }
            public long Process_date_start { get; set; }
            public long Process_date_end { get; set; }
            public string? User_code { get; set; }
            public string? Device_id { get; set; }
            public int Is_offline { get; set; }
            public int Is_retried { get; set; }
            public string? Cancel_reason { get; set; }
            public string? Productivity_time { get; set; }
            public int Order_id { get; set; }
        }

        /// <summary>
        /// オーダーデータ
        /// </summary>
        class OrderData
        {
            public int Id { get; set; }
            public long Import_time { get; set; }
            public int Import_index { get; set; }
            public int Status { get; set; }
            public int Is_retried { get; set; }
            public string? Record_id { get; set; }
            public int Data_category { get; set; }
            public int Logistics_center_code { get; set; }
            public int Shipment_no { get; set; }
            public string? Process_id { get; set; }
            public long Planed_shipping_date { get; set; }
            public int Picking_no { get; set; }
            public string? List_pattern_name { get; set; }
            public int Process_category { get; set; }
            public string? Customer_center_code { get; set; }
            public int Customer_company_code { get; set; }
            public string? Customer_name { get; set; }
            public string? Customer_center_name { get; set; }
            public string? Product_code { get; set; }
            public string? Product_sub_code { get; set; }
            public string? Product_name { get; set; }
            public int Count_per_case { get; set; }
            public int Piece_count { get; set; }
            public int Count_per_pack { get; set; }
            public int Limit_type { get; set; }
            public int Limit_days { get; set; }
            public int Case_paste_category { get; set; }
            public int Selling_price { get; set; }
            public string? Storage_method { get; set; }
            public int Planed_count { get; set; }
            public int Skipped_count { get; set; }
            public int Printed_count { get; set; }
            public int Pasted_count { get; set; }
            public int Passed_count { get; set; }
            public int Rejected_count { get; set; }
        }

        /// <summary>
        /// 「更新1」ボタン処理（1号機オーダーテーブル表示用）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh1_Click(object sender, EventArgs e)
        {
            string[] col = new string[35];
            ListViewItem itm1;
            
            try
            {
                LstViewResult1.Items.Clear();

                string sSQLData = "";
                string sPicDay1 = dTimPickerImportDate1.Value.ToString("yyyy-MM-dd");
                string sPicDay2 = dTimPickerImportDate1.Value.AddDays(1).ToString("yyyy-MM-dd");
                string sDate1 = "UNIX_TIMESTAMP('" + sPicDay1 + " 00:00:00') * 1000";
                string sDate2 = "UNIX_TIMESTAMP('" + sPicDay2 + " 00:00:00') * 1000";

                switch (CmbComp1.SelectedIndex)
                {
                    case 0: // ＞                        
                        sSQLData = "SELECT * FROM `order` WHERE IMPORT_TIME > " + sDate1 + ";";
                        break;
                    case 1: // ＝
                        sSQLData = "SELECT * FROM `order` WHERE IMPORT_TIME BETWEEN " + sDate1 + " AND " + sDate2 + ";";
                        break;
                    case 2: // ＜
                        sSQLData = "SELECT * FROM `order` WHERE IMPORT_TIME < " + sDate1 + ";";
                        break;
                }
                CommonModule.OutPutLogFile("【1号機】【オーダーテーブル】検索条件：" + sSQLData);
                var result = ExecuteReader(sSQLData, TxtIpAddress1.Text);
                foreach (var ret in result)
                {
                    // 検索結果を表示
                    col[0] = ret.Id.ToString();
                    col[1] = DateTimeOffset.FromUnixTimeSeconds(ret.Import_time / 1000).ToLocalTime().ToString();
                    col[2] = ret.Import_index.ToString();
                    col[3] = ret.Status.ToString();
                    col[4] = ret.Is_retried.ToString();
                    if(ret.Record_id is not null)
                        col[5] = ret.Record_id.ToString();
                    col[6] = ret.Data_category.ToString();
                    col[7] = ret.Logistics_center_code.ToString();
                    col[8] = ret.Shipment_no.ToString();
                    if(ret.Process_id is not null)
                        col[9] = ret.Process_id.ToString();                    
                    col[10] = DateTimeOffset.FromUnixTimeSeconds(ret.Planed_shipping_date / 1000).ToLocalTime().ToString();
                    col[11] = ret.Picking_no.ToString();
                    if(ret.List_pattern_name is not null)
                        col[12] = ret.List_pattern_name.ToString();
                    col[13] = ret.Process_category.ToString();
                    if(ret.Customer_center_code is not null)
                        col[14] = ret.Customer_center_code.ToString();                    
                    col[15] = ret.Customer_company_code.ToString();
                    if (ret.Customer_name is not null)
                        col[16] = ret.Customer_name.ToString();
                    if (ret.Customer_center_name is not null)
                        col[17] = ret.Customer_center_name.ToString();
                    if (ret.Product_code is not null)
                        col[18] = ret.Product_code.ToString();
                    if (ret.Product_sub_code is not null)
                        col[19] = ret.Product_sub_code.ToString();
                    if (ret.Product_name is not null)
                        col[20] = ret.Product_name.ToString();
                    col[21] = ret.Count_per_case.ToString();
                    col[22] = ret.Piece_count.ToString();
                    col[23] = ret.Count_per_pack.ToString();
                    col[24] = ret.Limit_type.ToString();
                    col[25] = ret.Limit_days.ToString();
                    col[26] = ret.Case_paste_category.ToString();
                    col[27] = ret.Selling_price.ToString();
                    if(ret.Storage_method is not null)
                        col[28] = ret.Storage_method.ToString();
                    col[29] = ret.Planed_count.ToString();
                    col[30] = ret.Skipped_count.ToString();
                    col[31] = ret.Printed_count.ToString();
                    col[32] = ret.Pasted_count.ToString();
                    col[33] = ret.Passed_count.ToString();
                    col[34] = ret.Rejected_count.ToString();

                    itm1 = new ListViewItem(col);
                    LstViewResult1.Items.Add(itm1);
                    LstViewResult1.Items[^1].UseItemStyleForSubItems = false;

                    if (LstViewResult1.Items.Count % 2 == 0)
                    {
                        // 偶数行の色反転
                        for (var intLoopCnt = 0; intLoopCnt <= 33; intLoopCnt++)
                        {
                            LstViewResult1.Items[^1].SubItems[intLoopCnt].BackColor = Color.FromArgb(200, 200, 230);
                        }
                    }
                    string sResult = "";
                    foreach(var sData in col)
                    {
                        sResult += sData + ",";
                    }
                    CommonModule.OutPutLogFile("【1号機】【オーダーテーブル】" + sResult);

                }
                LblResult1.Text = LstViewResult1.Items.Count.ToString("###,##0") + "件";

                // 履歴テーブルの更新
                BtnRefresh3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【BtnDisplay1_Click】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 「更新2」ボタン処理（2号機オーダーテーブル表示用）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh2_Click(object sender, EventArgs e)
        {
            string[] col = new string[35];
            ListViewItem itm2;

            try
            {
                LstViewResult2.Items.Clear();

                string sSQLData = "";
                string sPicDay1 = dTimPickerImportDate2.Value.ToString("yyyy-MM-dd");
                string sPicDay2 = dTimPickerImportDate2.Value.AddDays(1).ToString("yyyy-MM-dd");
                string sDate1 = "UNIX_TIMESTAMP('" + sPicDay1 + " 00:00:00') * 1000";
                string sDate2 = "UNIX_TIMESTAMP('" + sPicDay2 + " 00:00:00') * 1000";

                switch (CmbComp2.SelectedIndex)
                {
                    case 0: // ＞                        
                        sSQLData = "SELECT * FROM `order` WHERE IMPORT_TIME > " + sDate1 + ";";
                        break;
                    case 1: // ＝
                        sSQLData = "SELECT * FROM `order` WHERE IMPORT_TIME BETWEEN " + sDate1 + " AND " + sDate2 + ";";
                        break;
                    case 2: // ＜
                        sSQLData = "SELECT * FROM `order` WHERE IMPORT_TIME < " + sDate1 + ";";
                        break;
                }
                CommonModule.OutPutLogFile("【2号機】【オーダーテーブル】検索条件：" + sSQLData);
                var result = ExecuteReader(sSQLData, TxtIpAddress2.Text);
                foreach (var ret in result)
                {
                    // 検索結果を表示
                    col[0] = ret.Id.ToString();
                    col[1] = DateTimeOffset.FromUnixTimeSeconds(ret.Import_time / 1000).ToLocalTime().ToString();
                    col[2] = ret.Import_index.ToString();
                    col[3] = ret.Status.ToString();
                    col[4] = ret.Is_retried.ToString();
                    if(ret.Record_id is not null)
                        col[5] = ret.Record_id.ToString();
                    col[6] = ret.Data_category.ToString();
                    col[7] = ret.Logistics_center_code.ToString();
                    col[8] = ret.Shipment_no.ToString();
                    if(ret.Process_id is not null)
                        col[9] = ret.Process_id.ToString();
                    col[10] = DateTimeOffset.FromUnixTimeSeconds(ret.Planed_shipping_date / 1000).ToLocalTime().ToString();
                    col[11] = ret.Picking_no.ToString();
                    if(ret.List_pattern_name is not null)    
                        col[12] = ret.List_pattern_name.ToString();
                    col[13] = ret.Process_category.ToString();
                    if(ret.Customer_center_code is not null)
                        col[14] = ret.Customer_center_code.ToString();
                    col[15] = ret.Customer_company_code.ToString();
                    if(ret.Customer_name is not null)
                        col[16] = ret.Customer_name.ToString();                                       
                    if(ret.Customer_center_name is not null)
                        col[17] = ret.Customer_center_name.ToString();
                    if (ret.Product_code is not null)
                        col[18] = ret.Product_code.ToString();
                    if (ret.Product_sub_code is not null)
                        col[19] = ret.Product_sub_code.ToString();
                    if (ret.Product_name is not null)
                        col[20] = ret.Product_name.ToString();
                    col[21] = ret.Count_per_case.ToString();
                    col[22] = ret.Piece_count.ToString();
                    col[23] = ret.Count_per_pack.ToString();
                    col[24] = ret.Limit_type.ToString();
                    col[25] = ret.Limit_days.ToString();
                    col[26] = ret.Case_paste_category.ToString();
                    col[27] = ret.Selling_price.ToString();
                    if(ret.Storage_method is not null)
                        col[28] = ret.Storage_method.ToString();
                    col[29] = ret.Planed_count.ToString();
                    col[30] = ret.Skipped_count.ToString();
                    col[31] = ret.Printed_count.ToString();
                    col[32] = ret.Pasted_count.ToString();
                    col[33] = ret.Passed_count.ToString();
                    col[34] = ret.Rejected_count.ToString();

                    itm2 = new ListViewItem(col);
                    LstViewResult2.Items.Add(itm2);
                    LstViewResult2.Items[^1].UseItemStyleForSubItems = false;

                    if (LstViewResult2.Items.Count % 2 == 0)
                    {
                        // 偶数行の色反転
                        for (var intLoopCnt = 0; intLoopCnt <= 33; intLoopCnt++)
                        {
                            LstViewResult2.Items[^1].SubItems[intLoopCnt].BackColor = Color.FromArgb(200, 200, 230);
                        }
                    }

                    string sResult = "";
                    foreach (var sData in col)
                    {
                        sResult += sData + ",";
                    }
                    CommonModule.OutPutLogFile("【2号機】【オーダーテーブル】" + sResult);

                }
                LblResult2.Text = LstViewResult2.Items.Count.ToString("###,##0") + "件";

                // 履歴テーブルの更新
                BtnRefresh4_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【BtnDisplay2_Click】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 「更新3」ボタン処理（1号機履歴テーブル表示用）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh3_Click(object sender, EventArgs e)
        {
            string[] col = new string[17];
            ListViewItem itm3;

            try
            {
                LstViewResult3.Items.Clear();

                string sSQLData = "";
                string sPicDay1 = dTimPickerImportDate1.Value.ToString("yyyy-MM-dd");
                string sPicDay2 = dTimPickerImportDate1.Value.AddDays(1).ToString("yyyy-MM-dd");
                string sDate1 = "UNIX_TIMESTAMP('" + sPicDay1 + " 00:00:00') * 1000";
                string sDate2 = "UNIX_TIMESTAMP('" + sPicDay2 + " 00:00:00') * 1000";
                switch (CmbComp1.SelectedIndex)
                {
                    case 0: // ＞                        
                        sSQLData = "SELECT * FROM `history` WHERE PROCESS_DATE_START > " + sDate1 + ";";
                        break;
                    case 1: // ＝
                        sSQLData = "SELECT * FROM `history` WHERE PROCESS_DATE_START BETWEEN " + sDate1 + " AND " + sDate2 + ";";
                        break;
                    case 2: // ＜
                        sSQLData = "SELECT * FROM `history` WHERE PROCESS_DATE_START < " + sDate1 + ";";
                        break;
                }
                CommonModule.OutPutLogFile("【1号機】【履歴テーブル】検索条件：" + sSQLData);
                var result = ExecuteReaderForHistory(sSQLData, TxtIpAddress1.Text);
                foreach (var ret in result)
                {
                    // 検索結果を表示
                    col[0] = ret.Id.ToString();
                    col[1] = ret.Start_count.ToString();
                    col[2] = ret.Planed_count.ToString();
                    col[3] = ret.Skipped_count.ToString();
                    col[4] = ret.Printed_count.ToString();
                    col[5] = ret.Pasted_count.ToString();
                    col[6] = ret.Passed_count.ToString();
                    col[7] = ret.Rejected_count.ToString();
                    col[8] = DateTimeOffset.FromUnixTimeSeconds(ret.Process_date_start/1000).ToString();
                    col[9] = DateTimeOffset.FromUnixTimeSeconds(ret.Process_date_end/1000).ToString();
                    if(ret.User_code is not null)
                        col[10] = ret.User_code.ToString();
                    if(ret.Device_id is not null)
                        col[11] = ret.Device_id.ToString();
                    col[12] = ret.Is_offline.ToString();
                    col[13] = ret.Is_retried.ToString();
                    if(ret.Cancel_reason is not null)
                        col[14] = ret.Cancel_reason.ToString().Replace('\n', '■');
                    if(ret.Productivity_time is not null)
                        col[15] = ret.Productivity_time.ToString();
                    col[16] = ret.Order_id.ToString();

                    itm3 = new ListViewItem(col);
                    LstViewResult3.Items.Add(itm3);
                    LstViewResult3.Items[^1].UseItemStyleForSubItems = false;

                    if (LstViewResult3.Items.Count % 2 == 0)
                    {
                        // 偶数行の色反転
                        for (var intLoopCnt = 0; intLoopCnt <= 16; intLoopCnt++)
                        {
                            LstViewResult3.Items[^1].SubItems[intLoopCnt].BackColor = Color.FromArgb(200, 200, 230);
                        }
                    }

                    string sResult = "";
                    foreach (var sData in col)
                    {
                        sResult += sData + ",";
                    }
                    CommonModule.OutPutLogFile("【1号機】【履歴テーブル】" + sResult);

                }
                LblResult3.Text = LstViewResult3.Items.Count.ToString("###,##0") + "件";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【BtnRefresh3_Click】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// 「更新4」ボタン処理（2号機履歴テーブル用）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh4_Click(object sender, EventArgs e)
        {
            string[] col = new string[17];
            ListViewItem itm4;

            try
            {
                LstViewResult4.Items.Clear();

                string sSQLData = "";
                string sPicDay1 = dTimPickerImportDate2.Value.ToString("yyyy-MM-dd");
                string sPicDay2 = dTimPickerImportDate2.Value.AddDays(1).ToString("yyyy-MM-dd");
                string sDate1 = "UNIX_TIMESTAMP('" + sPicDay1 + " 00:00:00') * 1000";
                string sDate2 = "UNIX_TIMESTAMP('" + sPicDay2 + " 00:00:00') * 1000";
                switch (CmbComp2.SelectedIndex)
                {
                    case 0: // ＞                        
                        sSQLData = "SELECT * FROM `history` WHERE PROCESS_DATE_START > " + sDate1 + ";";
                        break;
                    case 1: // ＝
                        sSQLData = "SELECT * FROM `history` WHERE PROCESS_DATE_START BETWEEN " + sDate1 + " AND " + sDate2 + ";";
                        break;
                    case 2: // ＜
                        sSQLData = "SELECT * FROM `history` WHERE PROCESS_DATE_START < " + sDate1 + ";";
                        break;
                }
                CommonModule.OutPutLogFile("【2号機】【履歴テーブル】検索条件：" + sSQLData);
                var result4 = ExecuteReaderForHistory(sSQLData, TxtIpAddress2.Text);
                foreach (var ret in result4)
                {
                    // 検索結果を表示
                    col[0] = ret.Id.ToString();
                    col[1] = ret.Start_count.ToString();
                    col[2] = ret.Planed_count.ToString();
                    col[3] = ret.Skipped_count.ToString();
                    col[4] = ret.Printed_count.ToString();
                    col[5] = ret.Pasted_count.ToString();
                    col[6] = ret.Passed_count.ToString();
                    col[7] = ret.Rejected_count.ToString();
                    col[8] = DateTimeOffset.FromUnixTimeSeconds(ret.Process_date_start / 1000).ToString();
                    col[9] = DateTimeOffset.FromUnixTimeSeconds(ret.Process_date_end / 1000).ToString();
                    if(ret.User_code is not null)
                        col[10] = ret.User_code.ToString();
                    if(ret.Device_id is not null)
                        col[11] = ret.Device_id.ToString();
                    col[12] = ret.Is_offline.ToString();
                    col[13] = ret.Is_retried.ToString();
                    if (ret.Cancel_reason is not null)
                        col[14] = ret.Cancel_reason.ToString().Replace('\n', '■');
                    if(ret.Productivity_time is not null)
                        col[15] = ret.Productivity_time.ToString();
                    col[16] = ret.Order_id.ToString();

                    itm4 = new ListViewItem(col);
                    LstViewResult4.Items.Add(itm4);
                    LstViewResult4.Items[^1].UseItemStyleForSubItems = false;

                    if (LstViewResult4.Items.Count % 2 == 0)
                    {
                        // 偶数行の色反転
                        for (var intLoopCnt = 0; intLoopCnt <= 16; intLoopCnt++)
                        {
                            LstViewResult4.Items[^1].SubItems[intLoopCnt].BackColor = Color.FromArgb(200, 200, 230);
                        }
                    }

                    string sResult = "";
                    foreach (var sData in col)
                    {
                        sResult += sData + ",";
                    }
                    CommonModule.OutPutLogFile("【2号機】【履歴テーブル】" + sResult);

                }
                LblResult4.Text = LstViewResult4.Items.Count.ToString("###,##0") + "件";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【BtnRefresh4_Click】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 「終了」ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        /// <summary>
        /// 「✕」ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperationLogDisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                // フォームを閉じるのをキャンセル
                e.Cancel = true;
            }            
        }

    }
}