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
        private GraphCreator graphCreator;

        public Form2(string path)
        {
            InitializeComponent();
            graphCreator = new GraphCreator();
            graphCreator.GenerateGraphInfo(path);
            Form2_load();
        }

        public void Form2_load()
        {

            List<Department> infoList = graphCreator.GraphInfo;

            Municipios3.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < infoList.Count; i++)
            {
                Municipios3.Series["Cantidad de municipios"].Points.AddXY(infoList[i].Name, infoList[i].CountMun);
            }

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

        private void Municipios3_Click(object sender, EventArgs e)
        {

        }
    }
}
