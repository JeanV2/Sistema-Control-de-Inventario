using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace CapaPresentacion
{
    public partial class FrmImportarExcelPresupuesto : Form
    {
        DataTable dt = new DataTable();
        TbPresupuesto presupuesto = new TbPresupuesto();

        public FrmImportarExcelPresupuesto()
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
            //Validacion de si la tablas se encuentra vacia
            if (dt.Columns == null)
            {
                MessageBox.Show("Debes importar el exel");
                return;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            { 
                string cuenta = string.Empty;
                string nombre = string.Empty;
                double saldo = 0;
                cuenta =  dt.Rows[i]["Cuenta"].ToString();
                presupuesto.numeroCuenta = cuenta;
                nombre = dt.Rows[i]["Nombre Presupuesto"].ToString().Trim();
                presupuesto.nombrePresupuesto = nombre;
                saldo = Convert.ToDouble(dt.Rows[i]["Saldo "].ToString());
                presupuesto.MontoPresupuesto = saldo;
                MessageBox.Show(saldo.ToString());
            }

        }

        //private void FrmImportarExcelPresupuesto_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    this.Close();   
        //}
    }
}
