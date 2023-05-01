using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegociosSoliUnionCompra
    {
        DatosUnionSoliCompra datos = new DatosUnionSoliCompra();
        public bool GuardarSolicitud(TbCompraSolicitudP Solicitud)
        {
            return datos.GuardarSolicitud(Solicitud);
        }
        public bool EliminarSolicitud(TbCompraSolicitudP Solicitud)
        {
            return datos.EliminarSolicitud(Solicitud);
        }
        public bool ActualizarSolicitud(TbCompraSolicitudP Solicitud)
        {
            return datos.ActualizarSolicitud(Solicitud);
        }
        public List<TbCompraSolicitudP> ListaSolicitudes()
        {
            return datos.ListaSolicitudes();

        }
    }
}
