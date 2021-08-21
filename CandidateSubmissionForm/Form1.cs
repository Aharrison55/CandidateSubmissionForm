using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CandidateSubmissionForm
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Harrison55!");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO votingdata.votinginfo(fname,lname,age) VALUES('" + fname.Text + "','" + lname.Text + "'," + age.Text + ")"; 
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("worked");

                }
                else
                {
                    MessageBox.Show("no work");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }
    }
}
