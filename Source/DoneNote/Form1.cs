using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoneNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 既定の保存ファイル
        /// </summary>
        public const string TEXT_FILE = "DoneNote.txt";

        /// <summary>
        /// まだ保存していないなら真
        /// </summary>
        public bool Editing {
            get
            {
                return editing;
            }
            set
            {
                editing = value;

                TopUserControl topUserControl1 = (TopUserControl)topPanel.Controls["topUserControl1"];
                topUserControl1.SyncEditing(editing);
            }
        }
        bool editing;

        private void Form1_Load(object sender, EventArgs e)
        {
            // ファイル読み込み
            if (File.Exists(TEXT_FILE))
            {
                CenterUserControl centerUserControl1 = (CenterUserControl)centerPanel.Controls["centerUserControl1"];
                centerUserControl1.TextBoxText = File.ReadAllText(TEXT_FILE);

                // 初回のテキストボックスの内容変更は、未保存とは扱わない
                Editing = false;
                topUserControl1.SyncEditing(Editing);
            }
        }

        public string TextBoxText
        {
            get
            {
                return ((CenterUserControl)centerPanel.Controls["centerUserControl1"]).TextBoxText;
            }
            set
            {
                ((CenterUserControl)centerPanel.Controls["centerUserControl1"]).TextBoxText = value;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Control) == Keys.Control)
            {
                if ((e.KeyData & Keys.S) == Keys.S)
                {
                    TopUserControl topUserControl1 = (TopUserControl)topPanel.Controls["topUserControl1"];
                    topUserControl1.Save();
                    //Console.WriteLine("[Ctrl]+[S]キーが押されています。");

                    // ビープ音を鳴らないようにする
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}
