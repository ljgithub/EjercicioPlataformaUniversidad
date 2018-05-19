using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClases2018.Ejercicios
{
    public partial class Famortizacion : Form
    {
        public Famortizacion()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i;
            double monto, valorcuota, valorinteresAnual, valorInteresMensual, cuotaPago;
            int plazo;
            double interes;
            monto = Convert.ToDouble(txtmonto.Text);
            plazo = Convert.ToInt32(comboBox1.SelectedItem);
            interes = Convert.ToDouble(txtinteres.Text);
            valorinteresAnual = ((monto * interes) / 100);
            valorInteresMensual = (valorinteresAnual / plazo);
            valorcuota = (monto / plazo);

            for (i = 1; i <= plazo; i++)
            {

                cuotaPago = (valorcuota + valorInteresMensual);
                string[] row0 = { Convert.ToString(valorcuota), Convert.ToString(valorInteresMensual), Convert.ToString(cuotaPago), Convert.ToString(i) };
                dataGridView1.Rows.Add(row0);
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
