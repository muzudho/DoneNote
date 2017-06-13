using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoneNote
{
    public partial class CenterUserControl : UserControl
    {
        public CenterUserControl()
        {
            InitializeComponent();
        }

        public string TextBoxText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
