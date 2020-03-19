using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace SistemExperRadaProcop
{
    public partial class Form1 : Form
    {
        
        Form2 childForm_1 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTitlu_Click(object sender, EventArgs e)
        {
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            childForm_1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            childForm_1.Close();
        }
    }
}
