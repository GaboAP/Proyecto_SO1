using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cola
    {
        private Queue<PCB> Q;
        private int qxCola;
        private int qxProceso;

        public Cola(int qxCola, int qxProceso)
        {
            Q = new Queue<PCB>();
            this.qxCola = qxCola;
            this.qxProceso = qxProceso;
        }
        public int getqProceso()
        {
            return qxProceso;
        }
        public int Length()
        {
            return Q.Count();
        }
        public int getqCola()
        {
            return qxCola;
        }

        public PCB sacar()
        {
            return Q.Dequeue();
        }

        public void meter(PCB P)
        {
            Q.Enqueue(P);
        }

    }
}
