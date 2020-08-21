using DataReport.Model;
using System;
using System.Collections;
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
        private ArrayList departamentos;

        public Form2(string path)
        {
            InitializeComponent();
            departamentos = new ArrayList();
            Form2_load();
        }

        public void Form2_load()
        {


            Municipios3.Series["Municipio seleccionado 3"].Points.AddXY("Guaviare",1000);
            Municipios3.Series["Municipio seleccionado 3"].Points.AddXY("Huila", 1000);
            Municipios3.Series["Municipio seleccionado 3"].Points.AddXY("La Guajira", 1000);
            Municipios3.Series["Municipio seleccionado 3"].Points.AddXY("Magdalena", 1000);
            Municipios3.Series["Municipio seleccionado 3"].Points.AddXY("Meta", 1000);
            Municipios3.Series["Municipio seleccionado 3"].Points.AddXY("Nariño", 1000);
            Municipios3.Series["Municipio seleccionado 3"].Points.AddXY("Norte de Santander", 1000);
            Municipios3.Series["Municipio seleccionado 3"].Points.AddXY("Putumayo", 1000);


        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
