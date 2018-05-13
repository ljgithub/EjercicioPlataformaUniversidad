using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIndowsFormsClases2018B.Ejercicios
{
    public partial class FAmortizacion : Form
    {

        private float monto, interes, plazo, cuota_mensual, tasa_mensual, interesMensual, totalMes;

        public FAmortizacion()
        {
            InitializeComponent();
        }
        private void btn_calcular_Click(object sender, EventArgs e)
        {
          
            Validaciones.validacionesFAmortizacion val = new Validaciones.validacionesFAmortizacion();
            ErrorProvider err = new ErrorProvider();

            if (!val.validacionIsNumeric(txt_modPrestamo.Text) && !val.validacionIsNumeric(txt_interes.Text) && !val.validacionIsNumeric(txt_plazo.Text))
            {
                err.SetError(txt_modPrestamo, "El valor ingresado no es un número");
                err.SetError(txt_interes, "El valor ingresado no es un número");
                err.SetError(txt_plazo, "El valor ingresado no es un número");                
            }
            else{
                monto = float.Parse(txt_modPrestamo.Text);
                interes = (float.Parse(txt_interes.Text)) / 100; //0.06f;
                plazo = float.Parse(txt_plazo.Text);
                tasa_mensual = interes / 12;
                calcularAmortizacion(monto, plazo, interes);
            }

            //Interes mensual
            //MessageBox.Show(tasa_mensual.ToString("0.0000"));

            void calcularAmortizacion(float m, float p, float inter)
            {
                for (int i = 1; i <= plazo; i++)
                {
                    //cuota_mensual = (monto) / (1-(1/(1+tasa_mensual)));
                    cuota_mensual = m / p;
                    interesMensual = cuota_mensual * inter;
                    totalMes = cuota_mensual + interesMensual;
                    String[] filaRegistra = { cuota_mensual.ToString(), interesMensual.ToString(), totalMes.ToString(), i.ToString() };
                    grid_amortizacion.Rows.Add(filaRegistra);
                    
                }
            }

        }
    }
}
