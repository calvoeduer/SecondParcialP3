using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ContratistaService
    {
        public static ContratistaRepository contratistaRepository = new ContratistaRepository();
        public string Guardar(Contratista contratista)
        {
            contratistaRepository.Guardar(contratista);
            return $"Guardado";

        }

        public List<Contratista> BuscarEntidadFecha(string impuestodeEstampilla, DateTime fecha)
        {
            return contratistaRepository.BuscarEntidadFecha(impuestodeEstampilla, fecha);
        }

        public List<Contratista> Consultar()
        {
            return contratistaRepository.Consultar();
        }

        public void GenerarArchivoPorEstampillaFecha(string impuestodeEstampilla, DateTime fecha)
        {
            contratistaRepository.GenerarArchivoPorEstampillaFecha(impuestodeEstampilla,fecha);
        }
    }
}
