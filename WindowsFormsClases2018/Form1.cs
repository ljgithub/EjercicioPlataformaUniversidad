using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClases2018
{
    public partial class Form1 : Form

    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["StringNortwind"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

    private void Aceptar_Click(object sender, EventArgs e)
    {
        // Abre la cadena de conexion

        cn.Open();
        // Realiza la consulta a la base de datos
        SqlCommand consulta = new SqlCommand("SELECT * FROM USUSARIO WHERE USRIDUSUARIO='" + txtUsuario.Text + "' AND USRCLAVE= '" + txtContraseña.Text +"'", cn);
        SqlDataReader ejecuta = consulta.ExecuteReader();
        if (ejecuta.Read() == true)
        {

                
            MessageBox.Show("Bienvenido");
            Menu menu = new Menu();
            this.Hide();
            menu.Show();

        }
        else
        {
            MessageBox.Show("Usuario no encontrado");
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
        // Cierro la cadena de conexion
        cn.Close();
        cn.Dispose();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult varresultado;
            try
            {
                varresultado = MessageBox.Show("¿Realmente desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (varresultado == DialogResult.Yes)
                {
                    Close();
                    Application.Exit();

                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}