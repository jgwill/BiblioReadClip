
using System.Speech.Synthesis;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ReadClip
{
    public partial class MainForm : Form
    {


        #region Fields and props


        /// <summary>
        /// Read the current Text Context.
        /// </summary>
        protected void ReadContext()
              => ReadText(Txt);

        public string Txt
        {
            get { return textToSynthesize__textBox.Text; }
            set { textToSynthesize__textBox.Text = value; }
        }

        private List<BiblioCsl> listBiblioData;

        public List<BiblioCsl> CollectionBiblioData
        {
            get
            {
                if (listBiblioData == null) listBiblioData = new List<BiblioCsl>();
                return listBiblioData;
            }
            set { listBiblioData = value; }
        }

        #endregion




        public MainForm()
        {
            InitializeComponent();
        }

        private void test_Synt_button_Click(object sender, EventArgs e)
        {

            var txt = textToSynthesize__textBox.Text;

            ReadText(txt);

        }

        /// <summary>
        /// static Speech synthesizer.
        /// </summary>
        /// <param name="txt"></param>
        public static void ReadText(string txt)
        {

            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(txt);
        }
        private void pasteNRead__button_Click(object sender, EventArgs e)
        {
            try
            {

                Txt = Clipboard.GetText();

            }
            catch (Exception) //Try reread the text in clipboard if failed
            {
                Thread.Sleep(2);
                textToSynthesize__textBox.Text = Clipboard.GetText();

            }

            //read the text
            if (Txt.Length > 1)
            {
                ReadContext();
            }

        }

        private void cite__textBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in citeFull__textBox.AutoCompleteCustomSource)
            {
                textToSynthesize__textBox.AppendText(item.ToString() + "\n");
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //ReadBiblioText__DEPRECATING();
            ReadBiblioJSON();
        }

        private void ReadBiblioJSON()
        {
            var fname = "biblio.json";
            LoadJson(fname);
            //textToSynthesize__textBox.Text = 
        }

        public void LoadJson(string fname)
        {
            using (StreamReader r = new StreamReader(fname))
            {
                string json = r.ReadToEnd();
                List<BiblioCsl> items = JsonConvert.DeserializeObject<List<BiblioCsl>>(json);
                this.listBiblioData = items;
                foreach (var item in listBiblioData)
                {
                    textToSynthesize__textBox.AppendText(item.Title);
                }

            } //we should have 

        }

      
        private void ReadBiblioText__DEPRECATING()
        {
            var fname = "biblio.txt";
            var biblioDataSource = File.ReadAllText(fname);
            string[] b = biblioDataSource.Split('\n'); // we have an array with each line
            foreach (var item in b)
            {
                string[] d = item.Split(';'); //we have an array with the cite and full biblio
                var cite = d[0];
                var citeFull = d[1];

            }
        }
    }
}
