using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace ReporteLiquidacionGUI
{
    public partial class FrmPrincipal : Form
    {
       public static ContratistaService contratistaService = new ContratistaService();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Contratista contratista = new Contratista(TxtIdentificacion.Text, TxtNombre.Text, TxtImpuestoEstampilla.Text, DTFechaLiquidacion.Value.Date, Convert.ToDecimal(TxtValorImpuesto.Text) );
            contratistaService.Guardar(contratista);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
        }
    }
}
