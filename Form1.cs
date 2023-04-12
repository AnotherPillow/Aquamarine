using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;


namespace Aquamarine
{
    public partial class Form1 : Form
    {

        public string FileSaveName = "";
        public Regex fileNameRegex = new Regex(@"^.+_([0-9]+)$");
        public XmlDocument save = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
        
        private void SaveFileBrowseBtn_Click(object sender, EventArgs e)
        {
            //label is FileSaveNameLbl
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result != DialogResult.OK) // Test result.
                return;

            string fp = openFileDialog1.FileName;
            string fn = System.IO.Path.GetFileName(fp);

            Match match = fileNameRegex.Match(fn);
            if (!match.Success)
                return;
            
            
            FileSaveName = fn;
            FileSaveNameLbl.Text = fn;

            PopulateFields();
        }

        private void PopulateFields()
        {


            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string savepath = appdata + @"\StardewValley\Saves\" + FileSaveName + @"\" + FileSaveName;

            save.Load(savepath);

            XmlNodeList nameEls = save.GetElementsByTagName("name");
            string name = nameEls[0].InnerXml;
            SaveNameTxt.Text = name;

            XmlNodeList farmNameEls = save.GetElementsByTagName("farmName");
            string farmName = farmNameEls[0].InnerXml;
            FarmNameTxt.Text = farmName;

            XmlNodeList favouriteThingEls = save.GetElementsByTagName("favoriteThing");
            string favouriteThing = favouriteThingEls[0].InnerXml;
            FavouriteThingTxt.Text = favouriteThing;

            XmlNodeList catPersonEls = save.GetElementsByTagName("catPerson");
            bool catPerson = catPersonEls[0].InnerXml == "true";

            CatPersonBox.Checked = catPerson;
            
            XmlNodeList petTypeEls = save.GetElementsByTagName("whichPetBreed");
            string petType = petTypeEls[0].InnerXml;
            PetTypeCombo.SelectedIndex = int.Parse(petType);

            XmlNodeList hairColorEls = save.GetElementsByTagName("hairstyleColor");
            XmlNodeList hairColorChildEls = hairColorEls[0].ChildNodes;

            //Child 1 is Blue, 2 is Green, 3 is Red, 4 is Alpha

            Color hairColorColor = Color.FromArgb(
                int.Parse(hairColorChildEls[3].InnerXml),
                int.Parse(hairColorChildEls[2].InnerXml),
                int.Parse(hairColorChildEls[1].InnerXml),
                int.Parse(hairColorChildEls[0].InnerXml)
            );
            HairColourColourDialogBtn.BackColor = hairColorColor;

            XmlNodeList moneyEls = save.GetElementsByTagName("money");
            string money = moneyEls[0].InnerXml;
            MoneyTxt.Text = money;

            XmlNodeList healthEls = save.GetElementsByTagName("health");
            string health = healthEls[0].InnerXml;
            HealthTxt.Text = health;

            XmlNodeList maxHealthEls = save.GetElementsByTagName("maxHealth");
            string maxHealth = maxHealthEls[0].InnerXml;
            MaxHealthTxt.Text = maxHealth;

            XmlNodeList yearEls = save.GetElementsByTagName("yearForSaveGame");
            string year = yearEls[0].InnerXml;
            YearTxt.Text = year;

            XmlNodeList dayEls = save.GetElementsByTagName("dayOfMonthForSaveGame");
            string day = dayEls[0].InnerXml;
            DayTxt.Text = day;

            XmlNodeList seasonEls = save.GetElementsByTagName("seasonForSaveGame");
            string season = seasonEls[0].InnerXml;
            SeasonTxt.Text = season;

            XmlNodeList msPlayedEls = save.GetElementsByTagName("millisecondsPlayed");
            string msPlayed = msPlayedEls[0].InnerXml;
            MSPlayedTxt.Text = msPlayed;

            XmlNodeList gameVersionEls = save.GetElementsByTagName("gameVersion");
            string gameVersion = gameVersionEls[0].InnerXml;
            GameVersionTxt.Text = gameVersion;




        }

        private void SaveSaveBtn_Click(object sender, EventArgs e)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string savepath = appdata + @"\StardewValley\Saves\" + FileSaveName + @"\" + FileSaveName;

            save.Save(savepath);
        }

        private void CatPersonBox_Click(object sender, EventArgs e)
        {
            XmlNodeList catPersonEls = save.GetElementsByTagName("catPerson");
            catPersonEls[0].InnerXml = CatPersonBox.Checked.ToString();
        }

        private void PetTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlNodeList petTypeEls = save.GetElementsByTagName("whichPetBreed");
            petTypeEls[0].InnerXml = PetTypeCombo.SelectedIndex.ToString();
        }

        private void SaveNameTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList nameEls = save.GetElementsByTagName("name");
            nameEls[0].InnerXml = SaveNameTxt.Text;
        }

        private void FarmNameTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList farmNameEls = save.GetElementsByTagName("farmName");
            farmNameEls[0].InnerXml = FarmNameTxt.Text;
        }

        private void FavouriteThingTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList favouriteThingEls = save.GetElementsByTagName("favoriteThing");
            favouriteThingEls[0].InnerXml = FavouriteThingTxt.Text;
        }

        private void HairColourColourDialogBtn_Click(object sender, EventArgs e)
        {
            if (HairColorDialog.ShowDialog() == DialogResult.OK)
            {
                HairColourColourDialogBtn.BackColor = HairColorDialog.Color;

                XmlNodeList hairColorEls = save.GetElementsByTagName("hairstyleColor");
                XmlNodeList hairColorChildEls = hairColorEls[0].ChildNodes;

                hairColorChildEls[0].InnerXml = HairColorDialog.Color.B.ToString();
                hairColorChildEls[1].InnerXml = HairColorDialog.Color.G.ToString();
                hairColorChildEls[2].InnerXml = HairColorDialog.Color.R.ToString();
                hairColorChildEls[3].InnerXml = HairColorDialog.Color.A.ToString();

            }
        }

        private void MoneyTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList moneyEls = save.GetElementsByTagName("money");
            moneyEls[0].InnerXml = MoneyTxt.Text;
        }

        private void MaxHealthTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList maxHealthEls = save.GetElementsByTagName("maxHealth");
            maxHealthEls[0].InnerXml = MaxHealthTxt.Text;
        }

        private void HealthTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList healthEls = save.GetElementsByTagName("health");
            healthEls[0].InnerXml = HealthTxt.Text;
        }

        private void YearTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList yearEls = save.GetElementsByTagName("yearForSaveGame");
            yearEls[0].InnerXml = YearTxt.Text;
        }

        private void SeasonTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList seasonEls = save.GetElementsByTagName("seasonForSaveGame");
            seasonEls[0].InnerXml = SeasonTxt.Text;
        }

        private void DayTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList dayEls = save.GetElementsByTagName("dayOfMonthForSaveGame");
            dayEls[0].InnerXml = DayTxt.Text;
        }

        private void MSPlayedTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList msPlayedEls = save.GetElementsByTagName("millisecondsPlayed");
            msPlayedEls[0].InnerXml = MSPlayedTxt.Text;
        }

        private void GameVersionTxt_TextChanged(object sender, EventArgs e)
        {
            XmlNodeList gameVersionEls = save.GetElementsByTagName("gameVersion");
            gameVersionEls[0].InnerXml = GameVersionTxt.Text;
            gameVersionEls[1].InnerXml = GameVersionTxt.Text;
        }
    }
}