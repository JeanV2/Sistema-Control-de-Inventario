namespace CapaPresentacion
{
    partial class FrmPresupuesto
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoPresepuesto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnGuardarPresupuesto = new Guna.UI2.WinForms.Guna2Button();
            this.BtnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnVerLista = new Guna.UI2.WinForms.Guna2Button();
            this.DtpFechaSolicitud = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMontuoProsupuesto = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.TxtCodigoPresepuesto);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.DtpFechaSolicitud);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.TxtMontuoProsupuesto);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(341, 378);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3000, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 30, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prosupuesto #";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoPresepuesto
            // 
            this.TxtCodigoPresepuesto.BorderRadius = 10;
            this.TxtCodigoPresepuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigoPresepuesto.DefaultText = "";
            this.TxtCodigoPresepuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodigoPresepuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodigoPresepuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoPresepuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoPresepuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoPresepuesto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPresepuesto.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoPresepuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoPresepuesto.Location = new System.Drawing.Point(20, 98);
            this.TxtCodigoPresepuesto.Margin = new System.Windows.Forms.Padding(10, 7, 3000, 0);
            this.TxtCodigoPresepuesto.Name = "TxtCodigoPresepuesto";
            this.TxtCodigoPresepuesto.PasswordChar = '\0';
            this.TxtCodigoPresepuesto.PlaceholderText = "";
            this.TxtCodigoPresepuesto.SelectedText = "";
            this.TxtCodigoPresepuesto.Size = new System.Drawing.Size(247, 35);
            this.TxtCodigoPresepuesto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3000, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Aprobación";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.BtnGuardarPresupuesto);
            this.flowLayoutPanel1.Controls.Add(this.BtnModificar);
            this.flowLayoutPanel1.Controls.Add(this.BtnEliminar);
            this.flowLayoutPanel1.Controls.Add(this.BtnVerLista);
            this.flowLayoutPanel1.Controls.Add(this.BtnVolver);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(346, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 378);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // BtnGuardarPresupuesto
            // 
            this.BtnGuardarPresupuesto.Animated = true;
            this.BtnGuardarPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarPresupuesto.BorderColor = System.Drawing.Color.Transparent;
            this.BtnGuardarPresupuesto.BorderRadius = 10;
            this.BtnGuardarPresupuesto.BorderThickness = 1;
            this.BtnGuardarPresupuesto.DefaultAutoSize = true;
            this.BtnGuardarPresupuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardarPresupuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardarPresupuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGuardarPresupuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGuardarPresupuesto.FillColor = System.Drawing.SystemColors.Control;
            this.BtnGuardarPresupuesto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardarPresupuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.BtnGuardarPresupuesto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.BtnGuardarPresupuesto.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarPresupuesto.Location = new System.Drawing.Point(3, 10);
            this.BtnGuardarPresupuesto.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.BtnGuardarPresupuesto.Name = "BtnGuardarPresupuesto";
            this.BtnGuardarPresupuesto.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnGuardarPresupuesto.Size = new System.Drawing.Size(211, 32);
            this.BtnGuardarPresupuesto.TabIndex = 9;
            this.BtnGuardarPresupuesto.Text = "Guardar Presupuesto";
            this.BtnGuardarPresupuesto.UseTransparentBackground = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Animated = true;
            this.BtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnModificar.BorderRadius = 10;
            this.BtnModificar.BorderThickness = 1;
            this.BtnModificar.DefaultAutoSize = true;
            this.BtnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnModificar.FillColor = System.Drawing.SystemColors.Control;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.BtnModificar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.BtnModificar.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(3, 82);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnModificar.Size = new System.Drawing.Size(219, 32);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "Modificar Presupuesto";
            this.BtnModificar.UseTransparentBackground = true;
            this.BtnModificar.Visible = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Animated = true;
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BorderRadius = 10;
            this.BtnEliminar.BorderThickness = 1;
            this.BtnEliminar.DefaultAutoSize = true;
            this.BtnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEliminar.FillColor = System.Drawing.SystemColors.Control;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.BtnEliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.BtnEliminar.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(3, 154);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnEliminar.Size = new System.Drawing.Size(203, 32);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar Presupuesto";
            this.BtnEliminar.UseTransparentBackground = true;
            this.BtnEliminar.Visible = false;
            // 
            // BtnVerLista
            // 
            this.BtnVerLista.Animated = true;
            this.BtnVerLista.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerLista.BorderColor = System.Drawing.Color.Transparent;
            this.BtnVerLista.BorderRadius = 10;
            this.BtnVerLista.BorderThickness = 1;
            this.BtnVerLista.DefaultAutoSize = true;
            this.BtnVerLista.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVerLista.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVerLista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVerLista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVerLista.FillColor = System.Drawing.SystemColors.Control;
            this.BtnVerLista.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerLista.ForeColor = System.Drawing.Color.Black;
            this.BtnVerLista.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.BtnVerLista.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
            this.BtnVerLista.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerLista.Location = new System.Drawing.Point(3, 226);
            this.BtnVerLista.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.BtnVerLista.Name = "BtnVerLista";
            this.BtnVerLista.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnVerLista.Size = new System.Drawing.Size(244, 32);
            this.BtnVerLista.TabIndex = 12;
            this.BtnVerLista.Text = "Ver Lista de Presupuestos";
            this.BtnVerLista.UseTransparentBackground = true;
            // 
            // DtpFechaSolicitud
            // 
            this.DtpFechaSolicitud.BorderRadius = 10;
            this.DtpFechaSolicitud.Checked = true;
            this.DtpFechaSolicitud.FillColor = System.Drawing.SystemColors.Control;
            this.DtpFechaSolicitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaSolicitud.ForeColor = System.Drawing.Color.Black;
            this.DtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaSolicitud.Location = new System.Drawing.Point(20, 174);
            this.DtpFechaSolicitud.Margin = new System.Windows.Forms.Padding(10, 5, 3000, 0);
            this.DtpFechaSolicitud.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaSolicitud.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpFechaSolicitud.Name = "DtpFechaSolicitud";
            this.DtpFechaSolicitud.Size = new System.Drawing.Size(170, 36);
            this.DtpFechaSolicitud.TabIndex = 16;
            this.DtpFechaSolicitud.Value = new System.DateTime(2023, 4, 28, 0, 31, 37, 383);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Montuo Prosupuesto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtMontuoProsupuesto
            // 
            this.TxtMontuoProsupuesto.BorderRadius = 10;
            this.TxtMontuoProsupuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMontuoProsupuesto.DefaultText = "";
            this.TxtMontuoProsupuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMontuoProsupuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMontuoProsupuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMontuoProsupuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMontuoProsupuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMontuoProsupuesto.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontuoProsupuesto.ForeColor = System.Drawing.Color.Black;
            this.TxtMontuoProsupuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMontuoProsupuesto.Location = new System.Drawing.Point(20, 258);
            this.TxtMontuoProsupuesto.Margin = new System.Windows.Forms.Padding(10, 7, 3000, 0);
            this.TxtMontuoProsupuesto.Name = "TxtMontuoProsupuesto";
            this.TxtMontuoProsupuesto.PasswordChar = '\0';
            this.TxtMontuoProsupuesto.PlaceholderText = "";
            this.TxtMontuoProsupuesto.SelectedText = "";
            this.TxtMontuoProsupuesto.Size = new System.Drawing.Size(247, 35);
            this.TxtMontuoProsupuesto.TabIndex = 18;
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
            this.BtnVolver.Location = new System.Drawing.Point(3, 298);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnVolver.Size = new System.Drawing.Size(85, 32);
            this.BtnVolver.TabIndex = 13;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseTransparentBackground = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FrmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(605, 388);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(621, 427);
            this.Name = "FrmPresupuesto";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Presupuesto";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox TxtCodigoPresepuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public Guna.UI2.WinForms.Guna2Button BtnGuardarPresupuesto;
        public Guna.UI2.WinForms.Guna2Button BtnModificar;
        public Guna.UI2.WinForms.Guna2Button BtnEliminar;
        private Guna.UI2.WinForms.Guna2Button BtnVerLista;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox TxtMontuoProsupuesto;
        public Guna.UI2.WinForms.Guna2Button BtnVolver;
        public Guna.UI2.WinForms.Guna2DateTimePicker DtpFechaSolicitud;
    }
}