namespace Bloque4_Practica
{
    partial class Principal
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
            txt_nombre = new Label();
            inputNombre = new TextBox();
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.AutoSize = true;
            txt_nombre.Location = new Point(12, 57);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(103, 15);
            txt_nombre.TabIndex = 0;
            txt_nombre.Text = "Escribe tu nombre";
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(121, 54);
            inputNombre.Name = "inputNombre";
            inputNombre.PlaceholderText = "Tu nombre va a aqui";
            inputNombre.Size = new Size(223, 23);
            inputNombre.TabIndex = 1;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(350, 57);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(75, 23);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Saludar!";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 121);
            Controls.Add(btnSaludar);
            Controls.Add(inputNombre);
            Controls.Add(txt_nombre);
            Name = "Principal";
            Text = "Bloque 4 - Practica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_nombre;
        private TextBox inputNombre;
        private Button btnSaludar;
    }
}
