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
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
        }

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


                                        //CODIGO PARA GUARDAR Y ENVIAR A DB*****************************


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
