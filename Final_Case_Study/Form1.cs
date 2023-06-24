using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace Final_Case_Study
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("tbl");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));

            table.Rows.Add(1, "First A", "Last A", 10);
            table.Rows.Add(2, "First B", "Last B", 20);
            table.Rows.Add(3, "First C", "Last C", 30);
            table.Rows.Add(4, "First D", "Last D", 40);
            table.Rows.Add(5, "First E", "Last E", 50);
            table.Rows.Add(6, "First F", "Last F", 60);
            table.Rows.Add(7, "First G", "Last G", 70);
            table.Rows.Add(8, "First H", "Last H", 80);
            table.Rows.Add(9, "First I", "Last I", 90);

            dataGridView1.DataSource = table;
        }

        private void BTN_EXPORT_Click(object sender, EventArgs e)
        {
            table.WriteXml(@"C:\Users\average_Programmer\Desktop\xml\XMLFile1.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Data Exported");
        }

        private void BTN_IMPORT_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.ReadXml(@"C:\Users\average_Programmer\Desktop\xml\XMLFile1.xml");
            dataGridView2.DataSource = dt;
            MessageBox.Show("Data Imported");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
