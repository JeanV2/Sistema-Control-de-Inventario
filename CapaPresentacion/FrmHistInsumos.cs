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
    public partial class FrmHistInsumos : Form
    {
        public FrmHistInsumos()
        {
            InitializeComponent();
        }

        private void FrmHistInsumos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FrmHistInsumos_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
