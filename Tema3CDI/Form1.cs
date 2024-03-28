using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tema3CDI
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;
        public Form1()
        {
            InitializeComponent();
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universities", myCon);
            daUniv.Fill(dsUniv, "Universities");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Faculties", myCon);
            daFac.Fill(dsFac, "Faculties");
            foreach (DataRow dr in dsUniv.Tables["Universities"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);
            }
            myCon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Fac.Items.Clear();
            textBox_City.Clear();
            int code = 0;
            String UnivSelected = listBox_Univ.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universities"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox_CodeUniv.Text = code.ToString();
                }
            }
            foreach (DataRow dr in dsFac.Tables["Faculties"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox_Fac.Items.Add(nameFac);
                }
            }
        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
