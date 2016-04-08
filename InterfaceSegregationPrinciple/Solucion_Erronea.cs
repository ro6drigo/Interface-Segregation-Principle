using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple1
{
    public abstract class Proceso
    {
        public abstract void Iniciar();
        public abstract void Suspender();
        public abstract void Reanudar();
        public abstract void Finalizar();
    }
}


namespace InterfaceSegregationPrinciple2
{
    using InterfaceSegregationPrinciple1;

    public class ProcesoManual1 : Proceso
    {
        public override void Iniciar()
        {
            //...
        }
        public override void Suspender()
        {
            //...
        }
        public override void Reanudar()
        {
            //...
        }
        public override void Finalizar()
        {
            //...
        }
    }

    public class ProcesoAutomaizado1 : Proceso
    {
        public override void Iniciar()
        {
            //...
        }
        public override void Suspender()
        {
            throw new NotImplementedException();
        }
        public override void Reanudar()
        {
            throw new NotImplementedException();
        }
        public override void Finalizar()
        {
            //...
        }
    }
}