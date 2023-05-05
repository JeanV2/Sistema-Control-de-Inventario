using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmHistCompras : Form
    {
        public FrmHistCompras()
        {
            InitializeComponent();
        }

        private void FrmHistCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FrmHistCompras_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
