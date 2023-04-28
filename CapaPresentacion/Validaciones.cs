using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class Validaciones
    {
        //-----------------------------------------------------------------------------------------
        // LIMPIA LOS FORMULARIOS 
        #region Limpiar formularios
        /// <summary>
        /// Metodo para limpiar el formulario
        /// </summary>
        /// <param name="control">resibe el panel que contiene los controles a limpiar</param>
        public static void LimpiarFormulario(System.Windows.Forms.Panel control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is Guna2TextBox)
                {

                    ((Guna2TextBox)txt).Clear();
                }
                else if (txt is Guna2ComboBox)
                {
                    ((Guna2ComboBox)txt).StartIndex = 0;
                }
            }

        }
        #endregion
        //-----------------------------------------------------------------------------------------

    }
}
