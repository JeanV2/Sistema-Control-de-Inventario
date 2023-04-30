﻿using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegociosProductos
    {
        DatosProductos datosProduc = new DatosProductos();

        public bool GuardarProduct(TbProducto producto)
        {
            return datosProduc.GuardarProduct(producto);
        }

        public bool ModificarProduct(TbProducto producto)
        {
            return datosProduc.ModificarProduct(producto);
        }

        public bool EliminarProduct(TbProducto producto)
        {
            return datosProduc.EliminarProduct(producto);
        }

        public List<TbProducto> ListProduct()
        {
            return datosProduc.ListProduct();
        }

    }
}
