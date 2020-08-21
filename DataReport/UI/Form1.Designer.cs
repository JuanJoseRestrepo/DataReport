﻿namespace DataReport.UI
{
    partial class Form1
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.Municipios = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(17, 64);
            this.dataTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(570, 324);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(26, 20);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Cargar archivo";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(127, 25);
            this.txtBoxPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(201, 20);
            this.txtBoxPath.TabIndex = 2;
            // 
            // regionComboBox
            // 
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Items.AddRange(new object[] {
            "Región Centro Oriente",
            "Región Eje Cafetero - Antioquia",
            "Región Caribe",
            "Región Llano",
            "Región Centro Sur",
            "Región Pacífico"});
            this.regionComboBox.Location = new System.Drawing.Point(346, 24);
            this.regionComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(164, 21);
            this.regionComboBox.TabIndex = 3;
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // Municipios
            // 
            this.Municipios.Location = new System.Drawing.Point(401, 396);
            this.Municipios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Municipios.Name = "Municipios";
            this.Municipios.Size = new System.Drawing.Size(186, 38);
            this.Municipios.TabIndex = 4;
            this.Municipios.Text = "Generar grafico";
            this.Municipios.UseVisualStyleBackColor = true;
            this.Municipios.Click += new System.EventHandler(this.Municipios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 445);
            this.Controls.Add(this.Municipios);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Button Municipios;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

