namespace Bloque5_Practica
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
            components = new System.ComponentModel.Container();
            txt_hora_actual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnCalcular = new Button();
            txt_escribirNumero = new Label();
            inputNumero = new TextBox();
            btnAbrirInfo = new Button();
            SuspendLayout();
            // 
            // txt_hora_actual
            // 
            txt_hora_actual.AutoSize = true;
            txt_hora_actual.Location = new Point(12, 129);
            txt_hora_actual.Name = "txt_hora_actual";
            txt_hora_actual.Size = new Size(90, 15);
            txt_hora_actual.TabIndex = 0;
            txt_hora_actual.Text = "Hora 0 0 0 0 0 0 ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 56);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(122, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular doble";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txt_escribirNumero
            // 
            txt_escribirNumero.AutoSize = true;
            txt_escribirNumero.Location = new Point(12, 9);
            txt_escribirNumero.Name = "txt_escribirNumero";
            txt_escribirNumero.Size = new Size(106, 15);
            txt_escribirNumero.TabIndex = 2;
            txt_escribirNumero.Text = "Escriba un numero";
            // 
            // inputNumero
            // 
            inputNumero.Location = new Point(12, 27);
            inputNumero.Name = "inputNumero";
            inputNumero.Size = new Size(201, 23);
            inputNumero.TabIndex = 3;
            // 
            // btnAbrirInfo
            // 
            btnAbrirInfo.Location = new Point(413, 113);
            btnAbrirInfo.Name = "btnAbrirInfo";
            btnAbrirInfo.Size = new Size(128, 28);
            btnAbrirInfo.TabIndex = 4;
            btnAbrirInfo.Text = "Abrir Informacion";
            btnAbrirInfo.UseVisualStyleBackColor = true;
            btnAbrirInfo.Click += btnAbrirInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 153);
            Controls.Add(btnAbrirInfo);
            Controls.Add(inputNumero);
            Controls.Add(txt_escribirNumero);
            Controls.Add(btnCalcular);
            Controls.Add(txt_hora_actual);
            Name = "Form1";
            Text = "Bloque 5 - Practica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_hora_actual;
        private System.Windows.Forms.Timer timer1;
        private Button btnCalcular;
        private Label txt_escribirNumero;
        private TextBox inputNumero;
        private Button btnAbrirInfo;
    }
}
