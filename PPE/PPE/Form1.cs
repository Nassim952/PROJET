using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cbFichier.Click += new EventHandler(cbFichier_Click);
        }

        void cbFichier_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            cbFichier.Text = folderBrowserDialog1.SelectedPath;

        }

    }
}
