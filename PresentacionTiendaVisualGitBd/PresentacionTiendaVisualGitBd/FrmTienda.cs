using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ManejadoresTienda;
namespace PresentacionTiendaVisualGitBd
{
    public partial class FrmTienda : Form
    {
        ManejdaroTienda mt;
        public static Tienda tien = new Tienda(0,"","",0);
        int fila = 0, col = 0;
        public FrmTienda()
        {
            InitializeComponent();
            mt = new ManejdaroTienda();
        }
        void actualizar()
        {
            mt.Mostrar(dtgTienda,txtBuscar.Text);
        }
        private void dtgTienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tien.Idproducto = int.Parse(dtgTienda.Rows[fila].Cells[0].Value.ToString());
            tien.Nombre = dtgTienda.Rows[fila].Cells[1].Value.ToString();
            tien.Descripcion = dtgTienda.Rows[fila].Cells[2].Value.ToString();
            tien.Precio = double.Parse(dtgTienda.Rows[fila].Cells[3].Value.ToString());
            switch (col)
            {
                case 4:
                    {
                        FrmAgregarProducto fa = new FrmAgregarProducto();
                        fa.ShowDialog();
                        actualizar();
                    }break;

                case 5:
                    {
                        mt.Borrar(tien);
                        actualizar();
                    }break;
            }
        }

        private void dtgTienda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            actualizar();   
        }

 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tien.Idproducto = -1;
            FrmAgregarProducto ap = new FrmAgregarProducto();
            ap.ShowDialog();
        }
    }
}
