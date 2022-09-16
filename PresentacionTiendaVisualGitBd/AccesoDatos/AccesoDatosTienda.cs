using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using Entidades;
namespace AccesoDatos
{
    public class AccesoDatosTienda
    {
        Base b = new Base("localhost","root","", "tiendagit",3306);
    }
}
