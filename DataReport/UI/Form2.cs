using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReport.UI
{
    public partial class Form2 : Form
    {
        private int[] departamentos;

        public Form2()
        {
            InitializeComponent();
            Form2_load();
        }

        public void Form2_load()
        {

            Municipios.Series["Municipio seleccionado"].Points.AddXY("Peter", 1000);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
