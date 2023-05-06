using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using static CapaPresentacion.FrmListaUsuarios;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        CNColaborador CNColaborador = new CNColaborador();
        TbColaborador TbColabo = new TbColaborador();

        private void BtnGuardarColaborador_Click(object sender, EventArgs e)
        {
            if (TxtCedula.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCedula);

                if (TxtNombre.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombre);

                    if (TxtApe1.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtApe1);

                        if (TxtApe2.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtApe2);

                            //combo
                            if (CbTipo.SelectedIndex > -1)
                            {
                                Validaciones.LimpiarErrorCombo(CbTipo);

                                //Usuario
                                if (TxtUsuario.TextLength > 0)
                                {
                                    Validaciones.LimpiarError(TxtUsuario);

                                    //Contraseña
                                    if (TxtContraseña.TextLength > 0)
                                    {
                                        Validaciones.LimpiarError(TxtContraseña);

                                        TbColaborador colabo = new TbColaborador();

                                        //CODIGO PARA GUARDAR Y ENVIAR A DB*****************************
                                        colabo.NombreColaborador = TxtNombre.Text;
                                        colabo.PrimerApellidoColaborador = TxtApe1.Text;
                                        colabo.IdColaborador = TxtCedula.Text;
                                        colabo.SegundoApellidoColaborador = TxtApe2.Text;
                                        colabo.PasswordColaborador = TxtContraseña.Text;
                                        colabo.TipoColaborador = (int)CbTipo.SelectedValue;
                                        colabo.EstadoColaborador = true;
                                        colabo.UserNameColaborador = TxtUsuario.Text;

                                        if (CNColaborador.GuardarColaborador(colabo))
                                        {
                                            MessageBox.Show("Colaborador Guadar", "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Validaciones.LimpiarFormulario(flowLayoutPanel1);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al Guardar Colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        }

                                        //**************************************************************
                                        //LIMPIAR FORMULARIO
                                        Validaciones.LimpiarFormulario(flowLayoutPanel2);

                                    }
                                    else
                                    {
                                        Validaciones.MostarError(TxtContraseña, "Debes iingresar contraseña");
                                    }


                                }
                                else
                                {
                                    Validaciones.MostarError(TxtUsuario, "Debes ingresar usuario");
                                }


                            }
                            else
                            {
                                Validaciones.MostarErrorCombo(CbTipo, "Seleccionar tipo de usuario");
                            }

                        }
                        else
                        {
                            Validaciones.MostarError(TxtApe2, "Por favor ingresa segundo apellido");
                        }
                    }
                    else
                    {
                        Validaciones.MostarError(TxtApe1, "Por favor ingresa primer apellido");
                    }
                }
                else
                {
                    Validaciones.MostarError(TxtNombre, "Por favor ingresa nombre");
                }
            }
            else
            {
                Validaciones.MostarError(TxtCedula, "Debes ingresar una identificación valida");
            }
        }
        /// <summary>
        /// Ejecuatamos el pasar datos y llenamos los controles conrespondientes
        /// </summary>
        /// <param name="Colaborador"></param>
        private void pasarDatos(TbColaborador Colaborador)
        {
            TbColabo = Colaborador;
            cargarDatosForm(TbColabo);

        }
        /// <summary>
        /// Cargamos el formulario por medio de pasar datos 
        /// </summary>
        /// <param name="tbColaborador"></param>
        private void cargarDatosForm(TbColaborador tbColaborador)
        {
            TxtCedula.Text = tbColaborador.IdColaborador;
            TxtNombre.Text = tbColaborador.NombreColaborador;
            TxtApe2.Text = tbColaborador.SegundoApellidoColaborador;
            TxtApe1.Text = tbColaborador.PrimerApellidoColaborador;
            TxtUsuario.Text = tbColaborador.UserNameColaborador;
            CbTipo.SelectedIndex = (int)tbColaborador.TipoColaborador;
            TxtContraseña.Text = tbColaborador.PasswordColaborador;
        }
        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            FrmListaUsuarios frmListaColaboradores = new FrmListaUsuarios();
            frmListaColaboradores.pasarDatosEvent += pasarDatos;
            frmListaColaboradores.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtCedula.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCedula);

                if (TxtNombre.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombre);

                    if (TxtApe1.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtApe1);

                        if (TxtApe2.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtApe2);

                            //combo
                            if (CbTipo.SelectedIndex > -1)
                            {
                                Validaciones.LimpiarErrorCombo(CbTipo);

                                //Usuario
                                if (TxtUsuario.TextLength > 0)
                                {
                                    Validaciones.LimpiarError(TxtUsuario);

                                    //Contraseña
                                    if (TxtContraseña.TextLength > 0)
                                    {
                                        Validaciones.LimpiarError(TxtContraseña);

                                        //List<T> ListaColaborador;
                                        //foreach (var item in collection)
                                        //{

                                        //}
                                        TbColaborador colabo = new TbColaborador();

                                        List<TbColaborador> ListaColaborador = CNColaborador.listaColaboadores();
                                        foreach (TbColaborador colaborador in ListaColaborador)
                                        {
                                            if (TxtUsuario.Text.ToUpper() == colaborador.UserNameColaborador.ToUpper())
                                            {
                                                colabo.UserNameColaborador = TxtUsuario.Text;
                                                break;
                                            }

                                        }
                                        //CODIGO PARA GUARDAR Y MODIFICAR EN DB*****************************
                                        colabo.NombreColaborador = TxtNombre.Text;
                                        colabo.PrimerApellidoColaborador = TxtApe1.Text;
                                        colabo.SegundoApellidoColaborador = TxtApe2.Text;
                                        colabo.PasswordColaborador = TxtContraseña.Text;
                                        colabo.UserNameColaborador = TxtUsuario.Text;
                                        //colabo.TipoColaborador= CbTipo.Text;
                                        //colabo.EstadoColaborador = true;
                                        if (CNColaborador.ModificarColaborador(colabo))
                                        {
                                            MessageBox.Show("Colaborador Modificado", "Modificación correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                            //CODIGO PARA ACTUALIZAR AL FINAL OCULTAR LOS BOTONES DE NUEVO
                                            BtnModificar.Visible = false;
                                            BtnEliminar.Visible = false;
                                            BtnGuardarColaborador.Enabled = true;
                                            Validaciones.LimpiarFormulario(flowLayoutPanel1);

                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al Modificar Colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        }

                                        //CODIGO PARA MODIFICAR Y ENVIAR A DB*****************************


                                        //**************************************************************
                                        //LIMPIAR FORMULARIO
                                        Validaciones.LimpiarFormulario(flowLayoutPanel2);
                                    }
                                    else
                                    {
                                        Validaciones.MostarError(TxtContraseña, "Debes iingresar contraseña");
                                    }


                                }
                                else
                                {
                                    Validaciones.MostarError(TxtUsuario, "Debes ingresar usuario");
                                }


                            }
                            else
                            {
                                Validaciones.MostarErrorCombo(CbTipo, "Seleccionar tipo de usuario");
                            }

                        }
                        else
                        {
                            Validaciones.MostarError(TxtApe2, "Por favor ingresa segundo apellido");
                        }
                    }
                    else
                    {
                        Validaciones.MostarError(TxtApe1, "Por favor ingresa primer apellido");
                    }
                }
                else
                {
                    Validaciones.MostarError(TxtNombre, "Por favor ingresa nombre");
                }
            }
            else
            {
                Validaciones.MostarError(TxtCedula, "Debes ingresar una identificación valida");
            }


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //VALIDACION
            if (TxtCedula.TextLength > 0)
            {
                Validaciones.LimpiarError(TxtCedula);

                if (TxtNombre.TextLength > 0)
                {
                    Validaciones.LimpiarError(TxtNombre);

                    if (TxtApe1.TextLength > 0)
                    {
                        Validaciones.LimpiarError(TxtApe1);

                        if (TxtApe2.TextLength > 0)
                        {
                            Validaciones.LimpiarError(TxtApe2);

                            //combo
                            if (CbTipo.SelectedIndex > -1)
                            {
                                Validaciones.LimpiarErrorCombo(CbTipo);

                                //Usuario
                                if (TxtUsuario.TextLength > 0)
                                {
                                    Validaciones.LimpiarError(TxtUsuario);

                                    //Contraseña
                                    if (TxtContraseña.TextLength > 0)
                                    {
                                        Validaciones.LimpiarError(TxtContraseña);


                                        //CODIGO ELIMINAR Y ENVIAR A DB*****************************


                                        TbColaborador colabo = new TbColaborador();

                                        List<TbColaborador> ListaColaborador = CNColaborador.listaColaboadores();
                                        foreach (TbColaborador colaborador in ListaColaborador)
                                        {
                                            if (TxtCedula.Text == colaborador.IdColaborador)
                                            {
                                                //CODIGO PARA GUARDAR Y ENVIAR A DB*****************************
                                                colabo.IdColaborador = TxtCedula.Text;
                                                colabo.EstadoColaborador = false;
                                                if (CNColaborador.EliminarColaborador(colabo))
                                                {
                                                    MessageBox.Show("Colaborador Eliminado", "Eliminación correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    //ENABLE DE BOTONES

                                                    BtnModificar.Visible = false;
                                                    BtnEliminar.Visible = false;
                                                    BtnGuardarColaborador.Enabled = true;
                                                    Validaciones.LimpiarFormulario(flowLayoutPanel1);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error al Eliminar Colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                                }
                                                break;
                                            }

                                        }



                                        //**************************************************************
                                        //LIMPIAR FORMULARIO
                                        Validaciones.LimpiarFormulario(flowLayoutPanel2);

                                    }
                                    else
                                    {
                                        Validaciones.MostarError(TxtContraseña, "Debes iingresar contraseña");
                                    }


                                }
                                else
                                {
                                    Validaciones.MostarError(TxtUsuario, "Debes ingresar usuario");
                                }


                            }
                            else
                            {
                                Validaciones.MostarErrorCombo(CbTipo, "Seleccionar tipo de usuario");
                            }

                        }
                        else
                        {
                            Validaciones.MostarError(TxtApe2, "Por favor ingresa segundo apellido");
                        }
                    }
                    else
                    {
                        Validaciones.MostarError(TxtApe1, "Por favor ingresa primer apellido");
                    }
                }
                else
                {
                    Validaciones.MostarError(TxtNombre, "Por favor ingresa nombre");
                }
            }
            else
            {
                Validaciones.MostarError(TxtCedula, "Debes ingresar una identificación valida");
            }


        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCedula);
        }

        private void TxtCedula_Leave(object sender, EventArgs e)
        {
            // Si la longitud de la cedula es igual a 9 o 12 digitos permite continuar
            if (Validaciones.CedulaValidaBuscar(TxtCedula))
            {
                Validaciones.LimpiarError(TxtCedula);

                //   ACA VA EL CODIGO PARA VALIDAR SI EXISTE YA EL USUARIO REGISTRADO
                TbColaborador colaborador = new TbColaborador();
                colaborador.IdColaborador = TxtCedula.Text;
                if (CNColaborador.ExisteColaborador(colaborador))
                {
                    MessageBox.Show("Este numero de cedula ya se encuentra registrado");
                    TxtCedula.ResetText();
                    TxtCedula.Focus();
                }

            }
            else
            {
                Validaciones.MostarError(TxtCedula, "Formato o longitud de cedula no es valido");
            }

        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.TextLength < 4)
            {
                Validaciones.MostarError(TxtUsuario, "Longitud de nombre de usuario muy corta");
                TxtContraseña.BorderColor = Color.Red;
            }
            else
            {
                Validaciones.LimpiarError(TxtUsuario);
                TxtContraseña.BorderColor = Color.White;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (Validaciones.ContraseñaSegura2(TxtContraseña.Text))
            {

                Validaciones.LimpiarError(TxtContraseña);
                TxtContraseña.BorderColor = Color.White;
            }
            else
            {
                Validaciones.MostarError(TxtContraseña, "Seguridad de contraseña vulnerable debe ser de minimo 6 digitos entre mayuculas, minusculas y numeros");
                TxtContraseña.BorderColor = Color.Red;
            }
        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            //if (TxtCedula.Text.Length == 9 || TxtCedula.Text.Length == 12)
            //{
            //    List<TbColaborador> ListaColabo = CNColaborador.listaColaboadores();
            //    foreach (TbColaborador colabo in ListaColabo)
            //    {
            //        if (colabo.IdColaborador == TxtCedula.Text)
            //        {
            //            TxtNombre.Text = colabo.NombreColaborador;
            //            TxtApe2.Text = colabo.SegundoApellidoColaborador;
            //            TxtApe1.Text = colabo.PrimerApellidoColaborador;
            //            TxtUsuario.Text = colabo.UserNameColaborador;
            //            CbTipo.SelectedIndex = (int)colabo.TipoColaborador;
            //            break;
            //        }
            //    }
            //}
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            //Agreagamos el tipo de colaborador por medioo de enumeradores
            CbTipo.DataSource = Enum.GetValues(typeof(Enums.Tipo_Colaborador));
        }
    }
}
