namespace プロジェクト名_OperationLogDisplay
{
    partial class OrderFileReadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFileReadForm));
            this.BtnClose = new System.Windows.Forms.Button();
            this.LstOrderFile = new System.Windows.Forms.ListView();
            this.BtnSelectOrderFile = new System.Windows.Forms.Button();
            this.LblSelectFilePath = new System.Windows.Forms.Label();
            this.LblDateTimeLocal = new System.Windows.Forms.Label();
            this.TimDateTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dTimPickerImportDate = new System.Windows.Forms.DateTimePicker();
            this.LstViewResult = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.Image = global::プロジェクト名_OperationLogDisplay.Properties.Resources.cancel;
            this.BtnClose.Location = new System.Drawing.Point(1755, 895);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(133, 50);
            this.BtnClose.TabIndex = 20;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LstOrderFile
            // 
            this.LstOrderFile.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstOrderFile.FullRowSelect = true;
            this.LstOrderFile.Location = new System.Drawing.Point(11, 68);
            this.LstOrderFile.Name = "LstOrderFile";
            this.LstOrderFile.Size = new System.Drawing.Size(1877, 413);
            this.LstOrderFile.TabIndex = 21;
            this.LstOrderFile.UseCompatibleStateImageBehavior = false;
            // 
            // BtnSelectOrderFile
            // 
            this.BtnSelectOrderFile.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSelectOrderFile.Image = global::プロジェクト名_OperationLogDisplay.Properties.Resources.select_file;
            this.BtnSelectOrderFile.Location = new System.Drawing.Point(11, 12);
            this.BtnSelectOrderFile.Name = "BtnSelectOrderFile";
            this.BtnSelectOrderFile.Size = new System.Drawing.Size(293, 50);
            this.BtnSelectOrderFile.TabIndex = 22;
            this.BtnSelectOrderFile.Text = "オーダーファイル選択";
            this.BtnSelectOrderFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSelectOrderFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSelectOrderFile.UseVisualStyleBackColor = true;
            this.BtnSelectOrderFile.Click += new System.EventHandler(this.BtnSelectOrderFile_Click);
            // 
            // LblSelectFilePath
            // 
            this.LblSelectFilePath.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSelectFilePath.ForeColor = System.Drawing.Color.Blue;
            this.LblSelectFilePath.Location = new System.Drawing.Point(476, 35);
            this.LblSelectFilePath.Name = "LblSelectFilePath";
            this.LblSelectFilePath.Size = new System.Drawing.Size(1129, 23);
            this.LblSelectFilePath.TabIndex = 23;
            this.LblSelectFilePath.Text = "LblSelectFilePath";
            // 
            // LblDateTimeLocal
            // 
            this.LblDateTimeLocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblDateTimeLocal.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDateTimeLocal.ForeColor = System.Drawing.Color.Blue;
            this.LblDateTimeLocal.Location = new System.Drawing.Point(1611, 9);
            this.LblDateTimeLocal.Name = "LblDateTimeLocal";
            this.LblDateTimeLocal.Size = new System.Drawing.Size(277, 47);
            this.LblDateTimeLocal.TabIndex = 24;
            this.LblDateTimeLocal.Text = "LblDateTimeLocal";
            this.LblDateTimeLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimDateTime
            // 
            this.TimDateTime.Tick += new System.EventHandler(this.TimDateTime_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dTimPickerImportDate);
            this.groupBox3.Location = new System.Drawing.Point(309, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 59);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "取込日付";
            // 
            // dTimPickerImportDate
            // 
            this.dTimPickerImportDate.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTimPickerImportDate.Location = new System.Drawing.Point(8, 21);
            this.dTimPickerImportDate.Name = "dTimPickerImportDate";
            this.dTimPickerImportDate.Size = new System.Drawing.Size(147, 27);
            this.dTimPickerImportDate.TabIndex = 20;
            // 
            // LstViewResult
            // 
            this.LstViewResult.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstViewResult.FullRowSelect = true;
            this.LstViewResult.Location = new System.Drawing.Point(11, 521);
            this.LstViewResult.MultiSelect = false;
            this.LstViewResult.Name = "LstViewResult";
            this.LstViewResult.Size = new System.Drawing.Size(1876, 366);
            this.LstViewResult.TabIndex = 27;
            this.LstViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1876, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "■取込結果■";
            // 
            // OrderFileReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 957);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstViewResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LblDateTimeLocal);
            this.Controls.Add(this.LblSelectFilePath);
            this.Controls.Add(this.BtnSelectOrderFile);
            this.Controls.Add(this.LstOrderFile);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderFileReadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "オーダーファイル取込";
            this.Load += new System.EventHandler(this.OrderFileReadForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnClose;
        private ListView LstOrderFile;
        private Button BtnSelectOrderFile;
        private Label LblSelectFilePath;
        private Label LblDateTimeLocal;
        private System.Windows.Forms.Timer TimDateTime;
        private GroupBox groupBox3;
        private DateTimePicker dTimPickerImportDate;
        private ListView LstViewResult;
        private Label label1;
    }
}