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
            this.LstViewResult = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LstBoxResult
            // 
            this.LstBoxResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LstBoxResult.FormattingEnabled = true;
            this.LstBoxResult.ItemHeight = 16;
            this.LstBoxResult.Location = new System.Drawing.Point(12, 284);
            this.LstBoxResult.Name = "LstBoxResult";
            this.LstBoxResult.ScrollAlwaysVisible = true;
            this.LstBoxResult.Size = new System.Drawing.Size(1313, 68);
            this.LstBoxResult.TabIndex = 0;
            // 
            // BtnDisplay1
            // 
            this.BtnDisplay1.Location = new System.Drawing.Point(31, 396);
            this.BtnDisplay1.Name = "BtnDisplay1";
            this.BtnDisplay1.Size = new System.Drawing.Size(75, 23);
            this.BtnDisplay1.TabIndex = 1;
            this.BtnDisplay1.Text = "表示１";
            this.BtnDisplay1.UseVisualStyleBackColor = true;
            this.BtnDisplay1.Click += new System.EventHandler(this.BtnDisplay1_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(125, 396);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
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
            this.LblResult.Location = new System.Drawing.Point(12, 355);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(81, 24);
            this.LblResult.TabIndex = 3;
            this.LblResult.Text = "LblResult";
            // 
            // LstViewResult
            // 
            this.LstViewResult.Location = new System.Drawing.Point(9, 12);
            this.LstViewResult.Name = "LstViewResult";
            this.LstViewResult.Size = new System.Drawing.Size(1316, 260);
            this.LstViewResult.TabIndex = 4;
            this.LstViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // OperationLogDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 431);
            this.Controls.Add(this.LstViewResult);
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
        private ListView LstViewResult;
    }
}