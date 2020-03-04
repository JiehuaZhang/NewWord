using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWords.Core.Model;

namespace NewWord.Windows.TabControls
{
    public partial class BooksTab : UserControl
    {
        public WordBook CurrentBook { get; set; }
        public BooksTab()
        {
            InitializeComponent();
        }
    }
}
