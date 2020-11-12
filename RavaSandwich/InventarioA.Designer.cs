﻿namespace RavaSandwich
{
    partial class InventarioA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioA));
            this.tablaInventario = new System.Windows.Forms.DataGridView();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.btnAgregarI = new System.Windows.Forms.Button();
            this.btnEliminarI = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaInventario
            // 
            this.tablaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInventario.Location = new System.Drawing.Point(22, 116);
            this.tablaInventario.Name = "tablaInventario";
            this.tablaInventario.Size = new System.Drawing.Size(654, 318);
            this.tablaInventario.TabIndex = 0;
            this.tablaInventario.Text = "dataGridView1";
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.YellowGreen;
            this.btnIngreso.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIngreso.Location = new System.Drawing.Point(707, 114);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(163, 62);
            this.btnIngreso.TabIndex = 1;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnConsumo
            // 
            this.btnConsumo.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConsumo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConsumo.Location = new System.Drawing.Point(707, 182);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(162, 62);
            this.btnConsumo.TabIndex = 2;
            this.btnConsumo.Text = "Consumo";
            this.btnConsumo.UseVisualStyleBackColor = false;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // btnAgregarI
            // 
            this.btnAgregarI.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgregarI.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarI.Location = new System.Drawing.Point(706, 250);
            this.btnAgregarI.Name = "btnAgregarI";
            this.btnAgregarI.Size = new System.Drawing.Size(163, 61);
            this.btnAgregarI.TabIndex = 3;
            this.btnAgregarI.Text = "Agregar ingrediente";
            this.btnAgregarI.UseVisualStyleBackColor = false;
            // 
            // btnEliminarI
            // 
            this.btnEliminarI.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarI.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarI.Location = new System.Drawing.Point(706, 317);
            this.btnEliminarI.Name = "btnEliminarI";
            this.btnEliminarI.Size = new System.Drawing.Size(163, 62);
            this.btnEliminarI.TabIndex = 4;
            this.btnEliminarI.Text = "Eliminar Ingrediente";
            this.btnEliminarI.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMenu.Location = new System.Drawing.Point(571, 35);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(298, 58);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Volver al menú principal";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrarSesion.Location = new System.Drawing.Point(707, 399);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(162, 34);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Green;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnActualizar.Location = new System.Drawing.Point(397, 35);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 57);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar Tabla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // InventarioA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(890, 489);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnEliminarI);
            this.Controls.Add(this.btnAgregarI);
            this.Controls.Add(this.btnConsumo);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.tablaInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventarioA";
            this.Text = "Inventario de Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaInventario;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnConsumo;
        private System.Windows.Forms.Button btnAgregarI;
        private System.Windows.Forms.Button btnEliminarI;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnActualizar;
    }
}