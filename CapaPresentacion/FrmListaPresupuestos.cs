using CapaEntidades;
using CapaNegocios;
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
    public partial class FrmListaPresupuestos : Form
    {
        List<TbPresupuesto> listaPresupuestos;
        NegocioPresupuestos negocioPresupuestos = new NegocioPresupuestos();
        public delegate void pasarDatos(TbPresupuesto presupuesto);
        public event pasarDatos pasarDatosEvent;
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmPresupuesto frmPresupuesto = (FrmPresupuesto)Application.OpenForms["FrmPresupuesto"];
        //----------------------------------------------------------------------------------------------
        public FrmListaPresupuestos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int Fila = e.RowIndex;
                string id = DgvListaProductos.Rows[Fila].Cells[0].Value.ToString();

                TbPresupuesto presupuesto = new TbPresupuesto();
                presupuesto = listaPresupuestos.Where(x => x.IdPresupuesto.Trim() == id.Trim()).SingleOrDefault();

                pasarDatosEvent(presupuesto);
                this.Close();
            }
        }

        private void FrmListaPresupuestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FrmListaPresupuestos_Load(object sender, EventArgs e)
        {
            refrescardata();
        }

        private void cargarData(List<TbPresupuesto> listapresupuestos)
        {
            foreach(TbPresupuesto presupuesto in listapresupuestos)
            {
                int nr = DgvListaProductos.Rows.Add();

                DgvListaProductos.Rows[nr].Cells[0].Value = presupuesto.IdPresupuesto;
                DgvListaProductos.Rows[nr].Cells[1].Value = presupuesto.MesPresupuesto;
                DgvListaProductos.Rows[nr].Cells[2].Value = presupuesto.MontoPresupuesto;
                DgvListaProductos.Rows[nr].Cells[3].Value = presupuesto.EstadoPresupuesto;
            }
        }

        public void refrescardata()
        {
            listaPresupuestos = negocioPresupuestos.ListaPresupuestos();

            cargarData(listaPresupuestos);
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DgvListaProductos.Rows.Clear();
            IEnumerable<TbPresupuesto> Auxiliar = new List<TbPresupuesto>();

            if (TxtCodigo.Text != string.Empty)
            {
                Auxiliar = listaPresupuestos.Where(x => x.IdPresupuesto.Trim().ToUpper().Contains(TxtCodigo.Text.Trim().ToUpper())).ToList();
            }
            if (Auxiliar.Count() == 0 && TxtCodigo.Text == string.Empty)
            {
                Auxiliar = listaPresupuestos;
            }

            cargarData((List<TbPresupuesto>)Auxiliar);
        }
    }
}
