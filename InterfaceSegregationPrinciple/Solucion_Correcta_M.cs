using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple1
{
    //----------------------------------
    // Interfaz que deben cumplir los trabajos que 
    // se realicen de forma manual (por personas)
    public interface IManual
    {
        void Suspender();
        void Reiniciar();
    }

    //----------------------------------
    // Interfaz que debe cumplir CUALQUIER TIPO de trabajo
    public interface IProceso
    {
        void Iniciar();
        void Finalizar();
    }
}

namespace InterfaceSegregationPrinciple2
{
    using InterfaceSegregationPrinciple1;

    //----------------------------------
    // Clase que representa a un proceso realizado por personas
    // Implementa la interfaz [IProceso] correspondiente a cualquier proceso
    // e implementa la interfaz [IManual] procesos realizados por personas
    public class ProcesoManual : IProceso, IManual
    {
        public void Iniciar()
        {
            Console.WriteLine("Proceso Manual 2 -> Iniciar");
        }
        public void Suspender()
        {
            Console.WriteLine("Proceso Manual 2 -> Suspender");
        }
        public void Reiniciar()
        {
            Console.WriteLine("Proceso Manual 2 -> Reiniciar");
        }
        public void Finalizar(){
            Console.WriteLine("Proceso Manual 2 -> Finalizar");
        }
    }


    //----------------------------------
    // Clase que representa a un proceso realizado por maquinas
    // Implementa la interfaz [IProceso] correspondiente a cualquier proceso
    public class ProcesoAutomatizado : IProceso
    {
        public void Iniciar()
        {
            Console.WriteLine("Proceso Automatizado 2 -> Iniciar");
        }
        public void Finalizar()
        {
            Console.WriteLine("Proceso Automatizado 2 -> Finalizar");
        }
    }


    //----------------------------------
    // Una clase para manejar procesos
    public class GerenteProcesos
    {
        // Campo de la clase que guarda la referencia a la interfaz [IProceso]
        // Este valor se tiene que proporcionar a través del constructor
        // La palabra clave readonly corresponde a un modificador que 
        // se puede utilizar en campos. 
        // Cuando una declaración de campo incluye un modificador readonly,
        // las asignaciones a los campos que aparecen en la declaración
        // sólo pueden tener lugar en la propia declaración o
        // en un constructor de la misma clase.
        private readonly IProceso unProceso;

        // Constructor
        public GerenteProcesos(IProceso w)
        {
            unProceso = w;
        }

        // propiedad para leer el proceso que está almacenado en la clase
        public IProceso Proceso
        {
            get
            {
                return unProceso;
            }
        }

        // Poner en ejecución el proceso
        public void Gestionar()
        {
            unProceso.Iniciar();
            //unProceso.Suspender(); // provoca un error
            //unProceso.Reiniciar(); // provoca un error
            unProceso.Finalizar();

        }
    }


    //----------------------------------
    // Clase para probar las clases anteriores
    public class Test
    {
        public void TestGerente()
        {
            ProcesoManual PM1 = new ProcesoManual();
            ProcesoAutomatizado PA1 = new ProcesoAutomatizado();

            GerenteProcesos GP1 = new GerenteProcesos(PM1);
            GP1.Gestionar();

            GerenteProcesos GP2 = new GerenteProcesos(PA1);
            GP2.Gestionar();
        }
    }

}
