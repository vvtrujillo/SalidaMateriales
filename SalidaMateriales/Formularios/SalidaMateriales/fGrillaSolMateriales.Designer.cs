namespace SalidaMateriales.Formularios.SalidaMateriales
{
    partial class fGrillaSolMateriales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgSalidaMatSolicitud = new System.Windows.Forms.DataGridView();
            this.tsListadoMaterialesBodega = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarSM = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltroCodArt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalidaMatSolicitud)).BeginInit();
            this.tsListadoMaterialesBodega.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSalidaMatSolicitud
            // 
            this.dgSalidaMatSolicitud.AllowUserToAddRows = false;
            this.dgSalidaMatSolicitud.AllowUserToDeleteRows = false;
            this.dgSalidaMatSolicitud.AllowUserToResizeColumns = false;
            this.dgSalidaMatSolicitud.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgSalidaMatSolicitud.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSalidaMatSolicitud.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSalidaMatSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSalidaMatSolicitud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalidaMatSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSalidaMatSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSalidaMatSolicitud.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSalidaMatSolicitud.Location = new System.Drawing.Point(30, 155);
            this.dgSalidaMatSolicitud.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgSalidaMatSolicitud.MultiSelect = false;
            this.dgSalidaMatSolicitud.Name = "dgSalidaMatSolicitud";
            this.dgSalidaMatSolicitud.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgSalidaMatSolicitud.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSalidaMatSolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSalidaMatSolicitud.Size = new System.Drawing.Size(381, 241);
            this.dgSalidaMatSolicitud.TabIndex = 193;
            this.dgSalidaMatSolicitud.TabStop = false;
            this.dgSalidaMatSolicitud.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalidaMatSolicitud_CellContentDoubleClick);
            // 
            // tsListadoMaterialesBodega
            // 
            this.tsListadoMaterialesBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tsListadoMaterialesBodega.BackgroundImage = global::SalidaMateriales.Properties.Resources.BarraBotones;
            this.tsListadoMaterialesBodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsListadoMaterialesBodega.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarSM,
            this.lblTitulo});
            this.tsListadoMaterialesBodega.Location = new System.Drawing.Point(0, 0);
            this.tsListadoMaterialesBodega.Name = "tsListadoMaterialesBodega";
            this.tsListadoMaterialesBodega.Size = new System.Drawing.Size(449, 25);
            this.tsListadoMaterialesBodega.TabIndex = 194;
            this.tsListadoMaterialesBodega.Text = "toolStrip1";
            this.tsListadoMaterialesBodega.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsListadoMaterialesBodega_MouseDown);
            // 
            // tsbCerrarSM
            // 
            this.tsbCerrarSM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarSM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsbCerrarSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCerrarSM.Image = global::SalidaMateriales.Properties.Resources.Cerrar_16;
            this.tsbCerrarSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrarSM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarSM.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbCerrarSM.Name = "tsbCerrarSM";
            this.tsbCerrarSM.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbCerrarSM.Size = new System.Drawing.Size(75, 25);
            this.tsbCerrarSM.Text = "Cerrar";
            this.tsbCerrarSM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarSM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCerrarSM.Click += new System.EventHandler(this.tsbCerrarSM_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 22);
            this.lblTitulo.Text = "Listado";
            // 
            // txtFiltroCodArt
            // 
            this.txtFiltroCodArt.Location = new System.Drawing.Point(30, 122);
            this.txtFiltroCodArt.Name = "txtFiltroCodArt";
            this.txtFiltroCodArt.Size = new System.Drawing.Size(100, 25);
            this.txtFiltroCodArt.TabIndex = 195;
            this.txtFiltroCodArt.TextChanged += new System.EventHandler(this.txtFiltroCodArt_TextChanged);
            // 
            // fGrillaSolMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 420);
            this.Controls.Add(this.txtFiltroCodArt);
            this.Controls.Add(this.tsListadoMaterialesBodega);
            this.Controls.Add(this.dgSalidaMatSolicitud);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fGrillaSolMateriales";
            this.Text = "fGrillaSolMateriales";
            this.Load += new System.EventHandler(this.fGrillaSolMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalidaMatSolicitud)).EndInit();
            this.tsListadoMaterialesBodega.ResumeLayout(false);
            this.tsListadoMaterialesBodega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSalidaMatSolicitud;
        private System.Windows.Forms.ToolStrip tsListadoMaterialesBodega;
        private System.Windows.Forms.ToolStripButton tsbCerrarSM;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        private System.Windows.Forms.TextBox txtFiltroCodArt;
    }
}