using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReport.Model
{
    class Departamentos
    {

        private string nombre;
        private int numeroDeMunicipios;

        public Departamentos(string Nombre,int NumeroDeMunicipios)
        {
            this.nombre = Nombre;
            this.numeroDeMunicipios = NumeroDeMunicipios;
        }


        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNumeroDeMunicipios(int NumeroDeMunicipios)
        {
            this.numeroDeMunicipios = NumeroDeMunicipios;
        }

        public int getNumeroDeMunicipios()
        {
            return numeroDeMunicipios;
        }

    }
}
