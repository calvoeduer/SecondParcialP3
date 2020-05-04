using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contratista
    {

        public Contratista(string identificacion, string nombre, string impuestoEstampilla, DateTime fechaLiquidacion, decimal valorImpuesto)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            ImpuestodeEstampilla = impuestoEstampilla;
            FechaLiquidacion = fechaLiquidacion;
            ValorImpuesto = valorImpuesto;
        }

        
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string ImpuestodeEstampilla { get; set; }
        public DateTime FechaLiquidacion { get; set; }
        public decimal ValorImpuesto { get; set; }

    }
}
