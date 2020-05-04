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
    public partial class Consulta : Form
    {
        public static ContratistaService contratistaService = new ContratistaService();
        public Consulta()
        {
            InitializeComponent();
        }

        private void TablaContratista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            
            //contratistaService.BuscarEntidadFecha(TxtEntidadConsulta.Text, DtFecha.Value.Date);
            TablaContratista.DataSource = contratistaService.BuscarEntidadFecha(TxtEntidadConsulta.Text, DtFecha.Value.Date);
            contratistaService.GenerarArchivoPorEstampillaFecha(TxtEntidadConsulta.Text, DtFecha.Value.Date);

        }
    }
}
