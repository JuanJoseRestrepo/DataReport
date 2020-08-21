
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
            Console.WriteLine(regionComboBox.SelectedItem.ToString());
            dataHelper.refresh();
            if (regionComboBox.SelectedItem.ToString().Equals("Región Centro Oriente")) {
                Console.WriteLine(txtBoxPath.Text.ToString());
                string region = "Región Centro Oriente";
                string path = regionComboBox.SelectedItem.ToString();
                dataHelper.organizateInformation(txtBoxPath.Text.ToString(), region);
            }
            else if (regionComboBox.SelectedItem.ToString().Equals("Región Eje Cafetero - Antioquia"))
            {
                string region = "Región Eje Cafetero - Antioquia";
                string path = regionComboBox.SelectedItem.ToString();
                dataHelper.organizateInformation(txtBoxPath.Text.ToString(), region);

            }
            else if (regionComboBox.SelectedItem.ToString().Equals("Región Caribe"))
            {
                string region = "Región Caribe";
                string path = regionComboBox.SelectedItem.ToString();
                dataHelper.organizateInformation(txtBoxPath.Text.ToString(), region);


            }
            else if (regionComboBox.SelectedItem.ToString().Equals("Región Llano"))
            {
                string region = "Región Llano";
                string path = regionComboBox.SelectedItem.ToString();
                dataHelper.organizateInformation(txtBoxPath.Text.ToString(), region);

            }
            else if (regionComboBox.SelectedItem.ToString().Equals("Región Centro Sur"))
            {
                string region = "Región Centro Sur";
                string path = regionComboBox.SelectedItem.ToString();
                dataHelper.organizateInformation(txtBoxPath.Text.ToString(), region);
            }
            else if (regionComboBox.SelectedItem.ToString().Equals("Región Pacífico"))
            {
                string region = "Región Pacífico";
                string path = regionComboBox.SelectedItem.ToString();
                dataHelper.organizateInformation(txtBoxPath.Text.ToString(), region);
            }

        }

        private void Municipios_Click(object sender, EventArgs e)
        {
            txtBoxPath.Text = openFileDialog1.FileName;
            Form2 form1 = new Form2(txtBoxPath.Text.ToString());
            form1.ShowDialog();
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
