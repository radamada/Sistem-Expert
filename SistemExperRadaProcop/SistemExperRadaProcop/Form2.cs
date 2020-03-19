using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.Common;
using System.IO;

namespace SistemExperRadaProcop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        RulesDataSet database = new RulesDataSet();

        private void Form2_Load(object sender, EventArgs e)
        {    

            string questionFromDb = "";
            string answerFromDb = "";
            string baza = "Rules_Database.accdb";
            string fullpath = Path.GetFullPath(baza);
            string prov = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ";
            string stringdeconectare = prov + fullpath;
            OleDbConnection cnn = new OleDbConnection(stringdeconectare);
            cnn.Open();
            OleDbCommand getQuestion = new OleDbCommand("SELECT Question FROM Questions WHERE ID = 1", cnn);
            OleDbCommand getAnswer1 = new OleDbCommand("SELECT A1 FROM Questions WHERE ID = 1", cnn);
            OleDbCommand getAnswer2 = new OleDbCommand("SELECT A2 FROM Questions WHERE ID = 1", cnn);
            OleDbCommand getAnswer3 = new OleDbCommand("SELECT A3 FROM Questions WHERE ID = 1 AND A3 != NULL", cnn);
            OleDbCommand getAnswer4 = new OleDbCommand("SELECT A4 FROM Questions WHERE ID = 1 AND A4 != NULL", cnn);

            OleDbDataReader reader = getQuestion.ExecuteReader();
            while (reader.Read())
            {
                questionFromDb = reader[0].ToString();
            }

            OleDbDataReader reader1 = getAnswer1.ExecuteReader();
            while (reader1.Read())
            {
                answerFromDb = reader1[0].ToString();
            }
            possAnswers.Items.Add(answerFromDb);
            labelQuestion.Text = questionFromDb;
            labelQuestion.Visible = true;
            possAnswers.Visible = true;


            cnn.Close();
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void possAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
