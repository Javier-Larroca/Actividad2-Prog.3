﻿
namespace presentacion
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.ListarMarcas = new System.Windows.Forms.Button();
            this.ListarCategorias = new System.Windows.Forms.Button();
            this.dGVArticulos = new System.Windows.Forms.DataGridView();
            this.pBArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.modificarArticulo = new System.Windows.Forms.Button();
            this.eliminarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarMarcas
            // 
            this.ListarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ListarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarMarcas.ForeColor = System.Drawing.Color.Black;
            this.ListarMarcas.Location = new System.Drawing.Point(616, 322);
            this.ListarMarcas.Name = "ListarMarcas";
            this.ListarMarcas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListarMarcas.Size = new System.Drawing.Size(109, 37);
            this.ListarMarcas.TabIndex = 0;
            this.ListarMarcas.Text = "Listar Marcas";
            this.ListarMarcas.UseVisualStyleBackColor = true;
            this.ListarMarcas.Click += new System.EventHandler(this.ListarMarcas_Click);
            // 
            // ListarCategorias
            // 
            this.ListarCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ListarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarCategorias.ForeColor = System.Drawing.Color.Black;
            this.ListarCategorias.Location = new System.Drawing.Point(501, 322);
            this.ListarCategorias.Name = "ListarCategorias";
            this.ListarCategorias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListarCategorias.Size = new System.Drawing.Size(109, 37);
            this.ListarCategorias.TabIndex = 1;
            this.ListarCategorias.Text = "Listar Categorias";
            this.ListarCategorias.UseVisualStyleBackColor = true;
            this.ListarCategorias.Click += new System.EventHandler(this.ListarCategorias_Click);
            // 
            // dGVArticulos
            // 
            this.dGVArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVArticulos.ColumnHeadersHeight = 25;
            this.dGVArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVArticulos.Location = new System.Drawing.Point(22, 26);
            this.dGVArticulos.Name = "dGVArticulos";
            this.dGVArticulos.Size = new System.Drawing.Size(433, 265);
            this.dGVArticulos.TabIndex = 2;
            this.dGVArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dGVArticulos_MouseClick);
            // 
            // pBArticulo
            // 
            this.pBArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBArticulo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pBArticulo.ErrorImage")));
            this.pBArticulo.Location = new System.Drawing.Point(482, 55);
            this.pBArticulo.Name = "pBArticulo";
            this.pBArticulo.Size = new System.Drawing.Size(228, 205);
            this.pBArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBArticulo.TabIndex = 3;
            this.pBArticulo.TabStop = false;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(22, 322);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarArticulo.Size = new System.Drawing.Size(109, 37);
            this.btnAgregarArticulo.TabIndex = 4;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // modificarArticulo
            // 
            this.modificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarArticulo.ForeColor = System.Drawing.Color.Black;
            this.modificarArticulo.Location = new System.Drawing.Point(146, 322);
            this.modificarArticulo.Name = "modificarArticulo";
            this.modificarArticulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modificarArticulo.Size = new System.Drawing.Size(109, 37);
            this.modificarArticulo.TabIndex = 5;
            this.modificarArticulo.Text = "Modificar Articulo";
            this.modificarArticulo.UseVisualStyleBackColor = true;
            this.modificarArticulo.Click += new System.EventHandler(this.modificarArticulo_Click);
            // 
            // eliminarArticulo
            // 
            this.eliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.eliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarArticulo.ForeColor = System.Drawing.Color.Black;
            this.eliminarArticulo.Location = new System.Drawing.Point(271, 322);
            this.eliminarArticulo.Name = "eliminarArticulo";
            this.eliminarArticulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eliminarArticulo.Size = new System.Drawing.Size(109, 37);
            this.eliminarArticulo.TabIndex = 6;
            this.eliminarArticulo.Text = "Eliminar Articulo";
            this.eliminarArticulo.UseVisualStyleBackColor = true;
            this.eliminarArticulo.Click += new System.EventHandler(this.eliminarArticulo_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(737, 371);
            this.Controls.Add(this.eliminarArticulo);
            this.Controls.Add(this.modificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.pBArticulo);
            this.Controls.Add(this.dGVArticulos);
            this.Controls.Add(this.ListarCategorias);
            this.Controls.Add(this.ListarMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogador de articulos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListarMarcas;
        private System.Windows.Forms.Button ListarCategorias;
        private System.Windows.Forms.DataGridView dGVArticulos;
        private System.Windows.Forms.PictureBox pBArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button modificarArticulo;
        private System.Windows.Forms.Button eliminarArticulo;
    }
}

