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

namespace VoacbRemind
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = vocabdb.accdb;
                                                            Persist Security Info=False;"); //Ms accessDB connection instance
        OleDbCommand cmd;
      
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            con.Open(); // open the connection with database
            cmd = new OleDbCommand(); // initialize an instance for command excution
            cmd.CommandText = "insert into vocabtable(word) values('"+wordtxt.Text +" "+ meantxt.Text +"')"; // Sql query to be excuted
            cmd.Connection = con; // initialize the command with the connection
            cmd.ExecuteNonQuery();//excecute the query
            MessageBox.Show("Inserted","Infromation",MessageBoxButtons.OK,MessageBoxIcon.Information); // Successfully inserted message
            con.Close();//close the connection
            this.Dispose(); // dispose the form
        }
    }
}
