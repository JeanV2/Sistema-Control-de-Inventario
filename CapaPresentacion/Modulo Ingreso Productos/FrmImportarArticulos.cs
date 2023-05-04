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

namespace CapaPresentacion
{
    public partial class FrmImportarArticulos : Form
    {
        public FrmImportarArticulos()
        {
            InitializeComponent();
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

                // Obtiene los datos de la hoja de trabajo y los guarda en un DataTable
                DataTable dt = new DataTable();
                for (int i = 1; i <= worksheet.UsedRange.Columns.Count; i++)
                {
                    dt.Columns.Add((string)(worksheet.Cells[1, i] as Range).Value);
                }
                for (int i = 2; i <= worksheet.UsedRange.Rows.Count; i++)
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
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Obtenemos un listado de los productos directamente con el entities
            inventarioEntities1 Db = new inventarioEntities1();
            List<TbProducto> ListProductos;
            //Elaborado una entidad donde almacenar los datos a guardar o actualizar
            TbProducto producto = new TbProducto();
            ListProductos = Db.TbProducto.ToList();
            for (int i = 0; i <= dgvDatos.RowCount; i++)
            {
                string cod = dgvDatos.Rows[i].Cells[0].ToString();
                foreach (var item in ListProductos)
                {
                    if (item.CodProducto==cod)
                    {
                        producto.CodProducto = cod;
                        producto.DesResumida = dgvDatos.Rows[i].Cells[1].Value.ToString();
                        producto.CostoTotal =int.Parse( dgvDatos.Rows[i].Cells[2].Value.ToString());
                        producto.CFamilia = dgvDatos.Rows[i].Cells[3].Value.ToString();
                        producto.CSubFamilia = dgvDatos.Rows[i].Cells[4].Value.ToString();
                        producto.NumProducto = dgvDatos.Rows[i].Cells[5].Value.ToString();
                        producto.CFUnidadMedida = dgvDatos.Rows[i].Cells[6].Value.ToString();
                        if ((int)dgvDatos.Rows[i].Cells[7].Value != 0)
                        {
                            producto.InventarioRequerido = item.InventarioRequerido + (int)dgvDatos.Rows[i].Cells[7].Value;
                        }
                        else
                        {
                            producto.InventarioRequerido = (int)dgvDatos.Rows[i].Cells[7].Value;
                        }
                        
                        //producto.CostoTotal =(int)producto.CostoProducto* producto.InventarioRequerido;

                        if ((int)dgvDatos.Rows[i].Cells[9].Value != 0)
                        {
                            producto.InventarioExistente = item.InventarioExistente + (int)dgvDatos.Rows[i].Cells[7].Value;
                        }
                        else
                        {
                            producto.InventarioExistente = (int)dgvDatos.Rows[i].Cells[7].Value;
                        }


                    }
                }
                   
            }
        }

        //private void FrmImportarArticulos_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    this.Close();
        //}
    }
}
