using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NewWord.Windows
{
    public partial class WordCard : Form
    {
        private List<NewWords.Core.Model.WordCard> _words;
        private int count = 0;
        private Color _rememberColor  = Color.CornflowerBlue;
        private Color _forgotColor = Color.DarkViolet;

        public WordCard()
        {
            var wordstring = File.ReadAllText("Word.txt");
            wordstring = "[" + File.ReadAllText("Word.txt").TrimEnd(',') + "]";
            _words = JsonConvert.DeserializeObject<List<NewWords.Core.Model.WordCard>>(wordstring);
            if (_words.Count == 0)
            {
                NoNewWord();
            }

            this.TopMost = true;
            InitializeComponent();
            Beginning();
        }
        
        #region Events
        private void BtnNo_Click(object sender, EventArgs e)
        {
            _words[count].Remember = false;
            if (count == _words.Count - 1)
            {
                TheEnd();
            }
            else
            {
                _words[count].Count++;
                lblHidden.Visible = true;
                btnYes.Text = "Next";
            }
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            if (btnYes.Text != "Next")
            {
                lblHidden.Visible = true;
                btnYes.Text = "Next";
                _words[count].Remember = true;
            }
            else
            {
                _words[count].Count++;
                if (count == _words.Count - 1)
                {
                    TheEnd();
                }
                else
                {
                    count++;
                    txtWord.Text = _words[count].Word;
                    txtWord.ForeColor = _words[count].Remember ? _rememberColor : _forgotColor;
                    lblDifficulty.Text = new string('*', _words[count].Difficulty);
                    lblHidden.Text = _words[count].Meaning;
                    lblHidden.Visible = false;
                    btnYes.Text = "Yes";
                }
            }
        }
        private void BtnAgain_Click(object sender, EventArgs e)
        {
            Beginning();
        }

        private void NewWord_Closing(object sender, FormClosedEventArgs e)
        {
            var json = JsonConvert.SerializeObject(_words);
            json = json.TrimStart('[').TrimEnd(']') + ",";
            File.WriteAllText("Word.txt",json);
        }
        #endregion Events

        #region Local Function
        private void Beginning()
        {
            count = 0;
            txtWord.Text = _words[count].Word;
            txtWord.ForeColor = _words[count].Remember ? _rememberColor : _forgotColor;
            lblDifficulty.Text = new string('*', _words[count].Difficulty);
            lblHidden.Text = _words[count].Meaning;
            btnYes.Visible = true;
            btnNo.Visible = true;
            lblDifficulty.Visible = true;
            btnAgain.Visible = false;
            lblHidden.Visible = false;
        }
        private void TheEnd()
        {
            btnNo.Visible = false;
            btnYes.Visible = false;
            lblHidden.Visible = false;
            lblDifficulty.Visible = false;
            txtWord.ForeColor = Color.Black;
            txtWord.Text = "The End";
            btnAgain.Visible =_words.Count > 0;
        }

        private void NoNewWord()
        {
            btnNo.Visible = false;
            btnYes.Visible = false;
            btnAgain.Visible = false;
            lblDifficulty.Visible = false;
            txtWord.Text = "No new word.";
        }
        #endregion
        
    }
}
