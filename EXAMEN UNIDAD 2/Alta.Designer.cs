namespace EXAMEN_UNIDAD_2
{
    partial class Alta
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNombre = new TextBox();
            tbApat = new TextBox();
            tbAmat = new TextBox();
            tbCorreo = new TextBox();
            mtbTelefono = new MaskedTextBox();
            butInsertar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 73);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 142);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 1;
            label2.Text = "APELLIDO PATERNO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 211);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 2;
            label3.Text = "APELLIDO MATERNO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 286);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "CORREO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 364);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "TELEFONO:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(146, 70);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 5;
            // 
            // tbApat
            // 
            tbApat.Location = new Point(200, 139);
            tbApat.Name = "tbApat";
            tbApat.Size = new Size(125, 27);
            tbApat.TabIndex = 6;
            // 
            // tbAmat
            // 
            tbAmat.Location = new Point(200, 208);
            tbAmat.Name = "tbAmat";
            tbAmat.Size = new Size(125, 27);
            tbAmat.TabIndex = 7;
            // 
            // tbCorreo
            // 
            tbCorreo.Location = new Point(146, 283);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(125, 27);
            tbCorreo.TabIndex = 8;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(146, 361);
            mtbTelefono.Mask = "(999)000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(125, 27);
            mtbTelefono.TabIndex = 9;
            // 
            // butInsertar
            // 
            butInsertar.Location = new Point(612, 361);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(111, 43);
            butInsertar.TabIndex = 10;
            butInsertar.Text = "INSERTAR";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_tec_lag;
            pictureBox1.Location = new Point(663, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Alta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(butInsertar);
            Controls.Add(mtbTelefono);
            Controls.Add(tbCorreo);
            Controls.Add(tbAmat);
            Controls.Add(tbApat);
            Controls.Add(tbNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Alta";
            Text = "Alta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNombre;
        private TextBox tbApat;
        private TextBox tbAmat;
        private TextBox tbCorreo;
        private MaskedTextBox mtbTelefono;
        private Button butInsertar;
        private PictureBox pictureBox1;
    }
}