﻿namespace CapaPresentacion
{
    partial class ReporteCompra
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

            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.solicitudCompraReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaPresentacion.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.solicitudCompraReportTableAdapter = new CapaPresentacion.DataSet1TableAdapters.SolicitudCompraReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudCompraReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // solicitudCompraReportBindingSource
            // 
            this.solicitudCompraReportBindingSource.DataMember = "SolicitudCompraReport";
            this.solicitudCompraReportBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.solicitudCompraReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportSolicitudCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1180, 613);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // solicitudCompraReportTableAdapter
            // 
            this.solicitudCompraReportTableAdapter.ClearBeforeFill = true;

            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1117, 704);
            this.reportViewer1.TabIndex = 0;

            // 
            // ReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1180, 613);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteCompra";
            this.Text = "Reporte Solicitud de compra";
            this.Load += new System.EventHandler(this.ReporteCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solicitudCompraReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();

            this.ClientSize = new System.Drawing.Size(1117, 704);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCompra";
            this.Text = "ReporteCompra";
            this.Load += new System.EventHandler(this.ReporteCompra_Load);

            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        private System.Windows.Forms.BindingSource solicitudCompraReportBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.SolicitudCompraReportTableAdapter solicitudCompraReportTableAdapter;

    }
}