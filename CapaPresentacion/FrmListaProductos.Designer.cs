namespace CapaPresentacion
{
    partial class FrmListaProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.DgvListaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
<<<<<<< HEAD
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.BtnFiltrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNombreProducto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 154);
            this.panel1.TabIndex = 0;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Animated = true;
            this.BtnVolver.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolver.BorderColor = System.Drawing.Color.Transparent;
            this.BtnVolver.BorderRadius = 10;
            this.BtnVolver.BorderThickness = 1;
            this.BtnVolver.DefaultAutoSize = true;
            this.BtnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVolver.FillColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.Black;
            this.BtnVolver.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.BtnVolver.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.BtnVolver.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
<<<<<<< HEAD
            this.BtnVolver.Location = new System.Drawing.Point(1128, 9);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(4, 15, 4, 46);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnVolver.Size = new System.Drawing.Size(114, 43);
=======
            this.BtnVolver.Location = new System.Drawing.Point(752, 6);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnVolver.Size = new System.Drawing.Size(85, 32);
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.BtnVolver.TabIndex = 14;
            this.BtnVolver.Text = "Volver ";
            this.BtnVolver.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnVolver.UseTransparentBackground = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
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
<<<<<<< HEAD
            this.BtnFiltrar.Location = new System.Drawing.Point(741, 28);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(4, 15, 4, 46);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnFiltrar.Size = new System.Drawing.Size(120, 43);
=======
            this.BtnFiltrar.Location = new System.Drawing.Point(494, 18);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnFiltrar.Size = new System.Drawing.Size(95, 32);
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.BtnFiltrar.TabIndex = 13;
            this.BtnFiltrar.Text = "Filtrar ";
            this.BtnFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFiltrar.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 35, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
=======
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 23, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.BorderRadius = 10;
            this.TxtNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombreProducto.DefaultText = "";
            this.TxtNombreProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNombreProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNombreProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombreProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombreProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
<<<<<<< HEAD
            this.TxtNombreProducto.Location = new System.Drawing.Point(189, 91);
            this.TxtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 23, 0, 0);
=======
            this.TxtNombreProducto.Location = new System.Drawing.Point(126, 59);
            this.TxtNombreProducto.Margin = new System.Windows.Forms.Padding(2, 15, 0, 0);
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.PasswordChar = '\0';
            this.TxtNombreProducto.PlaceholderText = "";
            this.TxtNombreProducto.SelectedText = "";
<<<<<<< HEAD
            this.TxtNombreProducto.Size = new System.Drawing.Size(468, 54);
=======
            this.TxtNombreProducto.Size = new System.Drawing.Size(312, 35);
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.TxtNombreProducto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(32, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 35, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
=======
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 23, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BorderRadius = 10;
            this.TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigo.DefaultText = "";
            this.TxtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigo.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
<<<<<<< HEAD
            this.TxtCodigo.Location = new System.Drawing.Point(189, 23);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(3, 23, 0, 0);
=======
            this.TxtCodigo.Location = new System.Drawing.Point(126, 15);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2, 15, 0, 0);
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PasswordChar = '\0';
            this.TxtCodigo.PlaceholderText = "";
            this.TxtCodigo.SelectedText = "";
<<<<<<< HEAD
            this.TxtCodigo.Size = new System.Drawing.Size(303, 54);
            this.TxtCodigo.TabIndex = 5;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
=======
            this.TxtCodigo.Size = new System.Drawing.Size(202, 35);
            this.TxtCodigo.TabIndex = 5;
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaProductos.ColumnHeadersHeight = 35;
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(194)))));
<<<<<<< HEAD
            this.DgvListaProductos.Location = new System.Drawing.Point(0, 154);
            this.DgvListaProductos.Margin = new System.Windows.Forms.Padding(15);
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.ReadOnly = true;
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.RowHeadersWidth = 62;
            this.DgvListaProductos.RowTemplate.Height = 25;
            this.DgvListaProductos.Size = new System.Drawing.Size(1260, 632);
=======
            this.DgvListaProductos.Location = new System.Drawing.Point(0, 100);
            this.DgvListaProductos.Margin = new System.Windows.Forms.Padding(10);
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.ReadOnly = true;
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.RowTemplate.Height = 25;
            this.DgvListaProductos.Size = new System.Drawing.Size(846, 428);
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            this.DgvListaProductos.TabIndex = 4;
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
            this.DgvListaProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListaProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvListaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvListaProductos.ThemeStyle.HeaderStyle.Height = 35;
            this.DgvListaProductos.ThemeStyle.ReadOnly = true;
            this.DgvListaProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(194)))));
            this.DgvListaProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvListaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListaProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DgvListaProductos.ThemeStyle.RowsStyle.Height = 25;
            this.DgvListaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(123)))));
            this.DgvListaProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProductos_CellDoubleClick);
            // 
<<<<<<< HEAD
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
=======
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
<<<<<<< HEAD
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
=======
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
>>>>>>> 4eebb03d879067007a2e358499b7e88ce696c2d7
            // 
            // FrmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1260, 786);
            this.ControlBox = false;
            this.Controls.Add(this.DgvListaProductos);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1282, 842);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1282, 842);
            this.Name = "FrmListaProductos";
            this.Text = "Lista de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaProductos_FormClosing);
            this.Load += new System.EventHandler(this.FrmListaProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DgvListaProductos;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodigo;
        private Guna.UI2.WinForms.Guna2Button BtnFiltrar;
        private Guna.UI2.WinForms.Guna2Button BtnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}