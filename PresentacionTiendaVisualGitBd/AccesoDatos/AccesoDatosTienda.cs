using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using Entidades;
namespace AccesoDatos
{
    public class AccesoDatosTienda :IEntidadTienda
    {
        Base b = new Base("localhost","root","", "tiendagit",3306);

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("call deletetienda({0})",Entidad.Idproducto));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertartienda('{0}','{1}',{2},{3})",Entidad.Nombre,
                Entidad.Descripcion, Entidad.Precio,Entidad.Idproducto));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                 (string.Format("call showtienda('%{0}%')", filtro), "producto");
        }
    }
}
