namespace CapaPresentacion
{
    partial class FrmHistCompras
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.guna2DateTimePicker1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.guna2DateTimePicker2);
            this.flowLayoutPanel1.Controls.Add(this.BtnFiltrar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1037, 45);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar del ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 10;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(154, 3);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(146, 36);
            this.guna2DateTimePicker1.TabIndex = 1;
            this.guna2DateTimePicker1.Value = new System.DateTime(2023, 5, 2, 19, 0, 27, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 12, 20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "hasta el";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BorderRadius = 10;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.Black;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(430, 3);
            this.guna2DateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(146, 36);
            this.guna2DateTimePicker2.TabIndex = 16;
            this.guna2DateTimePicker2.Value = new System.DateTime(2023, 5, 2, 19, 0, 27, 0);
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
            this.BtnFiltrar.Location = new System.Drawing.Point(609, 7);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(3, 7, 3, 30);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.BtnFiltrar.Size = new System.Drawing.Size(95, 32);
            this.BtnFiltrar.TabIndex = 17;
            this.BtnFiltrar.Text = "Filtrar ";
            this.BtnFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFiltrar.UseTransparentBackground = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1037, 511);
            this.reportViewer1.TabIndex = 1;
            // 
            // FrmHistCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 556);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmHistCompras";
            this.Text = "FrmHistCompras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHistCompras_FormClosed);
            this.Load += new System.EventHandler(this.FrmHistCompras_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2Button BtnFiltrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}