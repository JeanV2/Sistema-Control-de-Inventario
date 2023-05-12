﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;
using CapaDatos;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public  partial class FrmImportarArticulos : Form
    {
   
       
        public FrmImportarArticulos()
        {
            InitializeComponent();
        }
        NegociosProductos Prod = new NegociosProductos();

        public int Contador;
        public async void CargarExcel()
        {

        }
        private void BtnImportar_Click(object sender, EventArgs e)
        {
            dgvDatos.Visible = true;
            
            // Abre el cuadro de diálogo para seleccionar el archivo de Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crea una instancia de Excel y abre el archivo
                Application excel = new Application();
                Workbook workbook = excel.Workbooks.Open(openFileDialog.FileName);

                // Crea una instancia de Excel y abre el archivo
                Application Excel= new Application();
                Workbook Workbook = excel.Workbooks.Open(openFileDialog.FileName);


                // Obtiene la primera hoja de trabajo
                Worksheet worksheet = (Worksheet)workbook.Sheets[1];

                if (validarFormatoExcel(worksheet))
                {
                    //Obtiene los datos de la hoja de trabajo y los guarda en un DataTable
                    DataTable dt = new DataTable();
                    for (int i = 1; i <= worksheet.UsedRange.Columns.Count; i++)
                    {

                        dt.Columns.Add((string)(worksheet.Cells[1, i] as Range).Value); 

                    }
                    for (int i = 2; i <= worksheet.UsedRange.Columns.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int j = 1; j <= worksheet.UsedRange.Columns.Count; j++)
                        {
                            dr[j - 1] = (worksheet.Cells[i, j] as Range).Value;
                        }
                        dt.Rows.Add(dr);
                    }

                    // Cierra el archivo y la instancia de Excel
                    workbook.Close();
                    excel.Quit();

                    // Asigna los datos al DataGridView
                    dgvDatos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Formato incorrecto");
                }

            }
            else
            {
                MessageBox.Show("Formato incorrecto");
            }

        
        //else
        //{
        //    MessageBox.Show("lo Sentimos la importancion solo se puede realizar una vez, si deseas añadir un producto debes ir a modulo de ingreso de productos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    DialogResult result = MessageBox.Show("¿Deseas ir al Modulo de ingreso de Productos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //    if (result == DialogResult.Yes)
        //    {
        //        //FrmInicio.AbrirFormularioHijo(new FrmAñadirProductos());
        //    }

    
            
         
        }
        public bool validarFormatoExcel(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {

            if ((string)(worksheet.Cells[1, 1] as Range).Value != "C_FAMILIA")
            {
                return false;
            }
            else if (Convert.ToString((string)(worksheet.Cells[1, 2] as Range).Value) != "C_SUBFAM")
            {
                return false;
            }
            else if ((string)(worksheet.Cells[1, 3] as Range).Value != "NUM_PRODUCTO")
            {
                return false;

            }
            else if ((string)(worksheet.Cells[1, 4] as Range).Value != "CÓDIGO")
            {
                return false;
            }
            else if ((string)(worksheet.Cells[1, 5] as Range).Value != "CF_UNIDADMEDIDA")
            {
                return false;
            }
            else if ((string)(worksheet.Cells[1, 6] as Range).Value != "DES_RESUMIDA")
            {
                return false;
            }
            else if ((string)(worksheet.Cells[1, 7] as Range).Value != "Inventario requerido")
            {
                return false;
            }
            else if ((string)(worksheet.Cells[1, 8] as Range).Value != "M_ULT_COSTO")
            {
                return false;

            }
            else if ((string)(worksheet.Cells[1, 9] as Range).Value != "COSTO TOTAL")
            {
                return false;
            }
            else if ((string)(worksheet.Cells[1, 10] as Range).Value != "Inventario Existente")
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool validar = true;
            int contador=0;
            //Obtenemos un listado de los productos directamente con el entities
            inventarioEntities1 Db = new inventarioEntities1();
            List<TbProducto> ListProductos;
            List<TbPresupuesto> ListPresupuesto=Db.TbPresupuesto.ToList();;
            //Elaborado una entidad donde almacenar los datos a guardar o actualizar
            TbProducto producto = new TbProducto();
            ListProductos = Db.TbProducto.ToList();
            dgvDatos.Visible = false;
            PanelCargar.Visible = true;
            for (int i = 0; i <= dgvDatos.Rows.Count; i++)
            {
            
               
                    foreach (var item2 in ListPresupuesto)
                    {
                        if (("1" + dgvDatos.Rows[i].Cells[0].Value.ToString())==item2.numeroCuenta)
                        {
                            validar = true;
                        }
                        else
                        {
                            validar = false;
                        }
                    }
                    if (validar==true)
                    {
                        producto.CFamilia = "1" + dgvDatos.Rows[i].Cells[0].Value.ToString();
                        producto.CSubFamilia = dgvDatos.Rows[i].Cells[1].Value.ToString();
                        producto.NumProducto = dgvDatos.Rows[i].Cells[2].Value.ToString();
                        producto.CodProducto = dgvDatos.Rows[i].Cells[3].Value.ToString();
                        producto.CFUnidadMedida = dgvDatos.Rows[i].Cells[4].Value.ToString();
                        producto.DesResumida = dgvDatos.Rows[i].Cells[5].Value.ToString();
                        producto.InventarioRequerido = int.Parse(dgvDatos.Rows[i].Cells[6].Value.ToString());
                        producto.MUltCosto = Convert.ToDouble(dgvDatos.Rows[i].Cells[7].Value.ToString());
                        producto.CostoTotal = Convert.ToDouble(dgvDatos.Rows[i].Cells[8].Value.ToString());


                        Prod.GuardarProduct(producto);

                  




                    
                    }
                    else
                    {
                        contador++;
                    }
                   
                

                LblCargarPr.Text = i.ToString() + "/ " + (dgvDatos.Rows.Count).ToString();
                System.Threading.Thread.Sleep(500);

                System.Windows.Forms.Application.DoEvents();



            }
            lblcompleted.Visible = true;




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblCargarPr_Click(object sender, EventArgs e)
        {

        }
    }
}


