namespace MetroFramework_MessageBox
{
    partial class Form1
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroBtnClickMe = new MetroFramework.Controls.MetroButton();
            this.metroTileOk = new MetroFramework.Controls.MetroTile();
            this.metroTileYesNo = new MetroFramework.Controls.MetroTile();
            this.metroTileError = new MetroFramework.Controls.MetroTile();
            this.metroTileNone = new MetroFramework.Controls.MetroTile();
            this.metroTileYesNoCancel = new MetroFramework.Controls.MetroTile();
            this.metroTileWarning = new MetroFramework.Controls.MetroTile();
            this.metroTileStop = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(132, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 34);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Enter your name: ";
            // 
            // metroTextBoxName
            // 
            // 
            // 
            // 
            this.metroTextBoxName.CustomButton.Image = null;
            this.metroTextBoxName.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.metroTextBoxName.CustomButton.Name = "";
            this.metroTextBoxName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxName.CustomButton.TabIndex = 1;
            this.metroTextBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxName.CustomButton.UseSelectable = true;
            this.metroTextBoxName.CustomButton.Visible = false;
            this.metroTextBoxName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxName.Lines = new string[0];
            this.metroTextBoxName.Location = new System.Drawing.Point(366, 61);
            this.metroTextBoxName.MaxLength = 32767;
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.PasswordChar = '\0';
            this.metroTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxName.SelectedText = "";
            this.metroTextBoxName.SelectionLength = 0;
            this.metroTextBoxName.SelectionStart = 0;
            this.metroTextBoxName.ShortcutsEnabled = true;
            this.metroTextBoxName.Size = new System.Drawing.Size(252, 34);
            this.metroTextBoxName.TabIndex = 1;
            this.metroTextBoxName.UseSelectable = true;
            this.metroTextBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroBtnClickMe
            // 
            this.metroBtnClickMe.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroBtnClickMe.Location = new System.Drawing.Point(361, 125);
            this.metroBtnClickMe.Name = "metroBtnClickMe";
            this.metroBtnClickMe.Size = new System.Drawing.Size(140, 59);
            this.metroBtnClickMe.TabIndex = 2;
            this.metroBtnClickMe.Text = "Click me";
            this.metroBtnClickMe.UseSelectable = true;
            this.metroBtnClickMe.Click += new System.EventHandler(this.metroBtnClickMe_Click);
            // 
            // metroTileOk
            // 
            this.metroTileOk.ActiveControl = null;
            this.metroTileOk.Location = new System.Drawing.Point(103, 216);
            this.metroTileOk.Name = "metroTileOk";
            this.metroTileOk.Size = new System.Drawing.Size(163, 100);
            this.metroTileOk.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileOk.TabIndex = 3;
            this.metroTileOk.Text = "OK";
            this.metroTileOk.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileOk.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileOk.UseSelectable = true;
            this.metroTileOk.Click += new System.EventHandler(this.metroTileOk_Click);
            // 
            // metroTileYesNo
            // 
            this.metroTileYesNo.ActiveControl = null;
            this.metroTileYesNo.Location = new System.Drawing.Point(103, 339);
            this.metroTileYesNo.Name = "metroTileYesNo";
            this.metroTileYesNo.Size = new System.Drawing.Size(163, 100);
            this.metroTileYesNo.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileYesNo.TabIndex = 3;
            this.metroTileYesNo.Text = "Yes No";
            this.metroTileYesNo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileYesNo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileYesNo.UseSelectable = true;
            this.metroTileYesNo.Click += new System.EventHandler(this.metroTileYesNo_Click);
            // 
            // metroTileError
            // 
            this.metroTileError.ActiveControl = null;
            this.metroTileError.Location = new System.Drawing.Point(103, 457);
            this.metroTileError.Name = "metroTileError";
            this.metroTileError.Size = new System.Drawing.Size(163, 100);
            this.metroTileError.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTileError.TabIndex = 3;
            this.metroTileError.Text = "Error";
            this.metroTileError.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileError.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileError.UseSelectable = true;
            this.metroTileError.Click += new System.EventHandler(this.metroTileError_Click);
            // 
            // metroTileNone
            // 
            this.metroTileNone.ActiveControl = null;
            this.metroTileNone.Location = new System.Drawing.Point(290, 216);
            this.metroTileNone.Name = "metroTileNone";
            this.metroTileNone.Size = new System.Drawing.Size(163, 100);
            this.metroTileNone.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTileNone.TabIndex = 3;
            this.metroTileNone.Text = "None";
            this.metroTileNone.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileNone.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileNone.UseSelectable = true;
            this.metroTileNone.Click += new System.EventHandler(this.metroTileNone_Click);
            // 
            // metroTileYesNoCancel
            // 
            this.metroTileYesNoCancel.ActiveControl = null;
            this.metroTileYesNoCancel.Location = new System.Drawing.Point(290, 339);
            this.metroTileYesNoCancel.Name = "metroTileYesNoCancel";
            this.metroTileYesNoCancel.Size = new System.Drawing.Size(163, 218);
            this.metroTileYesNoCancel.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileYesNoCancel.TabIndex = 3;
            this.metroTileYesNoCancel.Text = "Yes No Cancel";
            this.metroTileYesNoCancel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileYesNoCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileYesNoCancel.UseSelectable = true;
            this.metroTileYesNoCancel.Click += new System.EventHandler(this.metroTileYesNoCancel_Click);
            // 
            // metroTileWarning
            // 
            this.metroTileWarning.ActiveControl = null;
            this.metroTileWarning.Location = new System.Drawing.Point(478, 216);
            this.metroTileWarning.Name = "metroTileWarning";
            this.metroTileWarning.Size = new System.Drawing.Size(168, 214);
            this.metroTileWarning.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileWarning.TabIndex = 3;
            this.metroTileWarning.Text = "Warning";
            this.metroTileWarning.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileWarning.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileWarning.UseSelectable = true;
            this.metroTileWarning.Click += new System.EventHandler(this.metroTileWarning_Click);
            // 
            // metroTileStop
            // 
            this.metroTileStop.ActiveControl = null;
            this.metroTileStop.Location = new System.Drawing.Point(478, 457);
            this.metroTileStop.Name = "metroTileStop";
            this.metroTileStop.Size = new System.Drawing.Size(168, 100);
            this.metroTileStop.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTileStop.TabIndex = 3;
            this.metroTileStop.Text = "Stop";
            this.metroTileStop.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileStop.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileStop.UseSelectable = true;
            this.metroTileStop.Click += new System.EventHandler(this.metroTileStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 651);
            this.Controls.Add(this.metroTileStop);
            this.Controls.Add(this.metroTileWarning);
            this.Controls.Add(this.metroTileNone);
            this.Controls.Add(this.metroTileError);
            this.Controls.Add(this.metroTileYesNoCancel);
            this.Controls.Add(this.metroTileYesNo);
            this.Controls.Add(this.metroTileOk);
            this.Controls.Add(this.metroBtnClickMe);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroButton metroBtnClickMe;
        private MetroFramework.Controls.MetroTile metroTileOk;
        private MetroFramework.Controls.MetroTile metroTileYesNo;
        private MetroFramework.Controls.MetroTile metroTileError;
        private MetroFramework.Controls.MetroTile metroTileNone;
        private MetroFramework.Controls.MetroTile metroTileYesNoCancel;
        private MetroFramework.Controls.MetroTile metroTileWarning;
        private MetroFramework.Controls.MetroTile metroTileStop;
    }
}

