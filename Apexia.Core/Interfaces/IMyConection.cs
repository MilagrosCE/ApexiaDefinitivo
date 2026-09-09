using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Apexia.Core.Interfaces
{
    public interface IMyConexion
    {
        IDbConnection obtenerConexion();
        Task<IDbConnection> obtenerConexionAsync();
    }
}
