namespace Calculadora_binaria
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.binario1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.binario2 = new System.Windows.Forms.TextBox();
            this.multi = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(13, 56);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(111, 20);
            this.numero1.TabIndex = 0;
            // 
            // binario1
            // 
            this.binario1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.binario1.Location = new System.Drawing.Point(145, 56);
            this.binario1.Name = "binario1";
            this.binario1.ReadOnly = true;
            this.binario1.Size = new System.Drawing.Size(111, 13);
            this.binario1.TabIndex = 1;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(13, 106);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(111, 20);
            this.numero2.TabIndex = 2;
            // 
            // binario2
            // 
            this.binario2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.binario2.Location = new System.Drawing.Point(145, 106);
            this.binario2.Name = "binario2";
            this.binario2.ReadOnly = true;
            this.binario2.Size = new System.Drawing.Size(111, 13);
            this.binario2.TabIndex = 3;
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(13, 154);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 23);
            this.multi.TabIndex = 4;
            this.multi.Text = "multiplicar";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(13, 194);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(120, 20);
            this.Resultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Multiplicadora en binario ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Primer numeo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Segundo numero";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.binario2);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.binario1);
            this.Controls.Add(this.numero1);
            this.Name = "Form1";
            this.Text = "Multi_binario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox binario1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox binario2;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

