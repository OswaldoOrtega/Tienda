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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tien.Idproducto = -1;
            FrmAgregarProducto ap = new FrmAgregarProducto();
            ap.ShowDialog();
        }
    }
}
