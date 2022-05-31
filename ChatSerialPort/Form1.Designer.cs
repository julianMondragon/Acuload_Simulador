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
            this.BtnRead = new System.Windows.Forms.Button();
            this.TxtPantallaOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCOMs = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatusPort = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(325, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(166, 29);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Puerto Serial ";
            // 
            // TxtPantalla
            // 
            this.TxtPantalla.Location = new System.Drawing.Point(418, 166);
            this.TxtPantalla.Multiline = true;
            this.TxtPantalla.Name = "TxtPantalla";
            this.TxtPantalla.ReadOnly = true;
            this.TxtPantalla.Size = new System.Drawing.Size(281, 221);
            this.TxtPantalla.TabIndex = 1;
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(111, 427);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(281, 20);
            this.InputTxt.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(111, 453);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(624, 393);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 23);
            this.BtnRead.TabIndex = 4;
            this.BtnRead.Text = "Leer";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // TxtPantallaOutput
            // 
            this.TxtPantallaOutput.Location = new System.Drawing.Point(111, 166);
            this.TxtPantallaOutput.Multiline = true;
            this.TxtPantallaOutput.Name = "TxtPantallaOutput";
            this.TxtPantallaOutput.ReadOnly = true;
            this.TxtPantallaOutput.Size = new System.Drawing.Size(281, 221);
            this.TxtPantallaOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salida del Puerto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entrada del Puerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datos a enviar por el puerto ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Available Ports";
            // 
            // comboBoxCOMs
            // 
            this.comboBoxCOMs.FormattingEnabled = true;
            this.comboBoxCOMs.Location = new System.Drawing.Point(17, 40);
            this.comboBoxCOMs.Name = "comboBoxCOMs";
            this.comboBoxCOMs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOMs.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatusPort);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCOMs);
            this.groupBox1.Location = new System.Drawing.Point(111, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatusPort
            // 
            this.txtStatusPort.Location = new System.Drawing.Point(190, 23);
            this.txtStatusPort.Multiline = true;
            this.txtStatusPort.Name = "txtStatusPort";
            this.txtStatusPort.ReadOnly = true;
            this.txtStatusPort.Size = new System.Drawing.Size(138, 67);
            this.txtStatusPort.TabIndex = 12;
            this.txtStatusPort.Text = "Puerto cerrado";
            this.txtStatusPort.TextChanged += new System.EventHandler(this.txtStatusPort_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPantallaOutput);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.TxtPantalla);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxtPantalla;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.TextBox TxtPantallaOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCOMs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatusPort;
    }
}

