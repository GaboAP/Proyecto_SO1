namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qxColalbl = new System.Windows.Forms.Label();
            this.qxPCBlbl = new System.Windows.Forms.Label();
            this.pcbslbl = new System.Windows.Forms.Label();
            this.dtgCola = new System.Windows.Forms.DataGridView();
            this.nProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startScheduler = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgVectorColas = new System.Windows.Forms.DataGridView();
            this.Cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblColaActual = new System.Windows.Forms.Label();
            this.lblPRUN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVectorColas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Setup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NColas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nlbl
            // 
            this.Nlbl.AutoSize = true;
            this.Nlbl.Location = new System.Drawing.Point(329, 9);
            this.Nlbl.Name = "Nlbl";
            this.Nlbl.Size = new System.Drawing.Size(35, 13);
            this.Nlbl.TabIndex = 3;
            this.Nlbl.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "qxCola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "qxPCB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "PCBs:";
            // 
            // qxColalbl
            // 
            this.qxColalbl.AutoSize = true;
            this.qxColalbl.Location = new System.Drawing.Point(419, 9);
            this.qxColalbl.Name = "qxColalbl";
            this.qxColalbl.Size = new System.Drawing.Size(35, 13);
            this.qxColalbl.TabIndex = 7;
            this.qxColalbl.Text = "label6";
            // 
            // qxPCBlbl
            // 
            this.qxPCBlbl.AutoSize = true;
            this.qxPCBlbl.Location = new System.Drawing.Point(506, 9);
            this.qxPCBlbl.Name = "qxPCBlbl";
            this.qxPCBlbl.Size = new System.Drawing.Size(35, 13);
            this.qxPCBlbl.TabIndex = 8;
            this.qxPCBlbl.Text = "label7";
            // 
            // pcbslbl
            // 
            this.pcbslbl.AutoSize = true;
            this.pcbslbl.Location = new System.Drawing.Point(595, 9);
            this.pcbslbl.Name = "pcbslbl";
            this.pcbslbl.Size = new System.Drawing.Size(19, 13);
            this.pcbslbl.TabIndex = 9;
            this.pcbslbl.Text = "da";
            // 
            // dtgCola
            // 
            this.dtgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nProceso,
            this.PID,
            this.Prioridad});
            this.dtgCola.Location = new System.Drawing.Point(26, 35);
            this.dtgCola.Name = "dtgCola";
            this.dtgCola.Size = new System.Drawing.Size(184, 376);
            this.dtgCola.TabIndex = 10;
            this.dtgCola.SelectionChanged += new System.EventHandler(this.dtgCola_SelectionChanged);
            // 
            // nProceso
            // 
            this.nProceso.HeaderText = "P#";
            this.nProceso.Name = "nProceso";
            this.nProceso.Width = 30;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.Width = 50;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Width = 60;
            // 
            // startScheduler
            // 
            this.startScheduler.Location = new System.Drawing.Point(509, 415);
            this.startScheduler.Name = "startScheduler";
            this.startScheduler.Size = new System.Drawing.Size(91, 25);
            this.startScheduler.TabIndex = 11;
            this.startScheduler.Text = "Iniciar";
            this.startScheduler.UseVisualStyleBackColor = true;
            this.startScheduler.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(628, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 24);
            this.button3.TabIndex = 12;
            this.button3.Text = "Detener";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgVectorColas
            // 
            this.dtgVectorColas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVectorColas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cola});
            this.dtgVectorColas.Location = new System.Drawing.Point(242, 33);
            this.dtgVectorColas.Name = "dtgVectorColas";
            this.dtgVectorColas.Size = new System.Drawing.Size(537, 319);
            this.dtgVectorColas.TabIndex = 13;
            this.dtgVectorColas.SelectionChanged += new System.EventHandler(this.dtgVectorColas_SelectionChanged);
            // 
            // Cola
            // 
            this.Cola.HeaderText = "Cola#";
            this.Cola.Name = "Cola";
            this.Cola.Width = 50;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblColaActual
            // 
            this.lblColaActual.AutoSize = true;
            this.lblColaActual.BackColor = System.Drawing.Color.Lime;
            this.lblColaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaActual.Location = new System.Drawing.Point(89, 9);
            this.lblColaActual.Name = "lblColaActual";
            this.lblColaActual.Size = new System.Drawing.Size(46, 17);
            this.lblColaActual.TabIndex = 14;
            this.lblColaActual.Text = "label2";
            // 
            // lblPRUN
            // 
            this.lblPRUN.AutoSize = true;
            this.lblPRUN.BackColor = System.Drawing.Color.Lime;
            this.lblPRUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRUN.Location = new System.Drawing.Point(251, 364);
            this.lblPRUN.Name = "lblPRUN";
            this.lblPRUN.Size = new System.Drawing.Size(64, 25);
            this.lblPRUN.TabIndex = 15;
            this.lblPRUN.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "PRUN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPRUN);
            this.Controls.Add(this.lblColaActual);
            this.Controls.Add(this.dtgVectorColas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.startScheduler);
            this.Controls.Add(this.dtgCola);
            this.Controls.Add(this.pcbslbl);
            this.Controls.Add(this.qxPCBlbl);
            this.Controls.Add(this.qxColalbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVectorColas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label qxColalbl;
        private System.Windows.Forms.Label qxPCBlbl;
        private System.Windows.Forms.Label pcbslbl;
        private System.Windows.Forms.DataGridView dtgCola;
        private System.Windows.Forms.Button startScheduler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgVectorColas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblColaActual;
        private System.Windows.Forms.Label lblPRUN;
        private System.Windows.Forms.Label label6;
    }
}

