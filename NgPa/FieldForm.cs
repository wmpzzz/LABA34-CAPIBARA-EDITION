using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N7Pa
{
    public partial class FieldForm : Form
    {
        public FieldForm()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpenFileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            this.Text = System.IO.Path.GetFileNameWithoutExtension(filename);
        }
    }
}
