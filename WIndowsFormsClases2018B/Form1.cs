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

namespace WIndowsFormsClases2018B
{
    public partial class frm_login : Form
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindString"].ConnectionString);

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //string varusuario = "JAVIER";
            //string varpass = "1234";

            //ErrorProvider err = new ErrorProvider();

            ////if (!val.validacionIsLetras(Convert.ToInt32(txt_usuario.Text)))
            ///*if (!val.validacionIsNumeric(txt_password.Text))
            //{
            //    err.SetError(txt_password, "No se admiten letras");
            //}*/
            //if (txt_usuario.Text =="" || txt_password.Text=="")
            //{
            //    err.SetError(txt_usuario, "No se admite user vacío");
            //    err.SetError(txt_password, "No se admite pass vacío");
            //}
            //else
            //{
            //    if ((txt_usuario.Text == varusuario) & (txt_password.Text == varpass))
            //    {
            //        MessageBox.Show("Bienvenido Usuario: " + varusuario);
            //        MenuPrincipal menu = new MenuPrincipal();
            //        this.Hide();
            //        menu.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario Incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}




        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult varResultado;

            try
            {
                varResultado = MessageBox.Show("¿Realmente desea Salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (varResultado == DialogResult.Yes)
                {
                    Close();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_usuario.CharacterCasing = CharacterCasing.Upper;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
