using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegocioPresupuestos
    {
        DatosPresupuestos datosPresupuestos = new DatosPresupuestos();

        public bool GuardarPresupuesto(TbPresupuesto presupuesto)
        {
            return datosPresupuestos.GuardarPresupuesto(presupuesto);
        }
        public bool EditarPresupuesto(TbPresupuesto presupuesto)
        {
            return datosPresupuestos.EditarPresupuesto(presupuesto);
        }
        public bool EliminarPresupuesto(TbPresupuesto presupuesto)
        {
            return datosPresupuestos.EliminarPresupuesto(presupuesto);
        }
        public List<TbPresupuesto> ListaPresupuestos()
        {
            return datosPresupuestos.ListaPresupuestos();
        }
    }
}
