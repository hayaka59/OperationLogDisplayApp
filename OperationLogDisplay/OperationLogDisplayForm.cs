using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Diagnostics;

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
                LblResult.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ExecuteNonQuery(string query)
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
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (var command = connection.CreateCommand())
                {
                    // MySQLへ接続
                    connection.Open();

                    // クエリーの実行処理
                    command.CommandText = query;
                    //command.ExecuteNonQuery();
                    var value = command.ExecuteNonQuery();
                    MessageBox.Show($"更新されたレコード数は {value} です。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private List<Data> ExecuteReader(string query)
        {
            // 検索条件に一致したレコードを格納するコレクション
            List<Data> Datas = new List<Data>();

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
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (var commnad = connection.CreateCommand())
                {
                    // MySQLへ接続
                    connection.Open();

                    // クエリーの実行処理
                    commnad.CommandText = query;
                    using (var reader = commnad.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Datas.Add(new Data
                            {
                                Import_time = reader.GetInt64("import_time"),
                                Planed_shipping_date = reader.GetInt64("planed_shipping_date"),

                                Product_code = reader.GetString("product_code"),
                                Product_name = reader.GetString("product_name"),

                                Planed_count = reader.GetInt32("planed_count"),
                                Skipped_count = reader.GetInt32("skipped_count"),
                                Printed_count = reader.GetInt32("printed_count"),
                                Pasted_count = reader.GetInt32("pasted_count"),
                                Passed_count = reader.GetInt32("passed_count"),
                                Rejected_count = reader.GetInt32("rejected_count"),
                            });
                        }
                    }
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
        class Data
        {
            public long Import_time { get; set; }
            public long Planed_shipping_date { get; set; }

            public string Product_code { get; set; }
            public string Product_name { get; set; }
            public int Planed_count { get; set; }
            public int Skipped_count { get; set; }
            public int Printed_count { get; set; }
            public int Pasted_count { get; set; }
            public int Passed_count { get; set; }
            public int Rejected_count { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDisplay1_Click(object sender, EventArgs e)
        {
            try
            {
                LstBoxResult.Items.Clear();
                var result = ExecuteReader("SELECT * FROM `order`;");
                foreach (var ret in result)
                {
                    // 検索結果を表示
                    string sData = "";
                    sData += DateTimeOffset.FromUnixTimeSeconds(ret.Import_time/1000).ToLocalTime() + ",";
                    sData += DateTimeOffset.FromUnixTimeSeconds(ret.Planed_shipping_date/1000).ToLocalTime() + ",";

                    sData += ret.Product_code + ",";
                    sData += ret.Product_name + ",";

                    sData += ret.Planed_count + ",";
                    sData += ret.Skipped_count + ",";
                    sData += ret.Printed_count + ",";
                    sData += ret.Pasted_count + ",";
                    sData += ret.Passed_count + ",";
                    sData += ret.Rejected_count + ",";

                    LstBoxResult.Items.Add(sData);
                }
                LblResult.Text = LstBoxResult.Items.Count.ToString("###,##0")+"件";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "【BtnDisplay1_Click】", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            LstBoxResult.Items.Clear();
        }
    }
}