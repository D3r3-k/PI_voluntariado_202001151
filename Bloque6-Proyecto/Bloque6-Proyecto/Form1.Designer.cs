namespace Bloque6_Proyecto
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
            inputTarea = new TextBox();
            inputDescripcion = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            listaTareasbox = new ListBox();
            btnCompletar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label_hora = new Label();
            SuspendLayout();
            // 
            // inputTarea
            // 
            inputTarea.Location = new Point(138, 12);
            inputTarea.Name = "inputTarea";
            inputTarea.Size = new Size(528, 23);
            inputTarea.TabIndex = 0;
            // 
            // inputDescripcion
            // 
            inputDescripcion.Location = new Point(138, 41);
            inputDescripcion.Multiline = true;
            inputDescripcion.Name = "inputDescripcion";
            inputDescripcion.Size = new Size(528, 74);
            inputDescripcion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(591, 121);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // listaTareasbox
            // 
            listaTareasbox.FormattingEnabled = true;
            listaTareasbox.ItemHeight = 15;
            listaTareasbox.Location = new Point(12, 150);
            listaTareasbox.Name = "listaTareasbox";
            listaTareasbox.Size = new Size(654, 349);
            listaTareasbox.TabIndex = 5;
            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(591, 505);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(75, 23);
            btnCompletar.TabIndex = 6;
            btnCompletar.Text = "Completar";
            btnCompletar.UseVisualStyleBackColor = true;
            btnCompletar.Click += btnCompletar_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label_hora
            // 
            label_hora.AutoSize = true;
            label_hora.Location = new Point(12, 514);
            label_hora.Name = "label_hora";
            label_hora.Size = new Size(33, 15);
            label_hora.TabIndex = 7;
            label_hora.Text = "Hora";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 538);
            Controls.Add(label_hora);
            Controls.Add(btnCompletar);
            Controls.Add(listaTareasbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(inputDescripcion);
            Controls.Add(inputTarea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTarea;
        private TextBox inputDescripcion;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Button btnCompletar;
        private System.Windows.Forms.Timer timer1;
        private Label label_hora;
        public ListBox listaTareasbox;
    }
}
