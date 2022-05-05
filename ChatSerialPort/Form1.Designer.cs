namespace ChatSerialPort
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
            this.Titulo = new System.Windows.Forms.Label();
            this.TxtPantalla = new System.Windows.Forms.TextBox();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(285, 21);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(183, 29);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Acuload III .Net";
            // 
            // TxtPantalla
            // 
            this.TxtPantalla.Location = new System.Drawing.Point(109, 66);
            this.TxtPantalla.Multiline = true;
            this.TxtPantalla.Name = "TxtPantalla";
            this.TxtPantalla.Size = new System.Drawing.Size(588, 221);
            this.TxtPantalla.TabIndex = 1;
            this.TxtPantalla.TextChanged += new System.EventHandler(this.TxtPantalla_TextChanged);
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(109, 327);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(588, 20);
            this.InputTxt.TabIndex = 2;
            this.InputTxt.TextChanged += new System.EventHandler(this.InputTxt_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(620, 367);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.TxtPantalla);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxtPantalla;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Button btnEnter;
    }
}

