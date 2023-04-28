using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace Capa_Datos
{
    public class DatosUsuario
    {
        //se requiere mostrar lista y guardar usuario
        public List<TbColaborador> obtenerusuario()
        {
            /*interactua con la BD, le indica consultar los datos enviados por el usuario y
          los devuelva si existen dentro de ella.*/
            try
            {
                //hola
                using (var context = new ControlInventarioEntities())
                {
                    //prueba
                    //Lenguaje LinQ. Para realizar query a la base de datos.
                    return (from c in context.TbColaborador select c).ToList();
                }

            }
            catch (Exception ex)
            {

                return null;
            }
        }
        //    public bool modificar(TBLusuarios entidad)
        //    {
        //        try
        //        {
        //            using (var context = new dbRioCelesteNatureEntities())
        //            {
        //                context.Entry<TBLusuarios>(entidad).State = System.Data.Entity.EntityState.Modified;
        //                context.SaveChanges();
        //            }
        //            return true;

        //        }
        //        catch (Exception ex)
        //        {
        //            return false;
        //        }

        //    }
        //    public bool Guardar(TBLusuarios entidad)
        //    {
        //        try
        //        {
        //            using (var context = new dbRioCelesteNatureEntities())
        //            {
        //                context.TBLusuarios.Add(entidad);
        //                context.SaveChanges();
        //            }
        //            return true;

        //        }
        //        catch (Exception ex)
        //        {
        //            return false;
        //        }
        //    }
        //    public bool Eliminar(TBLusuarios entidad)
        //    {
        //        try
        //        {
        //            using (var context = new dbRioCelesteNatureEntities())
        //            {
        //                context.Entry<TBLusuarios>(entidad).State = System.Data.Entity.EntityState.Deleted;
        //                context.SaveChanges();
        //            }
        //            return true;

        //        }
        //        catch (Exception ex)
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
}
