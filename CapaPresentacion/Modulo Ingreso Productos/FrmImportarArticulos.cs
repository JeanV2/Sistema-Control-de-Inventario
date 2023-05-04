using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;
using CapaDatos;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmImportarArticulos : Form
    {
        public FrmImportarArticulos()
        {
            InitializeComponent();
        }
        NegociosProductos Prod = new NegociosProductos();
        public async void CargarExcel() 
        { 
        }
        private void BtnImportar_Click(object sender, EventArgs e)
        {
            // Abre el cuadro de diálogo para seleccionar el archivo de Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crea una instancia de Excel y abre el archivo
            Application excel = new Application();
                  Workbook workbook = excel.Workbooks.Open(openFileDialog.FileName);

                // Obtiene la primera hoja de trabajo
                Worksheet worksheet = (Worksheet)workbook.Sheets[1];

                if (validarFormatoExcel(worksheet))
                {
                    //Obtiene los datos de la hoja de trabajo y los guarda en un DataTable
                    DataTable dt = new DataTable();
                    for (int i = 1; i <= 10; i++)
                    {
                        dt.Columns.Add((string)(worksheet.Cells[1, i] as Range).Value);
                    }
                    for (int i = 2; i <= 10; i++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int j = 1; j <= 10; j++)
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
        }
        public bool validarFormatoExcel(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {

            if ((string)(worksheet.Cells[1, 1] as Range).Value != "C_FAMILIA")
            {
                return false;
            }
            else if(Convert.ToString((string)(worksheet.Cells[1, 2] as Range).Value) != "C_SUBFAM")
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
            //Obtenemos un listado de los productos directamente con el entities
            inventarioEntities1 Db = new inventarioEntities1();
            List<TbProducto> ListProductos;
            //Elaborado una entidad donde almacenar los datos a guardar o actualizar
            TbProducto producto = new TbProducto();
            ListProductos = Db.TbProducto.ToList();
            for (int i = 0; i < dgvDatos.RowCount; i++)
            {
               

               producto.CFamilia = "1"+dgvDatos.Rows[i].Cells[0].Value.ToString();
               producto.CSubFamilia = dgvDatos.Rows[i].Cells[1].Value.ToString();
               producto.NumProducto = dgvDatos.Rows[i].Cells[2].Value.ToString();
               producto.CodProducto = dgvDatos.Rows[i].Cells[3].ToString();
               producto.CFUnidadMedida = dgvDatos.Rows[i].Cells[4].Value.ToString();
               producto.DesResumida = dgvDatos.Rows[i].Cells[5].Value.ToString();
               producto.InventarioRequerido = int.Parse(dgvDatos.Rows[i].Cells[6].Value.ToString());
               producto.MUltCosto = int.Parse(dgvDatos.Rows[i].Cells[7].Value.ToString());
               producto.CostoTotal = int.Parse(dgvDatos.Rows[i].Cells[8].Value.ToString());
                if (dgvDatos.Rows[i].Cells[9].Value.ToString() != "")
                {
                    producto.InventarioExistente = int.Parse(dgvDatos.Rows[i].Cells[9].Value.ToString());
                }
                else
                {
                    producto.InventarioExistente = 0;
                }
                   

                Prod.GuardarProduct(producto);





            }
                   
            }
        }

        //private void FrmImportarArticulos_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    this.Close();
        //}
    }

