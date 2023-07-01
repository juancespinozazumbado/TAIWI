namespace TAIWI.DesktopApp
{
    partial class Baucher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DetalleVentaDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DetalleVentaDataGrid);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 521);
            this.panel1.TabIndex = 0;
            // 
            // DetalleVentaDataGrid
            // 
            this.DetalleVentaDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DetalleVentaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleVentaDataGrid.Location = new System.Drawing.Point(3, 3);
            this.DetalleVentaDataGrid.Name = "DetalleVentaDataGrid";
            this.DetalleVentaDataGrid.RowHeadersWidth = 62;
            this.DetalleVentaDataGrid.RowTemplate.Height = 28;
            this.DetalleVentaDataGrid.Size = new System.Drawing.Size(518, 181);
            this.DetalleVentaDataGrid.TabIndex = 0;
            // 
            // Baucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 611);
            this.Controls.Add(this.panel1);
            this.Name = "Baucher";
            this.Text = "TAIWI Baucher";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DetalleVentaDataGrid;
    }
}