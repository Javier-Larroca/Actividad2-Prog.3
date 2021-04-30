
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.dGVMarcas.Size = new System.Drawing.Size(249, 305);
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
            this.AgregarMarca.Location = new System.Drawing.Point(19, 33);
            this.AgregarMarca.Name = "AgregarMarca";
            this.AgregarMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AgregarMarca.Size = new System.Drawing.Size(109, 37);
            this.AgregarMarca.TabIndex = 2;
            this.AgregarMarca.Text = "Agregar Marca";
            this.AgregarMarca.UseVisualStyleBackColor = true;
            this.AgregarMarca.Click += new System.EventHandler(this.AgregarMarca_Click);
            // 
            // EliminarMarca
            // 
            this.EliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EliminarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarMarca.ForeColor = System.Drawing.Color.Black;
            this.EliminarMarca.Location = new System.Drawing.Point(19, 112);
            this.EliminarMarca.Name = "EliminarMarca";
            this.EliminarMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EliminarMarca.Size = new System.Drawing.Size(109, 37);
            this.EliminarMarca.TabIndex = 3;
            this.EliminarMarca.Text = "Eliminar Marca";
            this.EliminarMarca.UseVisualStyleBackColor = true;
            this.EliminarMarca.Click += new System.EventHandler(this.EliminarMarca_Click);
            // 
            // EditarMarca
            // 
            this.EditarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarMarca.ForeColor = System.Drawing.Color.Black;
            this.EditarMarca.Location = new System.Drawing.Point(19, 188);
            this.EditarMarca.Name = "EditarMarca";
            this.EditarMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditarMarca.Size = new System.Drawing.Size(109, 37);
            this.EditarMarca.TabIndex = 4;
            this.EditarMarca.Text = "Editar Marca";
            this.EditarMarca.UseVisualStyleBackColor = true;
            this.EditarMarca.Click += new System.EventHandler(this.EditarMarca_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(19, 263);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(431, 329);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}