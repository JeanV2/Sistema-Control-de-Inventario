using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosUnionSoliCompra
    {
        public bool GuardarSolicitud(TbCompraSolicitudP Solicitud)
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
        public bool EliminarSolicitud(TbCompraSolicitudP Solicitud)
        {
            try
            {
                using (var contex = new inventarioEntities1())
                {
                    contex.Entry<TbCompraSolicitudP>(Solicitud).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public bool ActualizarSolicitud(TbCompraSolicitudP Solicitud)
        {
            try
            {
                using (var contex = new inventarioEntities1())
                {
                    contex.Entry<TbCompraSolicitudP>(Solicitud).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public List<TbCompraSolicitudP> ListaSolicitudes()
        {
            try
            {
                using (var contex = new inventarioEntities1())
                {
                    return (from c in contex.TbCompraSolicitudP.Include("TbProducto") select c).ToList();
                }

            }
            catch (Exception ex) { return null; }
        }
    }
}
