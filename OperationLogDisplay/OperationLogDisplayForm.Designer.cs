namespace OperationLogDisplay
{
    partial class OperationLogDisplayForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstBoxResult = new System.Windows.Forms.ListBox();
            this.BtnDisplay1 = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.LstViewResult1 = new System.Windows.Forms.ListView();
            this.LstViewResult2 = new System.Windows.Forms.ListView();
            this.LblTitle1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstBoxResult
            // 
            this.LstBoxResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LstBoxResult.FormattingEnabled = true;
            this.LstBoxResult.ItemHeight = 16;
            this.LstBoxResult.Location = new System.Drawing.Point(39, 743);
            this.LstBoxResult.Name = "LstBoxResult";
            this.LstBoxResult.ScrollAlwaysVisible = true;
            this.LstBoxResult.Size = new System.Drawing.Size(1083, 20);
            this.LstBoxResult.TabIndex = 0;
            this.LstBoxResult.Visible = false;
            // 
            // BtnDisplay1
            // 
            this.BtnDisplay1.Location = new System.Drawing.Point(39, 622);
            this.BtnDisplay1.Name = "BtnDisplay1";
            this.BtnDisplay1.Size = new System.Drawing.Size(94, 46);
            this.BtnDisplay1.TabIndex = 1;
            this.BtnDisplay1.Text = "表示１";
            this.BtnDisplay1.UseVisualStyleBackColor = true;
            this.BtnDisplay1.Click += new System.EventHandler(this.BtnDisplay1_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(39, 674);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 46);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "クリア";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult.ForeColor = System.Drawing.Color.Red;
            this.LblResult.Location = new System.Drawing.Point(39, 580);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(81, 24);
            this.LblResult.TabIndex = 3;
            this.LblResult.Text = "LblResult";
            // 
            // LstViewResult1
            // 
            this.LstViewResult1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstViewResult1.FullRowSelect = true;
            this.LstViewResult1.Location = new System.Drawing.Point(39, 50);
            this.LstViewResult1.Name = "LstViewResult1";
            this.LstViewResult1.Size = new System.Drawing.Size(900, 500);
            this.LstViewResult1.TabIndex = 4;
            this.LstViewResult1.UseCompatibleStateImageBehavior = false;
            // 
            // LstViewResult2
            // 
            this.LstViewResult2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstViewResult2.FullRowSelect = true;
            this.LstViewResult2.Location = new System.Drawing.Point(966, 50);
            this.LstViewResult2.Name = "LstViewResult2";
            this.LstViewResult2.Size = new System.Drawing.Size(900, 500);
            this.LstViewResult2.TabIndex = 5;
            this.LstViewResult2.UseCompatibleStateImageBehavior = false;
            // 
            // LblTitle1
            // 
            this.LblTitle1.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblTitle1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle1.ForeColor = System.Drawing.Color.White;
            this.LblTitle1.Location = new System.Drawing.Point(39, 20);
            this.LblTitle1.Name = "LblTitle1";
            this.LblTitle1.Size = new System.Drawing.Size(900, 30);
            this.LblTitle1.TabIndex = 6;
            this.LblTitle1.Text = "１号機";
            this.LblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(966, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "２号機";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OperationLogDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle1);
            this.Controls.Add(this.LstViewResult2);
            this.Controls.Add(this.LstViewResult1);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDisplay1);
            this.Controls.Add(this.LstBoxResult);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationLogDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "稼働ログ表示";
            this.Load += new System.EventHandler(this.OperationLogDisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LstBoxResult;
        private Button BtnDisplay1;
        private Button BtnClear;
        private Label LblResult;
        private ListView LstViewResult1;
        private ListView LstViewResult2;
        private Label LblTitle1;
        private Label label1;
    }
}