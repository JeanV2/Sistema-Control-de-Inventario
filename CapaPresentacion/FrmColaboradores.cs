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

namespace CapaPresentacion
{
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
        }
        CNColaborador CNColaborador = new CNColaborador();

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
                                        colabo.PrimerApellidoColaborador= TxtApe1.Text;
                                        colabo.IdColaborador = TxtCedula.Text;
                                        colabo.SegundoApellidoColaborador = TxtApe2.Text;
                                        colabo.PasswordColaborador = TxtContraseña.Text;
                                        //colabo.TipoColaborador= CbTipo.Text;
                                        colabo.EstadoColaborador = true;
                                        colabo.UserNameColaborador = TxtUsuario.Text;

                                        if (CNColaborador.GuardarColaborador(colabo))
                                        {
                                            MessageBox.Show("Colaborador Guadar","Guardado correctamente",MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            FrmListaColaboradores frmListaColaboradores = new FrmListaColaboradores();
            frmListaColaboradores.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(TxtCedula.TextLength > 0)
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
                                        //CODIGO PARA GUARDAR Y ENVIAR A DB*****************************
                                        colabo.NombreColaborador = TxtNombre.Text;
                                        colabo.PrimerApellidoColaborador = TxtApe1.Text;
                                        colabo.SegundoApellidoColaborador = TxtApe2.Text;
                                        colabo.PasswordColaborador = TxtContraseña.Text;
                                        //colabo.TipoColaborador= CbTipo.Text;
                                        //colabo.EstadoColaborador = true;
                                        if (CNColaborador.ModificarColaborador(colabo))
                                        {
                                            MessageBox.Show("Colaborador Modificado", "Modificación correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al Modificar Colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        }

                                        //CODIGO PARA MODIFICAR Y ENVIAR A DB*****************************


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

            //CODIGO PARA ACTUALIZAR AL FINAL OCULTAR LOS BOTONES DE NUEVO
            BtnModificar.Visible = false;
            BtnEliminar.Visible = false;
            BtnGuardarColaborador.Enabled = true;
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
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error al Eliminar Colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                                }
                                                break;
                                            }

                                        }
                                        



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

            //ENABLE DE BOTONES

            BtnModificar.Visible = false;
            BtnEliminar.Visible = false;
            BtnGuardarColaborador.Enabled = true;
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros_y_Borrar(e, TxtCedula);
        }
    }
}
