using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

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
                LblResult1.Text = "";
                LblResult2.Text = "";
                DisplayHeader(LstViewResult1);
                DisplayHeader(LstViewResult2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【OperationLogDisplayForm_Load】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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


        public static void ExecuteNonQuery(string query)
        {
            // MySQLへの接続情報を設定
            //var server = "127.0.0.1";  // ホスト名
            var server = "192.168.40.119";  // ホスト名
            var port = 3306;                // ポート
            var user = "root";              // ユーザー名
            var pass = "srobo";             // パスワード
            var charset = "utf8";           // エンコード
            var connectionString = $"Hostname={server};Port={port};Username={user};Password={pass};Charset={charset};";

            try
            {
                using MySqlConnection connection = new(connectionString);
                using var command = connection.CreateCommand();
                // MySQLへ接続
                connection.Open();

                // クエリーの実行処理
                command.CommandText = query;
                //command.ExecuteNonQuery();
                var value = command.ExecuteNonQuery();
                MessageBox.Show($"更新されたレコード数は {value} です。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【ExecuteNonQuery】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private static List<OrderData> ExecuteReader1(string query)
        {
            // 検索条件に一致したレコードを格納するコレクション
            List<OrderData> Datas = new();

            // MySQLへの接続情報を設定
            var server = "127.0.0.1";   // ホスト名
            //var server = "192.168.101.10";   // ホスト名
            var port = 3306;            // ポート
            var user = "devuser";       // ユーザー名
            var pass = "Pf6QfXcQ";      // パスワード
            var charset = "utf8";       // エンコード
            var database = "srobo";     // データベース
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
                MessageBox.Show(ex.Message);
            }
            return Datas;
        }

        private static List<OrderData> ExecuteReader2(string query)
        {
            // 検索条件に一致したレコードを格納するコレクション
            List<OrderData> Datas = new();

            // MySQLへの接続情報を設定
            var server = "127.0.0.1";   // ホスト名
            //var server = "192.168.101.10";   // ホスト名
            var port = 3306;            // ポート
            var user = "devuser";       // ユーザー名
            var pass = "Pf6QfXcQ";      // パスワード
            var charset = "utf8";       // エンコード
            var database = "srobo";     // データベース
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
                MessageBox.Show(ex.Message);
            }
            return Datas;
        }

        /// <summary>
        /// 
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
        /// 「更新１」ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh1_Click(object sender, EventArgs e)
        {
            string[] col = new string[35];
            ListViewItem itm1;
            
            try
            {
                var result1 = ExecuteReader1("SELECT * FROM `order`;");
                foreach (var ret in result1)
                {
                    // 検索結果を表示
                    col[0] = ret.Id.ToString();
                    col[1] = DateTimeOffset.FromUnixTimeSeconds(ret.Import_time / 1000).ToLocalTime().ToString();
                    col[2] = ret.Import_index.ToString();
                    col[3] = ret.Status.ToString();
                    col[4] = ret.Is_retried.ToString();
                    col[5] = ret.Record_id.ToString();
                    col[6] = ret.Data_category.ToString();
                    col[7] = ret.Logistics_center_code.ToString();
                    col[8] = ret.Shipment_no.ToString();
                    col[9] = ret.Process_id.ToString();
                    col[10] = DateTimeOffset.FromUnixTimeSeconds(ret.Planed_shipping_date / 1000).ToLocalTime().ToString();
                    col[11] = ret.Picking_no.ToString();
                    col[12] = ret.List_pattern_name.ToString();
                    col[13] = ret.Process_category.ToString();
                    col[14] = ret.Customer_center_code.ToString();
                    col[15] = ret.Customer_company_code.ToString();
                    col[16] = ret.Customer_name.ToString();
                    col[17] = ret.Customer_center_name.ToString();
                    col[18] = ret.Product_code.ToString();
                    col[19] = ret.Product_sub_code.ToString();
                    col[20] = ret.Product_name.ToString();
                    col[21] = ret.Count_per_case.ToString();
                    col[22] = ret.Piece_count.ToString();
                    col[23] = ret.Count_per_pack.ToString();
                    col[24] = ret.Limit_type.ToString();
                    col[25] = ret.Limit_days.ToString();
                    col[26] = ret.Case_paste_category.ToString();
                    col[27] = ret.Selling_price.ToString();
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

                }
                LblResult1.Text = LstViewResult1.Items.Count.ToString("###,##0") + "件";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【BtnDisplay1_Click】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 「更新２」ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh2_Click(object sender, EventArgs e)
        {
            string[] col = new string[35];
            ListViewItem itm2;

            try
            {
                var result2 = ExecuteReader2("SELECT * FROM `order`;");
                foreach (var ret in result2)
                {
                    // 検索結果を表示
                    col[0] = ret.Id.ToString();
                    col[1] = DateTimeOffset.FromUnixTimeSeconds(ret.Import_time / 1000).ToLocalTime().ToString();
                    col[2] = ret.Import_index.ToString();
                    col[3] = ret.Status.ToString();
                    col[4] = ret.Is_retried.ToString();
                    col[5] = ret.Record_id.ToString();
                    col[6] = ret.Data_category.ToString();
                    col[7] = ret.Logistics_center_code.ToString();
                    col[8] = ret.Shipment_no.ToString();
                    col[9] = ret.Process_id.ToString();
                    col[10] = DateTimeOffset.FromUnixTimeSeconds(ret.Planed_shipping_date / 1000).ToLocalTime().ToString();
                    col[11] = ret.Picking_no.ToString();
                    col[12] = ret.List_pattern_name.ToString();
                    col[13] = ret.Process_category.ToString();
                    col[14] = ret.Customer_center_code.ToString();
                    col[15] = ret.Customer_company_code.ToString();
                    col[16] = ret.Customer_name.ToString();
                    col[17] = ret.Customer_center_name.ToString();
                    col[18] = ret.Product_code.ToString();
                    col[19] = ret.Product_sub_code.ToString();
                    col[20] = ret.Product_name.ToString();
                    col[21] = ret.Count_per_case.ToString();
                    col[22] = ret.Piece_count.ToString();
                    col[23] = ret.Count_per_pack.ToString();
                    col[24] = ret.Limit_type.ToString();
                    col[25] = ret.Limit_days.ToString();
                    col[26] = ret.Case_paste_category.ToString();
                    col[27] = ret.Selling_price.ToString();
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

                }
                LblResult2.Text = LstViewResult2.Items.Count.ToString("###,##0") + "件";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【BtnDisplay2_Click】", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 「クリア１」ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear1_Click(object sender, EventArgs e)
        {
            LstViewResult1.Items.Clear();
        }

        /// <summary>
        /// 「クリア２」ボタン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear2_Click(object sender, EventArgs e)
        {
            LstViewResult2.Items.Clear();
        }

    }
}