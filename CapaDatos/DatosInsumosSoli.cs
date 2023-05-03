using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosInsumosSoli
    {

        public bool GuardarInsumos(TbProductoInsumoS insumo)
        {
            try
            {
                //ttt
                using (inventarioEntities1 DB = new inventarioEntities1())
                {
                    DB.TbProductoInsumoS.Add(insumo);
                    DB.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<TbProducto> ObtenerListaProductos(string codigo)
        {
            try
            {
                using (inventarioEntities1 Conn = new inventarioEntities1())
                {
                    return (from c in Conn.TbProducto
                            where c.CodProducto == codigo
                            select c).ToList();
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool ExisteProducto(TbProducto producto)
        {

            var Existe = false;
            using (var Conn = new inventarioEntities1())
            {
                Existe = Conn.TbProducto.Any(c => c.CodProducto == producto.CodProducto);
                return Existe;
            }

        }
    }
}
