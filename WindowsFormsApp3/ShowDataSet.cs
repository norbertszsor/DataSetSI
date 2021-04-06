using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ShowDataSet : Form
    {
        
        static public class ErrorContainer
        {
            static public bool no1(string _fileName)
            {
                if (Program.tmpConfigFile.nazwaPlikuDanych != _fileName)
                {
                    DialogResult dialogResult = MessageBox.Show("Niekompatybilny plik danych", "Błąd n01", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                        return true;

                }
                return false;
            }
            static public bool no2(string _path)
            {
                if (_path == "")
                {
                    DialogResult dialogResult = MessageBox.Show("Nie wybrano pliku", "Błąd n02", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                        return true;
                }
                return false;
            }
            
        }
     
        public void LoadConfig()
        {
            
            openConfigFile.ShowDialog();
            
            string path = openConfigFile.FileName;
            string textContainer;

            if (ErrorContainer.no2(path) == true)
                return;
            this.RowsToNormalizeBox.Items.Clear();
            Program.tmpConfigFile = JsonOperations.Open(path);
            string[] tmpCharRows = new string[Program.tmpConfigFile.liczbaKolumn];

            textContainer = JsonConvert.SerializeObject(Program.tmpConfigFile, Formatting.Indented);
            
            
            for (int i = 0; i < Program.tmpConfigFile.liczbaKolumn; i++)
            {

                tmpCharRows[i] = "Kolumna " + i.ToString();
                this.RowsToNormalizeBox.Items.Add(tmpCharRows[i]);

                if (Program.tmpConfigFile.kolumnyDoNormalizacji[i] == true)
                {
                    this.RowsToNormalizeBox.SetItemCheckState(i, CheckState.Checked);
                }


            }

            this.ConfigShowBox.Text = textContainer;
            this.StatusBox1.BackColor = Color.Green;
            this.StatusBox1.Text = "Status: Ok";
            this.ButtonChangeConfig.Enabled = true;
            this.RowsToNormalizeBox.Visible = true;
            this.LabelRowsToNormalize.Visible = true;
        }
       
        public ShowDataSet()
        {
            InitializeComponent();
            
            this.StatusBox1.Text = "Status: Brak Pliku";
            this.StatusBox1.BackColor = Color.Red;
            this.StatusBox2.Text = "Status: Brak Pliku";
            this.StatusBox2.BackColor = Color.Red;
            this.StartNormalize.Enabled = false;
            this.ButtonChangeConfig.Enabled = false;
            this.DeflatuNormalizeRange.Enabled = false;
            this.SaveNormalizedData.Enabled = false;
            this.RowsToNormalizeBox.Visible = false;
            this.LabelRowsToNormalize.Visible = false;

        }

        private void LoadDataSet_Click(object sender, EventArgs e)
        {
            this.openDataSetFile.Filter = "data|*.data|dat|*.dat";
            if (Program.tmpConfigFile != null)
            {
                openDataSetFile.ShowDialog();
                
                string path = openDataSetFile.FileName;
                string fileName = openDataSetFile.SafeFileName;

                if (ErrorContainer.no2(path) == true)
                    return;
                if (ErrorContainer.no1(fileName) == true)
                    return;

                Program.unDataSet = new UnnormalizedDataSet(path, Program.tmpConfigFile);
                if (Program.unDataSet.dataList.Count == 0)
                {
                    MessageBox.Show("Sprawdź poprawność pliku konfiguracyjnego", "Błąd n05");
                    this.DeletedRowText.Text = Program.unDataSet.unvalidLines.ToString();
                    this.DeletedRowText.BackColor = Color.Red;
                    this.StatusBox1.Text = "Status: Błąd pliku Config";
                    this.StatusBox1.BackColor = Color.Red;
                    return;
                }

                this.DataSetShowBox.DataSource = Program.unDataSet.unnormalizedDataSetView();
                this.StatusBox2.Text = "Status: Ok";
                this.StatusBox2.BackColor = Color.Green;

                this.DeletedRowText.Text = Program.unDataSet.unvalidLines.ToString();
                this.DeletedRowText.BackColor = Color.Red;
                
                this.LoadDataSet.Enabled = false;
                this.LoadConfigFile.Enabled = false;
                this.StartNormalize.Enabled = true;
                this.DeflatuNormalizeRange.Enabled = true;
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Czy chcesz utworzyć plik automatycznie ?", "Brak pliku konfiguracyjnego", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    openDataSetFile.ShowDialog();
                    
                    string path = openDataSetFile.FileName;
                    string fileName = openDataSetFile.SafeFileName;
                    string textContainer;

                    if (ErrorContainer.no2(path) == true)
                        return;

                    Program.tmpConfigFile = AnalizeDataSet.generateConfigFIle(path, fileName);
                    string[] tmpCharRows = new string[Program.tmpConfigFile.liczbaKolumn];
                    textContainer = JsonConvert.SerializeObject(Program.tmpConfigFile, Formatting.Indented);
                    Program.unDataSet = new UnnormalizedDataSet(path, Program.tmpConfigFile);

                    this.DataSetShowBox.DataSource = Program.unDataSet.unnormalizedDataSetView();
                    this.ConfigShowBox.Text = textContainer;

                    for (int i = 0; i < Program.tmpConfigFile.liczbaKolumn; i++)
                    {

                        tmpCharRows[i] = "Kolumna " + i.ToString();
                        this.RowsToNormalizeBox.Items.Add(tmpCharRows[i]);

                        if (Program.tmpConfigFile.kolumnyDoNormalizacji[i] == true)
                        {
                            this.RowsToNormalizeBox.SetItemCheckState(i, CheckState.Checked);
                        }


                    }

                    this.StatusBox2.Text = "Status: Ok";
                    this.StatusBox2.BackColor = Color.Green;
                    this.StatusBox1.Text = "Status: Automatyczny";
                    this.StatusBox1.BackColor = Color.Yellow;

                    this.DeletedRowText.Text = Program.unDataSet.unvalidLines.ToString();
                    this.DeletedRowText.BackColor = Color.Red;
                    this.LoadDataSet.Enabled = false;
                    this.LoadConfigFile.Enabled = false;
                    this.StartNormalize.Enabled = true;
                    this.DeflatuNormalizeRange.Enabled = true;
                    this.ButtonChangeConfig.Enabled = true;
                    this.RowsToNormalizeBox.Visible = true;
                    this.LabelRowsToNormalize.Visible = true;


                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
           
        }

        private void LoadConfigFile_Click(object sender, EventArgs e)
        {

            this.LoadConfig();

         


        }
        private void RowsToNormalizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < RowsToNormalizeBox.Items.Count; i++)
            {
                string textContainer;
                if(RowsToNormalizeBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    Program.tmpConfigFile.kolumnyDoNormalizacji[i] = true;
                }
                else
                {
                    Program.tmpConfigFile.kolumnyDoNormalizacji[i] = false;
                }
                textContainer = JsonConvert.SerializeObject(Program.tmpConfigFile, Formatting.Indented);
                this.ConfigShowBox.Text = textContainer;

            }
        }

        private void StartNormalize_Click(object sender, EventArgs e)
        {
           
            if(Program.unDataSet !=null&& Program.tmpConfigFile != null)
            {
                if(DeflatuNormalizeRange.Checked == true)
                {
                    Program.nnDataset =new NormalizedDataSet(NormalizeOperations.prepareDataSet(Program.unDataSet, Program.tmpConfigFile,0,0), Program.tmpConfigFile);
                    this.DataSetShowBox.DataSource = Program.nnDataset.NormalizedDataSetView();
                }
                else
                {
                    float _newMin;
                    float _newMax;
                    bool succcesParse1 = float.TryParse(RangeNormalizeMin.Text, out _newMin);
                    bool successParse2 = float.TryParse(RangeNormalizeMax.Text, out _newMax);
                    if (succcesParse1 == true && successParse2 == true)
                    {
                        if (_newMax > 100 || _newMax < 0 || _newMin > 100 || _newMax < 0)
                        {
                            MessageBox.Show(" Wprowadź tylko liczby z przedziału od 1 do 100", "Info");
                            this.RangeNormalizeMax.Clear();
                            this.RangeNormalizeMin.Clear();
                            return;
                        }
                        else if (_newMax > _newMin)
                        {
                            Program.nnDataset = new NormalizedDataSet(NormalizeOperations.prepareDataSet(Program.unDataSet, Program.tmpConfigFile, _newMin, _newMax), Program.tmpConfigFile);
                            this.DataSetShowBox.DataSource = Program.nnDataset.NormalizedDataSetView();
                        }
                        else if(_newMin > _newMax)
                        {
                            MessageBox.Show("Maksimum nie może być mniejsze od miniumum", "Błąd n03");
                            this.RangeNormalizeMax.Clear();
                            this.RangeNormalizeMin.Clear();
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Proszę wprowadź tylko liczby", "Błąd n04");
                        this.RangeNormalizeMax.Clear();
                        this.RangeNormalizeMin.Clear();
                        return;
                    }
                       
                    
                   
                }


                this.SaveNormalizedData.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Nie podano pliku konfiguracyjnego lub pliku danych", "Wczytaj Pliki");
            }

        }
        

        private void ResetApp_Click(object sender, EventArgs e)
        {
            Program.tmpConfigFile = null;
            Program.unDataSet = null;
            ShowDataSet NewForm = new ShowDataSet();
            NewForm.Show();
            this.Dispose(false);

        }

        private void ButtonChangeConfig_Click(object sender, EventArgs e)
        {
            
            try
            {
                ConfigFile ConfigFileCheckEquals = JsonConvert.DeserializeObject<ConfigFile>(this.ConfigShowBox.Text);

                if (Program.tmpConfigFile != ConfigFileCheckEquals)
                {
                    Program.tmpConfigFile = JsonConvert.DeserializeObject<ConfigFile>(this.ConfigShowBox.Text);
                    this.RowsToNormalizeBox.Items.Clear();
                    string[] tmpCharRows = new string[Program.tmpConfigFile.liczbaKolumn];
                    for (int i = 0; i < Program.tmpConfigFile.liczbaKolumn; i++)
                    {

                        tmpCharRows[i] = "Kolumna " + i.ToString();
                        this.RowsToNormalizeBox.Items.Add(tmpCharRows[i]);

                        if (Program.tmpConfigFile.kolumnyDoNormalizacji[i] == true)
                        {
                            this.RowsToNormalizeBox.SetItemCheckState(i, CheckState.Checked);
                        }


                    }
                    MessageBox.Show("Wprowadzono zmiany", Program.tmpConfigFile.nazwaPlikuConfig);
                }
                else
                    MessageBox.Show("Nie wprowadziłeś żadnych zmian", Program.tmpConfigFile.nazwaPlikuConfig);
            }
            catch
            {
                MessageBox.Show("Niepoprawne dane pliku konfiguracyjego", "Błąd n06");
                this.ConfigShowBox.Text = JsonConvert.SerializeObject(Program.tmpConfigFile, Formatting.Indented);
                return;
            }
           


            
        }

        private void DeflatuNormalizeRange_CheckedChanged(object sender, EventArgs e)
        {
            if(DeflatuNormalizeRange.Checked == false)
            {
                this.RangeSelectLabel.Visible = true;
                this.RangeSelectLabel2.Visible = true;
                this.RangeNormalizeMin.Visible = true;
                this.RangeNormalizeMax.Visible = true;
            }
            else
            {
                this.RangeSelectLabel.Visible = false;
                this.RangeSelectLabel2.Visible = false;
                this.RangeNormalizeMin.Visible = false;
                this.RangeNormalizeMax.Visible = false;
            }
        }

        

        private void SaveNormalizedData_Click(object sender, EventArgs e)
        {
            
            this.SaveDataFile.Filter = "njson|*.njson|ovn|*.ovn|txt|*.txt";
            this.SaveDataFile.ShowDialog();
            if (ErrorContainer.no2(SaveDataFile.FileName) == true)
                return;

            if (SaveDataFile.FilterIndex == 1)
            {
                NormalizedDataSetSave.saveToJSON(this.SaveDataFile.FileName, Program.nnDataset.NormalizedDataSetView());
                this.StartNormalize.Enabled = false;
                this.DeflatuNormalizeRange.Enabled = false;
                this.RangeNormalizeMin.Enabled = false;
                this.RangeNormalizeMax.Enabled = false;
            }
            else if (SaveDataFile.FilterIndex == 2)
            {
                NormalizedDataSetSave.saveToOwnFormat(this.SaveDataFile.FileName, Program.nnDataset.dataset);
                this.StartNormalize.Enabled = false;
                this.DeflatuNormalizeRange.Enabled = false;
                this.RangeNormalizeMin.Enabled = false;
                this.RangeNormalizeMax.Enabled = false;
            }
            else if (SaveDataFile.FilterIndex == 3)
            {
                NormalizedDataSetSave.saveToTXT(this.SaveDataFile.FileName, Program.nnDataset.NormalizedDataSetView());
                this.StartNormalize.Enabled = false;
                this.DeflatuNormalizeRange.Enabled = false;
                this.RangeNormalizeMin.Enabled = false;
                this.RangeNormalizeMax.Enabled = false;
            }


            MessageBox.Show("Plik został zapisany", this.SaveDataFile.FileName);

        }

        private void LoadNormalizedData_Click(object sender, EventArgs e)
        {
            this.LoadNormalizedDataSet.Filter = "njson|*.njson|ovn|*.ovn|txt|*.txt";
            this.LoadNormalizedDataSet.ShowDialog();
            
            if (ErrorContainer.no2(LoadNormalizedDataSet.FileName) == true)
                return;

            if(LoadNormalizedDataSet.FilterIndex == 1)
            {
                this.DataSetShowBox.DataSource = NormalizedDataSetSave.opentFromJSON(LoadNormalizedDataSet.FileName);
            }
            else if (LoadNormalizedDataSet.FilterIndex == 2)
            {
                this.DataSetShowBox.DataSource = NormalizedDataSetSave.openFromOwnFromat(LoadNormalizedDataSet.FileName);
            }
            else if (LoadNormalizedDataSet.FilterIndex == 3)
            {
                this.DataSetShowBox.DataSource = NormalizedDataSetSave.openFromTXT(LoadNormalizedDataSet.FileName);
            }

            this.ConfigShowBox.Clear();

            this.RowsToNormalizeBox.Visible = false;
            this.LabelRowsToNormalize.Visible = false;

            this.LoadConfigFile.Enabled = false;
            this.LoadDataSet.Enabled = false;
            this.ButtonChangeConfig.Enabled = false;
            this.StartNormalize.Enabled = false;
            this.SaveNormalizedData.Enabled = false;
            this.DeflatuNormalizeRange.Enabled = false;

            this.StatusBox2.Text = "Status: Tylko do odczytu ";
            this.DeletedRowText.Clear();
            this.StatusBox1.Clear();
            this.StatusBox2.BackColor = Color.Blue;
            this.StatusBox1.BackColor = Color.White;
            this.DeletedRowText.BackColor = Color.White;
            
        }
        private void ShowDataSet_Load(object sender, EventArgs e)
        {

        }
        private void DataSetShowBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
