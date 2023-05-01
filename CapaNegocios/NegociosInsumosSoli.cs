using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegociosInsumosSoli
    {
        DatosInsumosSoli DatosInsumosSoli= new DatosInsumosSoli();
        public bool GuardarInsumos(TbSolicitudInsumo insumo)
        {
            return DatosInsumosSoli.GuardarInsumos(insumo);
        }
    }
}
