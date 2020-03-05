using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWord.Windows.Model;
using NewWords.Core;
using NewWords.Core.Model;

namespace NewWord.Windows.TabControls
{
    public partial class CardEndTab : UserControl
    {
        public event EventHandler TestModeEvent;

        public bool IsTest { get; set; } = false;
        public string CurrentBookName { get; set; }
        public CardEndTab()
        {
            InitializeComponent();
        }

        private void CardEndTab_Load(object sender, EventArgs e)
        {
            lblBookName.Text = CurrentBookName;
            lblEnd.Text = Constants.FormText.TheEnd;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            IsTest = true;
            TestModeEvent?.Invoke(new TabTransferDataModel (true,"CardEnd"), null);
        }

        private void BtnAgain_Click(object sender, EventArgs e)
        {
            IsTest = false;
            TestModeEvent?.Invoke(new TabTransferDataModel(false,"CardEnd"), null);
        }
    }
}
