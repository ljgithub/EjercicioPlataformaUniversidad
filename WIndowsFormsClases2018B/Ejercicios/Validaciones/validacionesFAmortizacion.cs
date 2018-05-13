using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIndowsFormsClases2018B.Ejercicios.Validaciones
{
    class validacionesFAmortizacion
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

    }
}
