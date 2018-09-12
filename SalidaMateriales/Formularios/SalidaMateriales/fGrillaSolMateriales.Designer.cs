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
            this.txtFiltroCodArt = new System.Windows.Forms.TextBox();
            this.txtFiltroNombreArtBod = new System.Windows.Forms.TextBox();
            this.lblFiltroCod = new System.Windows.Forms.Label();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalidaMatSolicitud)).BeginInit();
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
            this.dgSalidaMatSolicitud.Location = new System.Drawing.Point(12, 64);
            this.dgSalidaMatSolicitud.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgSalidaMatSolicitud.MultiSelect = false;
            this.dgSalidaMatSolicitud.Name = "dgSalidaMatSolicitud";
            this.dgSalidaMatSolicitud.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgSalidaMatSolicitud.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSalidaMatSolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSalidaMatSolicitud.Size = new System.Drawing.Size(381, 282);
            this.dgSalidaMatSolicitud.TabIndex = 193;
            this.dgSalidaMatSolicitud.TabStop = false;
            this.dgSalidaMatSolicitud.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalidaMatSolicitud_CellContentDoubleClick);
            // 
            // txtFiltroCodArt
            // 
            this.txtFiltroCodArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroCodArt.Location = new System.Drawing.Point(12, 31);
            this.txtFiltroCodArt.Name = "txtFiltroCodArt";
            this.txtFiltroCodArt.Size = new System.Drawing.Size(100, 25);
            this.txtFiltroCodArt.TabIndex = 195;
            this.txtFiltroCodArt.TextChanged += new System.EventHandler(this.txtFiltroCodArt_TextChanged);
            // 
            // txtFiltroNombreArtBod
            // 
            this.txtFiltroNombreArtBod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltroNombreArtBod.Location = new System.Drawing.Point(118, 31);
            this.txtFiltroNombreArtBod.Name = "txtFiltroNombreArtBod";
            this.txtFiltroNombreArtBod.Size = new System.Drawing.Size(182, 25);
            this.txtFiltroNombreArtBod.TabIndex = 196;
            this.txtFiltroNombreArtBod.TextChanged += new System.EventHandler(this.txtFiltroNombreArtBod_TextChanged);
            // 
            // lblFiltroCod
            // 
            this.lblFiltroCod.AutoSize = true;
            this.lblFiltroCod.Location = new System.Drawing.Point(12, 11);
            this.lblFiltroCod.Name = "lblFiltroCod";
            this.lblFiltroCod.Size = new System.Drawing.Size(51, 17);
            this.lblFiltroCod.TabIndex = 197;
            this.lblFiltroCod.Text = "Código";
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Location = new System.Drawing.Point(115, 9);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(105, 17);
            this.lblFiltroNombre.TabIndex = 198;
            this.lblFiltroNombre.Text = "Nombre Artículo";
            // 
            // fGrillaSolMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 361);
            this.Controls.Add(this.lblFiltroNombre);
            this.Controls.Add(this.lblFiltroCod);
            this.Controls.Add(this.txtFiltroNombreArtBod);
            this.Controls.Add(this.txtFiltroCodArt);
            this.Controls.Add(this.dgSalidaMatSolicitud);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fGrillaSolMateriales";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.fGrillaSolMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalidaMatSolicitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSalidaMatSolicitud;
        private System.Windows.Forms.TextBox txtFiltroCodArt;
        private System.Windows.Forms.TextBox txtFiltroNombreArtBod;
        private System.Windows.Forms.Label lblFiltroCod;
        private System.Windows.Forms.Label lblFiltroNombre;
    }
}