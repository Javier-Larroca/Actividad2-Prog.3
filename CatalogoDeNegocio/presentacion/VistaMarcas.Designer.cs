
namespace presentacion
{
    partial class VistaMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaMarcas));
            this.dGVMarcas = new System.Windows.Forms.DataGridView();
            this.AgregarMarca = new System.Windows.Forms.Button();
            this.EliminarMarca = new System.Windows.Forms.Button();
            this.EditarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVMarcas
            // 
            this.dGVMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMarcas.Location = new System.Drawing.Point(170, 12);
            this.dGVMarcas.Name = "dGVMarcas";
            this.dGVMarcas.Size = new System.Drawing.Size(215, 305);
            this.dGVMarcas.TabIndex = 0;
            // 
            // AgregarMarca
            // 
            this.AgregarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarMarca.ForeColor = System.Drawing.Color.Black;
            this.AgregarMarca.Location = new System.Drawing.Point(19, 52);
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AgregarMarca.Size = new System.Drawing.Size(109, 37);
            this.AgregarMarca.TabIndex = 2;
            this.AgregarMarca.Text = "Agregar Marca";
            this.AgregarMarca.UseVisualStyleBackColor = true;
            // 
            // EliminarMarca
            // 
            this.EliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EliminarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarMarca.ForeColor = System.Drawing.Color.Black;
            this.EliminarMarca.Location = new System.Drawing.Point(19, 128);
            this.EliminarMarca.Name = "EliminarMarca";
            this.EliminarMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EliminarMarca.Size = new System.Drawing.Size(109, 37);
            this.EliminarMarca.TabIndex = 3;
            this.EliminarMarca.Text = "Eliminar Marca";
            this.EliminarMarca.UseVisualStyleBackColor = true;
            // 
            // EditarMarca
            // 
            this.EditarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarMarca.ForeColor = System.Drawing.Color.Black;
            this.EditarMarca.Location = new System.Drawing.Point(19, 214);
            this.EditarMarca.Name = "EditarMarca";
            this.EditarMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditarMarca.Size = new System.Drawing.Size(109, 37);
            this.EditarMarca.TabIndex = 4;
            this.EditarMarca.Text = "Editar Marca";
            this.EditarMarca.UseVisualStyleBackColor = true;
            // 
            // VistaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(397, 329);
            this.Controls.Add(this.EditarMarca);
            this.Controls.Add(this.EliminarMarca);
            this.Controls.Add(this.AgregarMarca);
            this.Controls.Add(this.dGVMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaMarcas";
            this.Load += new System.EventHandler(this.VistaMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMarcas;
        private System.Windows.Forms.Button AgregarMarca;
        private System.Windows.Forms.Button EliminarMarca;
        private System.Windows.Forms.Button EditarMarca;
    }
}