using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoacbRemind
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
      

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = vocabdb.accdb;
                                                            Persist Security Info=False;"); //Ms accessDB connection instance
                DataTable table = new DataTable();
                con.Open(); // open the connection with database
                cmd = new OleDbCommand(); // initialize an instance for command excution
                cmd.CommandText = "SELECT * FROM vocabtable"; // Sql query to be excuted


                cmd.Connection = con; // initialize the command with the connection
                reader = cmd.ExecuteReader();
                table.Load(reader);
                metroGrid1.DataSource = table;
                con.Close();//close the connection
                con.Dispose();
            }
            catch (Exception ex)
            {


            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
           

            try
            {
                con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = vocabdb.accdb;
                                                            Persist Security Info=False;"); //Ms accessDB connection instance
                con.Open(); // open the connection with database
                cmd = new OleDbCommand(); // initialize an instance for command excution
                cmd.CommandText = "DELETE FROM vocabtable WHERE ID = ? "; // Sql query to be excuted
                cmd.Connection = con;
                cmd.Parameters.Add(new OleDbParameter("@ID", OleDbType.Integer)).Value = int.Parse(metroTextBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                con.Close();//close the connection
                metroTextBox1.Text = "";
                
            }
            catch (Exception ex)
            {


            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = vocabdb.accdb;
                                                            Persist Security Info=False;"); //Ms accessDB connection instance
            con.Open(); // open the connection with database
            cmd = new OleDbCommand(); // initialize an instance for command excution
            cmd.CommandText = "UPDATE vocabtable set word= ? WHERE ID= ? "; // Sql query to be excuted
            cmd.Connection = con; // initialize the command with the connection


            cmd.Parameters.Add(new OleDbParameter("@word", OleDbType.VarChar)).Value = edittxt.Text;
            cmd.Parameters.Add(new OleDbParameter("@ID", OleDbType.Integer)).Value = int.Parse(metroTextBox1.Text);



            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            con.Close();//close the connection
            edittxt.Text = "";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = vocabdb.accdb;
                                                            Persist Security Info=False;"); //Ms accessDB connection instance
                DataTable table = new DataTable();
                con.Open(); // open the connection with database
                cmd = new OleDbCommand(); // initialize an instance for command excution
                cmd.CommandText = "SELECT * FROM vocabtable"; // Sql query to be excuted


                cmd.Connection = con; // initialize the command with the connection
                reader = cmd.ExecuteReader();
                table.Load(reader);
                metroGrid1.DataSource = table;
                con.Close();//close the connection
                con.Dispose();
            }
            catch (Exception ex)
            {


            }
        }
    }
}
