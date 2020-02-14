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
           
            TopMost = true;
            InitializeComponent();
            

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
            if (e.KeyChar == 13 && btnUpdate.Visible == false)
            {
                SaveWordCard();
                txtNewWord.Text = string.Empty;
                txtMeaning.Text = string.Empty;
                numDifficulty.Value = 4;
                txtNewWord.Focus();
            }
        }

        private void TabAdd_Click(object sender, EventArgs e)
        {
            txtNewWord.Focus();
        }


        private void BtnNo_Click(object sender, EventArgs e)
        {
            if (btnNo.Text == "Previous" && count > 0)
            {
                if (count > 0)
                {
                    count--;
                    ShowWordCard();
                }
                else
                {
                    btnNo.Enabled = false;
                }
            }
            else
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
                    btnNo.Text = "Previous";
                }
            }
        }

        private void BtnAgain_Click(object sender, EventArgs e)
        {
            CardBeginning();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            if (btnYes.Text != "Next")
            {
                lblHidden.Visible = true;
                btnYes.Text = "Next";
                btnNo.Text = "Previous";
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
                    ShowWordCard();
                }
            }
        }

        private void Card_Closing(object sender, FormClosingEventArgs e)
        {
            SaveRememberStatus();
        }

        private void BtnArrange1_Click(object sender, EventArgs e)
        {
            var rememberWordsString = JsonConvert
                .SerializeObject(_words.Where(x => x.Remember && x.Count >= 50 || x.Difficulty == 0).ToList())
                .TrimStart('[').TrimEnd(']');
            var rememberWordTextName = "OKWord" + DateTime.Now.Date.ToString("yyyyMMdd") + ".txt";
            if (!File.Exists(rememberWordTextName) && !string.IsNullOrWhiteSpace(rememberWordsString))
                using (var sw = File.CreateText(rememberWordTextName))
                {
                    sw.Write(rememberWordsString + ",");
                }

            if (!string.IsNullOrWhiteSpace(rememberWordsString))
            {
                File.AppendAllText(rememberWordTextName, rememberWordsString);
                _words.RemoveAll(x => x.Remember && x.Count >= 50 || x.Difficulty == 0);
                lblArrange1.Visible = true;
                lblArrange1.Text = lblArrange1.Text + " (at" + DateTime.Now.ToString("HH:mm") + ")";
            }
            else
            {
                lblArrange1.Visible = true;
                lblArrange1.Text = "No remember words" + " (at" + DateTime.Now.ToString("HH:mm") + ")";
            }
        }

        private void TxtWord_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabAdd;
            txtNewWord.Text = _words[count].Word;
            txtMeaning.Text = _words[count].Meaning;
            numDifficulty.Value = _words[count].Difficulty;
            btnUpdate.Visible = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _words[count].Word = txtNewWord.Text;
            _words[count].Meaning = txtMeaning.Text;
            _words[count].Difficulty = (int) numDifficulty.Value;
            txtNewWord.Text = string.Empty;
            txtMeaning.Text = string.Empty;
            numDifficulty.Value = 4;
            btnUpdate.Visible = false;
            tabControl1.SelectedTab = tabCard;
            ShowWordCard();
        }

        private void BtnSplitWords_Click(object sender, EventArgs e)
        {
            if (_words.Count > 50)
            {
            }
            else
            {
            }

            lblSplit.Visible = true;
        }

        #region Local Function

        private void CardBeginning()
        {
            count = 0;
            ShowWordCard();
        }

        private void ShowWordCard()
        {
            txtWord.Text = _words[count].Word;
            txtWord.ForeColor = _words[count].Remember ? _rememberColor : _forgotColor;
            lblDifficulty.Text = new string('*', _words[count].Difficulty);
            lblHidden.Text = _words[count].Meaning;
            btnYes.Visible = true;
            btnYes.Text = "Yes";
            btnNo.Text = "No";
            btnNo.Visible = true;
            lblDifficulty.Visible = true;
            btnAgain.Visible = false;
            lblHidden.Visible = false;
            btnNo.Enabled = true;
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
            //var treeNode = new TreeNode("Word_0-10");
            //var treeNode2  = new TreeNode("Word_10-20");
            //treeBooks.Nodes.Add(treeNode);
            //treeBooks.Nodes.Add(treeNode2);
           
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

        private void WordCard_Load(object sender, EventArgs e)
        {
            var files = GetFiles();
            List<TreeNode> nodeList = new List<TreeNode>();
            foreach (var file in files)
            {
                nodeList.Add(new TreeNode(file));
            }
            ////
            //// Final node.
            ////
            var treeNode = new TreeNode("Books", nodeList.ToArray());
            treeBooks.Nodes.Add(treeNode);
            
            tabControl1.SelectedTab = tabBooks;
            GetWordList();
            if (_words.Count == 0)
                NoNewWord();
            else
                CardBeginning();
        }

        private string[] GetFiles()
        {
            var path =Path.GetFullPath(@"Library\Books") ;
            if (Directory.Exists(path))
            {
                var info =new DirectoryInfo(path);
                return info.GetFiles().Select(x => x.Name).ToArray();
            }

            File.Create(path);
            return null;
        }
    }
}