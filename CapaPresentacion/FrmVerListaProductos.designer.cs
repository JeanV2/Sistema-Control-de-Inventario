﻿namespace CapaPresentacion
{
    partial class FrmVerListaProductos
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
            this.DgvListaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoPresupuesto = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelCargar = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCargarPr = new System.Windows.Forms.Label();
            this.lblcompleted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelCargar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaProductos
            // 
            this.DgvListaProductos.AllowUserToAddRows = false;
            this.DgvListaProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.DgvListaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.DgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaProductos.ColumnHeadersHeight = 68;
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.DgvListaProductos.Location = new System.Drawing.Point(0, 123);
            this.DgvListaProductos.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.ReadOnly = true;
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.RowHeadersWidth = 62;
            this.DgvListaProductos.RowTemplate.Height = 25;
            this.DgvListaProductos.Size = new System.Drawing.Size(1067, 431);
            this.DgvListaProductos.TabIndex = 16;
            this.DgvListaProductos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvListaProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvListaProductos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.DgvListaProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.DgvListaProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.DgvListaProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvListaProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListaProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvListaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvListaProductos.ThemeStyle.HeaderStyle.Height = 68;
            this.DgvListaProductos.ThemeStyle.ReadOnly = true;
            this.DgvListaProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.DgvListaProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvListaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListaProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvListaProductos.ThemeStyle.RowsStyle.Height = 25;
            this.DgvListaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.DgvListaProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Cod. Presup";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 183;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Sub Familia";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 172;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Producto";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 164;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Codigo";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Desc.Producto";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unid. Medida";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Invent. Requerido";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Precio";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Costo Total";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Existencia";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnFiltrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtCodigoProducto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtCodigoPresupuesto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 123);
            this.panel1.TabIndex = 15;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Animated = true;
            this.BtnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnFiltrar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnFiltrar.BorderRadius = 10;
            this.BtnFiltrar.BorderThickness = 1;
            this.BtnFiltrar.DefaultAutoSize = true;
            this.BtnFiltrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFiltrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFiltrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFiltrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFiltrar.FillColor = System.Drawing.SystemColors.Control;
            this.BtnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BtnFiltrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.BtnFiltrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.BtnFiltrar.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Image = global::CapaPresentacion.Properties.Resources.filter_52px;
            this.BtnFiltrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnFiltrar.Location = new System.Drawing.Point(811, 76);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(4, 12, 4, 37);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnFiltrar.Size = new System.Drawing.Size(107, 37);
            this.BtnFiltrar.TabIndex = 13;
            this.BtnFiltrar.Text = "Filtrar ";
            this.BtnFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFiltrar.UseTransparentBackground = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 28, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.BorderRadius = 10;
            this.TxtCodigoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigoProducto.DefaultText = "";
            this.TxtCodigoProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodigoProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodigoProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(261, 73);
            this.TxtCodigoProducto.Margin = new System.Windows.Forms.Padding(3, 18, 0, 0);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.PasswordChar = '\0';
            this.TxtCodigoProducto.PlaceholderText = "";
            this.TxtCodigoProducto.SelectedText = "";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(416, 43);
            this.TxtCodigoProducto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 28, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod. Presupuesto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoPresupuesto
            // 
            this.TxtCodigoPresupuesto.BorderRadius = 10;
            this.TxtCodigoPresupuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigoPresupuesto.DefaultText = "";
            this.TxtCodigoPresupuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodigoPresupuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodigoPresupuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoPresupuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoPresupuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoPresupuesto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoPresupuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoPresupuesto.Location = new System.Drawing.Point(261, 18);
            this.TxtCodigoPresupuesto.Margin = new System.Windows.Forms.Padding(3, 18, 0, 0);
            this.TxtCodigoPresupuesto.Name = "TxtCodigoPresupuesto";
            this.TxtCodigoPresupuesto.PasswordChar = '\0';
            this.TxtCodigoPresupuesto.PlaceholderText = "";
            this.TxtCodigoPresupuesto.SelectedText = "";
            this.TxtCodigoPresupuesto.Size = new System.Drawing.Size(269, 43);
            this.TxtCodigoPresupuesto.TabIndex = 5;
            // 
            // PanelCargar
            // 
            this.PanelCargar.ColumnCount = 3;
            this.PanelCargar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.80275F));
            this.PanelCargar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.19725F));
            this.PanelCargar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 514F));
            this.PanelCargar.Controls.Add(this.label3, 1, 0);
            this.PanelCargar.Controls.Add(this.LblCargarPr, 1, 1);
            this.PanelCargar.Controls.Add(this.lblcompleted, 1, 2);
            this.PanelCargar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCargar.Location = new System.Drawing.Point(0, 123);
            this.PanelCargar.Name = "PanelCargar";
            this.PanelCargar.RowCount = 3;
            this.PanelCargar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.PanelCargar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.PanelCargar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.PanelCargar.Size = new System.Drawing.Size(1067, 431);
            this.PanelCargar.TabIndex = 17;
            this.PanelCargar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.PanelCargar.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(145, 96);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Size = new System.Drawing.Size(919, 98);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cargando Productos";
            // 
            // LblCargarPr
            // 
            this.LblCargarPr.AutoSize = true;
            this.LblCargarPr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblCargarPr.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarPr.ForeColor = System.Drawing.Color.White;
            this.LblCargarPr.Location = new System.Drawing.Point(145, 194);
            this.LblCargarPr.Name = "LblCargarPr";
            this.LblCargarPr.Padding = new System.Windows.Forms.Padding(400, 0, 0, 0);
            this.LblCargarPr.Size = new System.Drawing.Size(404, 166);
            this.LblCargarPr.TabIndex = 4;
            this.LblCargarPr.Text = "0/0";
            // 
            // lblcompleted
            // 
            this.lblcompleted.AutoSize = true;
            this.PanelCargar.SetColumnSpan(this.lblcompleted, 2);
            this.lblcompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcompleted.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompleted.ForeColor = System.Drawing.Color.White;
            this.lblcompleted.Location = new System.Drawing.Point(145, 360);
            this.lblcompleted.Name = "lblcompleted";
            this.lblcompleted.Padding = new System.Windows.Forms.Padding(25, 40, 0, 0);
            this.lblcompleted.Size = new System.Drawing.Size(919, 71);
            this.lblcompleted.TabIndex = 5;
            this.lblcompleted.Text = "Carga  Completada";
            this.lblcompleted.Visible = false;
            // 
            // FrmVerListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PanelCargar);
            this.Controls.Add(this.DgvListaProductos);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVerListaProductos";
            this.Text = "FrmVerListaProductos";
            this.Load += new System.EventHandler(this.FrmVerListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelCargar.ResumeLayout(false);
            this.PanelCargar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnFiltrar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodigoPresupuesto;
        private System.Windows.Forms.TableLayoutPanel PanelCargar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCargarPr;
        private System.Windows.Forms.Label lblcompleted;
    }
}