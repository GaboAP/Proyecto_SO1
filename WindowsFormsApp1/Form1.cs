using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int N = 3;
        private Cola[] Q;
        //Almacenar en variables globales: qCola,qProceso, y nPcbs quizá fue una mala
        //elección de estructuracion tomando en cuenta que estas variables se almacenan
        //en la clase cola y, aplican los mismos valores para todas, sin embargo 
        //deja abierta la posibilidad de manejar distintos q's para cada cola
        //(no lo cambié por falta de tiempo)
        int qCola = 1;
        int qProceso = 1;
        int nPCBs = 3;
        int cqp = 0;
        int cqc = 0;
        int k = 0;
        PCB PRUN;

        public Form1()
        {
            InitializeComponent();
            initQ();
            añadirFilas(dtgCola, nPCBs);
            añadirFilas(dtgVectorColas, N);
            añadirColumnas();
            rellenarDatosDtgCola(0);
            rellenarDatosDtgVectorColas();
        }
        public void initQ()//Inicializa el vector de Colas, por tanto, también ingresa los PCB's
        {
            Q = new Cola[N];
            Random PID = new Random();
            for (int i = 0; i < N; i++)
            {
                Q[i] = new Cola(qCola, qProceso);
                for (int j = 0; j < nPCBs; j++)
                {
                    Q[i].meter(new PCB(PID.Next(1, 1000), i, j + 1));
                }
            }
        }

        public void initPCBs(int nAnterior) //Inicializa(actualiza) la cantidad de PCBs x Cola
        {
            int diferencia = Math.Abs(nAnterior - nPCBs);
            Random PID = new Random();
            for (int j = 0; j < N; j++)
            {
                for (int i = 1; i <= diferencia; i++)
                {
                    if (nAnterior > nPCBs)
                    {
                        Q[j].sacar();
                    }
                    else
                    {
                        Q[j].meter(new PCB(PID.Next(1, 1000), j, Q[j].Length() + i));
                    }
                }
            }
        }

        private void pedirDatos()
        {
            int n = N;
            try
            {
                N = int.Parse(Interaction.InputBox("Ingrese la cantidad de Colas: ", "SetupScheduler"));
            }
            catch (Exception)//validacion
            {
                MessageBox.Show("No ha escrito un entero", "Error");
            }

            int qC = qCola;
            try
            {
                qCola = int.Parse(Interaction.InputBox("Ingrese los q x Colas: ", "SetupScheduler"));
            }
            catch (Exception)//validacion
            {
                MessageBox.Show("No ha escrito un entero", "Error");
            }
            int qP = qProceso;
            try
            {
                qProceso = int.Parse(Interaction.InputBox("Ingrese los q x Proceso: ", "SetupScheduler"));
            }
            catch (Exception)//validacion
            {
                MessageBox.Show("No ha escrito un entero", "Error");
            }
            int nP = nPCBs;
            try
            {
                nPCBs = int.Parse(Interaction.InputBox("Ingrese los PCBs x Cola ", "SetupScheduler"));
            }
            catch (Exception)//validacion
            {
                MessageBox.Show("No ha escrito un entero", "Error");
            }
            bool entra = false;
            if (n != N || qC != qCola || qP != qProceso)
            {
                /*Consideré mejor crear un nuevo vector de colas en caso de cualquiera de estos
                  elementos sean distintos a los de la previa estructura creada, ya que, controlar
                  la edición de solamente el elemento cambiado es muy tedioso*/
                initQ();
                entra = true;
            }
            if (nP != nPCBs && entra == false) //Controlo que no haya ya creado los PCB's
            {
                /*Creé este método en caso de que solamente los PCBs cambien de número, es una edición
                 que si consideré importante hacer ya que es fundamental, en caso de que deseemos la misma
                 estructura pero solo con más o menos PCBs, es importante no gastar memoria al pedo
                 (Tomado en cuenta desde el punto de vista de que es un simulador)*/
                initPCBs(nP);
            }
        }

        private void añadirFilas(DataGridView dtg, int cant)
        {
            dtg.RowCount = cant;
        }

        private void añadirColumnas()
        {
            int columnas = dtgVectorColas.ColumnCount - 1;
            if (columnas > nPCBs)
            {
                dtgVectorColas.ColumnCount = nPCBs + 1;
            }
            else
            {
                dtgVectorColas.ColumnCount = 1;
                for (int i = 1; i <= nPCBs; i++)
                {
                    String columnName = "Proceso" + i.ToString();
                    dtgVectorColas.Columns.Add(columnName, "");
                    DataGridViewColumn column = dtgVectorColas.Columns[i];
                    column.Width = 30;
                }
            }

        }

        private void setDatalbls()
        {
            Nlbl.Text = N.ToString();
            qxColalbl.Text = qCola.ToString();
            qxPCBlbl.Text = qProceso.ToString();
            pcbslbl.Text = nPCBs.ToString();
        }

        private void rellenarDatosDtgCola(int cola)
        {
            int numFilas = dtgCola.RowCount;
            int numColumnas = dtgCola.ColumnCount;
            for (int i = 0; i < Q[cola].Length(); i++)
            {
                PCB coso = Q[cola].sacar();
                dtgCola[0, i].Value = "P" + coso.getpNum().ToString();
                dtgCola[1, i].Value = coso.getPID().ToString();
                dtgCola[2, i].Value = coso.getPrioridad().ToString();
                Q[cola].meter(coso);
            }
            if (Q[cola].Length() < nPCBs)
            {
                for (int i = 0; i < 3; i++)
                {
                    dtgCola[i, nPCBs - 1].Value = "";
                }
            }
        }

        private void rellenarDatosDtgVectorColas()
        {
            int filas = dtgVectorColas.RowCount;
            int columnas = dtgVectorColas.ColumnCount;
            for (int fil = 0; fil < filas; fil++)
            {
                dtgVectorColas[0, fil].Style.BackColor = Color.White;
                dtgVectorColas[0, fil].Value = fil;
                for (int col = 1; col < columnas; col++)
                {
                    dtgVectorColas[col, fil].Value = "P" + col.ToString();
                }
            }
        }

        private void dibujarVectorColas()//Actualiza una row(una cola) del dtg derecho
        {
            for (int j = 0; j < Q.Length; j++)
            {
                dtgVectorColas[0, j].Style.BackColor = Color.White;
                for (int i = 1; i <= Q[j].Length(); i++)
                {
                    PCB coso = Q[j].sacar();
                    dtgVectorColas[i, j].Value = "P" + coso.getpNum();
                    Q[j].meter(coso);
                }
                if (Q[j].Length() < nPCBs)
                {
                    dtgVectorColas[nPCBs, j].Value = "";
                }
            }

        }

        private int nextK()
        {
            if (k < N - 1)
            {
                k++;
                return k;
            }
            return 0;
        }
        private void planificador()
        {
            cqp++;
            timer1.Interval = Q[k].getqProceso() * 1000;
            rellenarDatosDtgCola(k);
            dibujarVectorColas();
            actualizarlbls(PRUN);
            if (cqp == Q[k].getqProceso())
            {
                //Aquí vendría "PRUN.REG=CPU.REG;"
                int i = PRUN.getPrioridad();
                Q[i].meter(PRUN);
                cqc++;
                if (cqc == Q[k].getqCola())
                {
                    k = nextK();
                    cqc = 0;
                }
                PRUN = Q[k].sacar();
                /*^^ Mejora al algoritmo, es importante sacar el PCB de la cola ACTUAL, es
                 decir si cambiamos de cola, es mejor sacar el PCB de esa cola*/
                cqp = 0;
                //Aqui iria CPU.REG=PRUN.REG
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedirDatos();
            añadirFilas(dtgCola, nPCBs);
            añadirFilas(dtgVectorColas, N);
            añadirColumnas();
            setDatalbls();
            rellenarDatosDtgCola(0);
            rellenarDatosDtgVectorColas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDatalbls();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void actualizarlbls(PCB cosito)
        {
            String cola = "Q[" + cosito.getPrioridad().ToString() + "]";
            lblColaActual.Text = cola;
            lblPRUN.Text = cola + " - " + "P" + cosito.getpNum().ToString();
            dtgVectorColas[0, cosito.getPrioridad()].Style.BackColor = Color.Lime;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PRUN = Q[0].sacar();
            timer1.Start();
            timer1.Interval = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void dtgCola_SelectionChanged(object sender, EventArgs e)
        {
            dtgCola.ClearSelection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            planificador();

        }

        private void dtgVectorColas_SelectionChanged(object sender, EventArgs e)
        {
            dtgVectorColas.ClearSelection();
        }
    }
}
