
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
            this.ListarMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListarMarcas
            // 
            this.ListarMarcas.Location = new System.Drawing.Point(12, 21);
            this.ListarMarcas.Name = "ListarMarcas";
            this.ListarMarcas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListarMarcas.Size = new System.Drawing.Size(109, 37);
            this.ListarMarcas.TabIndex = 0;
            this.ListarMarcas.Text = "Listar Marcas";
            this.ListarMarcas.UseVisualStyleBackColor = true;
            this.ListarMarcas.Click += new System.EventHandler(this.ListarMarcas_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 329);
            this.Controls.Add(this.ListarMarcas);
            this.Name = "VentanaPrincipal";
            this.Text = "Catalogador de articulos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListarMarcas;
    }
}

