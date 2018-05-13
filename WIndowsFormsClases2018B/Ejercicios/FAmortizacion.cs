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
        

        public FAmortizacion()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float monto, interes, plazo, cuota_mensual, tasa_mensual, interesMensual, totalMes;
           
            monto = float.Parse(txt_modPrestamo.Text);
            interes = (float.Parse(txt_interes.Text))/100; //0.06f;
            plazo = float.Parse(txt_plazo.Text);

            tasa_mensual = interes / 12;
            
            
            //Interes mensual
            MessageBox.Show(tasa_mensual.ToString("0.0000"));



            for (int i = 1; i <= plazo; i++) {
                
                
                //cuota_mensual = (monto) / (1-(1/(1+tasa_mensual)));
                cuota_mensual = monto / plazo;
                interesMensual = cuota_mensual * interes;
                totalMes = cuota_mensual + interesMensual;
                String[] filaRegistra = { cuota_mensual.ToString() ,interesMensual.ToString() , totalMes.ToString() ,i.ToString()};
                grid_amortizacion.Rows.Add(filaRegistra);
            }

        }
    }
}
