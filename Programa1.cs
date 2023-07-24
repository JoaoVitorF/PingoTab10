using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace PingoTabs10
{
    public partial class Programa1 : Form
    {
        string[] Sites = new string[8];
        public string Savepath = Environment.CurrentDirectory + "/" + "save.txt";

        public void CreateSave()
        {
            StreamWriter sw = new StreamWriter(Savepath);
            sw.Close();
        }

        public void LoadSave()
        {
            Sites[0] = GetLine(Savepath,0);
            Sites[1] = GetLine(Savepath,1);
            Sites[2] = GetLine(Savepath,2);
            Sites[3] = GetLine(Savepath,3);
            Sites[4] = GetLine(Savepath,4);
            Sites[5] = GetLine(Savepath,5);
            Sites[6] = GetLine(Savepath,6);
            Sites[7] = GetLine(Savepath,7);
            UpdateSites();
        }

        public string LoadSaveComplete()
        {
            StreamReader sr = new StreamReader(Savepath);
            string load = sr.ReadToEnd();
            sr.Close();
            return load;
        }

        public void Salvar(string web)
        {
            string oldsave = LoadSaveComplete();
            StreamWriter sw = new StreamWriter(Savepath);
            sw.WriteLine(oldsave + web);
            sw.Close();
        }

        public Programa1()
        {
            InitializeComponent();
            if (!File.Exists(Savepath))
            {
                CreateSave();
                MessageBox.Show("New Save created sucess");
            }
            else
            {
                LoadSave();
            }
        }

        private void AddSiteTxt_Click(object sender, EventArgs e)
        {

        }

        private void SiteToAddTxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExplicacaoTxt_Click(object sender, EventArgs e)
        {

        }

        private void AddSiteBtn_Click(object sender, EventArgs e)
        {
            if (Sites[7] != null)
            {
                AvisosLabel.Text = "Lotado";
            }
            else
            {
                for (int i = 0; i <= Sites.Length - 1; i++)
                {
                    if (Sites[i] == null)
                    {
                        Sites[i] = SiteToAddTxB.Text;
                        Salvar(Sites[i]);
                        i = Sites.Length;
                    }
                }
                UpdateSites();
            }
        }

        private void UpdateSites()
        {
            Site1Btn.Text = Sites[0];
            Site2Btn.Text = Sites[1];
            Site3Btn.Text = Sites[2];
            Site4Btn.Text = Sites[3];
            Site5Btn.Text = Sites[4];
            Site6Btn.Text = Sites[5];
            Site7Btn.Text = Sites[6];
            Site8Btn.Text = Sites[7];
        }

        private void Site1Btn_Click(object sender, EventArgs e)
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site1Btn.Text;
            Process.Start(prs);
        }

        private void Site2Btn_Click(object sender, EventArgs e)
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site2Btn.Text;
            Process.Start(prs);
        }

        private void Site3Btn_Click(object sender, EventArgs e)
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site3Btn.Text;
            Process.Start(prs);
        }

        private void Site4Btn_Click(object sender, EventArgs e)
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site4Btn.Text;
            Process.Start(prs);
        }

        private void Site5Btn_Click(object sender, EventArgs e)
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site5Btn.Text;
            Process.Start(prs);
        }

        private void Site6Btn_Click(object sender, EventArgs e)
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site6Btn.Text;
            Process.Start(prs);
        }

        private void Site7Btn_Click(object sender, EventArgs e)
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site7Btn.Text;
            Process.Start(prs);
        }

        private void Site8Btn_Click(object sender, EventArgs e)
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site8Btn.Text;
            Process.Start(prs);
        }

        

        string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i <= line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        static void LineDelete(string fileName, int line_to_delete)
        {
            var file = new List<string>(System.IO.File.ReadAllLines(fileName));
            file.RemoveAt(line_to_delete);
            File.WriteAllLines(fileName, file.ToArray());
        }

        private void UpdateList_Click(object sender, EventArgs e)
        {
            LoadSave();
        }

        private void DeleteSite1_Click(object sender, EventArgs e)
        {
            Site1Btn.Text = "";
            Sites[0] = "";
            LineDelete(Savepath, 0);
            UpdateSites();
        }

        private void DeleteSite2_Click(object sender, EventArgs e)
        {
            Site2Btn.Text = "";
            Sites[1] = "";
            LineDelete(Savepath, 1);
            UpdateSites();
        }

        private void DeleteSite3_Click(object sender, EventArgs e)
        {
            Site2Btn.Text = "";
            Sites[2] = "";
            LineDelete(Savepath, 2);
            UpdateSites();
        }

        private void DeleteSite4_Click(object sender, EventArgs e)
        {
            Site2Btn.Text = "";
            Sites[3] = "";
            LineDelete(Savepath, 3);
            UpdateSites();
        }

        private void DeleteSite5_Click(object sender, EventArgs e)
        {
            Site2Btn.Text = "";
            Sites[4] = "";
            LineDelete(Savepath, 4);
            UpdateSites();
        }

        private void DeleteSite6_Click(object sender, EventArgs e)
        {
            Site2Btn.Text = "";
            Sites[5] = "";
            LineDelete(Savepath, 5);
            UpdateSites();
        }

        private void DeleteSite7_Click(object sender, EventArgs e)
        {
            Site2Btn.Text = "";
            Sites[6] = "";
            LineDelete(Savepath, 6);
            UpdateSites();
        }

        private void DeleteSite8_Click(object sender, EventArgs e)
        {
            Site2Btn.Text = "";
            Sites[7] = "";
            LineDelete(Savepath, 7);
            UpdateSites();
        }

        private void OpenAllBtn_Click(object sender, EventArgs e)
        {
            NovaJanela();
            //NovaAba();
        }

        private void NovaJanela()
        {
            LoadSave();
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            Process.Start(prs);
            for(int b = 0; b <= Sites.Length-1;b++)
            {
                if (Sites[b] != null)
                {
                    prs.Arguments = Sites[b];
                    Process.Start(prs);
                    AvisosLabel.Text = Sites[b];
                }
            }
        }

        private void NovaAba()
        {
            var prs = new ProcessStartInfo("C:/Program Files/Google/Chrome/Application/chrome.exe");
            prs.Arguments = Site6Btn.Text;
            Process.Start(prs);
        }
    }
}
