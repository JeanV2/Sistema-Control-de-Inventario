﻿using CapaEntidades;
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
    public partial class FrmVerListaProductos : Form
    {
        public FrmVerListaProductos()
        {
            InitializeComponent();
        }
        //Lista
        List<TbProducto> ListProducto;
        List<TbPresupuesto> ListPresupuesto;
        //
        NegociosProductos NegProduct = new NegociosProductos();
        NegocioPresupuestos NegPresupuesto = new NegocioPresupuestos();


        //
        string Presupuesto = "";
        double TotalCosto = 0;
        private void FrmVerListaProductos_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Boton de filtro por codigo y por presupuesto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            ListProducto = NegProduct.ListProduct();

            //buscar
            IEnumerable<TbProducto> listaAux = new List<TbProducto>();

            if (TxtCodigoPresupuesto.Text != string.Empty)
            {

                listaAux = ListProducto.Where(x => x.CFamilia.ToString().Contains(TxtCodigoPresupuesto.Text)).ToList();
                TxtCodigoPresupuesto.ResetText();
            }
            if (TxtCodigoProducto.Text != string.Empty)
            {

                listaAux = ListProducto.Where(x => x.CodProducto.ToString().Contains(TxtCodigoProducto.Text)).ToList();
                TxtCodigoProducto.ResetText();
            }
            else if ((TxtCodigoProducto.Text == string.Empty) && (TxtCodigoPresupuesto.Text == string.Empty))
            {
                ListProducto = NegProduct.ListProduct();
                listaAux = ListProducto;
            }
            RefreshDatos((List<TbProducto>)listaAux);

        }
        //Refrescar DataGridView conlos datos de la base
        private void RefreshDatos(List<TbProducto> listaProductos)
        {
            DgvListaProductos.Rows.Clear();

            foreach (TbProducto tbProducto in listaProductos)
            {
                int nr = DgvListaProductos.Rows.Add();

                DgvListaProductos.Rows[nr].Cells[0].Value = tbProducto.CFamilia;
                //almaceno el presupuesto
                Presupuesto = tbProducto.CFamilia;
                DgvListaProductos.Rows[nr].Cells[1].Value = tbProducto.CSubFamilia;
                DgvListaProductos.Rows[nr].Cells[2].Value = tbProducto.NumProducto;
                DgvListaProductos.Rows[nr].Cells[3].Value = tbProducto.CodProducto;
                DgvListaProductos.Rows[nr].Cells[4].Value = tbProducto.DesResumida;
                DgvListaProductos.Rows[nr].Cells[5].Value = tbProducto.CFUnidadMedida;
                DgvListaProductos.Rows[nr].Cells[6].Value = tbProducto.InventarioRequerido;
                DgvListaProductos.Rows[nr].Cells[7].Value = tbProducto.MUltCosto;
                //almaceno el costo total para compararlo con el monto de ese presupuesto
                TotalCosto = (double)(tbProducto.InventarioRequerido * tbProducto.MUltCosto);
                //if (PresupuestoAlcanza())
                //{
                    DgvListaProductos.Rows[nr].Cells[8].Value = TotalCosto;
                //}
                //else
                //{
                //    DgvListaProductos.Rows[nr].Cells[8].Value = "No hay presupuesto";
                //}

                DgvListaProductos.Rows[nr].Cells[9].Value = tbProducto.InventarioExistente;
            }
        }

        /// <summary>
        /// Valida que ahiga presupuesto
        /// </summary>
        /// <returns></returns>
        //private bool PresupuestoAlcanza()
        //{
        //    ListPresupuesto = NegPresupuesto.ListaPresupuestos();
        //    bool Alcanza = true;
        //    foreach (TbPresupuesto pres in ListPresupuesto)
        //    {

        //        if (pres.numeroCuenta.Equals(Presupuesto))
        //        {
        //            if (pres.MontoPresupuesto >= TotalCosto)
        //            {
        //                Alcanza = true;
        //                break;
        //            }
        //            else
        //            {
        //                Alcanza = false;
        //                break;
        //            }

        //        }


        //    }

        //    return Alcanza;
        //}
    }
}
