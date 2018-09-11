namespace SalidaMateriales.Formularios.Materiales
{
    partial class fIngresoMaterial
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
            this.btnBusqArticuloBodega = new System.Windows.Forms.Button();
            this.txtArtBodegaNombre = new System.Windows.Forms.TextBox();
            this.cmbTipoArticuloBodega = new System.Windows.Forms.ComboBox();
            this.lblTipoArticuloBodega = new System.Windows.Forms.Label();
            this.txtUnidadMedidaIngM = new System.Windows.Forms.TextBox();
            this.lblUnidadMedidaIngM = new System.Windows.Forms.Label();
            this.tsIngresoMatBodega = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarIngM = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabarIngM = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.lblCantidadIngM = new System.Windows.Forms.Label();
            this.txtCantidadIngM = new System.Windows.Forms.TextBox();
            this.tsIngresoMatBodega.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBusqArticuloBodega
            // 
            this.btnBusqArticuloBodega.Image = global::SalidaMateriales.Properties.Resources.search;
            this.btnBusqArticuloBodega.Location = new System.Drawing.Point(56, 74);
            this.btnBusqArticuloBodega.Name = "btnBusqArticuloBodega";
            this.btnBusqArticuloBodega.Size = new System.Drawing.Size(28, 25);
            this.btnBusqArticuloBodega.TabIndex = 93;
            this.btnBusqArticuloBodega.UseVisualStyleBackColor = true;
            this.btnBusqArticuloBodega.Click += new System.EventHandler(this.btnBusqArticuloBodega_Click);
            // 
            // txtArtBodegaNombre
            // 
            this.txtArtBodegaNombre.Enabled = false;
            this.txtArtBodegaNombre.Location = new System.Drawing.Point(90, 74);
            this.txtArtBodegaNombre.Name = "txtArtBodegaNombre";
            this.txtArtBodegaNombre.Size = new System.Drawing.Size(361, 25);
            this.txtArtBodegaNombre.TabIndex = 94;
            // 
            // cmbTipoArticuloBodega
            // 
            this.cmbTipoArticuloBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArticuloBodega.FormattingEnabled = true;
            this.cmbTipoArticuloBodega.Items.AddRange(new object[] {
            "Materias Primas",
            "Envases"});
            this.cmbTipoArticuloBodega.Location = new System.Drawing.Point(90, 43);
            this.cmbTipoArticuloBodega.Name = "cmbTipoArticuloBodega";
            this.cmbTipoArticuloBodega.Size = new System.Drawing.Size(131, 25);
            this.cmbTipoArticuloBodega.TabIndex = 95;
            this.cmbTipoArticuloBodega.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoArticuloBodega_SelectionChangeCommitted);
            // 
            // lblTipoArticuloBodega
            // 
            this.lblTipoArticuloBodega.AutoSize = true;
            this.lblTipoArticuloBodega.Location = new System.Drawing.Point(50, 46);
            this.lblTipoArticuloBodega.Name = "lblTipoArticuloBodega";
            this.lblTipoArticuloBodega.Size = new System.Drawing.Size(34, 17);
            this.lblTipoArticuloBodega.TabIndex = 96;
            this.lblTipoArticuloBodega.Text = "Tipo";
            // 
            // txtUnidadMedidaIngM
            // 
            this.txtUnidadMedidaIngM.Enabled = false;
            this.txtUnidadMedidaIngM.Location = new System.Drawing.Point(90, 105);
            this.txtUnidadMedidaIngM.Name = "txtUnidadMedidaIngM";
            this.txtUnidadMedidaIngM.Size = new System.Drawing.Size(32, 25);
            this.txtUnidadMedidaIngM.TabIndex = 98;
            // 
            // lblUnidadMedidaIngM
            // 
            this.lblUnidadMedidaIngM.AutoSize = true;
            this.lblUnidadMedidaIngM.Location = new System.Drawing.Point(55, 108);
            this.lblUnidadMedidaIngM.Name = "lblUnidadMedidaIngM";
            this.lblUnidadMedidaIngM.Size = new System.Drawing.Size(29, 17);
            this.lblUnidadMedidaIngM.TabIndex = 97;
            this.lblUnidadMedidaIngM.Text = "UM";
            // 
            // tsIngresoMatBodega
            // 
            this.tsIngresoMatBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tsIngresoMatBodega.BackgroundImage = global::SalidaMateriales.Properties.Resources.BarraBotones;
            this.tsIngresoMatBodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsIngresoMatBodega.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarIngM,
            this.tsbGrabarIngM,
            this.lblTitulo});
            this.tsIngresoMatBodega.Location = new System.Drawing.Point(0, 0);
            this.tsIngresoMatBodega.Name = "tsIngresoMatBodega";
            this.tsIngresoMatBodega.Size = new System.Drawing.Size(600, 25);
            this.tsIngresoMatBodega.TabIndex = 99;
            this.tsIngresoMatBodega.Text = "toolStrip1";
            this.tsIngresoMatBodega.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsIngresoMatBodega_MouseDown);
            // 
            // tsbCerrarIngM
            // 
            this.tsbCerrarIngM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarIngM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsbCerrarIngM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarIngM.Image = global::SalidaMateriales.Properties.Resources.Cerrar_16;
            this.tsbCerrarIngM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrarIngM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarIngM.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbCerrarIngM.Name = "tsbCerrarIngM";
            this.tsbCerrarIngM.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbCerrarIngM.Size = new System.Drawing.Size(75, 25);
            this.tsbCerrarIngM.Text = "Cerrar";
            this.tsbCerrarIngM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarIngM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrarIngM.Click += new System.EventHandler(this.tsbCerrarIngM_Click);
            // 
            // tsbGrabarIngM
            // 
            this.tsbGrabarIngM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGrabarIngM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsbGrabarIngM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbGrabarIngM.Image = global::SalidaMateriales.Properties.Resources.Grabar2;
            this.tsbGrabarIngM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrabarIngM.Margin = new System.Windows.Forms.Padding(0);
            this.tsbGrabarIngM.Name = "tsbGrabarIngM";
            this.tsbGrabarIngM.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbGrabarIngM.Size = new System.Drawing.Size(79, 25);
            this.tsbGrabarIngM.Text = "Grabar";
            this.tsbGrabarIngM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbGrabarIngM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbGrabarIngM.Click += new System.EventHandler(this.tsbGrabarIngM_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 22);
            this.lblTitulo.Text = "Ingreso";
            // 
            // lblCantidadIngM
            // 
            this.lblCantidadIngM.AutoSize = true;
            this.lblCantidadIngM.Location = new System.Drawing.Point(24, 139);
            this.lblCantidadIngM.Name = "lblCantidadIngM";
            this.lblCantidadIngM.Size = new System.Drawing.Size(60, 17);
            this.lblCantidadIngM.TabIndex = 101;
            this.lblCantidadIngM.Text = "Cantidad";
            // 
            // txtCantidadIngM
            // 
            this.txtCantidadIngM.Location = new System.Drawing.Point(90, 136);
            this.txtCantidadIngM.Name = "txtCantidadIngM";
            this.txtCantidadIngM.Size = new System.Drawing.Size(88, 25);
            this.txtCantidadIngM.TabIndex = 100;
            this.txtCantidadIngM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadIngM_KeyPress);
            // 
            // fIngresoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 379);
            this.Controls.Add(this.lblCantidadIngM);
            this.Controls.Add(this.txtCantidadIngM);
            this.Controls.Add(this.tsIngresoMatBodega);
            this.Controls.Add(this.txtUnidadMedidaIngM);
            this.Controls.Add(this.lblUnidadMedidaIngM);
            this.Controls.Add(this.cmbTipoArticuloBodega);
            this.Controls.Add(this.lblTipoArticuloBodega);
            this.Controls.Add(this.txtArtBodegaNombre);
            this.Controls.Add(this.btnBusqArticuloBodega);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fIngresoMaterial";
            this.Text = "fIngresoMaterial";
            this.Load += new System.EventHandler(this.fIngresoMaterial_Load);
            this.tsIngresoMatBodega.ResumeLayout(false);
            this.tsIngresoMatBodega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusqArticuloBodega;
        private System.Windows.Forms.TextBox txtArtBodegaNombre;
        private System.Windows.Forms.ComboBox cmbTipoArticuloBodega;
        private System.Windows.Forms.Label lblTipoArticuloBodega;
        private System.Windows.Forms.TextBox txtUnidadMedidaIngM;
        private System.Windows.Forms.Label lblUnidadMedidaIngM;
        private System.Windows.Forms.ToolStrip tsIngresoMatBodega;
        private System.Windows.Forms.ToolStripButton tsbCerrarIngM;
        private System.Windows.Forms.ToolStripButton tsbGrabarIngM;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        private System.Windows.Forms.Label lblCantidadIngM;
        private System.Windows.Forms.TextBox txtCantidadIngM;
    }
}