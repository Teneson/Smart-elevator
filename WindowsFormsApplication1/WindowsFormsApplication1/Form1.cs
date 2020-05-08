using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This is the first method for the first floor call buton that makes the shaft go up and open the doors

        private void Floor1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("First floor") + Environment.NewLine;
            textBox1.Text += DateTime.Now.ToString() + Environment.NewLine;

            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = lift.accdb";
            string dbcommand = "insert into [lift]([Status],[Date]) values (@stat,@dat)";//insert data into database.
            string time = DateTime.Now.ToString();//set and convert attribute to string.
            string Status = "First floor";// declare string attribute
            OleDbConnection conn = new OleDbConnection(dbconnection);
            OleDbCommand comm = new OleDbCommand(dbcommand, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

            comm.Parameters.AddWithValue("@dat", time);
            comm.Parameters.AddWithValue("@stat", Status);


            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();


            Parallel.Invoke(
                () => btnlftdrclose(),
                () => btnrytdrclose());

            for (Lift.Top = 318; Lift.Top > 11; Lift.Top--)
            {
                richTextBox1.Clear();
                richTextBox1.Text = richTextBox1.Text + "1";
                Thread.Sleep(20);
            }
            System.Threading.Thread.Sleep(3000);
            Parallel.Invoke(
                () => toplftdropen(),
                () => toprytopen());

        }
        //This is the second method for the ground floor call buton that makes the shaft go up and open the doors

        private void FloorG_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("Ground floor") + Environment.NewLine;
            textBox1.Text += DateTime.Now.ToString() + Environment.NewLine;

            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = lift.accdb";
            string dbcommand = "insert into [lift]([status],[date]) values (@stat,@dat)";//insert data into database.
            string time = DateTime.Now.ToString();//set and convert attribute to string.
            string status = "Ground floor";// declare string attribute
            OleDbConnection conn = new OleDbConnection(dbconnection);
            OleDbCommand comm = new OleDbCommand(dbcommand, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

            comm.Parameters.AddWithValue("@dat", time);
            comm.Parameters.AddWithValue("@stat", status);


            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            Parallel.Invoke(
                () => toplftdrclose(),
                () => toprytdrclose());

            for (Lift.Top = 11; Lift.Top < 318; Lift.Top++)
            {
                richTextBox1.Clear();
                richTextBox1.Text = richTextBox1.Text + "0";
                Thread.Sleep(20);
            }
            System.Threading.Thread.Sleep(3000);
            Parallel.Invoke(
                () => btnlftdropen(),
                () => btnrytdropen());
        }

        //this method makes the top left door of the lift open
        private void toplftdropen()
        {
            for (toplftdr.Left = 253; toplftdr.Left > 217; toplftdr.Left--)
            {
                Thread.Sleep(10);
            }
        }
        //this method makes the top right door of the lift open
        private void toprytopen()
        {
            for (toprytdr.Left = 332; toprytdr.Left < 360; toprytdr.Left++)
            {
                Thread.Sleep(10);
            }
        }
        //this method the top left door close
        private void toplftdrclose()
        {
            for (toplftdr.Left = 217; toplftdr.Left < 253; toplftdr.Left++)
            {
                Thread.Sleep(10);
            }
        }
        //this method makes the top right door close
        private void toprytdrclose()
        {
            for (toprytdr.Left = 360; toprytdr.Left > 332; toprytdr.Left--)
            {
                Thread.Sleep(10);
            }
        }
        //this method makes the buttom right door open
        private void btnrytdropen()
        {
            for (btnrytdr.Left = 328; btnrytdr.Left < 362; btnrytdr.Left++)
            {
                Thread.Sleep(10);
            }
        }
        //this method makes the buttom left door close
        private void btnlftdrclose()
        {
            for (btnlftdr.Left = 217; btnlftdr.Left < 253; btnlftdr.Left++)
            {
                Thread.Sleep(10);

            }
        }
        //this method makes the buttom left door open
        private void btnlftdropen()
        {
            for (btnlftdr.Left = 253; btnlftdr.Left > 217; btnlftdr.Left--)
            {
                Thread.Sleep(10);

            }
        }
        //this method makes the buttom right door close
        private void btnrytdrclose()
        {
            for (btnrytdr.Left = 362; btnrytdr.Left > 328; btnrytdr.Left--)
            {
                Thread.Sleep(10);
            }
        }
        //this method makes the shaft go down
        private void CallDown_Click(object sender, EventArgs e)
        {
           

            if (Lift.Top == 318)
            {
                Parallel.Invoke(
                    () => btnlftdropen(),
                    () => btnrytdropen());
            }
        }
        //this method makes the shaft come down
        private void CallUp_Click(object sender, EventArgs e)
        {
 
            {
                Parallel.Invoke(
                    () => toplftdropen(),
                    () => toprytopen());

            }
        }
        //this method clears the records in the database text box
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}


