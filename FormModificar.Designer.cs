namespace Ficheros_XML
{
    partial class FormModificar
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
            this.cbDNI = new System.Windows.Forms.ComboBox();
            this.btnOpcion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDNI
            // 
            this.cbDNI.FormattingEnabled = true;
            this.cbDNI.Location = new System.Drawing.Point(12, 47);
            this.cbDNI.Name = "cbDNI";
            this.cbDNI.Size = new System.Drawing.Size(139, 21);
            this.cbDNI.TabIndex = 0;
            // 
            // btnOpcion
            // 
            this.btnOpcion.Location = new System.Drawing.Point(184, 12);
            this.btnOpcion.Name = "btnOpcion";
            this.btnOpcion.Size = new System.Drawing.Size(134, 42);
            this.btnOpcion.TabIndex = 1;
            this.btnOpcion.UseVisualStyleBackColor = true;
            this.btnOpcion.Click += new System.EventHandler(this.btnOpcion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(184, 60);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 109);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOpcion);
            this.Controls.Add(this.cbDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormModificar";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDNI;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnOpcion;
    }
}