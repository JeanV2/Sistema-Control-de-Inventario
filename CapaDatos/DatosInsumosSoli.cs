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

    }
}
