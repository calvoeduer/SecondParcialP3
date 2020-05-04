using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ContratistaRepository
    {
        public string ruta = @"Contratista.txt";

        public List<Contratista> contratistas = new List<Contratista>();

        public void Guardar(Contratista contratista)
        {
            FileStream origenFlujo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(origenFlujo);
            escritor.WriteLine(contratista.Identificacion +";"+ contratista.No  mbre +";"+contratista.ImpuestodeEstampilla
                +";"+contratista.FechaLiquidacion.ToShortDateString()+";"+contratista.ValorImpuesto);
            escritor.Close();
            origenFlujo.Close();
        }


        public List<Contratista> BuscarEntidadFecha(string impuestodeEstampilla, DateTime fecha)
        {
            contratistas.Clear();
            contratistas = Consultar();
            return contratistas.Where(c => c.ImpuestodeEstampilla == impuestodeEstampilla && c.FechaLiquidacion.Month  == fecha.Month && c.FechaLiquidacion.Year == fecha.Year).ToList();
        }

        public List<Contratista> Consultar()
        {
            List<Contratista> contratistas = new List<Contratista>();
            FileStream origen = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(origen);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Contratista contratista = Mapear(linea);
                contratistas.Add(contratista);
            }
            reader.Close();
            origen.Close();
            return contratistas;
            
        }
        private Contratista Mapear(string linea)
        {
            string[] datos = linea.Split(';');
            Contratista recaudo = new Contratista(datos[0],datos[1], datos[2], DateTime.Parse(datos[3]), decimal.Parse(datos[4]));
          
            return recaudo;
        }

        public void GenerarArchivoPorEstampillaFecha(string impuestodeEstampilla, DateTime fecha)
        {
            List<Contratista> estampillasPorFecha = BuscarEntidadFecha(impuestodeEstampilla, fecha);
            if (estampillasPorFecha.Count == 0)
                return;
            FileStream origenFlujo = new FileStream($"{impuestodeEstampilla}{fecha.ToString("MMyyyy")}.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(origenFlujo);

            escritor.WriteLine($"{impuestodeEstampilla};{fecha.ToShortDateString()}") ; //escribe enntidad y fecha
            //suma valores de los impuestos de las estampillas y cuenta cuantos hay
            escritor.WriteLine($"{estampillasPorFecha.Sum(r => r.ValorImpuesto)};{estampillasPorFecha.Count}");

            //muestro todos los recaudos

            foreach (var estampilla in estampillasPorFecha)
            {
                escritor.WriteLine($"{estampilla.Identificacion};{estampilla.Nombre};{estampilla.FechaLiquidacion.ToShortDateString()};{estampilla.ValorImpuesto}");

            }
            escritor.Close();
        }

    }
}
