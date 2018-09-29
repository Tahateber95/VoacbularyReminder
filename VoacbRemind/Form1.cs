using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.Data.OleDb;

namespace VoacbRemind
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = vocabdb.accdb;
                                                            Persist Security Info=False;");
                DataTable table = new DataTable();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT * from vocabtable";
                cmd.Connection = con;
                con.Open();
                table.Load(cmd.ExecuteReader());
                metroGrid1.DataSource = table;
                con.Close();
            }
            catch (Exception ex)
            {

                
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newVocabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void redefinePeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void refreshtable(){
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = vocabdb.accdb;
                                                            Persist Security Info=False;");
                DataTable table = new DataTable();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT * from vocabtable";
                cmd.Connection = con;
                con.Open();
                table.Load(cmd.ExecuteReader());
                metroGrid1.DataSource = table;
                con.Close();
                
            }
            catch (Exception ex)
            {


            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            PopupNotifier pop = new PopupNotifier();
            pop.Size= new Size(400,150);
            pop.Delay = 4000;
            pop.ContentPadding = new Padding(15);
            pop.BodyColor = Color.LightSkyBlue;
            pop.ContentColor = Color.Black;
            pop.ContentFont = new Font("Arabic Typesetting", 32);
            pop.ContentText = metroGrid1.Rows[rand.Next(0,metroGrid1.RowCount - 1)].Cells[1].Value.ToString();
            pop.Popup();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            refreshtable();
            timer1.Interval = Convert.ToInt16(metroComboBox1.Text) * 60000;
            if(metroTile1.Text == "تشغيل")
            {
                timer1.Enabled = true;
                metroTile1.Text = "إيقاف";
                metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            }else if (metroTile1.Text == "إيقاف")
            {
                timer1.Enabled = false;
                metroTile1.Text = "تشغيل";
                metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            }
            
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTile1.Enabled = true;
        }

        private void editDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void aboutحولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Taha Teber","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if(this.WindowState== FormWindowState.Minimized){
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000,"Important","Vobabreminder Minimized",ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
