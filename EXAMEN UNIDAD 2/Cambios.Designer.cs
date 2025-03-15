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
            pictureBox1.Location = new Point(739, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 94);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 1;
            label1.Text = "ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 193);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 3;
            label3.Text = "APELLIDO PATERNO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 193);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 4;
            label4.Text = "APELLIDO MATERNO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 311);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 6;
            label6.Text = "CORREO:";
            // 
            // tbId
            // 
            tbId.Location = new Point(91, 94);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(125, 27);
            tbId.TabIndex = 7;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(91, 186);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 8;
            // 
            // tbApat
            // 
            tbApat.Location = new Point(392, 190);
            tbApat.Name = "tbApat";
            tbApat.Size = new Size(125, 27);
            tbApat.TabIndex = 9;
            // 
            // tbAmat
            // 
            tbAmat.Location = new Point(704, 190);
            tbAmat.Name = "tbAmat";
            tbAmat.Size = new Size(125, 27);
            tbAmat.TabIndex = 10;
            // 
            // mtbCorreo
            // 
            mtbCorreo.Location = new Point(241, 304);
            mtbCorreo.Mask = "(999)000-0000";
            mtbCorreo.Name = "mtbCorreo";
            mtbCorreo.Size = new Size(125, 27);
            mtbCorreo.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 311);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 12;
            label5.Text = "TELEFONO:";
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(547, 308);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(125, 27);
            tbTelefono.TabIndex = 13;
            // 
            // butActualizar
            // 
            butActualizar.Location = new Point(423, 391);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(109, 29);
            butActualizar.TabIndex = 14;
            butActualizar.Text = "ACTUALIZAR";
            butActualizar.UseVisualStyleBackColor = true;
            butActualizar.Click += butActualizar_Click;
            // 
            // butEliminar
            // 
            butEliminar.Location = new Point(562, 391);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(94, 29);
            butEliminar.TabIndex = 15;
            butEliminar.Text = "ELIMINAR";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += button2_Click;
            // 
            // butCancelar
            // 
            butCancelar.Location = new Point(690, 391);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(94, 29);
            butCancelar.TabIndex = 16;
            butCancelar.Text = "CANCELAR";
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // Cambios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(866, 450);
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
            Name = "Cambios";
            Text = "Cambios";
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