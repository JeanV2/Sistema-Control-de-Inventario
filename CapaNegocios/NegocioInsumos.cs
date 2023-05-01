using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
   public class NegocioInsumos
    {
        DatosInsumos datos = new DatosInsumos();
        public bool GuardarInsumos(TbSolicitudInsumo insumo)
        {
            return datos.GuardarInsumos(insumo);
        }
        public List<TbSolicitudInsumo> obtenerListaInsumos(int estado)
        {
            return datos.obtenerListaInsumos(0);

        }
    }
}
