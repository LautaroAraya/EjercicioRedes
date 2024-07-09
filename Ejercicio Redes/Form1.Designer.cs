namespace Ejercicio_Redes
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
            label1 = new Label();
            btnAbrir = new Button();
            txtArchivo = new TextBox();
            txtContenido = new TextBox();
            label2 = new Label();
            btnLeer = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnCopia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 79);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Arcivos";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(613, 75);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(94, 29);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir...";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtArchivo
            // 
            txtArchivo.Location = new Point(158, 76);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.ReadOnly = true;
            txtArchivo.Size = new Size(431, 27);
            txtArchivo.TabIndex = 2;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(158, 172);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ReadOnly = true;
            txtContenido.Size = new Size(431, 195);
            txtContenido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 139);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Contenido:";
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(613, 110);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(94, 29);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer...";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnCopia
            // 
            btnCopia.Location = new Point(595, 172);
            btnCopia.Name = "btnCopia";
            btnCopia.Size = new Size(171, 29);
            btnCopia.TabIndex = 6;
            btnCopia.Text = "Copia de Seguridad...";
            btnCopia.UseVisualStyleBackColor = true;
            btnCopia.Click += btnCopia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCopia);
            Controls.Add(btnLeer);
            Controls.Add(label2);
            Controls.Add(txtContenido);
            Controls.Add(txtArchivo);
            Controls.Add(btnAbrir);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lector de Archivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAbrir;
        private TextBox txtArchivo;
        private TextBox txtContenido;
        private Label label2;
        private Button btnLeer;
        private OpenFileDialog openFileDialog1;
        private Button btnCopia;
    }
}
