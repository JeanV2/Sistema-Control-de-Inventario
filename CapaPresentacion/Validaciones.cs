using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    ((Guna2ComboBox)txt).StartIndex = -1;
                }
            }

        }

        /// <summary>
        /// Metodo para limpiar el formulario
        /// </summary>
        /// <param name="control">resibe el panel que contiene los controles a limpiar</param>
        public static void LimpiarFormularioSolicitudEntrega(System.Windows.Forms.Panel control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is Guna2TextBox && control.Name != "TxtCedula")
                {

                    ((Guna2TextBox)txt).Clear();
                }
                else if (txt is Guna2ComboBox)
                {
                    ((Guna2ComboBox)txt).StartIndex = -1;
                }
            }

        }
        #endregion
        //-----------------------------------------------------------------------------------------
        //dd
        //-----------------------------------------------------------------------------------------
        // VALIDA LA LONGITUD DE LAS CEDULAS DE IDENTIDAD 
        #region Validar Longitud de la cedulas

        /// <summary>
        ///  Función para validar  la longitud de la cedula ingresada y que sea igual a 9 o a 12
        /// </summary>
        /// <param name="cedula"> Resibe como parametro un txtbox</param>
        /// <returns> Retorna true si la longitud es = a 9  o = 10 o = 12 </returns>
        public static bool CedulaValidaBuscar(Guna2TextBox cedula)
        {

            if (cedula.TextLength == 9 || cedula.TextLength == 12)
            {
                return true;

            }
            return false;
        }

        #endregion
        //-----------------------------------------------------------------------------------------

        //-----------------------------------------------------------------------------------------
        // VALIDACIONES DE LOS EVENTOS KEY PRESS 
        #region Validaciones KeyPress


        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Metodo para impedir el ingreso de numeros  o caracteres especiales en los text box
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public static void LetrasEspacio_y_Borrar(KeyPressEventArgs e, Guna2TextBox txt)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '´' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Si la tecla presionada no es una letra ni un espacio, se ignora
                MostarError(txt, "No se admiten numeros o caracteres especiales");
            }
            else
            {
                LimpiarError(txt);

            }
        }
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Metodo para impedir el ingreso de numeros  o caracteres especiales en los text box
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public static void Letras_Coma_Espacio_Borrar(KeyPressEventArgs e, Guna2TextBox txt)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '´' && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Si la tecla presionada no es una letra ni un espacio, se ignora
                MostarError(txt, "No se admiten numeros o caracteres especiales");
            }
            else
            {
                LimpiarError(txt);

            }
        }
        //----------------------------------------------------------------------------------------------

        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Metodo para impedir el ingreso de letras, espacios o caracteres especiales en los txt cedula
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public static void Numeros_y_Borrar(KeyPressEventArgs e, Guna2TextBox txt)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Si la tecla presionada no es una letra ni un espacio, se ignora
                MostarError(txt, "No se admiten Letras o caracteres especiales");
            }
            else
            {
                LimpiarError(txt);

            }
        }
        //----------------------------------------------------------------------------------------------

        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Metodo para validar el ingreso de solo numeros, decimales solo un punto y borrar
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public static void Numeros_Decimales_y_Borrar(KeyPressEventArgs e, Guna2TextBox txt)
        {

            // Verificar si la tecla presionada es un número, un punto o una tecla de retroceso o suprimir
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MostarError(txt, "No se admiten Letras o caracteres especiales");
            }
            else
            {
                LimpiarError(txt);
            }

            // Verificar si hay más de un punto en el texto
            if (e.KeyChar == '.' && txt.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MostarError(txt, "No se admite  mas de un '.' decimal");
            }
            else
            {
                LimpiarError(txt);
            }
        }
        //----------------------------------------------------------------------------------------------

        //----------------------------------------------------------------------------------------------
        /// <summary>
        /// Metodo para validar el ingreso de solo numeros, decimales solo un punto y borrar
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public static void Numeros_Decimales_Coma_y_Borrar(KeyPressEventArgs e, Guna2TextBox txt)
        {

            // Verificar si la tecla presionada es un número, un punto o una tecla de retroceso o suprimir
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                MostarError(txt, "No se admiten Letras o caracteres especiales");
            }
            else
            {
                LimpiarError(txt);
            }

            // Verificar si hay más de un punto en el texto
            if (e.KeyChar == ',' && txt.Text.IndexOf(',') > -1)
            {
                e.Handled = true;
                MostarError(txt, "No se admite  mas de un ',' decimal");
            }
            else
            {
                LimpiarError(txt);
            }
        }

        /// <summary>
        /// Metodo para permitir el ingreso de letras y numeros
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public static void Letras_y_Numeros(KeyPressEventArgs e, Guna2TextBox txt)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MostarError(txt, "No se admiten caracteres especiales");
            }
            else
            {
                LimpiarError(txt);
            }
        }
        //----------------------------------------------------------------------------------------------
        #endregion
        //-----------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------
        // ERROR PROVIDER
        #region Creacion de los Metodos ErrorProvider
        public static ErrorProvider Error = new ErrorProvider();



        public static void MsgError(string msg, Label LblError)
        {
            LblError.Text = "     " + msg;
            LblError.Visible = true;
        }

        public static void OcultarMsgError(Label LblError)
        {
            LblError.Text = "";
            LblError.Visible = false;
        }
        public static void LimpiarError(Guna2TextBox txt)
        {

            Error.Clear();
            txt.BorderColor = Color.FromArgb(213, 218, 223);
        }
        public static void MostarError(Guna2TextBox Txt, string mensaje)
        {
            Error.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            Error.SetError(Txt, mensaje);
            Txt.BorderColor = Color.Red;
            //Txt.Focus();
        }
        public static void LimpiarErrorLabel(Label txt)
        {
            Error.Clear();

        }
        public static void MostarErrorLabel(Label Txt, string mensaje)
        {
            Error.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            Error.SetError(Txt, mensaje);

            Txt.Focus();
        }
        public static void MostarErrorDtp(DateTimePicker Dtp, string mensaje)
        {
            Error.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            Error.SetError(Dtp, mensaje);
            //Dtp.Focus();
        }
        public static void LimpiarErrorDtp(DateTimePicker Dtp)
        {
            Error.Clear();
        }
        public static void LimpiarErrorDtp2(Guna2DateTimePicker Dtp)
        {
            Error.Clear();
        }
        public static void MostarErrorDtp2(Guna2DateTimePicker Dtp, string mensaje)
        {
            Error.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            Error.SetError(Dtp, mensaje);
            Dtp.BorderColor = Color.Red;
            //Dtp.Focus();
        }
        public static void LimpiarErrorCombo(Guna2ComboBox CB)
        {
            Error.Clear();
            CB.BorderColor = Color.FromArgb(213, 218, 223);
        }
        public static void MostarErrorCombo(Guna2ComboBox CB, string mensaje)
        {
            Error.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            Error.SetError(CB, mensaje);
            CB.BorderColor = Color.Red;
            //CB.Focus();
        }
        #endregion
        //-----------------------------------------------------------------------------------------

        /// <summary>
        /// Metodo para ingresar el simbolo de colones a los txt de tipo divisa
        /// </summary>
        /// <param name="Txt">Resibe el control al que se desea mostrar el simbolo de colones</param>
        public static void AgregarSimboloColones(Guna2TextBox Txt)
        {
            if (!string.IsNullOrEmpty(Txt.Text))
            {
                if (!Txt.Text.StartsWith("₡"))
                {
                    Txt.Text = "₡" + Txt.Text;
                    Txt.SelectionStart = Txt.Text.Length;

                }
            }
        }

        public static bool ContraseñaSegura2(string password)
        {
            bool Mayuscula = false, Miniscula = false, Numeros = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password, i))
                {
                    Mayuscula = true;
                }
                else if (char.IsLower(password, i))
                {
                    Miniscula = true;
                }
                else if (char.IsDigit(password, i))
                {
                    Numeros = true;
                }
            }
            if (Mayuscula && Miniscula && Numeros && password.Length >= 6)
            {

                return true;
            }

            return false;
        }
    }
}
