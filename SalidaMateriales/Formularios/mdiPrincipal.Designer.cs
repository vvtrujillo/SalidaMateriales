namespace SalidaMateriales.Formularios
{
    partial class mdiPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiPrincipal));
            this.sstPrincipal = new System.Windows.Forms.StatusStrip();
            this.Proceso = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraProgreso = new System.Windows.Forms.ToolStripProgressBar();
            this.Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.Perfil = new System.Windows.Forms.ToolStripStatusLabel();
            this.EstacionDeTrabajo = new System.Windows.Forms.ToolStripStatusLabel();
            this.Servidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.BaseDeDatos = new System.Windows.Forms.ToolStripStatusLabel();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSolicitudMateriales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSolicitudMaterialesForm = new System.Windows.Forms.ToolStripMenuItem();
            this.finToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActualizacionDeControles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalirSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sstPrincipal.SuspendLayout();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sstPrincipal
            // 
            this.sstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Proceso,
            this.BarraProgreso,
            this.Version,
            this.Usuario,
            this.Perfil,
            this.EstacionDeTrabajo,
            this.Servidor,
            this.BaseDeDatos});
            this.sstPrincipal.Location = new System.Drawing.Point(0, 450);
            this.sstPrincipal.Name = "sstPrincipal";
            this.sstPrincipal.Size = new System.Drawing.Size(1077, 33);
            this.sstPrincipal.TabIndex = 22;
            this.sstPrincipal.Text = "statusStrip1";
            // 
            // Proceso
            // 
            this.Proceso.AutoSize = false;
            this.Proceso.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.Proceso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceso.Name = "Proceso";
            this.Proceso.Size = new System.Drawing.Size(400, 28);
            this.Proceso.Text = "proceso";
            this.Proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarraProgreso
            // 
            this.BarraProgreso.AutoSize = false;
            this.BarraProgreso.Name = "BarraProgreso";
            this.BarraProgreso.Size = new System.Drawing.Size(150, 27);
            // 
            // Version
            // 
            this.Version.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Version.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(49, 28);
            this.Version.Text = "versión";
            // 
            // Usuario
            // 
            this.Usuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Usuario.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(50, 28);
            this.Usuario.Text = "usuario";
            // 
            // Perfil
            // 
            this.Perfil.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(38, 28);
            this.Perfil.Text = "Perfil";
            // 
            // EstacionDeTrabajo
            // 
            this.EstacionDeTrabajo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.EstacionDeTrabajo.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.EstacionDeTrabajo.Name = "EstacionDeTrabajo";
            this.EstacionDeTrabajo.Size = new System.Drawing.Size(55, 28);
            this.EstacionDeTrabajo.Text = "estación";
            // 
            // Servidor
            // 
            this.Servidor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(54, 28);
            this.Servidor.Text = "Servidor";
            this.Servidor.Visible = false;
            // 
            // BaseDeDatos
            // 
            this.BaseDeDatos.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.BaseDeDatos.Name = "BaseDeDatos";
            this.BaseDeDatos.Size = new System.Drawing.Size(79, 28);
            this.BaseDeDatos.Text = "BaseDeDatos";
            this.BaseDeDatos.Visible = false;
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmParametros,
            this.materialesToolStripMenuItem,
            this.tsmSolicitudMateriales,
            this.finToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1077, 24);
            this.msPrincipal.TabIndex = 24;
            this.msPrincipal.Text = "Menú principal del Sistema de Gestión Integrado";
            // 
            // tsmParametros
            // 
            this.tsmParametros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConfiguracion});
            this.tsmParametros.Name = "tsmParametros";
            this.tsmParametros.Size = new System.Drawing.Size(79, 20);
            this.tsmParametros.Tag = "-";
            this.tsmParametros.Text = "Parámetros";
            // 
            // tsmConfiguracion
            // 
            this.tsmConfiguracion.Name = "tsmConfiguracion";
            this.tsmConfiguracion.Size = new System.Drawing.Size(150, 22);
            this.tsmConfiguracion.Tag = "fConfiguracion";
            this.tsmConfiguracion.Text = "Configuración";
            this.tsmConfiguracion.Click += new System.EventHandler(this.tsmConfiguracion_Click);
            // 
            // tsmSolicitudMateriales
            // 
            this.tsmSolicitudMateriales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSolicitudMaterialesForm});
            this.tsmSolicitudMateriales.Name = "tsmSolicitudMateriales";
            this.tsmSolicitudMateriales.Size = new System.Drawing.Size(138, 20);
            this.tsmSolicitudMateriales.Tag = "-";
            this.tsmSolicitudMateriales.Text = "Solicitud de Materiales";
            // 
            // tsmSolicitudMaterialesForm
            // 
            this.tsmSolicitudMaterialesForm.Name = "tsmSolicitudMaterialesForm";
            this.tsmSolicitudMaterialesForm.Size = new System.Drawing.Size(193, 22);
            this.tsmSolicitudMaterialesForm.Tag = "fAuditoria";
            this.tsmSolicitudMaterialesForm.Text = "Solicitud de Materiales";
            this.tsmSolicitudMaterialesForm.Click += new System.EventHandler(this.tsmSolicitudMaterialesForm_Click);
            // 
            // finToolStripMenuItem
            // 
            this.finToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAcercaDe,
            this.tsmActualizacionDeControles,
            this.toolStripSeparator1,
            this.tsmCerrarSesion,
            this.tsmSalirSistema});
            this.finToolStripMenuItem.Name = "finToolStripMenuItem";
            this.finToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.finToolStripMenuItem.Tag = "-";
            this.finToolStripMenuItem.Text = "Fin";
            // 
            // tsmAcercaDe
            // 
            this.tsmAcercaDe.Name = "tsmAcercaDe";
            this.tsmAcercaDe.Size = new System.Drawing.Size(213, 22);
            this.tsmAcercaDe.Tag = "-";
            this.tsmAcercaDe.Text = "Acerca de";
            // 
            // tsmActualizacionDeControles
            // 
            this.tsmActualizacionDeControles.Name = "tsmActualizacionDeControles";
            this.tsmActualizacionDeControles.Size = new System.Drawing.Size(213, 22);
            this.tsmActualizacionDeControles.Tag = "fActualizaControlAcceso";
            this.tsmActualizacionDeControles.Text = "Actualizacion de controles";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(213, 22);
            this.tsmCerrarSesion.Tag = "-";
            this.tsmCerrarSesion.Text = "Cerrar sesión";
            // 
            // tsmSalirSistema
            // 
            this.tsmSalirSistema.Name = "tsmSalirSistema";
            this.tsmSalirSistema.Size = new System.Drawing.Size(213, 22);
            this.tsmSalirSistema.Tag = "-";
            this.tsmSalirSistema.Text = "Salir del sistema";
            // 
            // materialesToolStripMenuItem
            // 
            this.materialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoMaterialesToolStripMenuItem});
            this.materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            this.materialesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.materialesToolStripMenuItem.Text = "Materiales";
            // 
            // ingresoMaterialesToolStripMenuItem
            // 
            this.ingresoMaterialesToolStripMenuItem.Name = "ingresoMaterialesToolStripMenuItem";
            this.ingresoMaterialesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ingresoMaterialesToolStripMenuItem.Text = "Ingreso Materiales";
            this.ingresoMaterialesToolStripMenuItem.Click += new System.EventHandler(this.ingresoMaterialesToolStripMenuItem_Click);
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 483);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.sstPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "mdiPrincipal";
            this.Text = "Solicitud de Material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiPrincipal_Load);
            this.sstPrincipal.ResumeLayout(false);
            this.sstPrincipal.PerformLayout();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sstPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel Proceso;
        private System.Windows.Forms.ToolStripProgressBar BarraProgreso;
        private System.Windows.Forms.ToolStripStatusLabel Version;
        private System.Windows.Forms.ToolStripStatusLabel Usuario;
        private System.Windows.Forms.ToolStripStatusLabel Perfil;
        private System.Windows.Forms.ToolStripStatusLabel EstacionDeTrabajo;
        private System.Windows.Forms.ToolStripStatusLabel Servidor;
        private System.Windows.Forms.ToolStripStatusLabel BaseDeDatos;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmParametros;
        private System.Windows.Forms.ToolStripMenuItem tsmConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem tsmSolicitudMateriales;
        private System.Windows.Forms.ToolStripMenuItem tsmSolicitudMaterialesForm;
        private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizacionDeControles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalirSistema;
        private System.Windows.Forms.ToolStripMenuItem materialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoMaterialesToolStripMenuItem;
    }
}