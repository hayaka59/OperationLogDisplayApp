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
            this.BtnRefresh1 = new System.Windows.Forms.Button();
            this.BtnClear1 = new System.Windows.Forms.Button();
            this.LblResult1 = new System.Windows.Forms.Label();
            this.LstViewResult1 = new System.Windows.Forms.ListView();
            this.LstViewResult2 = new System.Windows.Forms.ListView();
            this.LblTitle1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResult2 = new System.Windows.Forms.Label();
            this.BtnClear2 = new System.Windows.Forms.Button();
            this.BtnRefresh2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRefresh1
            // 
            this.BtnRefresh1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh1.Location = new System.Drawing.Point(39, 622);
            this.BtnRefresh1.Name = "BtnRefresh1";
            this.BtnRefresh1.Size = new System.Drawing.Size(133, 40);
            this.BtnRefresh1.TabIndex = 1;
            this.BtnRefresh1.Text = "更新";
            this.BtnRefresh1.UseVisualStyleBackColor = true;
            this.BtnRefresh1.Click += new System.EventHandler(this.BtnRefresh1_Click);
            // 
            // BtnClear1
            // 
            this.BtnClear1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClear1.Location = new System.Drawing.Point(178, 622);
            this.BtnClear1.Name = "BtnClear1";
            this.BtnClear1.Size = new System.Drawing.Size(133, 40);
            this.BtnClear1.TabIndex = 2;
            this.BtnClear1.Text = "クリア";
            this.BtnClear1.UseVisualStyleBackColor = true;
            this.BtnClear1.Click += new System.EventHandler(this.BtnClear1_Click);
            // 
            // LblResult1
            // 
            this.LblResult1.AutoSize = true;
            this.LblResult1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult1.ForeColor = System.Drawing.Color.Red;
            this.LblResult1.Location = new System.Drawing.Point(39, 580);
            this.LblResult1.Name = "LblResult1";
            this.LblResult1.Size = new System.Drawing.Size(91, 24);
            this.LblResult1.TabIndex = 3;
            this.LblResult1.Text = "LblResult1";
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
            // LblResult2
            // 
            this.LblResult2.AutoSize = true;
            this.LblResult2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult2.ForeColor = System.Drawing.Color.Red;
            this.LblResult2.Location = new System.Drawing.Point(966, 580);
            this.LblResult2.Name = "LblResult2";
            this.LblResult2.Size = new System.Drawing.Size(91, 24);
            this.LblResult2.TabIndex = 8;
            this.LblResult2.Text = "LblResult2";
            // 
            // BtnClear2
            // 
            this.BtnClear2.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClear2.Location = new System.Drawing.Point(1105, 622);
            this.BtnClear2.Name = "BtnClear2";
            this.BtnClear2.Size = new System.Drawing.Size(133, 40);
            this.BtnClear2.TabIndex = 10;
            this.BtnClear2.Text = "クリア";
            this.BtnClear2.UseVisualStyleBackColor = true;
            this.BtnClear2.Click += new System.EventHandler(this.BtnClear2_Click);
            // 
            // BtnRefresh2
            // 
            this.BtnRefresh2.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh2.Location = new System.Drawing.Point(966, 622);
            this.BtnRefresh2.Name = "BtnRefresh2";
            this.BtnRefresh2.Size = new System.Drawing.Size(133, 40);
            this.BtnRefresh2.TabIndex = 9;
            this.BtnRefresh2.Text = "更新";
            this.BtnRefresh2.UseVisualStyleBackColor = true;
            this.BtnRefresh2.Click += new System.EventHandler(this.BtnRefresh2_Click);
            // 
            // OperationLogDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 693);
            this.Controls.Add(this.BtnClear2);
            this.Controls.Add(this.BtnRefresh2);
            this.Controls.Add(this.LblResult2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle1);
            this.Controls.Add(this.LstViewResult2);
            this.Controls.Add(this.LstViewResult1);
            this.Controls.Add(this.LblResult1);
            this.Controls.Add(this.BtnClear1);
            this.Controls.Add(this.BtnRefresh1);
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
        private Button BtnRefresh1;
        private Button BtnClear1;
        private Label LblResult1;
        private ListView LstViewResult1;
        private ListView LstViewResult2;
        private Label LblTitle1;
        private Label label1;
        private Label LblResult2;
        private Button BtnClear2;
        private Button BtnRefresh2;
    }
}