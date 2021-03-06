﻿namespace SalidaMateriales.Formularios
{
    partial class fSalidaMateriales
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
            this.lblCodPlanta = new System.Windows.Forms.Label();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.gbEncabezado = new System.Windows.Forms.GroupBox();
            this.txtPlantaSol = new System.Windows.Forms.TextBox();
            this.txtPlanta = new System.Windows.Forms.TextBox();
            this.lblPlantaRecibe = new System.Windows.Forms.Label();
            this.txtCentroCostoDescrip = new System.Windows.Forms.TextBox();
            this.lblCentroCosto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArticuloNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgSalidaMat = new System.Windows.Forms.DataGridView();
            this.gbDetalleSolicitud = new System.Windows.Forms.GroupBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblSumPedido = new System.Windows.Forms.Label();
            this.lblContMatPri = new System.Windows.Forms.Label();
            this.gbContadorMP = new System.Windows.Forms.GroupBox();
            this.gbContadorEnv = new System.Windows.Forms.GroupBox();
            this.lblTotalPedidoEnv = new System.Windows.Forms.Label();
            this.lblContadorEnvases = new System.Windows.Forms.Label();
            this.btnBuscarCodArticulo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPlantaSol = new System.Windows.Forms.Button();
            this.btnCentroCostoBusq = new System.Windows.Forms.Button();
            this.tsSalidaMateriales = new System.Windows.Forms.ToolStrip();
            this.tsbCerrarSM = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelarSM = new System.Windows.Forms.ToolStripButton();
            this.tsbGrabarSM = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.codigo_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_articulo_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalidaMat)).BeginInit();
            this.gbDetalleSolicitud.SuspendLayout();
            this.gbContadorMP.SuspendLayout();
            this.gbContadorEnv.SuspendLayout();
            this.tsSalidaMateriales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodPlanta
            // 
            this.lblCodPlanta.AutoSize = true;
            this.lblCodPlanta.Location = new System.Drawing.Point(20, 27);
            this.lblCodPlanta.Name = "lblCodPlanta";
            this.lblCodPlanta.Size = new System.Drawing.Size(92, 17);
            this.lblCodPlanta.TabIndex = 83;
            this.lblCodPlanta.Text = "Planta Bodega";
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanta.FormattingEnabled = true;
            this.cmbPlanta.Location = new System.Drawing.Point(118, 24);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(79, 25);
            this.cmbPlanta.TabIndex = 84;
            this.cmbPlanta.SelectionChangeCommitted += new System.EventHandler(this.cmbPlanta_SelectionChangeCommitted);
            // 
            // gbEncabezado
            // 
            this.gbEncabezado.Controls.Add(this.btnPlantaSol);
            this.gbEncabezado.Controls.Add(this.btnCentroCostoBusq);
            this.gbEncabezado.Controls.Add(this.txtPlantaSol);
            this.gbEncabezado.Controls.Add(this.txtPlanta);
            this.gbEncabezado.Controls.Add(this.lblPlantaRecibe);
            this.gbEncabezado.Controls.Add(this.txtCentroCostoDescrip);
            this.gbEncabezado.Controls.Add(this.lblCentroCosto);
            this.gbEncabezado.Controls.Add(this.cmbPlanta);
            this.gbEncabezado.Controls.Add(this.lblCodPlanta);
            this.gbEncabezado.Location = new System.Drawing.Point(46, 40);
            this.gbEncabezado.Name = "gbEncabezado";
            this.gbEncabezado.Size = new System.Drawing.Size(744, 142);
            this.gbEncabezado.TabIndex = 85;
            this.gbEncabezado.TabStop = false;
            this.gbEncabezado.Text = "Encabezado";
            // 
            // txtPlantaSol
            // 
            this.txtPlantaSol.Enabled = false;
            this.txtPlantaSol.Location = new System.Drawing.Point(152, 86);
            this.txtPlantaSol.Name = "txtPlantaSol";
            this.txtPlantaSol.Size = new System.Drawing.Size(247, 25);
            this.txtPlantaSol.TabIndex = 91;
            // 
            // txtPlanta
            // 
            this.txtPlanta.Enabled = false;
            this.txtPlanta.Location = new System.Drawing.Point(203, 24);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.Size = new System.Drawing.Size(196, 25);
            this.txtPlanta.TabIndex = 90;
            // 
            // lblPlantaRecibe
            // 
            this.lblPlantaRecibe.AutoSize = true;
            this.lblPlantaRecibe.Location = new System.Drawing.Point(6, 89);
            this.lblPlantaRecibe.Name = "lblPlantaRecibe";
            this.lblPlantaRecibe.Size = new System.Drawing.Size(106, 17);
            this.lblPlantaRecibe.TabIndex = 88;
            this.lblPlantaRecibe.Text = "Planta Solicitante";
            // 
            // txtCentroCostoDescrip
            // 
            this.txtCentroCostoDescrip.Enabled = false;
            this.txtCentroCostoDescrip.Location = new System.Drawing.Point(152, 54);
            this.txtCentroCostoDescrip.Name = "txtCentroCostoDescrip";
            this.txtCentroCostoDescrip.Size = new System.Drawing.Size(247, 25);
            this.txtCentroCostoDescrip.TabIndex = 87;
            // 
            // lblCentroCosto
            // 
            this.lblCentroCosto.AutoSize = true;
            this.lblCentroCosto.Location = new System.Drawing.Point(27, 58);
            this.lblCentroCosto.Name = "lblCentroCosto";
            this.lblCentroCosto.Size = new System.Drawing.Size(85, 17);
            this.lblCentroCosto.TabIndex = 85;
            this.lblCentroCosto.Text = "Centro Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Artículo";
            // 
            // txtArticuloNombre
            // 
            this.txtArticuloNombre.Enabled = false;
            this.txtArticuloNombre.Location = new System.Drawing.Point(100, 35);
            this.txtArticuloNombre.Name = "txtArticuloNombre";
            this.txtArticuloNombre.Size = new System.Drawing.Size(361, 25);
            this.txtArticuloNombre.TabIndex = 90;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(606, 35);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(88, 25);
            this.txtCantidad.TabIndex = 93;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(540, 39);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(60, 17);
            this.lblCantidad.TabIndex = 94;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgSalidaMat
            // 
            this.dgSalidaMat.AllowUserToAddRows = false;
            this.dgSalidaMat.AllowUserToDeleteRows = false;
            this.dgSalidaMat.AllowUserToResizeColumns = false;
            this.dgSalidaMat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.dgSalidaMat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSalidaMat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSalidaMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSalidaMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalidaMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSalidaMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalidaMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_articulo,
            this.nombre_articulo,
            this.cant_articulo,
            this.unidad_medida,
            this.tipo_material,
            this.id_articulo_bodega});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSalidaMat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSalidaMat.Location = new System.Drawing.Point(46, 265);
            this.dgSalidaMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSalidaMat.MultiSelect = false;
            this.dgSalidaMat.Name = "dgSalidaMat";
            this.dgSalidaMat.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.dgSalidaMat.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSalidaMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSalidaMat.Size = new System.Drawing.Size(744, 245);
            this.dgSalidaMat.TabIndex = 192;
            this.dgSalidaMat.TabStop = false;
            // 
            // gbDetalleSolicitud
            // 
            this.gbDetalleSolicitud.Controls.Add(this.txtUnidadMedida);
            this.gbDetalleSolicitud.Controls.Add(this.lblUnidadMedida);
            this.gbDetalleSolicitud.Controls.Add(this.label2);
            this.gbDetalleSolicitud.Controls.Add(this.btnBuscarCodArticulo);
            this.gbDetalleSolicitud.Controls.Add(this.lblCantidad);
            this.gbDetalleSolicitud.Controls.Add(this.txtArticuloNombre);
            this.gbDetalleSolicitud.Controls.Add(this.txtCantidad);
            this.gbDetalleSolicitud.Location = new System.Drawing.Point(46, 188);
            this.gbDetalleSolicitud.Name = "gbDetalleSolicitud";
            this.gbDetalleSolicitud.Size = new System.Drawing.Size(744, 70);
            this.gbDetalleSolicitud.TabIndex = 195;
            this.gbDetalleSolicitud.TabStop = false;
            this.gbDetalleSolicitud.Text = "Detalle";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Enabled = false;
            this.txtUnidadMedida.Location = new System.Drawing.Point(502, 35);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(32, 25);
            this.txtUnidadMedida.TabIndex = 96;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(467, 39);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(29, 17);
            this.lblUnidadMedida.TabIndex = 95;
            this.lblUnidadMedida.Text = "UM";
            // 
            // lblSumPedido
            // 
            this.lblSumPedido.AutoSize = true;
            this.lblSumPedido.Location = new System.Drawing.Point(6, 21);
            this.lblSumPedido.Name = "lblSumPedido";
            this.lblSumPedido.Size = new System.Drawing.Size(81, 17);
            this.lblSumPedido.TabIndex = 197;
            this.lblSumPedido.Text = "Total Pedido";
            // 
            // lblContMatPri
            // 
            this.lblContMatPri.AutoSize = true;
            this.lblContMatPri.Location = new System.Drawing.Point(97, 21);
            this.lblContMatPri.Name = "lblContMatPri";
            this.lblContMatPri.Size = new System.Drawing.Size(15, 17);
            this.lblContMatPri.TabIndex = 198;
            this.lblContMatPri.Text = "0";
            // 
            // gbContadorMP
            // 
            this.gbContadorMP.Controls.Add(this.lblSumPedido);
            this.gbContadorMP.Controls.Add(this.lblContMatPri);
            this.gbContadorMP.Location = new System.Drawing.Point(46, 517);
            this.gbContadorMP.Name = "gbContadorMP";
            this.gbContadorMP.Size = new System.Drawing.Size(156, 82);
            this.gbContadorMP.TabIndex = 199;
            this.gbContadorMP.TabStop = false;
            this.gbContadorMP.Text = "Materias Primas";
            // 
            // gbContadorEnv
            // 
            this.gbContadorEnv.Controls.Add(this.lblTotalPedidoEnv);
            this.gbContadorEnv.Controls.Add(this.lblContadorEnvases);
            this.gbContadorEnv.Location = new System.Drawing.Point(228, 517);
            this.gbContadorEnv.Name = "gbContadorEnv";
            this.gbContadorEnv.Size = new System.Drawing.Size(156, 82);
            this.gbContadorEnv.TabIndex = 200;
            this.gbContadorEnv.TabStop = false;
            this.gbContadorEnv.Text = "Envases";
            // 
            // lblTotalPedidoEnv
            // 
            this.lblTotalPedidoEnv.AutoSize = true;
            this.lblTotalPedidoEnv.Location = new System.Drawing.Point(6, 21);
            this.lblTotalPedidoEnv.Name = "lblTotalPedidoEnv";
            this.lblTotalPedidoEnv.Size = new System.Drawing.Size(81, 17);
            this.lblTotalPedidoEnv.TabIndex = 197;
            this.lblTotalPedidoEnv.Text = "Total Pedido";
            // 
            // lblContadorEnvases
            // 
            this.lblContadorEnvases.AutoSize = true;
            this.lblContadorEnvases.Location = new System.Drawing.Point(97, 21);
            this.lblContadorEnvases.Name = "lblContadorEnvases";
            this.lblContadorEnvases.Size = new System.Drawing.Size(15, 17);
            this.lblContadorEnvases.TabIndex = 198;
            this.lblContadorEnvases.Text = "0";
            // 
            // btnBuscarCodArticulo
            // 
            this.btnBuscarCodArticulo.Image = global::SalidaMateriales.Properties.Resources.search;
            this.btnBuscarCodArticulo.Location = new System.Drawing.Point(64, 35);
            this.btnBuscarCodArticulo.Name = "btnBuscarCodArticulo";
            this.btnBuscarCodArticulo.Size = new System.Drawing.Size(28, 25);
            this.btnBuscarCodArticulo.TabIndex = 92;
            this.btnBuscarCodArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarCodArticulo.Click += new System.EventHandler(this.btnBuscarCodArticulo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::SalidaMateriales.Properties.Resources.cancelar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(796, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(49, 48);
            this.btnEliminar.TabIndex = 194;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::SalidaMateriales.Properties.Resources.add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(796, 300);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(49, 47);
            this.btnAgregar.TabIndex = 193;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPlantaSol
            // 
            this.btnPlantaSol.Image = global::SalidaMateriales.Properties.Resources.search;
            this.btnPlantaSol.Location = new System.Drawing.Point(118, 85);
            this.btnPlantaSol.Name = "btnPlantaSol";
            this.btnPlantaSol.Size = new System.Drawing.Size(28, 25);
            this.btnPlantaSol.TabIndex = 96;
            this.btnPlantaSol.UseVisualStyleBackColor = true;
            this.btnPlantaSol.Click += new System.EventHandler(this.btnPlantaSol_Click);
            // 
            // btnCentroCostoBusq
            // 
            this.btnCentroCostoBusq.Image = global::SalidaMateriales.Properties.Resources.search;
            this.btnCentroCostoBusq.Location = new System.Drawing.Point(118, 54);
            this.btnCentroCostoBusq.Name = "btnCentroCostoBusq";
            this.btnCentroCostoBusq.Size = new System.Drawing.Size(28, 25);
            this.btnCentroCostoBusq.TabIndex = 95;
            this.btnCentroCostoBusq.UseVisualStyleBackColor = true;
            this.btnCentroCostoBusq.Click += new System.EventHandler(this.btnCentroCostoBusq_Click);
            // 
            // tsSalidaMateriales
            // 
            this.tsSalidaMateriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tsSalidaMateriales.BackgroundImage = global::SalidaMateriales.Properties.Resources.BarraBotones;
            this.tsSalidaMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsSalidaMateriales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarSM,
            this.tsbGrabarSM,
            this.tsbCancelarSM,
            this.lblTitulo});
            this.tsSalidaMateriales.Location = new System.Drawing.Point(0, 0);
            this.tsSalidaMateriales.Name = "tsSalidaMateriales";
            this.tsSalidaMateriales.Size = new System.Drawing.Size(856, 25);
            this.tsSalidaMateriales.TabIndex = 82;
            this.tsSalidaMateriales.Text = "toolStrip1";
            this.tsSalidaMateriales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsSalidaMateriales_MouseDown);
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
            // tsbCancelarSM
            // 
            this.tsbCancelarSM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCancelarSM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsbCancelarSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbCancelarSM.Image = global::SalidaMateriales.Properties.Resources.cancel_icon;
            this.tsbCancelarSM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelarSM.Margin = new System.Windows.Forms.Padding(0);
            this.tsbCancelarSM.Name = "tsbCancelarSM";
            this.tsbCancelarSM.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbCancelarSM.Size = new System.Drawing.Size(88, 25);
            this.tsbCancelarSM.Text = "Cancelar";
            this.tsbCancelarSM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCancelarSM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbCancelarSM.Click += new System.EventHandler(this.tsbCancelarSM_Click);
            // 
            // tsbGrabarSM
            // 
            this.tsbGrabarSM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGrabarSM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsbGrabarSM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbGrabarSM.Image = global::SalidaMateriales.Properties.Resources.Grabar2;
            this.tsbGrabarSM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrabarSM.Margin = new System.Windows.Forms.Padding(0);
            this.tsbGrabarSM.Name = "tsbGrabarSM";
            this.tsbGrabarSM.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbGrabarSM.Size = new System.Drawing.Size(79, 25);
            this.tsbGrabarSM.Text = "Grabar";
            this.tsbGrabarSM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbGrabarSM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbGrabarSM.Click += new System.EventHandler(this.tsbGrabarSM_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 22);
            this.lblTitulo.Text = "Solicitud Materiales";
            // 
            // codigo_articulo
            // 
            this.codigo_articulo.HeaderText = "Código";
            this.codigo_articulo.Name = "codigo_articulo";
            this.codigo_articulo.ReadOnly = true;
            // 
            // nombre_articulo
            // 
            this.nombre_articulo.HeaderText = "Nombre Artículo";
            this.nombre_articulo.Name = "nombre_articulo";
            this.nombre_articulo.ReadOnly = true;
            this.nombre_articulo.Width = 400;
            // 
            // cant_articulo
            // 
            this.cant_articulo.HeaderText = "Cantidad";
            this.cant_articulo.Name = "cant_articulo";
            this.cant_articulo.ReadOnly = true;
            // 
            // unidad_medida
            // 
            this.unidad_medida.HeaderText = "UM";
            this.unidad_medida.Name = "unidad_medida";
            this.unidad_medida.ReadOnly = true;
            // 
            // tipo_material
            // 
            this.tipo_material.HeaderText = "Tipo";
            this.tipo_material.Name = "tipo_material";
            this.tipo_material.ReadOnly = true;
            this.tipo_material.Visible = false;
            // 
            // id_articulo_bodega
            // 
            this.id_articulo_bodega.HeaderText = "idArticuloBodega";
            this.id_articulo_bodega.Name = "id_articulo_bodega";
            this.id_articulo_bodega.ReadOnly = true;
            this.id_articulo_bodega.Visible = false;
            // 
            // fSalidaMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 611);
            this.Controls.Add(this.gbContadorEnv);
            this.Controls.Add(this.gbContadorMP);
            this.Controls.Add(this.gbDetalleSolicitud);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgSalidaMat);
            this.Controls.Add(this.gbEncabezado);
            this.Controls.Add(this.tsSalidaMateriales);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fSalidaMateriales";
            this.Load += new System.EventHandler(this.SalidaMateriales_Load);
            this.gbEncabezado.ResumeLayout(false);
            this.gbEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalidaMat)).EndInit();
            this.gbDetalleSolicitud.ResumeLayout(false);
            this.gbDetalleSolicitud.PerformLayout();
            this.gbContadorMP.ResumeLayout(false);
            this.gbContadorMP.PerformLayout();
            this.gbContadorEnv.ResumeLayout(false);
            this.gbContadorEnv.PerformLayout();
            this.tsSalidaMateriales.ResumeLayout(false);
            this.tsSalidaMateriales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSalidaMateriales;
        private System.Windows.Forms.ToolStripButton tsbCerrarSM;
        private System.Windows.Forms.ToolStripButton tsbGrabarSM;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        private System.Windows.Forms.Label lblCodPlanta;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.GroupBox gbEncabezado;
        private System.Windows.Forms.TextBox txtCentroCostoDescrip;
        private System.Windows.Forms.Label lblCentroCosto;
        private System.Windows.Forms.Label lblPlantaRecibe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCodArticulo;
        private System.Windows.Forms.TextBox txtArticuloNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgSalidaMat;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbDetalleSolicitud;
        private System.Windows.Forms.TextBox txtPlantaSol;
        private System.Windows.Forms.TextBox txtPlanta;
        private System.Windows.Forms.Button btnCentroCostoBusq;
        private System.Windows.Forms.Button btnPlantaSol;
        private System.Windows.Forms.Label lblSumPedido;
        private System.Windows.Forms.Label lblContMatPri;
        private System.Windows.Forms.GroupBox gbContadorMP;
        private System.Windows.Forms.GroupBox gbContadorEnv;
        private System.Windows.Forms.Label lblTotalPedidoEnv;
        private System.Windows.Forms.Label lblContadorEnvases;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.ToolStripButton tsbCancelarSM;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo_bodega;
    }
}