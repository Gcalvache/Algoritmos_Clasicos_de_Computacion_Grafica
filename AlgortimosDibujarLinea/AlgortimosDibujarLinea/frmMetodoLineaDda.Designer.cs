namespace AlgortimosDibujarLinea
{
    partial class frmMetodoLineaDda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGrafico = new System.Windows.Forms.GroupBox();
            this.pcbGrafico = new System.Windows.Forms.PictureBox();
            this.grpInicial = new System.Windows.Forms.GroupBox();
            this.txtYi = new System.Windows.Forms.TextBox();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.lblYi = new System.Windows.Forms.Label();
            this.lblXi = new System.Windows.Forms.Label();
            this.grpFinal = new System.Windows.Forms.GroupBox();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.lblYf = new System.Windows.Forms.Label();
            this.lblXf = new System.Windows.Forms.Label();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.trkZoom = new System.Windows.Forms.TrackBar();
            this.grpSalida = new System.Windows.Forms.GroupBox();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrafico)).BeginInit();
            this.grpInicial.SuspendLayout();
            this.grpFinal.SuspendLayout();
            this.grpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkZoom)).BeginInit();
            this.grpSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(345, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de entrada";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // grpGrafico
            // 
            this.grpGrafico.Controls.Add(this.pcbGrafico);
            this.grpGrafico.Location = new System.Drawing.Point(448, 30);
            this.grpGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGrafico.Name = "grpGrafico";
            this.grpGrafico.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGrafico.Size = new System.Drawing.Size(603, 420);
            this.grpGrafico.TabIndex = 2;
            this.grpGrafico.TabStop = false;
            this.grpGrafico.Text = "GRAFICO";
            // 
            // pcbGrafico
            // 
            this.pcbGrafico.Location = new System.Drawing.Point(9, 25);
            this.pcbGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbGrafico.Name = "pcbGrafico";
            this.pcbGrafico.Size = new System.Drawing.Size(585, 367);
            this.pcbGrafico.TabIndex = 0;
            this.pcbGrafico.TabStop = false;
            this.pcbGrafico.Click += new System.EventHandler(this.pcbGrafico_Click);
            // 
            // grpInicial
            // 
            this.grpInicial.Controls.Add(this.txtYi);
            this.grpInicial.Controls.Add(this.txtXi);
            this.grpInicial.Controls.Add(this.lblYi);
            this.grpInicial.Controls.Add(this.lblXi);
            this.grpInicial.Location = new System.Drawing.Point(32, 30);
            this.grpInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInicial.Name = "grpInicial";
            this.grpInicial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInicial.Size = new System.Drawing.Size(381, 124);
            this.grpInicial.TabIndex = 0;
            this.grpInicial.TabStop = false;
            this.grpInicial.Text = "COOORDENADAS INICIALES";
            this.grpInicial.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtYi
            // 
            this.txtYi.Location = new System.Drawing.Point(80, 69);
            this.txtYi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYi.Name = "txtYi";
            this.txtYi.Size = new System.Drawing.Size(235, 22);
            this.txtYi.TabIndex = 2;
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(79, 34);
            this.txtXi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(235, 22);
            this.txtXi.TabIndex = 2;
            // 
            // lblYi
            // 
            this.lblYi.AutoSize = true;
            this.lblYi.Location = new System.Drawing.Point(36, 70);
            this.lblYi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYi.Name = "lblYi";
            this.lblYi.Size = new System.Drawing.Size(23, 16);
            this.lblYi.TabIndex = 1;
            this.lblYi.Text = "Y=";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(36, 39);
            this.lblXi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(22, 16);
            this.lblXi.TabIndex = 0;
            this.lblXi.Text = "X=";
            // 
            // grpFinal
            // 
            this.grpFinal.Controls.Add(this.txtYf);
            this.grpFinal.Controls.Add(this.txtXf);
            this.grpFinal.Controls.Add(this.lblYf);
            this.grpFinal.Controls.Add(this.lblXf);
            this.grpFinal.Location = new System.Drawing.Point(32, 174);
            this.grpFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFinal.Name = "grpFinal";
            this.grpFinal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFinal.Size = new System.Drawing.Size(381, 122);
            this.grpFinal.TabIndex = 0;
            this.grpFinal.TabStop = false;
            this.grpFinal.Text = "COORDENADAS FINALES";
            // 
            // txtYf
            // 
            this.txtYf.Location = new System.Drawing.Point(80, 69);
            this.txtYf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(235, 22);
            this.txtYf.TabIndex = 2;
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(79, 34);
            this.txtXf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(235, 22);
            this.txtXf.TabIndex = 2;
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(36, 71);
            this.lblYf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(23, 16);
            this.lblYf.TabIndex = 1;
            this.lblYf.Text = "Y=";
            this.lblYf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(37, 37);
            this.lblXf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(22, 16);
            this.lblXf.TabIndex = 0;
            this.lblXf.Text = "X=";
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.btnSalir);
            this.grpOpciones.Controls.Add(this.btnLimpiar);
            this.grpOpciones.Controls.Add(this.btnCalcular);
            this.grpOpciones.Location = new System.Drawing.Point(31, 315);
            this.grpOpciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOpciones.Size = new System.Drawing.Size(383, 89);
            this.grpOpciones.TabIndex = 0;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "OPCIONES";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(266, 41);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(139, 41);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(11, 41);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(453, 453);
            this.lblZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(79, 16);
            this.lblZoom.TabIndex = 4;
            this.lblZoom.Text = "Zoom: 10 px";
            // 
            // trkZoom
            // 
            this.trkZoom.Location = new System.Drawing.Point(457, 473);
            this.trkZoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkZoom.Maximum = 100;
            this.trkZoom.Minimum = 2;
            this.trkZoom.Name = "trkZoom";
            this.trkZoom.Size = new System.Drawing.Size(331, 56);
            this.trkZoom.TabIndex = 3;
            this.trkZoom.Value = 10;
            // 
            // grpSalida
            // 
            this.grpSalida.Controls.Add(this.txtPendiente);
            this.grpSalida.Controls.Add(this.lblPendiente);
            this.grpSalida.Location = new System.Drawing.Point(42, 425);
            this.grpSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSalida.Name = "grpSalida";
            this.grpSalida.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSalida.Size = new System.Drawing.Size(381, 86);
            this.grpSalida.TabIndex = 0;
            this.grpSalida.TabStop = false;
            this.grpSalida.Text = "SALIDA";
            // 
            // txtPendiente
            // 
            this.txtPendiente.Location = new System.Drawing.Point(123, 31);
            this.txtPendiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(235, 22);
            this.txtPendiente.TabIndex = 2;
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Location = new System.Drawing.Point(23, 34);
            this.lblPendiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(88, 16);
            this.lblPendiente.TabIndex = 0;
            this.lblPendiente.Text = "PENDIENTE:";
            // 
            // frmMetodoLineaDda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 534);
            this.Controls.Add(this.trkZoom);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.grpGrafico);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.grpSalida);
            this.Controls.Add(this.grpFinal);
            this.Controls.Add(this.grpInicial);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMetodoLineaDda";
            this.Text = "Trazado de Linea-DDA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrafico)).EndInit();
            this.grpInicial.ResumeLayout(false);
            this.grpInicial.PerformLayout();
            this.grpFinal.ResumeLayout(false);
            this.grpFinal.PerformLayout();
            this.grpOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkZoom)).EndInit();
            this.grpSalida.ResumeLayout(false);
            this.grpSalida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGrafico;
        private System.Windows.Forms.PictureBox pcbGrafico;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpInicial;
        private System.Windows.Forms.TextBox txtYi;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label lblYi;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.GroupBox grpFinal;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.TrackBar trkZoom;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpSalida;
        private System.Windows.Forms.TextBox txtPendiente;
        private System.Windows.Forms.Label lblPendiente;
    }
}

