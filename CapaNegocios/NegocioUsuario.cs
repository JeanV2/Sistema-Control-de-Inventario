using Capa_Datos;
using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegocioUsuario
    {
        //prueba
        //hola
         DatosUsuario DatosUsuario = new DatosUsuario();
        public List<TbColaborador> obtenerusuario()
        {
           return DatosUsuario.obtenerusuario();
        }
    }
}
