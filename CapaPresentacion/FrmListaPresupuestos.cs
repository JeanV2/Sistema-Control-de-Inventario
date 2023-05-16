using CapaDatos;
using CapaEntidades;
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
        inventarioEntities1 db= new inventarioEntities1();
        List<TbPresupuesto> ListaPre;
        public FrmListaPresupuestos()
        {
            InitializeComponent();
        }

        private void FrmListaPresupuestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
          
        }

        public void cargardt(List<TbPresupuesto>Pre)
        {
       
            foreach (TbPresupuesto List in Pre)
            {
                int row = DgvListaProductos.Rows.Add();
                DgvListaProductos.Rows[row].Cells[0].Value = List.numeroCuenta;
                DgvListaProductos.Rows[row].Cells[1].Value = List.nombrePresupuesto;
                DgvListaProductos.Rows[row].Cells[2].Value = List.MontoPresupuesto;
            }
        }

        private void FrmListaPresupuestos_Load(object sender, EventArgs e)
        {
            DgvListaProductos.Rows.Clear();
            ListaPre  =   db.TbPresupuesto.ToList();
            cargardt(ListaPre);
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DgvListaProductos.Rows.Clear();
            List<TbPresupuesto> ListaAux;
            ListaAux = ListaPre.Where(x=>x.numeroCuenta==TxtCodigoPresupuesto.Text).ToList();
            if (ListaAux.Count>0)
            {
                cargardt(ListaAux);
            }
            else
            {
                MessageBox.Show("El presupuesto que intentas buscar no existe","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cargardt(ListaPre);
            }
        }
    }
}
