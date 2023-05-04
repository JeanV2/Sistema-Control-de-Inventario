using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Enums
    {
        /// <summary>
        /// El tipo de estado Actvio e Inactivo
        /// </summary>
        public enum Estado
        {
            Activo=0,
            Inactivo=1

        }
        /// <summary>
        /// El tipo que se le otorga al usuario
        /// </summary>
        public enum Tipo_Colaborador
        {
            Administrador=0,
            Limpieza=1

        }
        /// <summary>
        /// El estado que se otorga al producto en almacen
        /// </summary>
        public enum Estado_producto
        {
            Disponible=0,
            Agotado=1

        }
        /// <summary>
        /// El tipo que se asigna a su respectivo retiro
        /// </summary>
        public enum Tipo_retiro
        {
            Administrativo=0,
            Cursos=1

        }
        /// <summary>
        /// Unidad de medida para los productos
        /// </summary>
        public enum Unidad_Medida
        {
            Unidad = 0,
            Kilogramos = 1

        }
    }
}
