using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDColaborador
    {

        public bool GuardarColaborador(TbColaborador colaborador)
        {
            try
            //hola
            {
                //ttt
                using (inventarioEntities1 DB = new inventarioEntities1())
                {
                    DB.TbColaborador.Add(colaborador);
                    DB.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ModificarColaborador(TbColaborador colaborador)
        {
            //try
            //{
            using (inventarioEntities1 DB = new inventarioEntities1())
            {
                TbColaborador ColaboradorModifica = DB.TbColaborador.Single(C => C.IdColaborador == colaborador.IdColaborador);
                    ColaboradorModifica.PasswordColaborador = colaborador.PasswordColaborador;
                    ColaboradorModifica.NombreColaborador = colaborador.NombreColaborador;
                    ColaboradorModifica.PrimerApellidoColaborador = colaborador.PrimerApellidoColaborador;
                    ColaboradorModifica.SegundoApellidoColaborador = colaborador.SegundoApellidoColaborador;
                    ColaboradorModifica.UserNameColaborador = colaborador.UserNameColaborador;
                    ColaboradorModifica.TipoColaborador = colaborador.TipoColaborador;
                    DB.SaveChanges();


                }

                return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }
        public bool EliminarColaborador(TbColaborador colaborador)
        {
            try
            {
                using (inventarioEntities1 DB = new inventarioEntities1())
                {
                    TbColaborador ColaboradorModifica = DB.TbColaborador.Single(C => C.IdColaborador == colaborador.IdColaborador);
                    ColaboradorModifica.EstadoColaborador = colaborador.EstadoColaborador;
                    DB.SaveChanges();


                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<TbColaborador> listaColaboadores()
        {
            try
            {
                using (inventarioEntities1 DB = new inventarioEntities1())
                {
                    return (from c in DB.TbColaborador
                            select c).ToList();


                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool ExisteColaborador(TbColaborador colaborador)
        {

            var Existe = false;
            using (var Conn = new inventarioEntities1())
            {
                Existe = Conn.TbColaborador.Any(c => c.IdColaborador == colaborador.IdColaborador);
                return Existe;
            }

        }
    }
}
