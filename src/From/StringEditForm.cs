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
using Sunny.UI;

namespace HuluwaToken
{
    public partial class StringEditForm : UIEditForm
    {
        public StringEditForm()
        {
            InitializeComponent();
        }

        public string Value { get { return uiTextBox1.Text; } set { uiTextBox1.Text = value; } }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.FileName;
                var text = File.ReadAllText(file);
                Value = text;
            }
        }
    }
}
