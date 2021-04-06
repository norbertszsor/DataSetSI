namespace WindowsFormsApp3
{
    partial class ShowDataSet
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
            this.LoadDataSet = new System.Windows.Forms.Button();
            this.openConfigFile = new System.Windows.Forms.OpenFileDialog();
            this.LoadConfigFile = new System.Windows.Forms.Button();
            this.openDataSetFile = new System.Windows.Forms.OpenFileDialog();
            this.StatusBox1 = new System.Windows.Forms.TextBox();
            this.StatusBox2 = new System.Windows.Forms.TextBox();
            this.ConfigShowBox = new System.Windows.Forms.RichTextBox();
            this.DataSetShowBox = new System.Windows.Forms.ListBox();
            this.ConfigBoxTitle = new System.Windows.Forms.Label();
            this.DataSetViewTitle = new System.Windows.Forms.Label();
            this.StartNormalize = new System.Windows.Forms.Button();
            this.LabelUnvalidRows = new System.Windows.Forms.Label();
            this.DeletedRowText = new System.Windows.Forms.TextBox();
            this.ResetApp = new System.Windows.Forms.Button();
            this.ButtonChangeConfig = new System.Windows.Forms.Button();
            this.SaveNormalizedData = new System.Windows.Forms.Button();
            this.RangeNormalizeLabel = new System.Windows.Forms.Label();
            this.DeflatuNormalizeRange = new System.Windows.Forms.CheckBox();
            this.RangeSelectLabel = new System.Windows.Forms.Label();
            this.RangeNormalizeMin = new System.Windows.Forms.TextBox();
            this.RangeSelectLabel2 = new System.Windows.Forms.Label();
            this.RangeNormalizeMax = new System.Windows.Forms.TextBox();
            this.SaveDataFile = new System.Windows.Forms.SaveFileDialog();
            this.LoadNormalizedData = new System.Windows.Forms.Button();
            this.NormalizedLoadLabel = new System.Windows.Forms.Label();
            this.LoadNormalizedDataSet = new System.Windows.Forms.OpenFileDialog();
            this.RowsToNormalizeBox = new System.Windows.Forms.CheckedListBox();
            this.LabelRowsToNormalize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadDataSet
            // 
            this.LoadDataSet.Location = new System.Drawing.Point(12, 0);
            this.LoadDataSet.Name = "LoadDataSet";
            this.LoadDataSet.Size = new System.Drawing.Size(108, 42);
            this.LoadDataSet.TabIndex = 0;
            this.LoadDataSet.Text = "Wczytaj Dataset";
            this.LoadDataSet.UseVisualStyleBackColor = true;
            this.LoadDataSet.Click += new System.EventHandler(this.LoadDataSet_Click);
            // 
            // openConfigFile
            // 
            this.openConfigFile.Filter = "Config|*.ini";
            // 
            // LoadConfigFile
            // 
            this.LoadConfigFile.Location = new System.Drawing.Point(12, 48);
            this.LoadConfigFile.Name = "LoadConfigFile";
            this.LoadConfigFile.Size = new System.Drawing.Size(108, 42);
            this.LoadConfigFile.TabIndex = 1;
            this.LoadConfigFile.Text = "Wczytaj Plik Konfiguracyjny";
            this.LoadConfigFile.UseVisualStyleBackColor = true;
            this.LoadConfigFile.Click += new System.EventHandler(this.LoadConfigFile_Click);
            // 
            // StatusBox1
            // 
            this.StatusBox1.ForeColor = System.Drawing.Color.Black;
            this.StatusBox1.Location = new System.Drawing.Point(139, 67);
            this.StatusBox1.Name = "StatusBox1";
            this.StatusBox1.ReadOnly = true;
            this.StatusBox1.Size = new System.Drawing.Size(187, 23);
            this.StatusBox1.TabIndex = 3;
            this.StatusBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusBox2
            // 
            this.StatusBox2.Location = new System.Drawing.Point(139, 19);
            this.StatusBox2.Name = "StatusBox2";
            this.StatusBox2.ReadOnly = true;
            this.StatusBox2.Size = new System.Drawing.Size(187, 23);
            this.StatusBox2.TabIndex = 4;
            this.StatusBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfigShowBox
            // 
            this.ConfigShowBox.Location = new System.Drawing.Point(12, 267);
            this.ConfigShowBox.Name = "ConfigShowBox";
            this.ConfigShowBox.Size = new System.Drawing.Size(314, 240);
            this.ConfigShowBox.TabIndex = 5;
            this.ConfigShowBox.Text = "";
            // 
            // DataSetShowBox
            // 
            this.DataSetShowBox.FormattingEnabled = true;
            this.DataSetShowBox.ItemHeight = 15;
            this.DataSetShowBox.Location = new System.Drawing.Point(793, 48);
            this.DataSetShowBox.Name = "DataSetShowBox";
            this.DataSetShowBox.Size = new System.Drawing.Size(442, 319);
            this.DataSetShowBox.TabIndex = 6;
            this.DataSetShowBox.SelectedIndexChanged += new System.EventHandler(this.DataSetShowBox_SelectedIndexChanged);
            // 
            // ConfigBoxTitle
            // 
            this.ConfigBoxTitle.AutoSize = true;
            this.ConfigBoxTitle.Location = new System.Drawing.Point(12, 249);
            this.ConfigBoxTitle.Name = "ConfigBoxTitle";
            this.ConfigBoxTitle.Size = new System.Drawing.Size(151, 15);
            this.ConfigBoxTitle.TabIndex = 7;
            this.ConfigBoxTitle.Text = "Edytuj Plik Konfiguracyjny: ";
            // 
            // DataSetViewTitle
            // 
            this.DataSetViewTitle.AutoSize = true;
            this.DataSetViewTitle.Location = new System.Drawing.Point(793, 27);
            this.DataSetViewTitle.Name = "DataSetViewTitle";
            this.DataSetViewTitle.Size = new System.Drawing.Size(90, 15);
            this.DataSetViewTitle.TabIndex = 8;
            this.DataSetViewTitle.Text = "Widok Danych: ";
            // 
            // StartNormalize
            // 
            this.StartNormalize.Location = new System.Drawing.Point(886, 376);
            this.StartNormalize.Name = "StartNormalize";
            this.StartNormalize.Size = new System.Drawing.Size(87, 33);
            this.StartNormalize.TabIndex = 9;
            this.StartNormalize.Text = "Normalizuj";
            this.StartNormalize.UseVisualStyleBackColor = true;
            this.StartNormalize.Click += new System.EventHandler(this.StartNormalize_Click);
            // 
            // LabelUnvalidRows
            // 
            this.LabelUnvalidRows.AutoSize = true;
            this.LabelUnvalidRows.Location = new System.Drawing.Point(1085, 22);
            this.LabelUnvalidRows.Name = "LabelUnvalidRows";
            this.LabelUnvalidRows.Size = new System.Drawing.Size(113, 15);
            this.LabelUnvalidRows.TabIndex = 10;
            this.LabelUnvalidRows.Text = "Usunietych wierszy: ";
            // 
            // DeletedRowText
            // 
            this.DeletedRowText.Location = new System.Drawing.Point(1204, 19);
            this.DeletedRowText.Name = "DeletedRowText";
            this.DeletedRowText.ReadOnly = true;
            this.DeletedRowText.Size = new System.Drawing.Size(31, 23);
            this.DeletedRowText.TabIndex = 11;
            this.DeletedRowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResetApp
            // 
            this.ResetApp.Location = new System.Drawing.Point(12, 96);
            this.ResetApp.Name = "ResetApp";
            this.ResetApp.Size = new System.Drawing.Size(108, 42);
            this.ResetApp.TabIndex = 12;
            this.ResetApp.Text = "Reset";
            this.ResetApp.UseVisualStyleBackColor = true;
            this.ResetApp.Click += new System.EventHandler(this.ResetApp_Click);
            // 
            // ButtonChangeConfig
            // 
            this.ButtonChangeConfig.Location = new System.Drawing.Point(234, 514);
            this.ButtonChangeConfig.Name = "ButtonChangeConfig";
            this.ButtonChangeConfig.Size = new System.Drawing.Size(91, 32);
            this.ButtonChangeConfig.TabIndex = 13;
            this.ButtonChangeConfig.Text = "Akceptuj";
            this.ButtonChangeConfig.UseVisualStyleBackColor = true;
            this.ButtonChangeConfig.Click += new System.EventHandler(this.ButtonChangeConfig_Click);
            // 
            // SaveNormalizedData
            // 
            this.SaveNormalizedData.Location = new System.Drawing.Point(793, 376);
            this.SaveNormalizedData.Name = "SaveNormalizedData";
            this.SaveNormalizedData.Size = new System.Drawing.Size(87, 33);
            this.SaveNormalizedData.TabIndex = 14;
            this.SaveNormalizedData.Text = "Zapisz";
            this.SaveNormalizedData.UseVisualStyleBackColor = true;
            this.SaveNormalizedData.Click += new System.EventHandler(this.SaveNormalizedData_Click);
            // 
            // RangeNormalizeLabel
            // 
            this.RangeNormalizeLabel.AutoSize = true;
            this.RangeNormalizeLabel.Location = new System.Drawing.Point(979, 385);
            this.RangeNormalizeLabel.Name = "RangeNormalizeLabel";
            this.RangeNormalizeLabel.Size = new System.Drawing.Size(110, 15);
            this.RangeNormalizeLabel.TabIndex = 15;
            this.RangeNormalizeLabel.Text = "Zakres Normalizacji";
            // 
            // DeflatuNormalizeRange
            // 
            this.DeflatuNormalizeRange.AutoSize = true;
            this.DeflatuNormalizeRange.Checked = true;
            this.DeflatuNormalizeRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DeflatuNormalizeRange.Location = new System.Drawing.Point(1095, 384);
            this.DeflatuNormalizeRange.Name = "DeflatuNormalizeRange";
            this.DeflatuNormalizeRange.Size = new System.Drawing.Size(79, 19);
            this.DeflatuNormalizeRange.TabIndex = 16;
            this.DeflatuNormalizeRange.Text = "Domyślny";
            this.DeflatuNormalizeRange.UseVisualStyleBackColor = true;
            this.DeflatuNormalizeRange.CheckedChanged += new System.EventHandler(this.DeflatuNormalizeRange_CheckedChanged);
            // 
            // RangeSelectLabel
            // 
            this.RangeSelectLabel.AutoSize = true;
            this.RangeSelectLabel.Location = new System.Drawing.Point(979, 420);
            this.RangeSelectLabel.Name = "RangeSelectLabel";
            this.RangeSelectLabel.Size = new System.Drawing.Size(71, 15);
            this.RangeSelectLabel.TabIndex = 17;
            this.RangeSelectLabel.Text = "Zakres  Min:";
            this.RangeSelectLabel.Visible = false;
            // 
            // RangeNormalizeMin
            // 
            this.RangeNormalizeMin.Location = new System.Drawing.Point(1056, 417);
            this.RangeNormalizeMin.Name = "RangeNormalizeMin";
            this.RangeNormalizeMin.Size = new System.Drawing.Size(41, 23);
            this.RangeNormalizeMin.TabIndex = 18;
            this.RangeNormalizeMin.Visible = false;
            // 
            // RangeSelectLabel2
            // 
            this.RangeSelectLabel2.AutoSize = true;
            this.RangeSelectLabel2.Location = new System.Drawing.Point(1103, 420);
            this.RangeSelectLabel2.Name = "RangeSelectLabel2";
            this.RangeSelectLabel2.Size = new System.Drawing.Size(33, 15);
            this.RangeSelectLabel2.TabIndex = 19;
            this.RangeSelectLabel2.Text = "Max:";
            this.RangeSelectLabel2.Visible = false;
            // 
            // RangeNormalizeMax
            // 
            this.RangeNormalizeMax.Location = new System.Drawing.Point(1142, 417);
            this.RangeNormalizeMax.Name = "RangeNormalizeMax";
            this.RangeNormalizeMax.Size = new System.Drawing.Size(50, 23);
            this.RangeNormalizeMax.TabIndex = 20;
            this.RangeNormalizeMax.Visible = false;
            // 
            // LoadNormalizedData
            // 
            this.LoadNormalizedData.Location = new System.Drawing.Point(793, 512);
            this.LoadNormalizedData.Name = "LoadNormalizedData";
            this.LoadNormalizedData.Size = new System.Drawing.Size(87, 33);
            this.LoadNormalizedData.TabIndex = 21;
            this.LoadNormalizedData.Text = "Wczytaj";
            this.LoadNormalizedData.UseVisualStyleBackColor = true;
            this.LoadNormalizedData.Click += new System.EventHandler(this.LoadNormalizedData_Click);
            // 
            // NormalizedLoadLabel
            // 
            this.NormalizedLoadLabel.AutoSize = true;
            this.NormalizedLoadLabel.Location = new System.Drawing.Point(793, 492);
            this.NormalizedLoadLabel.Name = "NormalizedLoadLabel";
            this.NormalizedLoadLabel.Size = new System.Drawing.Size(216, 15);
            this.NormalizedLoadLabel.TabIndex = 22;
            this.NormalizedLoadLabel.Text = "Wyświetl znormalizowane pliki danych: ";
            // 
            // RowsToNormalizeBox
            // 
            this.RowsToNormalizeBox.FormattingEnabled = true;
            this.RowsToNormalizeBox.Location = new System.Drawing.Point(331, 267);
            this.RowsToNormalizeBox.Name = "RowsToNormalizeBox";
            this.RowsToNormalizeBox.Size = new System.Drawing.Size(116, 292);
            this.RowsToNormalizeBox.TabIndex = 23;
            this.RowsToNormalizeBox.SelectedIndexChanged += new System.EventHandler(this.RowsToNormalizeBox_SelectedIndexChanged);
            // 
            // LabelRowsToNormalize
            // 
            this.LabelRowsToNormalize.AutoSize = true;
            this.LabelRowsToNormalize.Location = new System.Drawing.Point(331, 249);
            this.LabelRowsToNormalize.Name = "LabelRowsToNormalize";
            this.LabelRowsToNormalize.Size = new System.Drawing.Size(58, 15);
            this.LabelRowsToNormalize.TabIndex = 24;
            this.LabelRowsToNormalize.Text = "Kolumny:";
            // 
            // ShowDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 576);
            this.Controls.Add(this.LabelRowsToNormalize);
            this.Controls.Add(this.RowsToNormalizeBox);
            this.Controls.Add(this.NormalizedLoadLabel);
            this.Controls.Add(this.LoadNormalizedData);
            this.Controls.Add(this.RangeNormalizeMax);
            this.Controls.Add(this.RangeSelectLabel2);
            this.Controls.Add(this.RangeNormalizeMin);
            this.Controls.Add(this.RangeSelectLabel);
            this.Controls.Add(this.DeflatuNormalizeRange);
            this.Controls.Add(this.RangeNormalizeLabel);
            this.Controls.Add(this.SaveNormalizedData);
            this.Controls.Add(this.ButtonChangeConfig);
            this.Controls.Add(this.ResetApp);
            this.Controls.Add(this.DeletedRowText);
            this.Controls.Add(this.LabelUnvalidRows);
            this.Controls.Add(this.StartNormalize);
            this.Controls.Add(this.DataSetViewTitle);
            this.Controls.Add(this.ConfigBoxTitle);
            this.Controls.Add(this.DataSetShowBox);
            this.Controls.Add(this.ConfigShowBox);
            this.Controls.Add(this.StatusBox2);
            this.Controls.Add(this.StatusBox1);
            this.Controls.Add(this.LoadConfigFile);
            this.Controls.Add(this.LoadDataSet);
            this.Name = "ShowDataSet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShowDataSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button LoadDataSet;
        private System.Windows.Forms.OpenFileDialog openConfigFile;
        private System.Windows.Forms.Button LoadConfigFile;
        private System.Windows.Forms.OpenFileDialog openDataSetFile;
        private System.Windows.Forms.TextBox StatusBox1;
        private System.Windows.Forms.TextBox StatusBox2;
        private System.Windows.Forms.RichTextBox ConfigShowBox;
        private System.Windows.Forms.ListBox DataSetShowBox;
        private System.Windows.Forms.Label ConfigBoxTitle;
        private System.Windows.Forms.Label DataSetViewTitle;
        private System.Windows.Forms.Button StartNormalize;
        private System.Windows.Forms.Label LabelUnvalidRows;
        private System.Windows.Forms.TextBox DeletedRowText;
        private System.Windows.Forms.Button ResetApp;
        private System.Windows.Forms.Button ButtonChangeConfig;
        private System.Windows.Forms.Button SaveNormalizedData;
        private System.Windows.Forms.Label RangeNormalizeLabel;
        private System.Windows.Forms.CheckBox DeflatuNormalizeRange;
        private System.Windows.Forms.Label RangeSelectLabel;
        private System.Windows.Forms.TextBox RangeNormalizeMin;
        private System.Windows.Forms.Label RangeSelectLabel2;
        private System.Windows.Forms.TextBox RangeNormalizeMax;
        private System.Windows.Forms.SaveFileDialog SaveDataFile;
        private System.Windows.Forms.Button LoadNormalizedData;
        private System.Windows.Forms.Label NormalizedLoadLabel;
        private System.Windows.Forms.OpenFileDialog LoadNormalizedDataSet;
        private System.Windows.Forms.CheckedListBox RowsToNormalizeBox;
        private System.Windows.Forms.Label LabelRowsToNormalize;
    }
}

