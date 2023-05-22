using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

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
        //globales
        public static string Idetificacion;
        public static string NombreCompleto;
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
        public String ObtenerConexionReporte()
        {
            String CadenaRetorno = "";
            try
            {

                String Ruta = "C:\\Instalador S.C.I\\configBD";


                XmlDocument dock = new XmlDocument();
                dock.Load(Ruta);

                foreach (XmlElement element in dock.DocumentElement)
                {
                    if (element.Name.Equals("connectionStrings"))
                    {
                        foreach (XmlNode Node in element.ChildNodes)
                        {
                            if (Node.Attributes[0].Value == "ReporteConexion")
                            {

                                CadenaRetorno = Node.Attributes[1].Value;
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lo sentimos el archivo de configuracion no existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return CadenaRetorno;

        }
        public String ObtenerConexion()
        {
            String CadenaRetorno = "";
            try
            {

                String Ruta = "C:\\Instalador S.C.I\\configBD";


                XmlDocument dock = new XmlDocument();
                dock.Load(Ruta);

                foreach (XmlElement element in dock.DocumentElement)
                {
                    if (element.Name.Equals("connectionStrings"))
                    {
                        foreach (XmlNode Node in element.ChildNodes)
                        {
                            if (Node.Attributes[0].Value == "inventarioEntities1")
                            {

                                CadenaRetorno = Node.Attributes[1].Value;
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Lo sentimos el archivo de configuracion no existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return CadenaRetorno;

        }
        public  void RefreshAppConfig()
        {
            try
            {
                string Cadena = ObtenerConexion();
                // Obtener la configuración actual
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Obtener la sección de conexión
                ConnectionStringsSection connectionStringsSection = config.ConnectionStrings;

                // Modificar la cadena de conexión
                connectionStringsSection.ConnectionStrings["inventarioEntities1"].ConnectionString = Cadena;

                // Guardar los cambios
                config.Save(ConfigurationSaveMode.Modified);

                // Actualizar la configuración en tiempo de ejecución
                ConfigurationManager.RefreshSection("connectionStrings");

                //Application.Restart();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al intentar conectarse", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    //le decimos a la variables globales que sea igual a los datos de usuario
                    Idetificacion = TBLusuario.IdColaborador;
                    NombreCompleto = TBLusuario.NombreColaborador;
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
                lblError.Text = "Contraseña Equivocada";
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
                lblError.Text = "Usuario no Existe";
            }
            //---------------------------------------------------------------------------------------------------------------------
            //pregunto si ambos son correctos
            if ((user == true) && (pass == true))
            {
                obtenerdatoscontraseña();
                lblError.Visible = false;
                this.Hide();
                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                frmMenu.ShowDialog();
            }
            else
            {
                lblError.Visible = true;
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            RefreshAppConfig();
        }
    }
}
