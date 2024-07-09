namespace Ejercicio_Redes
{
    partial class foquitos
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
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            lblSwitchRojo = new Label();
            lblSwitchVerde = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 137);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "ROJO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 266);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "VERDE:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(356, 140);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(356, 266);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 3;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // lblSwitchRojo
            // 
            lblSwitchRojo.AutoSize = true;
            lblSwitchRojo.Location = new Point(410, 137);
            lblSwitchRojo.Name = "lblSwitchRojo";
            lblSwitchRojo.Size = new Size(71, 20);
            lblSwitchRojo.TabIndex = 4;
            lblSwitchRojo.Text = "Apagado";
            // 
            // lblSwitchVerde
            // 
            lblSwitchVerde.AutoSize = true;
            lblSwitchVerde.Location = new Point(410, 266);
            lblSwitchVerde.Name = "lblSwitchVerde";
            lblSwitchVerde.Size = new Size(71, 20);
            lblSwitchVerde.TabIndex = 5;
            lblSwitchVerde.Text = "Apagado";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(172, 134);
            txtRojo.Multiline = true;
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(40, 34);
            txtRojo.TabIndex = 6;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(172, 260);
            txtVerde.Multiline = true;
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(40, 34);
            txtVerde.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(27, 38);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 8;
            button1.Text = "Abrir Conexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(198, 38);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 9;
            button2.Text = "Cerrar Conexion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // foquitos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(lblSwitchVerde);
            Controls.Add(lblSwitchRojo);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "foquitos";
            Text = "foquitos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label lblSwitchRojo;
        private Label lblSwitchVerde;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private Button button1;
        private Button button2;
    }
}