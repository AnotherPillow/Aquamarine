namespace Aquamarine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SaveFileBrowseBtn = new System.Windows.Forms.Button();
            this.FileSaveNameLbl = new System.Windows.Forms.Label();
            this.SaveNameLbl = new System.Windows.Forms.Label();
            this.SaveNameTxt = new System.Windows.Forms.TextBox();
            this.FarmNameTxt = new System.Windows.Forms.TextBox();
            this.FarmNameLbl = new System.Windows.Forms.Label();
            this.FavouriteThingTxt = new System.Windows.Forms.TextBox();
            this.FavouriteThingLbl = new System.Windows.Forms.Label();
            this.YearTxt = new System.Windows.Forms.TextBox();
            this.YearLbl = new System.Windows.Forms.Label();
            this.HealthTxt = new System.Windows.Forms.TextBox();
            this.HealthLbl = new System.Windows.Forms.Label();
            this.MaxHealthTxt = new System.Windows.Forms.TextBox();
            this.MaxHealthLbl = new System.Windows.Forms.Label();
            this.MoneyTxt = new System.Windows.Forms.TextBox();
            this.MoneyLbl = new System.Windows.Forms.Label();
            this.GameVersionTxt = new System.Windows.Forms.TextBox();
            this.GameVersionLbl = new System.Windows.Forms.Label();
            this.MSPlayedTxt = new System.Windows.Forms.TextBox();
            this.MSPlayedLbl = new System.Windows.Forms.Label();
            this.DayTxt = new System.Windows.Forms.TextBox();
            this.DayLbl = new System.Windows.Forms.Label();
            this.SeasonTxt = new System.Windows.Forms.TextBox();
            this.SeasonLbl = new System.Windows.Forms.Label();
            this.SaveSaveBtn = new System.Windows.Forms.Button();
            this.CatPersonBox = new System.Windows.Forms.CheckBox();
            this.PetTypeCombo = new System.Windows.Forms.ComboBox();
            this.PetTypeLbl = new System.Windows.Forms.Label();
            this.HairColorDialog = new System.Windows.Forms.ColorDialog();
            this.HairColourColourDialogBtn = new System.Windows.Forms.Button();
            this.HairColourLbl = new System.Windows.Forms.Label();
            this.backupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveFileBrowseBtn
            // 
            this.SaveFileBrowseBtn.Location = new System.Drawing.Point(12, 12);
            this.SaveFileBrowseBtn.Name = "SaveFileBrowseBtn";
            this.SaveFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveFileBrowseBtn.TabIndex = 0;
            this.SaveFileBrowseBtn.Text = "Browse";
            this.SaveFileBrowseBtn.UseVisualStyleBackColor = true;
            this.SaveFileBrowseBtn.Click += new System.EventHandler(this.SaveFileBrowseBtn_Click);
            // 
            // FileSaveNameLbl
            // 
            this.FileSaveNameLbl.AutoSize = true;
            this.FileSaveNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FileSaveNameLbl.Location = new System.Drawing.Point(93, 16);
            this.FileSaveNameLbl.Name = "FileSaveNameLbl";
            this.FileSaveNameLbl.Size = new System.Drawing.Size(108, 17);
            this.FileSaveNameLbl.TabIndex = 1;
            this.FileSaveNameLbl.Text = "No Save Selected...";
            // 
            // SaveNameLbl
            // 
            this.SaveNameLbl.AutoSize = true;
            this.SaveNameLbl.Location = new System.Drawing.Point(12, 56);
            this.SaveNameLbl.Name = "SaveNameLbl";
            this.SaveNameLbl.Size = new System.Drawing.Size(42, 15);
            this.SaveNameLbl.TabIndex = 2;
            this.SaveNameLbl.Text = "Name:";
            // 
            // SaveNameTxt
            // 
            this.SaveNameTxt.Location = new System.Drawing.Point(101, 53);
            this.SaveNameTxt.Name = "SaveNameTxt";
            this.SaveNameTxt.Size = new System.Drawing.Size(100, 23);
            this.SaveNameTxt.TabIndex = 3;
            this.SaveNameTxt.TextChanged += new System.EventHandler(this.SaveNameTxt_TextChanged);
            // 
            // FarmNameTxt
            // 
            this.FarmNameTxt.Location = new System.Drawing.Point(101, 82);
            this.FarmNameTxt.Name = "FarmNameTxt";
            this.FarmNameTxt.Size = new System.Drawing.Size(100, 23);
            this.FarmNameTxt.TabIndex = 5;
            this.FarmNameTxt.TextChanged += new System.EventHandler(this.FarmNameTxt_TextChanged);
            // 
            // FarmNameLbl
            // 
            this.FarmNameLbl.AutoSize = true;
            this.FarmNameLbl.Location = new System.Drawing.Point(12, 85);
            this.FarmNameLbl.Name = "FarmNameLbl";
            this.FarmNameLbl.Size = new System.Drawing.Size(72, 15);
            this.FarmNameLbl.TabIndex = 4;
            this.FarmNameLbl.Text = "Farm Name:";
            // 
            // FavouriteThingTxt
            // 
            this.FavouriteThingTxt.Location = new System.Drawing.Point(101, 111);
            this.FavouriteThingTxt.Name = "FavouriteThingTxt";
            this.FavouriteThingTxt.Size = new System.Drawing.Size(100, 23);
            this.FavouriteThingTxt.TabIndex = 7;
            this.FavouriteThingTxt.TextChanged += new System.EventHandler(this.FavouriteThingTxt_TextChanged);
            // 
            // FavouriteThingLbl
            // 
            this.FavouriteThingLbl.AutoSize = true;
            this.FavouriteThingLbl.Location = new System.Drawing.Point(12, 114);
            this.FavouriteThingLbl.Name = "FavouriteThingLbl";
            this.FavouriteThingLbl.Size = new System.Drawing.Size(92, 15);
            this.FavouriteThingLbl.TabIndex = 6;
            this.FavouriteThingLbl.Text = "Favourite Thing:";
            // 
            // YearTxt
            // 
            this.YearTxt.Location = new System.Drawing.Point(101, 227);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.Size = new System.Drawing.Size(100, 23);
            this.YearTxt.TabIndex = 17;
            this.YearTxt.TextChanged += new System.EventHandler(this.YearTxt_TextChanged);
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Location = new System.Drawing.Point(12, 230);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(29, 15);
            this.YearLbl.TabIndex = 16;
            this.YearLbl.Text = "Year";
            // 
            // HealthTxt
            // 
            this.HealthTxt.Location = new System.Drawing.Point(101, 198);
            this.HealthTxt.Name = "HealthTxt";
            this.HealthTxt.Size = new System.Drawing.Size(100, 23);
            this.HealthTxt.TabIndex = 15;
            this.HealthTxt.TextChanged += new System.EventHandler(this.HealthTxt_TextChanged);
            // 
            // HealthLbl
            // 
            this.HealthLbl.AutoSize = true;
            this.HealthLbl.Location = new System.Drawing.Point(12, 201);
            this.HealthLbl.Name = "HealthLbl";
            this.HealthLbl.Size = new System.Drawing.Size(42, 15);
            this.HealthLbl.TabIndex = 14;
            this.HealthLbl.Text = "Health";
            // 
            // MaxHealthTxt
            // 
            this.MaxHealthTxt.Location = new System.Drawing.Point(101, 169);
            this.MaxHealthTxt.Name = "MaxHealthTxt";
            this.MaxHealthTxt.Size = new System.Drawing.Size(100, 23);
            this.MaxHealthTxt.TabIndex = 13;
            this.MaxHealthTxt.TextChanged += new System.EventHandler(this.MaxHealthTxt_TextChanged);
            // 
            // MaxHealthLbl
            // 
            this.MaxHealthLbl.AutoSize = true;
            this.MaxHealthLbl.Location = new System.Drawing.Point(12, 172);
            this.MaxHealthLbl.Name = "MaxHealthLbl";
            this.MaxHealthLbl.Size = new System.Drawing.Size(71, 15);
            this.MaxHealthLbl.TabIndex = 12;
            this.MaxHealthLbl.Text = "Max Health:";
            // 
            // MoneyTxt
            // 
            this.MoneyTxt.Location = new System.Drawing.Point(101, 140);
            this.MoneyTxt.Name = "MoneyTxt";
            this.MoneyTxt.Size = new System.Drawing.Size(100, 23);
            this.MoneyTxt.TabIndex = 11;
            this.MoneyTxt.TextChanged += new System.EventHandler(this.MoneyTxt_TextChanged);
            // 
            // MoneyLbl
            // 
            this.MoneyLbl.AutoSize = true;
            this.MoneyLbl.Location = new System.Drawing.Point(12, 143);
            this.MoneyLbl.Name = "MoneyLbl";
            this.MoneyLbl.Size = new System.Drawing.Size(35, 15);
            this.MoneyLbl.TabIndex = 10;
            this.MoneyLbl.Text = "Gold:";
            // 
            // GameVersionTxt
            // 
            this.GameVersionTxt.Location = new System.Drawing.Point(101, 343);
            this.GameVersionTxt.Name = "GameVersionTxt";
            this.GameVersionTxt.Size = new System.Drawing.Size(100, 23);
            this.GameVersionTxt.TabIndex = 25;
            this.GameVersionTxt.TextChanged += new System.EventHandler(this.GameVersionTxt_TextChanged);
            // 
            // GameVersionLbl
            // 
            this.GameVersionLbl.AutoSize = true;
            this.GameVersionLbl.Location = new System.Drawing.Point(12, 346);
            this.GameVersionLbl.Name = "GameVersionLbl";
            this.GameVersionLbl.Size = new System.Drawing.Size(79, 15);
            this.GameVersionLbl.TabIndex = 24;
            this.GameVersionLbl.Text = "Game Version";
            // 
            // MSPlayedTxt
            // 
            this.MSPlayedTxt.Location = new System.Drawing.Point(101, 314);
            this.MSPlayedTxt.Name = "MSPlayedTxt";
            this.MSPlayedTxt.Size = new System.Drawing.Size(100, 23);
            this.MSPlayedTxt.TabIndex = 23;
            this.MSPlayedTxt.TextChanged += new System.EventHandler(this.MSPlayedTxt_TextChanged);
            // 
            // MSPlayedLbl
            // 
            this.MSPlayedLbl.AutoSize = true;
            this.MSPlayedLbl.Location = new System.Drawing.Point(12, 317);
            this.MSPlayedLbl.Name = "MSPlayedLbl";
            this.MSPlayedLbl.Size = new System.Drawing.Size(62, 15);
            this.MSPlayedLbl.TabIndex = 22;
            this.MSPlayedLbl.Text = "MS Played";
            // 
            // DayTxt
            // 
            this.DayTxt.Location = new System.Drawing.Point(101, 285);
            this.DayTxt.Name = "DayTxt";
            this.DayTxt.Size = new System.Drawing.Size(100, 23);
            this.DayTxt.TabIndex = 21;
            this.DayTxt.TextChanged += new System.EventHandler(this.DayTxt_TextChanged);
            // 
            // DayLbl
            // 
            this.DayLbl.AutoSize = true;
            this.DayLbl.Location = new System.Drawing.Point(12, 288);
            this.DayLbl.Name = "DayLbl";
            this.DayLbl.Size = new System.Drawing.Size(27, 15);
            this.DayLbl.TabIndex = 20;
            this.DayLbl.Text = "Day";
            // 
            // SeasonTxt
            // 
            this.SeasonTxt.Location = new System.Drawing.Point(101, 256);
            this.SeasonTxt.Name = "SeasonTxt";
            this.SeasonTxt.Size = new System.Drawing.Size(100, 23);
            this.SeasonTxt.TabIndex = 19;
            this.SeasonTxt.TextChanged += new System.EventHandler(this.SeasonTxt_TextChanged);
            // 
            // SeasonLbl
            // 
            this.SeasonLbl.AutoSize = true;
            this.SeasonLbl.Location = new System.Drawing.Point(12, 259);
            this.SeasonLbl.Name = "SeasonLbl";
            this.SeasonLbl.Size = new System.Drawing.Size(44, 15);
            this.SeasonLbl.TabIndex = 18;
            this.SeasonLbl.Text = "Season";
            // 
            // SaveSaveBtn
            // 
            this.SaveSaveBtn.Location = new System.Drawing.Point(713, 12);
            this.SaveSaveBtn.Name = "SaveSaveBtn";
            this.SaveSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveSaveBtn.TabIndex = 26;
            this.SaveSaveBtn.Text = "Save";
            this.SaveSaveBtn.UseVisualStyleBackColor = true;
            this.SaveSaveBtn.Click += new System.EventHandler(this.SaveSaveBtn_Click);
            // 
            // CatPersonBox
            // 
            this.CatPersonBox.AutoSize = true;
            this.CatPersonBox.Location = new System.Drawing.Point(264, 52);
            this.CatPersonBox.Name = "CatPersonBox";
            this.CatPersonBox.Size = new System.Drawing.Size(83, 19);
            this.CatPersonBox.TabIndex = 27;
            this.CatPersonBox.Text = "Cat Person";
            this.CatPersonBox.UseVisualStyleBackColor = true;
            this.CatPersonBox.Click += new System.EventHandler(this.CatPersonBox_Click);
            // 
            // PetTypeCombo
            // 
            this.PetTypeCombo.FormattingEnabled = true;
            this.PetTypeCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.PetTypeCombo.Location = new System.Drawing.Point(321, 77);
            this.PetTypeCombo.Name = "PetTypeCombo";
            this.PetTypeCombo.Size = new System.Drawing.Size(121, 23);
            this.PetTypeCombo.TabIndex = 28;
            this.PetTypeCombo.SelectedIndexChanged += new System.EventHandler(this.PetTypeCombo_SelectedIndexChanged);
            // 
            // PetTypeLbl
            // 
            this.PetTypeLbl.AutoSize = true;
            this.PetTypeLbl.Location = new System.Drawing.Point(264, 80);
            this.PetTypeLbl.Name = "PetTypeLbl";
            this.PetTypeLbl.Size = new System.Drawing.Size(51, 15);
            this.PetTypeLbl.TabIndex = 29;
            this.PetTypeLbl.Text = "Pet Type";
            // 
            // HairColourColourDialogBtn
            // 
            this.HairColourColourDialogBtn.Location = new System.Drawing.Point(338, 107);
            this.HairColourColourDialogBtn.Name = "HairColourColourDialogBtn";
            this.HairColourColourDialogBtn.Size = new System.Drawing.Size(75, 23);
            this.HairColourColourDialogBtn.TabIndex = 30;
            this.HairColourColourDialogBtn.Text = "Change";
            this.HairColourColourDialogBtn.UseVisualStyleBackColor = true;
            this.HairColourColourDialogBtn.Click += new System.EventHandler(this.HairColourColourDialogBtn_Click);
            // 
            // HairColourLbl
            // 
            this.HairColourLbl.AutoSize = true;
            this.HairColourLbl.Location = new System.Drawing.Point(264, 111);
            this.HairColourLbl.Name = "HairColourLbl";
            this.HairColourLbl.Size = new System.Drawing.Size(68, 15);
            this.HairColourLbl.TabIndex = 31;
            this.HairColourLbl.Text = "Hair Colour";
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(713, 41);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(75, 23);
            this.backupBtn.TabIndex = 32;
            this.backupBtn.Text = "Backup";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.HairColourLbl);
            this.Controls.Add(this.HairColourColourDialogBtn);
            this.Controls.Add(this.PetTypeLbl);
            this.Controls.Add(this.PetTypeCombo);
            this.Controls.Add(this.CatPersonBox);
            this.Controls.Add(this.SaveSaveBtn);
            this.Controls.Add(this.GameVersionTxt);
            this.Controls.Add(this.GameVersionLbl);
            this.Controls.Add(this.MSPlayedTxt);
            this.Controls.Add(this.MSPlayedLbl);
            this.Controls.Add(this.DayTxt);
            this.Controls.Add(this.DayLbl);
            this.Controls.Add(this.SeasonTxt);
            this.Controls.Add(this.SeasonLbl);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.HealthTxt);
            this.Controls.Add(this.HealthLbl);
            this.Controls.Add(this.MaxHealthTxt);
            this.Controls.Add(this.MaxHealthLbl);
            this.Controls.Add(this.MoneyTxt);
            this.Controls.Add(this.MoneyLbl);
            this.Controls.Add(this.FavouriteThingTxt);
            this.Controls.Add(this.FavouriteThingLbl);
            this.Controls.Add(this.FarmNameTxt);
            this.Controls.Add(this.FarmNameLbl);
            this.Controls.Add(this.SaveNameTxt);
            this.Controls.Add(this.SaveNameLbl);
            this.Controls.Add(this.FileSaveNameLbl);
            this.Controls.Add(this.SaveFileBrowseBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aquamarine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveFileBrowseBtn;
        private Label FileSaveNameLbl;
        private Label SaveNameLbl;
        private TextBox SaveNameTxt;
        private TextBox FarmNameTxt;
        private Label FarmNameLbl;
        private TextBox FavouriteThingTxt;
        private Label FavouriteThingLbl;
        private TextBox YearTxt;
        private Label YearLbl;
        private TextBox HealthTxt;
        private Label HealthLbl;
        private TextBox MaxHealthTxt;
        private Label MaxHealthLbl;
        private TextBox MoneyTxt;
        private Label MoneyLbl;
        private TextBox GameVersionTxt;
        private Label GameVersionLbl;
        private TextBox MSPlayedTxt;
        private Label MSPlayedLbl;
        private TextBox DayTxt;
        private Label DayLbl;
        private TextBox SeasonTxt;
        private Label SeasonLbl;
        private Button SaveSaveBtn;
        private CheckBox CatPersonBox;
        private ComboBox PetTypeCombo;
        private Label PetTypeLbl;
        private ColorDialog HairColorDialog;
        private Button HairColourColourDialogBtn;
        private Label HairColourLbl;
        private Button backupBtn;
    }
}