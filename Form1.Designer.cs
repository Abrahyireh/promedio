namespace notasDeEstudianteyPromedio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Nota1 = new TextBox();
            txt_Nota2 = new TextBox();
            txt_Nota3 = new TextBox();
            txt_Nota4 = new TextBox();
            txt_Promedio = new TextBox();
            btn_Calcualar = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Estado = new TextBox();
            SuspendLayout();
            // 
            // txt_Nota1
            // 
            txt_Nota1.Location = new Point(77, 66);
            txt_Nota1.Name = "txt_Nota1";
            txt_Nota1.Size = new Size(100, 23);
            txt_Nota1.TabIndex = 0;
            // 
            // txt_Nota2
            // 
            txt_Nota2.Location = new Point(77, 112);
            txt_Nota2.Name = "txt_Nota2";
            txt_Nota2.Size = new Size(100, 23);
            txt_Nota2.TabIndex = 1;
            // 
            // txt_Nota3
            // 
            txt_Nota3.Location = new Point(77, 155);
            txt_Nota3.Name = "txt_Nota3";
            txt_Nota3.Size = new Size(100, 23);
            txt_Nota3.TabIndex = 2;
            // 
            // txt_Nota4
            // 
            txt_Nota4.Location = new Point(77, 202);
            txt_Nota4.Name = "txt_Nota4";
            txt_Nota4.Size = new Size(100, 23);
            txt_Nota4.TabIndex = 3;
            // 
            // txt_Promedio
            // 
            txt_Promedio.Location = new Point(77, 288);
            txt_Promedio.Name = "txt_Promedio";
            txt_Promedio.Size = new Size(100, 23);
            txt_Promedio.TabIndex = 4;
            // 
            // btn_Calcualar
            // 
            btn_Calcualar.Location = new Point(25, 392);
            btn_Calcualar.Name = "btn_Calcualar";
            btn_Calcualar.Size = new Size(75, 23);
            btn_Calcualar.TabIndex = 5;
            btn_Calcualar.Text = "Calcular";
            btn_Calcualar.UseVisualStyleBackColor = true;
            btn_Calcualar.Click += btn_Calcualar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(124, 392);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(75, 23);
            btn_Limpiar.TabIndex = 6;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.Red;
            btn_Salir.ForeColor = SystemColors.ButtonHighlight;
            btn_Salir.Location = new Point(225, 392);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(75, 23);
            btn_Salir.TabIndex = 7;
            btn_Salir.Text = "X";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 69);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 8;
            label1.Text = "NotaP1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 115);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "NotaP2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 163);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 10;
            label3.Text = "NotaP3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 202);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 11;
            label4.Text = "NotaP4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 12;
            label5.Text = "Promedio";
            // 
            // txt_Estado
            // 
            txt_Estado.Location = new Point(77, 340);
            txt_Estado.Name = "txt_Estado";
            txt_Estado.Size = new Size(100, 23);
            txt_Estado.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(txt_Estado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcualar);
            Controls.Add(txt_Promedio);
            Controls.Add(txt_Nota4);
            Controls.Add(txt_Nota3);
            Controls.Add(txt_Nota2);
            Controls.Add(txt_Nota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nota1;
        private TextBox txt_Nota2;
        private TextBox txt_Nota3;
        private TextBox txt_Nota4;
        private TextBox txt_Promedio;
        private Button btn_Calcualar;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Estado;
    }
}