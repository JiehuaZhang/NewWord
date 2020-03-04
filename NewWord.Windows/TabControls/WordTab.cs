using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWord.Windows.TabControls
{
    public partial class WordTab : UserControl
    {
        public WordCard Word { get; set; } = new WordCard();
        public WordTab()
        {
            InitializeComponent();
        }
    }
}
