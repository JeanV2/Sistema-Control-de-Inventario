using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosSolictudCompra
    {

        public bool GuardarSolicitud(TbSolicitudCompra Solicitud)
        {
            try
            {
                using (var contex= new inventarioEntities1())
                {
                    contex.TbSolicitudCompra.Add(Solicitud);
                    contex.SaveChanges();
                }
                    return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool GuardarbCompraSolicitudProductos(TbCompraSolicitudP Solicitud)
        {
            try
            {
                using (var contex = new inventarioEntities1())
                {
                    contex.TbCompraSolicitudP.Add(Solicitud);
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool EliminarSolicitud(TbSolicitudCompra Solicitud)
        {
            try
            {
                using (var contex = new inventarioEntities1())
                {
                    contex.Entry<TbSolicitudCompra>(Solicitud).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool ActualizarSolicitud(TbSolicitudCompra Solicitud)
        {
            try
            {
                using (var contex = new inventarioEntities1())
                {
                    contex.Entry<TbSolicitudCompra>(Solicitud).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public List<TbSolicitudCompra> ListaSolicitudes()
        {
            try
            {
                using (var contex = new inventarioEntities1())
                {
                    return (from c in contex.TbSolicitudCompra  select c).ToList();
                }
                
            }
            catch (Exception ex) { return null; }
        }

    }
}
