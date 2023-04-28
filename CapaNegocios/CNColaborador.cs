using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CNColaborador
    {
        //hola
        CDColaborador CDcolaborador = new CDColaborador();
        public bool GuardarColaborador(TbColaborador colaborador)
        {
            return CDcolaborador.GuardarColaborador(colaborador);
        }
        public bool ModificarColaborador(TbColaborador colaborador)
        {
            return CDcolaborador.ModificarColaborador(colaborador);
        }
        public bool EliminarColaborador(TbColaborador colaborador)
        {
            return CDcolaborador.EliminarColaborador(colaborador);

        }
        public List<TbColaborador> listaColaboadores()
        {
            return CDcolaborador.listaColaboadores( );
        }
    }
}
