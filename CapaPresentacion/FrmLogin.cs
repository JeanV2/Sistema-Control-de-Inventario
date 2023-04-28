using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // validar inicio de seccion
            if(TxtUsuario.TextLength > 0 )
            {
                Validaciones.LimpiarError(TxtUsuario);

                if (TxtContraseña.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtContraseña);

                    //CODIGO PARA VERIFICAR USUARIO IN DB****************************+

                    if (true)
                    {
                        this.Hide();
                        FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                        frmMenu.ShowDialog();
                    }



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
