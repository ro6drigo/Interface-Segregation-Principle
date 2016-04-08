using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    // Interfaz que deben cumplir los trabajos que 
    // se realicen de forma manual
    public interface IManual
    {
        void Suspender();
        void Reiniciar();
    }

    // Clase Base que contiene la plantilla, los metodos 
    // que deben implementar todas las clases 
    // que representen a un proceso
    public abstract class Proceso
    {
        public abstract void Iniciar();
        public abstract void Finalizar();
    }


    // Clase que hereda de la clase base [Proceso]
    // Observa el modificador [override]
    // y que implementa la interfaz [IManual]
    public class ProcesoManual : Proceso, IManual
    {
        public override void Iniciar()
        {
           Console.WriteLine("Proceso Manual 1 -> Iniciar");
        }
        public void Suspender(){
            Console.WriteLine("Proceso Manual 1 -> Suspender");
        }
        public void Reiniciar(){
            Console.WriteLine("Proceso Manual 1 -> Reiniciar");
        }
        public override void Finalizar()
        {
            Console.WriteLine("Proceso Manual 1 -> Finalizar");
        }
    }


    // Clase que hereda de la clase base [Proceso]
    // Observa el modificador [override]
    public class ProcesoAutomaizado : Proceso
    {
        public override void Iniciar()
        {
            Console.WriteLine("Proceso Automatizado 1 -> Iniciar");
        }
        public override void Finalizar()
        {
            Console.WriteLine("Proceso Automatizado 1 -> Finalizar");
        }
    }
}
