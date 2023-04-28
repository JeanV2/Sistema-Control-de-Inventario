using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //validaciones de usuario

        //-------------------------------------------------------------------------------------------------------------
        NegocioUsuario usuarioins = new NegocioUsuario();
        List<TbColaborador> Listausuarios;
        bool pass;
        bool user;
        //hola
        //-------------------------------------------------------------------------------------------------------------
        private void obtenerdatosusuario()
        {
            Listausuarios = usuarioins.obtenerusuario();
            //consultamos si el usuario existe


            foreach (TbColaborador TBLusuario in Listausuarios)
            {

                if (TxtUsuario.Text == TBLusuario.UserNameColaborador.Trim())
                {

                    user = true;
                    break;


                }
                else
                {
                    user = false;

                }
            }
        }
        private void obtenerdatoscontraseña()
        {
            Listausuarios = usuarioins.obtenerusuario();
            //consultamos si el usuario existe


            foreach (TbColaborador TBLusuario in Listausuarios)
            {

                if (TxtContraseña.Text == TBLusuario.PasswordColaborador.Trim() && (TxtUsuario.Text == TBLusuario.UserNameColaborador.Trim()))
                {

                    pass = true;
                    break;


                }
                else
                {
                    pass = false;

                }
            }
        }

        private void validacion_datos()
        {
            //valido si la contraseña es correcta
            //---------------------------------------------------------------------------------------------------------------------
            if ((pass == true))
            {
                TxtContraseña.BorderColor = Color.Green;
                
            }
            //---------------------------------------------------------------------------------------------------------------------
            else
            {
                TxtContraseña.BorderColor = Color.Red;
            }
            //---------------------------------------------------------------------------------------------------------------------
            //valido si el usuario es correcto
            if ((user == true))
            {
                TxtUsuario.BorderColor = Color.Green;
            }
            else
            {
                TxtUsuario.BorderColor = Color.Red;
            }
            //---------------------------------------------------------------------------------------------------------------------
            //pregunto si ambos son correctos
            if ((user == true) && (pass == true))
            {
                MessageBox.Show("Has ingresado con exito " , " correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                frmMenu.ShowDialog();







            }
            else
            {
                MessageBox.Show("Por favor verifica que los datos esten correctos", "correcto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //---------------------------------------

        }

        //fin validacion de usuarios

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // validar inicio de seccion
            if (TxtUsuario.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtUsuario);

                if (TxtContraseña.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtContraseña);

                    //CODIGO PARA VERIFICAR USUARIO IN DB****************************+
                    obtenerdatosusuario();
                    //la contraseña es correcta
                    obtenerdatoscontraseña();
                    //valiadacion de datos
                    validacion_datos();
                   



                }
                else
                {
                    Validaciones.MostarError(TxtContraseña, "Contraseña de usuario es obligatoria");
                }


            }
            else
            {
                Validaciones.MostarError(TxtUsuario, "Nombre de usuario es obligatorio");
            }


        }
    }
}
