using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosPresupuestos
    {
        public bool GuardarPresupuesto(TbPresupuesto presupuesto)
        {
            try
            {
                using (var context = new inventarioEntities1())
                {
                    context.TbPresupuesto.Add(presupuesto);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditarPresupuesto(TbPresupuesto presupuesto)
        {
            try
            {
                using (var context = new inventarioEntities1())
                {
                    context.Entry<TbPresupuesto>(presupuesto).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarPresupuesto(TbPresupuesto presupuesto)
        {
            try
            {
                using (var context = new inventarioEntities1())
                {
                    context.Entry<TbPresupuesto>(presupuesto).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TbPresupuesto> ListaPresupuestos()
        {
            try
            {
                using (var context = new inventarioEntities1())
                {
                    return (from c in context.TbPresupuesto
                            select c).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<TbColaborador> ListaColaborador()
        {
            try
            {
                using (var context = new inventarioEntities1())
                {
                    return (from c in context.TbColaborador
                            select c).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
