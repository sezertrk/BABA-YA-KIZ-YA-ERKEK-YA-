using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Baba = int .Parse (textBox1 .Text );
            int Kiz = int .Parse (textBox2 .Text );
            int Erkek = int .Parse (textBox3 .Text );
            Baba += 2;
            Kiz += 2;
            Erkek += 2;

            if (Kiz % 2 == 0) ;
            {
                MessageBox.Show((Kiz + Baba).ToString());
            } if (Erkek % 2 == 0)
            {
                MessageBox.Show((Erkek + Baba).ToString());
            }
            else
            { }

        }
    }
}
