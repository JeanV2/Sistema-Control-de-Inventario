using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaUtilidades.Interfaces
{
    public interface IGenerica<entidad>
    {
        bool Guardar(entidad entidad);
        bool Actualizar(entidad entidad);
        bool Eliminar(entidad entidad);
        List<entidad> Lista(entidad entidad);

    }
}
