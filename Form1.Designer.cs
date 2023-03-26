namespace Calculadora
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
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScreen
            // 
            this.txtScreen.Location = new System.Drawing.Point(12, 27);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(258, 60);
            this.txtScreen.TabIndex = 0;
            this.txtScreen.TextChanged += new System.EventHandler(this.txtScreen_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "8";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(281, 227);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(91, 40);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(281, 273);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(91, 39);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(284, 59);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 28);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Clear";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(281, 184);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(91, 37);
            this.btnResta.TabIndex = 6;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(281, 103);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(91, 32);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnPunto.Location = new System.Drawing.Point(195, 273);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 29);
            this.btnPunto.TabIndex = 8;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(281, 141);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(91, 37);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "X";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 103);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 38);
            this.button10.TabIndex = 10;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 157);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(73, 38);
            this.button11.TabIndex = 11;
            this.button11.Text = "4";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(100, 157);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 38);
            this.button12.TabIndex = 12;
            this.button12.Text = "5";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(195, 212);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 38);
            this.button13.TabIndex = 13;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(100, 212);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 38);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(195, 157);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 38);
            this.button15.TabIndex = 15;
            this.button15.Text = "6";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(195, 103);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(73, 38);
            this.button16.TabIndex = 16;
            this.button16.Text = "9";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 212);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(73, 38);
            this.button17.TabIndex = 17;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(100, 265);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 38);
            this.button18.TabIndex = 18;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 315);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
    }
}

