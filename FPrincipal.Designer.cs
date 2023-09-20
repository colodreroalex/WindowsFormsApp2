namespace WindowsFormsApp2
{
    partial class FPrincipal
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
            this.L_entrada = new System.Windows.Forms.Label();
            this.L_salida = new System.Windows.Forms.Label();
            this.TB_etrada = new System.Windows.Forms.TextBox();
            this.TB_salida = new System.Windows.Forms.TextBox();
            this.B_ocultar = new System.Windows.Forms.Button();
            this.B_readOnly = new System.Windows.Forms.Button();
            this.B_deshabilitar = new System.Windows.Forms.Button();
            this.b_copiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_entrada
            // 
            this.L_entrada.AutoSize = true;
            this.L_entrada.Location = new System.Drawing.Point(15, 15);
            this.L_entrada.Name = "L_entrada";
            this.L_entrada.Size = new System.Drawing.Size(50, 13);
            this.L_entrada.TabIndex = 0;
            this.L_entrada.Text = "Entrada: ";
            // 
            // L_salida
            // 
            this.L_salida.AutoSize = true;
            this.L_salida.Location = new System.Drawing.Point(15, 42);
            this.L_salida.Name = "L_salida";
            this.L_salida.Size = new System.Drawing.Size(42, 13);
            this.L_salida.TabIndex = 1;
            this.L_salida.Text = "Salida: ";
            // 
            // TB_etrada
            // 
            this.TB_etrada.Location = new System.Drawing.Point(71, 12);
            this.TB_etrada.Name = "TB_etrada";
            this.TB_etrada.Size = new System.Drawing.Size(221, 20);
            this.TB_etrada.TabIndex = 0;
            // 
            // TB_salida
            // 
            this.TB_salida.Location = new System.Drawing.Point(71, 39);
            this.TB_salida.Name = "TB_salida";
            this.TB_salida.Size = new System.Drawing.Size(221, 20);
            this.TB_salida.TabIndex = 1;
            // 
            // B_ocultar
            // 
            this.B_ocultar.Location = new System.Drawing.Point(18, 65);
            this.B_ocultar.Name = "B_ocultar";
            this.B_ocultar.Size = new System.Drawing.Size(75, 23);
            this.B_ocultar.TabIndex = 2;
            this.B_ocultar.Text = "Ocultar";
            this.B_ocultar.UseVisualStyleBackColor = true;
            this.B_ocultar.Click += new System.EventHandler(this.B_ocultar_Click);
            // 
            // B_readOnly
            // 
            this.B_readOnly.Location = new System.Drawing.Point(217, 65);
            this.B_readOnly.Name = "B_readOnly";
            this.B_readOnly.Size = new System.Drawing.Size(75, 23);
            this.B_readOnly.TabIndex = 4;
            this.B_readOnly.Text = "Solo lectura";
            this.B_readOnly.UseVisualStyleBackColor = true;
            this.B_readOnly.Click += new System.EventHandler(this.B_readOnly_Click);
            // 
            // B_deshabilitar
            // 
            this.B_deshabilitar.Location = new System.Drawing.Point(119, 65);
            this.B_deshabilitar.Name = "B_deshabilitar";
            this.B_deshabilitar.Size = new System.Drawing.Size(75, 23);
            this.B_deshabilitar.TabIndex = 3;
            this.B_deshabilitar.Text = "Deshabilitar";
            this.B_deshabilitar.UseVisualStyleBackColor = true;
            this.B_deshabilitar.Click += new System.EventHandler(this.B_deshabilitar_Click);
            // 
            // b_copiar
            // 
            this.b_copiar.Location = new System.Drawing.Point(310, 10);
            this.b_copiar.Name = "b_copiar";
            this.b_copiar.Size = new System.Drawing.Size(75, 23);
            this.b_copiar.TabIndex = 5;
            this.b_copiar.Text = "Copiar";
            this.b_copiar.UseVisualStyleBackColor = true;
            this.b_copiar.Click += new System.EventHandler(this.b_copiar_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 108);
            this.Controls.Add(this.b_copiar);
            this.Controls.Add(this.B_deshabilitar);
            this.Controls.Add(this.B_readOnly);
            this.Controls.Add(this.B_ocultar);
            this.Controls.Add(this.TB_salida);
            this.Controls.Add(this.TB_etrada);
            this.Controls.Add(this.L_salida);
            this.Controls.Add(this.L_entrada);
            this.Name = "FPrincipal";
            this.Text = "WindowsForm: Ejemplo 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_entrada;
        private System.Windows.Forms.Label L_salida;
        private System.Windows.Forms.TextBox TB_etrada;
        private System.Windows.Forms.TextBox TB_salida;
        private System.Windows.Forms.Button B_ocultar;
        private System.Windows.Forms.Button B_readOnly;
        private System.Windows.Forms.Button B_deshabilitar;
        private System.Windows.Forms.Button b_copiar;
    }
}

