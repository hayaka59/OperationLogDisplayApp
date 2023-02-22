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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationLogDisplayForm));
            this.BtnRefresh1 = new System.Windows.Forms.Button();
            this.LblResult1 = new System.Windows.Forms.Label();
            this.LstViewResult1 = new System.Windows.Forms.ListView();
            this.LstViewResult2 = new System.Windows.Forms.ListView();
            this.LblTitle1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResult2 = new System.Windows.Forms.Label();
            this.BtnRefresh2 = new System.Windows.Forms.Button();
            this.TxtIpAddress1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIpAddress2 = new System.Windows.Forms.TextBox();
            this.LstViewResult3 = new System.Windows.Forms.ListView();
            this.BtnRefresh3 = new System.Windows.Forms.Button();
            this.LblResult3 = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.dTimPickerImportDate1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbComp1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmbComp2 = new System.Windows.Forms.ComboBox();
            this.dTimPickerImportDate2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.LstViewResult4 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRefresh4 = new System.Windows.Forms.Button();
            this.LblResult4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRefresh1
            // 
            this.BtnRefresh1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh1.Image = global::プロジェクト名_OperationLogDisplay.Properties.Resources.reload_small;
            this.BtnRefresh1.Location = new System.Drawing.Point(639, 10);
            this.BtnRefresh1.Name = "BtnRefresh1";
            this.BtnRefresh1.Size = new System.Drawing.Size(133, 45);
            this.BtnRefresh1.TabIndex = 1;
            this.BtnRefresh1.Text = "更新";
            this.BtnRefresh1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRefresh1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh1.UseVisualStyleBackColor = true;
            this.BtnRefresh1.Click += new System.EventHandler(this.BtnRefresh1_Click);
            // 
            // LblResult1
            // 
            this.LblResult1.AutoSize = true;
            this.LblResult1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult1.ForeColor = System.Drawing.Color.Red;
            this.LblResult1.Location = new System.Drawing.Point(848, 415);
            this.LblResult1.Name = "LblResult1";
            this.LblResult1.Size = new System.Drawing.Size(91, 24);
            this.LblResult1.TabIndex = 3;
            this.LblResult1.Text = "LblResult1";
            // 
            // LstViewResult1
            // 
            this.LstViewResult1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstViewResult1.FullRowSelect = true;
            this.LstViewResult1.Location = new System.Drawing.Point(39, 60);
            this.LstViewResult1.Name = "LstViewResult1";
            this.LstViewResult1.Size = new System.Drawing.Size(900, 352);
            this.LstViewResult1.TabIndex = 4;
            this.LstViewResult1.UseCompatibleStateImageBehavior = false;
            // 
            // LstViewResult2
            // 
            this.LstViewResult2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstViewResult2.FullRowSelect = true;
            this.LstViewResult2.Location = new System.Drawing.Point(966, 60);
            this.LstViewResult2.Name = "LstViewResult2";
            this.LstViewResult2.Size = new System.Drawing.Size(900, 352);
            this.LstViewResult2.TabIndex = 5;
            this.LstViewResult2.UseCompatibleStateImageBehavior = false;
            // 
            // LblTitle1
            // 
            this.LblTitle1.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblTitle1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle1.ForeColor = System.Drawing.Color.White;
            this.LblTitle1.Location = new System.Drawing.Point(39, 9);
            this.LblTitle1.Name = "LblTitle1";
            this.LblTitle1.Size = new System.Drawing.Size(144, 45);
            this.LblTitle1.TabIndex = 6;
            this.LblTitle1.Text = "１号機";
            this.LblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(966, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "２号機";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblResult2
            // 
            this.LblResult2.AutoSize = true;
            this.LblResult2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult2.ForeColor = System.Drawing.Color.Red;
            this.LblResult2.Location = new System.Drawing.Point(1775, 415);
            this.LblResult2.Name = "LblResult2";
            this.LblResult2.Size = new System.Drawing.Size(91, 24);
            this.LblResult2.TabIndex = 8;
            this.LblResult2.Text = "LblResult2";
            // 
            // BtnRefresh2
            // 
            this.BtnRefresh2.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh2.Image = global::プロジェクト名_OperationLogDisplay.Properties.Resources.reload_small;
            this.BtnRefresh2.Location = new System.Drawing.Point(1555, 12);
            this.BtnRefresh2.Name = "BtnRefresh2";
            this.BtnRefresh2.Size = new System.Drawing.Size(133, 45);
            this.BtnRefresh2.TabIndex = 9;
            this.BtnRefresh2.Text = "更新";
            this.BtnRefresh2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh2.UseVisualStyleBackColor = true;
            this.BtnRefresh2.Click += new System.EventHandler(this.BtnRefresh2_Click);
            // 
            // TxtIpAddress1
            // 
            this.TxtIpAddress1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIpAddress1.Location = new System.Drawing.Point(11, 21);
            this.TxtIpAddress1.Name = "TxtIpAddress1";
            this.TxtIpAddress1.Size = new System.Drawing.Size(155, 27);
            this.TxtIpAddress1.TabIndex = 11;
            this.TxtIpAddress1.Text = "255.255.255.255";
            this.TxtIpAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtIpAddress1);
            this.groupBox1.Location = new System.Drawing.Point(189, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 59);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1号機IPアドレス";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtIpAddress2);
            this.groupBox2.Location = new System.Drawing.Point(1116, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 59);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2号機IPアドレス";
            // 
            // TxtIpAddress2
            // 
            this.TxtIpAddress2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIpAddress2.Location = new System.Drawing.Point(11, 21);
            this.TxtIpAddress2.Name = "TxtIpAddress2";
            this.TxtIpAddress2.Size = new System.Drawing.Size(155, 27);
            this.TxtIpAddress2.TabIndex = 11;
            this.TxtIpAddress2.Text = "255.255.255.255";
            this.TxtIpAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LstViewResult3
            // 
            this.LstViewResult3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstViewResult3.FullRowSelect = true;
            this.LstViewResult3.Location = new System.Drawing.Point(39, 501);
            this.LstViewResult3.Name = "LstViewResult3";
            this.LstViewResult3.Size = new System.Drawing.Size(900, 397);
            this.LstViewResult3.TabIndex = 15;
            this.LstViewResult3.UseCompatibleStateImageBehavior = false;
            // 
            // BtnRefresh3
            // 
            this.BtnRefresh3.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh3.Image = global::プロジェクト名_OperationLogDisplay.Properties.Resources.reload_small;
            this.BtnRefresh3.Location = new System.Drawing.Point(639, 450);
            this.BtnRefresh3.Name = "BtnRefresh3";
            this.BtnRefresh3.Size = new System.Drawing.Size(133, 45);
            this.BtnRefresh3.TabIndex = 16;
            this.BtnRefresh3.Text = "更新";
            this.BtnRefresh3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRefresh3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh3.UseVisualStyleBackColor = true;
            this.BtnRefresh3.Click += new System.EventHandler(this.BtnRefresh3_Click);
            // 
            // LblResult3
            // 
            this.LblResult3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult3.ForeColor = System.Drawing.Color.Red;
            this.LblResult3.Location = new System.Drawing.Point(804, 901);
            this.LblResult3.Name = "LblResult3";
            this.LblResult3.Size = new System.Drawing.Size(133, 24);
            this.LblResult3.TabIndex = 17;
            this.LblResult3.Text = "LblResult3";
            this.LblResult3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblVersion
            // 
            this.LblVersion.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVersion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblVersion.Location = new System.Drawing.Point(1612, 929);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(254, 23);
            this.LblVersion.TabIndex = 18;
            this.LblVersion.Text = "LblVersion";
            this.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnEnd
            // 
            this.BtnEnd.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEnd.Image = global::プロジェクト名_OperationLogDisplay.Properties.Resources.exit_icon_small;
            this.BtnEnd.Location = new System.Drawing.Point(39, 907);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(133, 45);
            this.BtnEnd.TabIndex = 19;
            this.BtnEnd.Text = "終了";
            this.BtnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // dTimPickerImportDate1
            // 
            this.dTimPickerImportDate1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTimPickerImportDate1.Location = new System.Drawing.Point(71, 22);
            this.dTimPickerImportDate1.Name = "dTimPickerImportDate1";
            this.dTimPickerImportDate1.Size = new System.Drawing.Size(160, 27);
            this.dTimPickerImportDate1.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbComp1);
            this.groupBox3.Controls.Add(this.dTimPickerImportDate1);
            this.groupBox3.Location = new System.Drawing.Point(377, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 59);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "取込日付";
            // 
            // CmbComp1
            // 
            this.CmbComp1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbComp1.FormattingEnabled = true;
            this.CmbComp1.Location = new System.Drawing.Point(15, 22);
            this.CmbComp1.Name = "CmbComp1";
            this.CmbComp1.Size = new System.Drawing.Size(50, 28);
            this.CmbComp1.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmbComp2);
            this.groupBox4.Controls.Add(this.dTimPickerImportDate2);
            this.groupBox4.Location = new System.Drawing.Point(1302, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 59);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "取込日付";
            // 
            // CmbComp2
            // 
            this.CmbComp2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbComp2.FormattingEnabled = true;
            this.CmbComp2.Location = new System.Drawing.Point(15, 22);
            this.CmbComp2.Name = "CmbComp2";
            this.CmbComp2.Size = new System.Drawing.Size(50, 28);
            this.CmbComp2.TabIndex = 20;
            // 
            // dTimPickerImportDate2
            // 
            this.dTimPickerImportDate2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTimPickerImportDate2.Location = new System.Drawing.Point(71, 22);
            this.dTimPickerImportDate2.Name = "dTimPickerImportDate2";
            this.dTimPickerImportDate2.Size = new System.Drawing.Size(160, 27);
            this.dTimPickerImportDate2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 45);
            this.label2.TabIndex = 21;
            this.label2.Text = "履歴テーブル";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LstViewResult4
            // 
            this.LstViewResult4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstViewResult4.FullRowSelect = true;
            this.LstViewResult4.Location = new System.Drawing.Point(966, 501);
            this.LstViewResult4.Name = "LstViewResult4";
            this.LstViewResult4.Size = new System.Drawing.Size(900, 397);
            this.LstViewResult4.TabIndex = 24;
            this.LstViewResult4.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(966, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 45);
            this.label3.TabIndex = 26;
            this.label3.Text = "履歴テーブル";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRefresh4
            // 
            this.BtnRefresh4.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh4.Image = global::プロジェクト名_OperationLogDisplay.Properties.Resources.reload_small;
            this.BtnRefresh4.Location = new System.Drawing.Point(1566, 450);
            this.BtnRefresh4.Name = "BtnRefresh4";
            this.BtnRefresh4.Size = new System.Drawing.Size(133, 45);
            this.BtnRefresh4.TabIndex = 25;
            this.BtnRefresh4.Text = "更新";
            this.BtnRefresh4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRefresh4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh4.UseVisualStyleBackColor = true;
            this.BtnRefresh4.Click += new System.EventHandler(this.BtnRefresh4_Click);
            // 
            // LblResult4
            // 
            this.LblResult4.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResult4.ForeColor = System.Drawing.Color.Red;
            this.LblResult4.Location = new System.Drawing.Point(1730, 901);
            this.LblResult4.Name = "LblResult4";
            this.LblResult4.Size = new System.Drawing.Size(133, 24);
            this.LblResult4.TabIndex = 29;
            this.LblResult4.Text = "LblResult4";
            this.LblResult4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OperationLogDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.LblResult4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRefresh4);
            this.Controls.Add(this.LstViewResult4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.LblResult3);
            this.Controls.Add(this.BtnRefresh3);
            this.Controls.Add(this.LstViewResult3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnRefresh2);
            this.Controls.Add(this.LblResult2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle1);
            this.Controls.Add(this.LstViewResult2);
            this.Controls.Add(this.LstViewResult1);
            this.Controls.Add(this.LblResult1);
            this.Controls.Add(this.BtnRefresh1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationLogDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "稼働ログ表示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperationLogDisplayForm_FormClosing);
            this.Load += new System.EventHandler(this.OperationLogDisplayForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnRefresh1;
        private Label LblResult1;
        private ListView LstViewResult1;
        private ListView LstViewResult2;
        private Label LblTitle1;
        private Label label1;
        private Label LblResult2;
        private Button BtnRefresh2;
        private TextBox TxtIpAddress1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TxtIpAddress2;
        private ListView LstViewResult3;
        private Button BtnRefresh3;
        private Label LblResult3;
        private Label LblVersion;
        private Button BtnEnd;
        private DateTimePicker dTimPickerImportDate1;
        private GroupBox groupBox3;
        private ComboBox CmbComp1;
        private GroupBox groupBox4;
        private ComboBox CmbComp2;
        private DateTimePicker dTimPickerImportDate2;
        private Label label2;
        private ListView LstViewResult4;
        private Label label3;
        private Button BtnRefresh4;
        private Label LblResult4;
    }
}