using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace CapaPresentacion
{
    public partial class FrmListaUsuarios : Form
    {
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Instancia al formulario principal para acceder a los controles que se encuentran en el
        /// </summary>
        FrmUsuarios frmcolaboradores = (FrmUsuarios)Application.OpenForms["FrmUsuarios"];
        //------------------------------------------------------------------------------------------
        List<TbColaborador> ListaColabo;
        CNColaborador NegocioColaborador = new CNColaborador();
        public FrmListaUsuarios()
        {
            InitializeComponent();
        }

        //Atravez del evento vamos a poder pasar datos entre los formularios

        public delegate void pasarDatos(TbColaborador Colaboradores);
        //Aquí vamos a llamar al evento
        //[acceso] [tipoEvento] [delegado] [identificadorEvento]
        public event pasarDatos pasarDatosEvent;
        private void DgvListaColaboradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // METODO PASAR DATOS NO CAMBIAR
            if (e.RowIndex != -1)
            {
                int fila = e.RowIndex;

                string id = DgvListaColaboradores.Rows[fila].Cells[0].Value.ToString();
                //int tipoId = (int)dtgvClientes.Rows[n].Cells[1].Value;

                TbColaborador Colaborador = new TbColaborador();
                 
                //filtra los tipos de id sean igual al tipo de id cuando hacemos el dobleclick en el grid
                Colaborador = ListaColabo.Where(x => x.IdColaborador.Trim() == id.Trim()).SingleOrDefault();

                //disparar el evento y mandar la identidad
                pasarDatosEvent(Colaborador);

                frmcolaboradores.ActivarBtn();
                this.Close();
            }

        }
     
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmListaColaboradores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            //Realizamos los tipos de busqueda de los colaboradores haciendo un filtro 
            IEnumerable<TbColaborador> ListAux= new List<TbColaborador>();
            if (TxtCodigo.Text!=string.Empty)
            {
                ListAux= ListaColabo.Where(x => x.IdColaborador.Trim().ToUpper().Contains(TxtCodigo.Text.Trim().ToUpper())).ToList();
            }
            if (TxtNombreProducto.Text!=string.Empty)
            {
                ListAux= ListaColabo.Where(x => x.NombreColaborador.Trim().ToUpper().Contains(TxtNombreProducto.Text.Trim().ToUpper())).ToList();
            }

            if (ListAux.Count() == 0 && TxtCodigo.Text == string.Empty && TxtNombreProducto.Text == string.Empty)
            {
                ListAux = ListaColabo;
            }

            CargarData((List<TbColaborador>) ListAux);

        }

        private void FrmListaColaboradores_Load(object sender, EventArgs e)
        {
            refrescarDataGridView();
        }
        /// <summary>
        /// Metodo que hace la sobrecarga del datagrid tanto en el load como en los filtros de busqueda
        /// </summary>
        public void refrescarDataGridView()
        {
            ListaColabo = NegocioColaborador.listaColaboadores();


            CargarData(ListaColabo);
        }
        /// <summary>
        /// Metodoo que Muestra los datos de los colaboaradores en un Datagrid
        /// </summary>
        /// <param name="colaboradores"></param>
        private void CargarData(List<TbColaborador> colaboradores)
        {
            DgvListaColaboradores.Rows.Clear();
            foreach (TbColaborador Colabo in colaboradores)
            {
                int nr = DgvListaColaboradores.Rows.Add();
                DgvListaColaboradores.Rows[nr].Cells[0].Value = Colabo.IdColaborador;
                DgvListaColaboradores.Rows[nr].Cells[1].Value = Colabo.NombreColaborador;
                DgvListaColaboradores.Rows[nr].Cells[2].Value = Colabo.PrimerApellidoColaborador;
                DgvListaColaboradores.Rows[nr].Cells[3].Value = Colabo.SegundoApellidoColaborador;
                if (Colabo.TipoColaborador== null)
                {
                    DgvListaColaboradores.Rows[nr].Cells[4].Value = Colabo.TipoColaborador;

                }
                else
                {
                    DgvListaColaboradores.Rows[nr].Cells[4].Value =Enum.GetName(typeof(Enums.Tipo_Colaborador),Colabo.TipoColaborador);

                }
            }
        }
    }
}
