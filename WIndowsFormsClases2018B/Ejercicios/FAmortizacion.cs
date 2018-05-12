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
            float monto, interes, plazo, cuota_mensual, tasa_mensual;

            monto = 100000;
            interes = 0.06f;
            plazo = float.Parse(txt_plazo.Text);

            tasa_mensual = interes / 12;

            MessageBox.Show(tasa_mensual.ToString("0.0000"));
            for (int i=1; i<=plazo; i++) {
                grid_amortizacion.Rows.Add(plazo);
                grid_amortizacion.Rows[i].Cells["Nombre"].Value = i;
            }

        }
    }
}
