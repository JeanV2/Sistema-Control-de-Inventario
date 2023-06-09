﻿using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosProductos
    {

        /// <summary>
        /// Guarda Productos en la tabla
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool GuardarProduct(TbProducto producto)
        {
            try
            {
                using (var C = new inventarioEntities1())
                {
                    C.TbProducto.Add(producto);
                    C.SaveChanges();
                }
                return true;

            }
            catch (Exception exe)
            {
                return false;
            }
        }
        /// <summary>
        /// Modifica los productos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool ModificarProduct(TbProducto producto)
        {
            //try
            //{
                using (var C = new inventarioEntities1())
                {
                    C.Entry<TbProducto>(producto).State = System.Data.Entity.EntityState.Modified;
                    C.SaveChanges();
                }
                return true;

            //}
            //catch (Exception exe)
            //{
            //    return false;
            //}
        }
        /// <summary>
        /// Elimina los productos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool EliminarProduct(TbProducto producto)
        {
            try
            {
                using (var C = new inventarioEntities1())
                {
                    C.Entry<TbProducto>(producto).State = System.Data.Entity.EntityState.Modified;
                    C.SaveChanges();
                }
                return true;
            }
            catch (Exception exe)
            {
                return false;
            }
        }
        /// <summary>
        /// Lista de todos los productos Guardados
        /// </summary>
        /// <returns></returns>
        public async Task< List<TbProducto>> ListProduct()
        {
            try
            {
                using (var C = new inventarioEntities1())
                {
                    return await Task.Run(() => C.TbProducto.ToList());
                }

            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public List<TbProducto> ListProductosSinAsy()
        {
            try
            {
                using (var C = new inventarioEntities1())
                {
                    return (from P in C.TbProducto select P).ToList();
                }

            }
            catch (Exception ex)
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
