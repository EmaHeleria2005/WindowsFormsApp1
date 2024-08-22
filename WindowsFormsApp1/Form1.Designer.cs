namespace WindowsFormsApp1
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFarenheit = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.BtnCelsius = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnFarenheit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(157, 127);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(129, 22);
            this.txtCelsius.TabIndex = 0;
            // 
            // txtFarenheit
            // 
            this.txtFarenheit.Location = new System.Drawing.Point(464, 127);
            this.txtFarenheit.Name = "txtFarenheit";
            this.txtFarenheit.Size = new System.Drawing.Size(147, 22);
            this.txtFarenheit.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltitle.Location = new System.Drawing.Point(183, 29);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(451, 48);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Conversor de Temperatura";
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // BtnCelsius
            // 
            this.BtnCelsius.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCelsius.Location = new System.Drawing.Point(71, 264);
            this.BtnCelsius.Name = "BtnCelsius";
            this.BtnCelsius.Size = new System.Drawing.Size(148, 73);
            this.BtnCelsius.TabIndex = 3;
            this.BtnCelsius.Text = "Celsius a Farenheit";
            this.BtnCelsius.UseVisualStyleBackColor = false;
            this.BtnCelsius.Click += new System.EventHandler(this.BtnCelsius_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpiar.Location = new System.Drawing.Point(341, 297);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(92, 60);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnFarenheit
            // 
            this.BtnFarenheit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnFarenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFarenheit.Location = new System.Drawing.Point(572, 264);
            this.BtnFarenheit.Name = "BtnFarenheit";
            this.BtnFarenheit.Size = new System.Drawing.Size(155, 73);
            this.BtnFarenheit.TabIndex = 5;
            this.BtnFarenheit.Text = "Farenheit a Celsius";
            this.BtnFarenheit.UseVisualStyleBackColor = false;
            this.BtnFarenheit.Click += new System.EventHandler(this.BtnFarenheit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFarenheit);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCelsius);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtFarenheit);
            this.Controls.Add(this.txtCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFarenheit;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button BtnCelsius;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnFarenheit;
    }
}

