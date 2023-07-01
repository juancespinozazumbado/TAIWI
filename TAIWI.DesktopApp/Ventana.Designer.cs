namespace TAIWI.DesktopApp
{
    partial class TAIWI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImprimirVentaBtn = new System.Windows.Forms.Button();
            this.TerminarVentaBtn = new System.Windows.Forms.Button();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.ProductosComboBox = new System.Windows.Forms.ComboBox();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CantTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DetalleVentaDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubtotalLabelText = new System.Windows.Forms.Label();
            this.ImpuestosLabelText = new System.Windows.Forms.Label();
            this.TotalLabelText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ImprimirVentaBtn);
            this.panel1.Controls.Add(this.TerminarVentaBtn);
            this.panel1.Controls.Add(this.PrecioTextBox);
            this.panel1.Controls.Add(this.PrecioLabel);
            this.panel1.Controls.Add(this.ProductosComboBox);
            this.panel1.Controls.Add(this.BotonAgregar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CantTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 139);
            this.panel1.TabIndex = 0;
            // 
            // ImprimirVentaBtn
            // 
            this.ImprimirVentaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirVentaBtn.Location = new System.Drawing.Point(693, 49);
            this.ImprimirVentaBtn.Name = "ImprimirVentaBtn";
            this.ImprimirVentaBtn.Size = new System.Drawing.Size(134, 37);
            this.ImprimirVentaBtn.TabIndex = 10;
            this.ImprimirVentaBtn.Text = "Imprimir";
            this.ImprimirVentaBtn.UseVisualStyleBackColor = true;
            this.ImprimirVentaBtn.Click += new System.EventHandler(this.ImprimirVentaBtn_Click);
            // 
            // TerminarVentaBtn
            // 
            this.TerminarVentaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminarVentaBtn.Location = new System.Drawing.Point(833, 50);
            this.TerminarVentaBtn.Name = "TerminarVentaBtn";
            this.TerminarVentaBtn.Size = new System.Drawing.Size(134, 37);
            this.TerminarVentaBtn.TabIndex = 9;
            this.TerminarVentaBtn.Text = "Terminar";
            this.TerminarVentaBtn.UseVisualStyleBackColor = true;
            this.TerminarVentaBtn.Click += new System.EventHandler(this.TerminarVentaBtn_Click);
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox.Location = new System.Drawing.Point(289, 50);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(86, 30);
            this.PrecioTextBox.TabIndex = 8;
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(285, 19);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(66, 22);
            this.PrecioLabel.TabIndex = 7;
            this.PrecioLabel.Text = "Precio:";
            // 
            // ProductosComboBox
            // 
            this.ProductosComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductosComboBox.Location = new System.Drawing.Point(20, 48);
            this.ProductosComboBox.Name = "ProductosComboBox";
            this.ProductosComboBox.Size = new System.Drawing.Size(263, 30);
            this.ProductosComboBox.TabIndex = 6;
            this.ProductosComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductosComboBox_SelectedIndexChanged);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.DarkBlue;
            this.BotonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.ForeColor = System.Drawing.Color.White;
            this.BotonAgregar.Location = new System.Drawing.Point(511, 45);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(134, 37);
            this.BotonAgregar.TabIndex = 5;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // CantTextBox
            // 
            this.CantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantTextBox.Location = new System.Drawing.Point(395, 50);
            this.CantTextBox.Name = "CantTextBox";
            this.CantTextBox.Size = new System.Drawing.Size(86, 28);
            this.CantTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DetalleVentaDataGrid);
            this.panel2.Location = new System.Drawing.Point(12, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 277);
            this.panel2.TabIndex = 1;
            // 
            // DetalleVentaDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetalleVentaDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetalleVentaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleVentaDataGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DetalleVentaDataGrid.Location = new System.Drawing.Point(3, 3);
            this.DetalleVentaDataGrid.Name = "DetalleVentaDataGrid";
            this.DetalleVentaDataGrid.ReadOnly = true;
            this.DetalleVentaDataGrid.RowHeadersWidth = 62;
            this.DetalleVentaDataGrid.RowTemplate.Height = 28;
            this.DetalleVentaDataGrid.Size = new System.Drawing.Size(1113, 271);
            this.DetalleVentaDataGrid.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sub Total :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impuestos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total :";
            // 
            // SubtotalLabelText
            // 
            this.SubtotalLabelText.AutoSize = true;
            this.SubtotalLabelText.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLabelText.Location = new System.Drawing.Point(156, 19);
            this.SubtotalLabelText.Name = "SubtotalLabelText";
            this.SubtotalLabelText.Size = new System.Drawing.Size(26, 29);
            this.SubtotalLabelText.TabIndex = 5;
            this.SubtotalLabelText.Text = "0";
            // 
            // ImpuestosLabelText
            // 
            this.ImpuestosLabelText.AutoSize = true;
            this.ImpuestosLabelText.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpuestosLabelText.Location = new System.Drawing.Point(156, 49);
            this.ImpuestosLabelText.Name = "ImpuestosLabelText";
            this.ImpuestosLabelText.Size = new System.Drawing.Size(26, 29);
            this.ImpuestosLabelText.TabIndex = 6;
            this.ImpuestosLabelText.Text = "0";
            // 
            // TotalLabelText
            // 
            this.TotalLabelText.AutoSize = true;
            this.TotalLabelText.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabelText.Location = new System.Drawing.Point(156, 83);
            this.TotalLabelText.Name = "TotalLabelText";
            this.TotalLabelText.Size = new System.Drawing.Size(26, 29);
            this.TotalLabelText.TabIndex = 7;
            this.TotalLabelText.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TotalLabelText);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ImpuestosLabelText);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.SubtotalLabelText);
            this.panel3.Location = new System.Drawing.Point(884, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 138);
            this.panel3.TabIndex = 8;
            // 
            // TAIWI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TAIWI";
            this.Text = "TAIWI Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CantTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.ComboBox ProductosComboBox;
        private System.Windows.Forms.DataGridView DetalleVentaDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label SubtotalLabelText;
        private System.Windows.Forms.Label ImpuestosLabelText;
        private System.Windows.Forms.Label TotalLabelText;
        private System.Windows.Forms.Button TerminarVentaBtn;
        private System.Windows.Forms.Button ImprimirVentaBtn;
        private System.Windows.Forms.Panel panel3;
    }
}

