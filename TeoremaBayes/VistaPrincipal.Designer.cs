namespace TeoremaBayes
{
    partial class VistaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPrincipal));
            this.txtProbabilidadEnunciado = new System.Windows.Forms.TextBox();
            this.btnTeorema = new System.Windows.Forms.Button();
            this.btnLlenarTabla = new System.Windows.Forms.Button();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.cbPregunta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProbabilidadEnunciado
            // 
            this.txtProbabilidadEnunciado.Enabled = false;
            this.txtProbabilidadEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProbabilidadEnunciado.Location = new System.Drawing.Point(17, 12);
            this.txtProbabilidadEnunciado.Multiline = true;
            this.txtProbabilidadEnunciado.Name = "txtProbabilidadEnunciado";
            this.txtProbabilidadEnunciado.Size = new System.Drawing.Size(922, 129);
            this.txtProbabilidadEnunciado.TabIndex = 7;
            // 
            // btnTeorema
            // 
            this.btnTeorema.Location = new System.Drawing.Point(945, 36);
            this.btnTeorema.Name = "btnTeorema";
            this.btnTeorema.Size = new System.Drawing.Size(143, 48);
            this.btnTeorema.TabIndex = 9;
            this.btnTeorema.Text = "P(A|B)";
            this.btnTeorema.UseVisualStyleBackColor = true;
            this.btnTeorema.Click += new System.EventHandler(this.btnTeorema_Click);
            // 
            // btnLlenarTabla
            // 
            this.btnLlenarTabla.Location = new System.Drawing.Point(945, 90);
            this.btnLlenarTabla.Name = "btnLlenarTabla";
            this.btnLlenarTabla.Size = new System.Drawing.Size(143, 48);
            this.btnLlenarTabla.TabIndex = 10;
            this.btnLlenarTabla.Text = "Datos";
            this.btnLlenarTabla.UseVisualStyleBackColor = true;
            // 
            // DGVDatos
            // 
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Location = new System.Drawing.Point(17, 147);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.Size = new System.Drawing.Size(1071, 348);
            this.DGVDatos.TabIndex = 11;
            // 
            // cbPregunta
            // 
            this.cbPregunta.FormattingEnabled = true;
            this.cbPregunta.Location = new System.Drawing.Point(945, 9);
            this.cbPregunta.Name = "cbPregunta";
            this.cbPregunta.Size = new System.Drawing.Size(136, 21);
            this.cbPregunta.TabIndex = 12;
            this.cbPregunta.SelectedIndexChanged += new System.EventHandler(this.cbPregunta_SelectedIndexChanged);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 507);
            this.Controls.Add(this.cbPregunta);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.btnLlenarTabla);
            this.Controls.Add(this.btnTeorema);
            this.Controls.Add(this.txtProbabilidadEnunciado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaPrincipal";
            this.Text = "Teorema de bayes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProbabilidadEnunciado;
        private System.Windows.Forms.Button btnTeorema;
        private System.Windows.Forms.Button btnLlenarTabla;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.ComboBox cbPregunta;
    }
}

