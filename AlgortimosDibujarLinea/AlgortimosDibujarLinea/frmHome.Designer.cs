namespace AlgortimosDibujarLinea
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoBresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoPuntoMedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanlineSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteDeLineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cohenSutherlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liangBarskyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nichollLeeNichollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorteDePoligonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sutherlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineasToolStripMenuItem,
            this.circuloToolStripMenuItem,
            this.rellenoToolStripMenuItem,
            this.recorteDeLineasToolStripMenuItem,
            this.recorteDePoligonosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lineasToolStripMenuItem
            // 
            this.lineasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.metodoBresenhamToolStripMenuItem,
            this.metodoPuntoMedioToolStripMenuItem});
            this.lineasToolStripMenuItem.Name = "lineasToolStripMenuItem";
            this.lineasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lineasToolStripMenuItem.Text = "Lineas";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dDAToolStripMenuItem.Text = "Metodo DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // metodoBresenhamToolStripMenuItem
            // 
            this.metodoBresenhamToolStripMenuItem.Name = "metodoBresenhamToolStripMenuItem";
            this.metodoBresenhamToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.metodoBresenhamToolStripMenuItem.Text = "Metodo Bresenham";
            this.metodoBresenhamToolStripMenuItem.Click += new System.EventHandler(this.metodoBresenhamToolStripMenuItem_Click);
            // 
            // metodoPuntoMedioToolStripMenuItem
            // 
            this.metodoPuntoMedioToolStripMenuItem.Name = "metodoPuntoMedioToolStripMenuItem";
            this.metodoPuntoMedioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.metodoPuntoMedioToolStripMenuItem.Text = "Metodo Punto Medio";
            this.metodoPuntoMedioToolStripMenuItem.Click += new System.EventHandler(this.metodoPuntoMedioToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuloToolStripMenuItem1,
            this.bresenhamToolStripMenuItem,
            this.polarToolStripMenuItem});
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.circuloToolStripMenuItem.Text = "Circulo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem1
            // 
            this.circuloToolStripMenuItem1.Name = "circuloToolStripMenuItem1";
            this.circuloToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.circuloToolStripMenuItem1.Text = "Punto Medio";
            this.circuloToolStripMenuItem1.Click += new System.EventHandler(this.circuloToolStripMenuItem1_Click);
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.bresenhamToolStripMenuItem.Text = "Bresenham";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // polarToolStripMenuItem
            // 
            this.polarToolStripMenuItem.Name = "polarToolStripMenuItem";
            this.polarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.polarToolStripMenuItem.Text = "Polar";
            this.polarToolStripMenuItem.Click += new System.EventHandler(this.polarToolStripMenuItem_Click);
            // 
            // rellenoToolStripMenuItem
            // 
            this.rellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boundaryToolStripMenuItem,
            this.floodToolStripMenuItem,
            this.scanlineSeedToolStripMenuItem});
            this.rellenoToolStripMenuItem.Name = "rellenoToolStripMenuItem";
            this.rellenoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.rellenoToolStripMenuItem.Text = "Relleno";
            // 
            // boundaryToolStripMenuItem
            // 
            this.boundaryToolStripMenuItem.Name = "boundaryToolStripMenuItem";
            this.boundaryToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.boundaryToolStripMenuItem.Text = "Boundary";
            this.boundaryToolStripMenuItem.Click += new System.EventHandler(this.boundaryToolStripMenuItem_Click);
            // 
            // floodToolStripMenuItem
            // 
            this.floodToolStripMenuItem.Name = "floodToolStripMenuItem";
            this.floodToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.floodToolStripMenuItem.Text = "Flood";
            this.floodToolStripMenuItem.Click += new System.EventHandler(this.floodToolStripMenuItem_Click);
            // 
            // scanlineSeedToolStripMenuItem
            // 
            this.scanlineSeedToolStripMenuItem.Name = "scanlineSeedToolStripMenuItem";
            this.scanlineSeedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.scanlineSeedToolStripMenuItem.Text = "Scanline Seed";
            this.scanlineSeedToolStripMenuItem.Click += new System.EventHandler(this.scanlineSeedToolStripMenuItem_Click);
            // 
            // recorteDeLineasToolStripMenuItem
            // 
            this.recorteDeLineasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cohenSutherlandToolStripMenuItem,
            this.liangBarskyToolStripMenuItem,
            this.nichollLeeNichollToolStripMenuItem});
            this.recorteDeLineasToolStripMenuItem.Name = "recorteDeLineasToolStripMenuItem";
            this.recorteDeLineasToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.recorteDeLineasToolStripMenuItem.Text = "Recorte de Lineas";
            // 
            // cohenSutherlandToolStripMenuItem
            // 
            this.cohenSutherlandToolStripMenuItem.Name = "cohenSutherlandToolStripMenuItem";
            this.cohenSutherlandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cohenSutherlandToolStripMenuItem.Text = "Cohen–Sutherland";
            this.cohenSutherlandToolStripMenuItem.Click += new System.EventHandler(this.cohenSutherlandToolStripMenuItem_Click);
            // 
            // liangBarskyToolStripMenuItem
            // 
            this.liangBarskyToolStripMenuItem.Name = "liangBarskyToolStripMenuItem";
            this.liangBarskyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.liangBarskyToolStripMenuItem.Text = "Liang–Barsky";
            this.liangBarskyToolStripMenuItem.Click += new System.EventHandler(this.liangBarskyToolStripMenuItem_Click);
            // 
            // nichollLeeNichollToolStripMenuItem
            // 
            this.nichollLeeNichollToolStripMenuItem.Name = "nichollLeeNichollToolStripMenuItem";
            this.nichollLeeNichollToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nichollLeeNichollToolStripMenuItem.Text = "Nicholl–Lee–Nicholl";
            this.nichollLeeNichollToolStripMenuItem.Click += new System.EventHandler(this.nichollLeeNichollToolStripMenuItem_Click);
            // 
            // recorteDePoligonosToolStripMenuItem
            // 
            this.recorteDePoligonosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greinerToolStripMenuItem,
            this.sutherlandToolStripMenuItem,
            this.weilerToolStripMenuItem});
            this.recorteDePoligonosToolStripMenuItem.Name = "recorteDePoligonosToolStripMenuItem";
            this.recorteDePoligonosToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.recorteDePoligonosToolStripMenuItem.Text = "Recorte de Poligonos";
            // 
            // sutherlandToolStripMenuItem
            // 
            this.sutherlandToolStripMenuItem.Name = "sutherlandToolStripMenuItem";
            this.sutherlandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sutherlandToolStripMenuItem.Text = "Sutherland";
            this.sutherlandToolStripMenuItem.Click += new System.EventHandler(this.sutherlandToolStripMenuItem_Click);
            // 
            // weilerToolStripMenuItem
            // 
            this.weilerToolStripMenuItem.Name = "weilerToolStripMenuItem";
            this.weilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.weilerToolStripMenuItem.Text = "Weiler";
            this.weilerToolStripMenuItem.Click += new System.EventHandler(this.weilerToolStripMenuItem_Click);
            // 
            // greinerToolStripMenuItem
            // 
            this.greinerToolStripMenuItem.Name = "greinerToolStripMenuItem";
            this.greinerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greinerToolStripMenuItem.Text = "Greiner";
            this.greinerToolStripMenuItem.Click += new System.EventHandler(this.greinerToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoBresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoPuntoMedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteDeLineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteDePoligonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boundaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanlineSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cohenSutherlandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liangBarskyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nichollLeeNichollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sutherlandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weilerToolStripMenuItem;
    }
}