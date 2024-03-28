using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3CDI
{
    public partial class Form2 : Form
    {
        bool UniSelected = true;

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Faculties' table. You can move, or remove it, as needed.
            this.facultiesTableAdapter.Fill(this.database1DataSet.Faculties);
            // TODO: This line of code loads data into the 'database1DataSet.Universities' table. You can move, or remove it, as needed.
            this.universitiesTableAdapter.Fill(this.database1DataSet.Universities);

        }
        private bool ColumnContainsValue(DataTable dataTable, string columnName, string valueToCheck)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row[columnName].ToString() == valueToCheck)
                {
                    return true;
                }
                // here throws an error if you delete the row adn then try to re-delete the row
            }
            return false;
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            if (UniSelected)
            {
                if (ColumnContainsValue(this.database1DataSet.Universities, "Id", textBox_Id.Text) ||
                   ColumnContainsValue(this.database1DataSet.Universities, "Code", textBox_Code.Text))
                {
                    MessageBox.Show("Invalid entry! \n Id or Code already exists!");
                }
                else
                {
                    this.database1DataSet.Universities.Rows.Add(textBox_Id.Text, textBox_NameUniv.Text, textBox_City.Text, textBox_Code.Text);
                }
            }
            else
            {
                if (ColumnContainsValue(this.database1DataSet.Faculties, "Id", textBox_Id.Text) ||
                    textBox_City.Text != "")
                {
                    MessageBox.Show("Invalid entry! \n Id or Code already exists! \n City is not null");
                }
                else
                {
                    this.database1DataSet.Faculties.Rows.Add(textBox_Id.Text, textBox_Code.Text, textBox_NameUniv.Text);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (UniSelected)
            {
                if (!ColumnContainsValue(this.database1DataSet.Universities, "Code", textBox_Code.Text))
                {
                    MessageBox.Show("Invalid entry!");
                }
                else
                { 
                    DataRow[] row = database1DataSet.Universities.Select("code = '" + textBox_Code.Text + "'");
                    row[0].Delete();
                }
            }
            else
            {
                if (!ColumnContainsValue(this.database1DataSet.Faculties, "Id", textBox_Id.Text))
                {
                    MessageBox.Show("Invalid entry!");
                }
                else
                {
                    DataRow[] row = database1DataSet.Faculties.Select("id = '" + textBox_Id.Text + "'");
                    row[0].Delete();
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (UniSelected)
            {
                if (!ColumnContainsValue(this.database1DataSet.Universities, "Code", textBox_Code.Text))
                {
                    MessageBox.Show("Invalid entry!");
                }
                else
                {
                    DataRow[] row = database1DataSet.Universities.Select("id = '" + textBox_Id.Text + "'");
                    row[0].Delete();
                    this.database1DataSet.Universities.Rows.Add(textBox_Id.Text, textBox_NameUniv.Text, textBox_City.Text, textBox_Code.Text);
                }
            }
            else
            {
                if (!ColumnContainsValue(this.database1DataSet.Faculties, "Id", textBox_Id.Text))
                {
                    MessageBox.Show("Invalid entry!");
                }
                else
                {
                    DataRow[] row = database1DataSet.Faculties.Select("id = '" + textBox_Id.Text + "'");
                    row[0].Delete();
                    this.database1DataSet.Faculties.Rows.Add(textBox_Id.Text, textBox_NameUniv.Text, textBox_City.Text, textBox_Code.Text);
                }
            }
        }


        private void MSI_Universities_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = database1DataSet.Universities;
            UniSelected = true;
        }


        private void MSI_Faculties_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = database1DataSet.Faculties;
            UniSelected = false;
        }

      
    }
}
