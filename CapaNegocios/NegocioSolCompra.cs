using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public  class NegocioSolCompra
    {
        DatosSolictudCompra datos = new DatosSolictudCompra();
        public bool GuardarSolicitud(TbSolicitudCompra Solicitud)
        {
            return datos.GuardarSolicitud(Solicitud);
        }
        public bool EliminarSolicitud(TbSolicitudCompra Solicitud)
        {
            return datos.EliminarSolicitud(Solicitud);
        }
        public bool ActualizarSolicitud(TbSolicitudCompra Solicitud)
        {
            return datos.ActualizarSolicitud(Solicitud);
        }
        public List<TbSolicitudCompra> ListaSolicitudes()
        {
            return datos.ListaSolicitudes() ;

        }
    }
}
