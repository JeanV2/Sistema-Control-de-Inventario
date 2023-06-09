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
using Utilidades;

namespace CapaPresentacion
{
    public partial class FrmHistInsumos : Form
    {
        public static String CodigoPasar;
        NegocioInsumos NInsumos= new NegocioInsumos();
        List<TbSolicitudInsumo> ListaInsumos;
        public FrmHistInsumos()
        {
            InitializeComponent();
        }

        private void FrmHistInsumos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        public void cargarDt(List<TbSolicitudInsumo>list)
        {
            foreach (TbSolicitudInsumo In in list)
            {
                int row = DgvListaSolicitudInsumos.Rows.Add();

                DgvListaSolicitudInsumos.Rows[row].Cells[0].Value = In.IdSolicitudInsumo;
                DgvListaSolicitudInsumos.Rows[row].Cells[1].Value = In.TbColaborador.NombreColaborador;
                DgvListaSolicitudInsumos.Rows[row].Cells[2].Value = In.IdColaboradorRecibe;
                DgvListaSolicitudInsumos.Rows[row].Cells[3].Value = Enum.GetName(typeof(Enums.Tipo_retiro),In.tipoSolicitud);
                DgvListaSolicitudInsumos.Rows[row].Cells[4].Value = In.ReferenciaCurso;
                DgvListaSolicitudInsumos.Rows[row].Cells[5].Value = In.fechaSolicitud;
            }
        }
        private void FrmHistInsumos_Load(object sender, EventArgs e)
        {
            DgvListaSolicitudInsumos.Rows.Clear();
            ListaInsumos = NInsumos.obtenerListaInsumos(0);
            cargarDt(ListaInsumos);
      
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            List<TbSolicitudInsumo> listaAux = ListaInsumos.Where(x=>x.fechaSolicitud>=Fecha1.Value && x.fechaSolicitud<=Fecha2.Value ).ToList(); ;
            if (listaAux.Count>0)
            {
                DgvListaSolicitudInsumos.Rows.Clear();
                cargarDt(listaAux);
            }
            else
            {
                DgvListaSolicitudInsumos.Rows.Clear();
                cargarDt(ListaInsumos);
                MessageBox.Show("No se encontraron solicitudes entre el rango de fechas ingresado","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnFiltrarPornombre_Click(object sender, EventArgs e)
        {
            List<TbSolicitudInsumo> listaAux = ListaInsumos.Where(x => x.TbColaborador.NombreColaborador==txtNombre.Text).ToList(); ;
            if (listaAux.Count > 0)
            {
                DgvListaSolicitudInsumos.Rows.Clear();
                cargarDt(listaAux);
            }
            else
            {
                DgvListaSolicitudInsumos.Rows.Clear();
                cargarDt(ListaInsumos);
                MessageBox.Show("No se encontraron solicitudes a nombre de "+txtNombre.Text+"", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvListaSolicitudInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                string id = DgvListaSolicitudInsumos.Rows[e.RowIndex].Cells[0].Value.ToString();
                CodigoPasar = id;
                ReporteEntrega Frm= new ReporteEntrega();
                Frm.ShowDialog();
            }
        }
    }
}
