using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIndowsFormsClases2018B.Ejercicios.Validaciones
{
    class validacionesLogin
    {

        public bool validacionIsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool validacionIsLetras(String valor)
        {
            try
            {
                string x = Convert.ToString(valor);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}
