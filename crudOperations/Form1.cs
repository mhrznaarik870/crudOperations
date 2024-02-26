using MySqlConnector;
using System.Data.Common;
namespace crudOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelSuccess.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string conString = "server=127.0.0.1; uid=root; pwd=''; database=studentinfo";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "select * from studentinfo where sid='" + int.Parse(labelSid.Text) + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, con);
            MySqlDataReader mydr = mycmd.ExecuteReader();
            mydr.Read();
            labelFname.Text = mydr.GetString(1);
            labelLname.Text = mydr.GetString(2);
            con.Close();

                labelSuccess.Visible = true;
                labelSuccess.ForeColor = Color.Blue;
                labelSuccess.Text = "Record found!";

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string conString = "server=127.0.0.1; uid=root; pwd=''; database = studentinfo";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "INSERT INTO `studentinfo` ( `firstname`, `lastname`) VALUES ('" + labelFname.Text + "','" + labelLname.Text + "')";
            MySqlCommand mycmd = new MySqlCommand(sql, con);
            if (mycmd.ExecuteNonQuery() != 0)
            {
                labelSuccess.Visible = true;
                labelSuccess.ForeColor = Color.Green;
                labelSuccess.Text = "Data inserted Successfully!";
            }
            else
            {
                labelSuccess.Visible = true;
                labelSuccess.ForeColor = Color.Red;
                labelSuccess.Text = "Unable to insert the data!";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string conString = "server=127.0.0.1; uid=root; pwd=''; database=studentinfo";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql= "DELETE FROM `studentinfo` WHERE sid='"+labelSid.Text+"'";
            MySqlCommand mycmd = new MySqlCommand(sql, con);
            if (mycmd.ExecuteNonQuery()!= 0)
            {
                labelSuccess.Visible=true;
                labelSuccess.ForeColor = Color.Red;
                labelSuccess.Text = "Data deleted Successfully";
            }
            else
            {
                labelSuccess.Visible = true;
                labelSuccess.ForeColor = Color.Red;
                labelSuccess.BackColor = Color.Yellow;
                labelSuccess.Text = "Unable to delete data!!";
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string conString = "server=127.0.0.1; uid=root; pwd=''; database=studentinfo";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string sql = "update studentinfo set firstname='" + labelFname.Text + "', lastname='" + labelLname.Text + "' where sid='" + labelSid.Text + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, con);
            if (mycmd.ExecuteNonQuery() != 0)
            {
                labelSuccess.Visible = true;
                labelSuccess.ForeColor = Color.Green;
                labelSuccess.Text="Updated the record!" ;   
            }
            else
            {
                labelSuccess.Visible = true;
                labelSuccess.ForeColor= Color.Red;
                labelSuccess.Text = "Unable to update the current data on the database";
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void labelSid_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
