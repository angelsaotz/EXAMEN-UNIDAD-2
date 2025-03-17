namespace EXAMEN_UNIDAD_2
{
    partial class Cambios
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            tbId = new TextBox();
            tbNombre = new TextBox();
            tbApat = new TextBox();
            tbAmat = new TextBox();
            mtbCorreo = new MaskedTextBox();
            label5 = new Label();
            tbTelefono = new TextBox();
            butActualizar = new Button();
            butEliminar = new Button();
            butCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_tec_lag;
            pictureBox1.Location = new Point(831, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 94);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 1;
            label1.Text = "ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 193);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 193);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 3;
            label3.Text = "APELLIDO PATERNO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(615, 193);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 4;
            label4.Text = "APELLIDO MATERNO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 311);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 6;
            label6.Text = "CORREO:";
            // 
            // tbId
            // 
            tbId.Location = new Point(102, 94);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(140, 27);
            tbId.TabIndex = 7;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(102, 186);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(140, 27);
            tbNombre.TabIndex = 8;
            // 
            // tbApat
            // 
            tbApat.Location = new Point(441, 190);
            tbApat.Name = "tbApat";
            tbApat.Size = new Size(140, 27);
            tbApat.TabIndex = 9;
            // 
            // tbAmat
            // 
            tbAmat.Location = new Point(792, 190);
            tbAmat.Name = "tbAmat";
            tbAmat.Size = new Size(140, 27);
            tbAmat.TabIndex = 10;
            // 
            // mtbCorreo
            // 
            mtbCorreo.Location = new Point(271, 304);
            mtbCorreo.Mask = "(999)000-0000";
            mtbCorreo.Name = "mtbCorreo";
            mtbCorreo.Size = new Size(140, 27);
            mtbCorreo.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 311);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 12;
            label5.Text = "TELEFONO:";
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(615, 308);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(140, 27);
            tbTelefono.TabIndex = 13;
            // 
            // butActualizar
            // 
            butActualizar.BackColor = Color.FromArgb(0, 0, 64);
            butActualizar.FlatStyle = FlatStyle.Popup;
            butActualizar.ForeColor = Color.White;
            butActualizar.Location = new Point(476, 391);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(123, 29);
            butActualizar.TabIndex = 14;
            butActualizar.Text = "ACTUALIZAR";
            butActualizar.UseVisualStyleBackColor = false;
            butActualizar.Click += butActualizar_Click;
            // 
            // butEliminar
            // 
            butEliminar.BackColor = Color.Red;
            butEliminar.FlatStyle = FlatStyle.Popup;
            butEliminar.ForeColor = SystemColors.ButtonHighlight;
            butEliminar.Location = new Point(632, 391);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(106, 29);
            butEliminar.TabIndex = 15;
            butEliminar.Text = "ELIMINAR";
            butEliminar.UseVisualStyleBackColor = false;
            butEliminar.Click += button2_Click;
            // 
            // butCancelar
            // 
            butCancelar.BackColor = Color.FromArgb(192, 0, 0);
            butCancelar.FlatStyle = FlatStyle.Popup;
            butCancelar.Location = new Point(776, 391);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(106, 29);
            butCancelar.TabIndex = 16;
            butCancelar.Text = "CANCELAR";
            butCancelar.UseVisualStyleBackColor = false;
            butCancelar.Click += butCancelar_Click;
            // 
            // Cambios
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(974, 450);
            Controls.Add(butCancelar);
            Controls.Add(butEliminar);
            Controls.Add(butActualizar);
            Controls.Add(tbTelefono);
            Controls.Add(label5);
            Controls.Add(mtbCorreo);
            Controls.Add(tbAmat);
            Controls.Add(tbApat);
            Controls.Add(tbNombre);
            Controls.Add(tbId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Cambios";
            Text = "CAMBIOS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox tbId;
        private TextBox tbNombre;
        private TextBox tbApat;
        private TextBox tbAmat;
        private MaskedTextBox mtbCorreo;
        private Label label5;
        private TextBox tbTelefono;
        private Button butActualizar;
        private Button butEliminar;
        private Button butCancelar;
    }
}