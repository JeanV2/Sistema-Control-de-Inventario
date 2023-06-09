﻿using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosInsumos
    {
        public bool GuardarInsumos(TbSolicitudInsumo insumo)
        {
            try
            {
                //ttt
                using (inventarioEntities1 DB = new inventarioEntities1())
                {
                    DB.TbSolicitudInsumo.Add(insumo);
                    DB.SaveChanges();

                }
            return true;
        }
            catch (Exception)
            {
                return false;
            }
           }
        public List<TbSolicitudInsumo> obtenerListaInsumos(int estado)
        {
            /*interactua con la BD, le indica consultar los datos enviados por el usuario y
          los devuelva si existen dentro de ella.*/
            try
            {

                using (var context = new inventarioEntities1())
                {
                    //bool est = estado == (int)Enums.estado.activo;
                    //Lenguaje LinQ. Para realizar query a la base de datos.
                    return (from c in context.TbSolicitudInsumo.Include("TbColaborador")
                                //where c.Estado == est
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
