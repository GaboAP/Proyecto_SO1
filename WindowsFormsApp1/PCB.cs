using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PCB
    {
        private int PID;
        private int prioridad;
        private int pNum;
        
        public PCB(int pid,int priority,int pNUM)
        {
            this.PID = pid;
            this.prioridad = priority;
            pNum = pNUM;
        }
        public int getpNum()
        {
            return pNum;
        }

        public int getPrioridad()
        {
            return prioridad;
        }

        public int getPID()
        {
            return PID;
        }
    }
}
