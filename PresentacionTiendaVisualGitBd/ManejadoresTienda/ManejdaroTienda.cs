using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using AccesoDatos;
using Entidades;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadoresTienda
{
    public class ManejdaroTienda : IManejador
    {
        AccesoDatosTienda at = new AccesoDatosTienda();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar {0}",
                Entidad.Nombre),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                at.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            at.Guardar(Entidad);
            g.Mensaje("Producto guardao con exito", "!ATENCION", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = at.Mostrar(filtro).Tables["producto"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Blue));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Violet));
            tabla.Columns[0].Visible = false;
        }
    }
}
