
using NPoco.Expressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReport.UI
{
    public partial class Form1 : Form
    {

        private Model.DataHelper dataHelper;

        public Form1()
        {
            InitializeComponent();
            dataHelper = new Model.DataHelper();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            txtBoxPath.Text = openFileDialog1.FileName;

            dataHelper.CreateTable(txtBoxPath.Text);

            if (dataHelper.Table != null)
                dataTable.DataSource = dataHelper.Table;
        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Municipios_Click(object sender, EventArgs e)
        {
            txtBoxPath.Text = openFileDialog1.FileName;
            Form2 form1 = new Form2(txtBoxPath.Text);
            form1.ShowDialog();
        }
    }
}
