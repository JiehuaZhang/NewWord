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
using NewWords.Core;

namespace NewWord.Windows
{
    public partial class CombinedWordCard : Form
    {
        private List<NewWords.Core.Model.WordCard> _words;
        private int count = 0;
        private Color _rememberColor = Color.CornflowerBlue;
        private Color _forgotColor = Color.DarkViolet;
        public CombinedWordCard()
        {
            GetWordList();
           

            this.TopMost = true;
            InitializeComponent();
            if (_words.Count == 0)
            {
                NoNewWord();
            }
            else
            {
                Beginning();
            }
        }

        private void SaveWordCard()
        {
            if (string.IsNullOrEmpty(txtNewWord.Text)) return;
            var word = new NewWords.Core.Model.WordCard
            {
                Word = txtNewWord.Text, Meaning = txtMeaning.Text, Difficulty = (int) numDifficulty.Value
            };
            var saveWord = new SaveWord();
            saveWord.SaveOneWord(word);
            _words.Add(word);
        }

        private void Difficulty_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SaveWordCard();
                txtNewWord.Text = string.Empty;
                txtMeaning.Text = string.Empty;
                numDifficulty.Value = 4;
                //this.ActiveControl = txtWord;
                txtNewWord.Focus();
            } 
        }

        private void TabAdd_Click(object sender, EventArgs e)
        {
            txtNewWord.Focus();
        }

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
            btnAgain.Visible = _words.Count > 0;
        }

        private void NoNewWord()
        {
            btnNo.Visible = false;
            btnYes.Visible = false;
            btnAgain.Visible = false;
            lblDifficulty.Visible = false;
            txtWord.Text = "No new word.";
        }

        private void GetWordList()
        {
            var wordstring = File.ReadAllText("Word.txt");
            wordstring = "[" + File.ReadAllText("Word.txt").TrimEnd(',') + "]";
            _words = JsonConvert.DeserializeObject<List<NewWords.Core.Model.WordCard>>(wordstring);
        }

        private void SaveRememberStatus()
        {
            var json = JsonConvert.SerializeObject(_words);
            json = json.TrimStart('[').TrimEnd(']') + ",";
            File.WriteAllText("Word.txt", json);
        }
        #endregion

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

        private void BtnAgain_Click(object sender, EventArgs e)
        {
            Beginning();
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

        private void Card_Closing(object sender, FormClosingEventArgs e)
        {
            SaveRememberStatus();
        }

        private void BtnArrange1_Click(object sender, EventArgs e)
        {
            var rememberWordsString = JsonConvert.SerializeObject(_words.Where(x => x.Remember && x.Count >= 50).ToList()).TrimStart('[').TrimEnd(']');
            var rememberWordTextName = "OKWord" + DateTime.Now.Date.ToString("yyyyMMdd") + ".txt";
            if (!File.Exists(rememberWordTextName) && !string.IsNullOrWhiteSpace(rememberWordsString))
            {
                using (StreamWriter sw = File.CreateText(rememberWordTextName))
                {
                    sw.Write(rememberWordsString + ",");
                }
            }
           
            if (!string.IsNullOrWhiteSpace(rememberWordsString))
            {
                File.AppendAllText(rememberWordTextName, rememberWordsString);
                _words.RemoveAll(x => x.Remember && x.Count >= 50);
                lblArrange1.Visible = true;
                lblArrange1.Text = lblArrange1.Text + " (at" + DateTime.Now.ToString("HH:mm") + ")";
            }
            else
            {
                lblArrange1.Visible = true;
                lblArrange1.Text = "No remember words" + " (at" + DateTime.Now.ToString("HH:mm")+")";
            }
        }
    }
}
