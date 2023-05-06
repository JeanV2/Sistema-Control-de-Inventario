﻿namespace CapaPresentacion
{
    partial class FrmSolicitudEntrega
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.DgvListaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CbCodigoProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CbNombrePresupuesto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtReferencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbTipoSilicitud = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSolicitadoPor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDisponibles = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnConfirmar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 575);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 4, 11, 4);
            this.panel2.Size = new System.Drawing.Size(1218, 43);
            this.panel2.TabIndex = 0;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Animated = true;
            this.BtnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnConfirmar.BorderRadius = 10;
            this.BtnConfirmar.BorderThickness = 1;
            this.BtnConfirmar.DefaultAutoSize = true;
            this.BtnConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnConfirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConfirmar.FillColor = System.Drawing.SystemColors.Control;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirmar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.BtnConfirmar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.BtnConfirmar.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(989, 4);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(3, 295, 3, 30);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnConfirmar.Size = new System.Drawing.Size(218, 35);
            this.BtnConfirmar.TabIndex = 15;
            this.BtnConfirmar.Text = "Confirmar Solicitud";
            this.BtnConfirmar.UseTransparentBackground = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // DgvListaProductos
            // 
            this.DgvListaProductos.AllowUserToAddRows = false;
            this.DgvListaProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(196)))));
            this.DgvListaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaProductos.ColumnHeadersHeight = 35;
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.X});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(194)))));
            this.DgvListaProductos.Location = new System.Drawing.Point(8, 8);
            this.DgvListaProductos.Margin = new System.Windows.Forms.Padding(5);
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.ReadOnly = true;
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.RowHeadersWidth = 62;
            this.DgvListaProductos.RowTemplate.Height = 25;
            this.DgvListaProductos.Size = new System.Drawing.Size(898, 259);
            this.DgvListaProductos.TabIndex = 5;
            this.DgvListaProductos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Lime;
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(196)))));
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvListaProductos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.DgvListaProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(194)))));
            this.DgvListaProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(57)))));
            this.DgvListaProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvListaProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListaProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvListaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvListaProductos.ThemeStyle.HeaderStyle.Height = 35;
            this.DgvListaProductos.ThemeStyle.ReadOnly = true;
            this.DgvListaProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(194)))));
            this.DgvListaProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvListaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListaProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DgvListaProductos.ThemeStyle.RowsStyle.Height = 25;
            this.DgvListaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(123)))));
            this.DgvListaProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProductos_CellContentClick);
            this.DgvListaProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListaProductos_CellMouseClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo Producto";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Producto";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Text = "X";
            this.X.UseColumnTextForButtonValue = true;
            this.X.Width = 36;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.1747F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01937F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.75464F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.56271F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.74429F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.74429F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(0, 234);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // CbCodigoProducto
            // 
            this.CbCodigoProducto.BackColor = System.Drawing.Color.Transparent;
            this.CbCodigoProducto.BorderRadius = 10;
            this.CbCodigoProducto.DisabledState.FillColor = System.Drawing.Color.White;
            this.CbCodigoProducto.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.CbCodigoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbCodigoProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbCodigoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCodigoProducto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbCodigoProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CbCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.CbCodigoProducto.ItemHeight = 30;
            this.CbCodigoProducto.Location = new System.Drawing.Point(168, 98);
            this.CbCodigoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.CbCodigoProducto.Name = "CbCodigoProducto";
            this.CbCodigoProducto.Size = new System.Drawing.Size(590, 36);
            this.CbCodigoProducto.TabIndex = 18;
            this.CbCodigoProducto.SelectedIndexChanged += new System.EventHandler(this.CbCodigoProducto_SelectedIndexChanged);
            // 
            // CbNombrePresupuesto
            // 
            this.CbNombrePresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.CbNombrePresupuesto.BorderRadius = 10;
            this.CbNombrePresupuesto.DisabledState.FillColor = System.Drawing.Color.White;
            this.CbNombrePresupuesto.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.CbNombrePresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbNombrePresupuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbNombrePresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNombrePresupuesto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbNombrePresupuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbNombrePresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CbNombrePresupuesto.ForeColor = System.Drawing.Color.Black;
            this.CbNombrePresupuesto.ItemHeight = 30;
            this.CbNombrePresupuesto.Location = new System.Drawing.Point(168, 66);
            this.CbNombrePresupuesto.Margin = new System.Windows.Forms.Padding(2);
            this.CbNombrePresupuesto.Name = "CbNombrePresupuesto";
            this.CbNombrePresupuesto.Size = new System.Drawing.Size(590, 36);
            this.CbNombrePresupuesto.TabIndex = 17;
            this.CbNombrePresupuesto.SelectedIndexChanged += new System.EventHandler(this.CbNombrePresupuesto_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nombre Presupuesto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.BorderRadius = 10;
            this.TxtReferencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtReferencia.DefaultText = "";
            this.TxtReferencia.DisabledState.BorderColor = System.Drawing.Color.White;
            this.TxtReferencia.DisabledState.FillColor = System.Drawing.Color.White;
            this.TxtReferencia.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.TxtReferencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtReferencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtReferencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReferencia.ForeColor = System.Drawing.Color.Black;
            this.TxtReferencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtReferencia.Location = new System.Drawing.Point(610, 35);
            this.TxtReferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.PasswordChar = '\0';
            this.TxtReferencia.PlaceholderText = "";
            this.TxtReferencia.SelectedText = "";
            this.TxtReferencia.Size = new System.Drawing.Size(301, 26);
            this.TxtReferencia.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.label8.Size = new System.Drawing.Size(101, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Referencia";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbTipoSilicitud
            // 
            this.CbTipoSilicitud.BackColor = System.Drawing.Color.Transparent;
            this.CbTipoSilicitud.BorderRadius = 10;
            this.CbTipoSilicitud.DisabledState.FillColor = System.Drawing.Color.White;
            this.CbTipoSilicitud.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.CbTipoSilicitud.Dock = System.Windows.Forms.DockStyle.Left;
            this.CbTipoSilicitud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbTipoSilicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoSilicitud.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbTipoSilicitud.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbTipoSilicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoSilicitud.ForeColor = System.Drawing.Color.Black;
            this.CbTipoSilicitud.ItemHeight = 30;
            this.CbTipoSilicitud.Location = new System.Drawing.Point(168, 34);
            this.CbTipoSilicitud.Margin = new System.Windows.Forms.Padding(2);
            this.CbTipoSilicitud.Name = "CbTipoSilicitud";
            this.CbTipoSilicitud.Size = new System.Drawing.Size(295, 36);
            this.CbTipoSilicitud.TabIndex = 16;
            this.CbTipoSilicitud.SelectedIndexChanged += new System.EventHandler(this.CbTipoSilicitud_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo Solicitud";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSolicitadoPor
            // 
            this.TxtSolicitadoPor.BorderRadius = 10;
            this.TxtSolicitadoPor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSolicitadoPor.DefaultText = "";
            this.TxtSolicitadoPor.DisabledState.BorderColor = System.Drawing.Color.White;
            this.TxtSolicitadoPor.DisabledState.FillColor = System.Drawing.Color.White;
            this.TxtSolicitadoPor.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.TxtSolicitadoPor.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtSolicitadoPor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSolicitadoPor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSolicitadoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSolicitadoPor.ForeColor = System.Drawing.Color.Black;
            this.TxtSolicitadoPor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSolicitadoPor.Location = new System.Drawing.Point(610, 3);
            this.TxtSolicitadoPor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSolicitadoPor.Name = "TxtSolicitadoPor";
            this.TxtSolicitadoPor.PasswordChar = '\0';
            this.TxtSolicitadoPor.PlaceholderText = "";
            this.TxtSolicitadoPor.SelectedText = "";
            this.TxtSolicitadoPor.Size = new System.Drawing.Size(301, 26);
            this.TxtSolicitadoPor.TabIndex = 16;
            this.TxtSolicitadoPor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSolicitadoPor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Solicitado por";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCedula
            // 
            this.TxtCedula.BorderRadius = 10;
            this.TxtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCedula.DefaultText = "";
            this.TxtCedula.DisabledState.BorderColor = System.Drawing.Color.White;
            this.TxtCedula.DisabledState.FillColor = System.Drawing.Color.White;
            this.TxtCedula.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.TxtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtCedula.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.ForeColor = System.Drawing.Color.Black;
            this.TxtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCedula.Location = new System.Drawing.Point(169, 3);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.PasswordChar = '\0';
            this.TxtCedula.PlaceholderText = "";
            this.TxtCedula.SelectedText = "";
            this.TxtCedula.Size = new System.Drawing.Size(293, 26);
            this.TxtCedula.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autorizado por";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Animated = true;
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BorderRadius = 10;
            this.BtnAgregar.BorderThickness = 1;
            this.BtnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAgregar.FillColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.BtnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.BtnAgregar.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(770, 162);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnAgregar.Size = new System.Drawing.Size(142, 28);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Añadir a Lista";
            this.BtnAgregar.UseTransparentBackground = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Disponibles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDisponibles
            // 
            this.TxtDisponibles.BorderRadius = 10;
            this.TxtDisponibles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDisponibles.DefaultText = "";
            this.TxtDisponibles.DisabledState.BorderColor = System.Drawing.Color.White;
            this.TxtDisponibles.DisabledState.FillColor = System.Drawing.Color.White;
            this.TxtDisponibles.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.TxtDisponibles.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtDisponibles.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtDisponibles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisponibles.ForeColor = System.Drawing.Color.Black;
            this.TxtDisponibles.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDisponibles.Location = new System.Drawing.Point(169, 131);
            this.TxtDisponibles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDisponibles.Name = "TxtDisponibles";
            this.TxtDisponibles.PasswordChar = '\0';
            this.TxtDisponibles.PlaceholderText = "";
            this.TxtDisponibles.ReadOnly = true;
            this.TxtDisponibles.SelectedText = "";
            this.TxtDisponibles.Size = new System.Drawing.Size(129, 26);
            this.TxtDisponibles.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad Solicitada";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantProducto
            // 
            this.txtCantProducto.BorderRadius = 10;
            this.txtCantProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantProducto.DefaultText = "";
            this.txtCantProducto.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txtCantProducto.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtCantProducto.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtCantProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCantProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCantProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantProducto.ForeColor = System.Drawing.Color.Black;
            this.txtCantProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantProducto.Location = new System.Drawing.Point(468, 131);
            this.txtCantProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantProducto.Name = "txtCantProducto";
            this.txtCantProducto.PasswordChar = '\0';
            this.txtCantProducto.PlaceholderText = "";
            this.txtCantProducto.SelectedText = "";
            this.txtCantProducto.Size = new System.Drawing.Size(134, 26);
            this.txtCantProducto.TabIndex = 10;
            this.txtCantProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 618);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 123);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 123);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FrmSolicitudEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1232, 630);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSolicitudEntrega";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Text = "FrmSolicitudInsumos";
            this.Load += new System.EventHandler(this.FrmSolicitudInsumos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnConfirmar;
        private Guna.UI2.WinForms.Guna2DataGridView DgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn X;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public Guna.UI2.WinForms.Guna2TextBox txtCantProducto;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox TxtDisponibles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox TxtReferencia;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox CbTipoSilicitud;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox TxtSolicitadoPor;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox TxtCedula;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnAgregar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox CbNombrePresupuesto;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox CbCodigoProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
    }
}