namespace EXAMEN_UNIDAD_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvOpciones = new DataGridView();
            menuStrip1 = new MenuStrip();
            oPCIONESToolStripMenuItem = new ToolStripMenuItem();
            uSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            aLTAToolStripMenuItem = new ToolStripMenuItem();
            cERRARTABLAToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvOpciones).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvOpciones
            // 
            dgvOpciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvOpciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOpciones.Location = new Point(0, 79);
            dgvOpciones.Name = "dgvOpciones";
            dgvOpciones.RowHeadersWidth = 51;
            dgvOpciones.Size = new Size(800, 371);
            dgvOpciones.TabIndex = 0;
            dgvOpciones.CellContentClick += dgvOpciones_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { oPCIONESToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // oPCIONESToolStripMenuItem
            // 
            oPCIONESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uSUARIOSToolStripMenuItem, aLTAToolStripMenuItem, cERRARTABLAToolStripMenuItem, sALIRToolStripMenuItem });
            oPCIONESToolStripMenuItem.Name = "oPCIONESToolStripMenuItem";
            oPCIONESToolStripMenuItem.Size = new Size(93, 24);
            oPCIONESToolStripMenuItem.Text = "OPCIONES";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            uSUARIOSToolStripMenuItem.Size = new Size(224, 26);
            uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            uSUARIOSToolStripMenuItem.Click += uSUARIOSToolStripMenuItem_Click;
            // 
            // aLTAToolStripMenuItem
            // 
            aLTAToolStripMenuItem.Name = "aLTAToolStripMenuItem";
            aLTAToolStripMenuItem.Size = new Size(224, 26);
            aLTAToolStripMenuItem.Text = "ALTA";
            aLTAToolStripMenuItem.Click += aLTAToolStripMenuItem_Click;
            // 
            // cERRARTABLAToolStripMenuItem
            // 
            cERRARTABLAToolStripMenuItem.Name = "cERRARTABLAToolStripMenuItem";
            cERRARTABLAToolStripMenuItem.Size = new Size(224, 26);
            cERRARTABLAToolStripMenuItem.Text = "CERRAR TABLA";
            cERRARTABLAToolStripMenuItem.Click += cERRARTABLAToolStripMenuItem_Click;
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(224, 26);
            sALIRToolStripMenuItem.Text = "SALIR";
            sALIRToolStripMenuItem.Click += sALIRToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_tec_lag;
            pictureBox1.Location = new Point(663, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(dgvOpciones);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOpciones).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOpciones;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oPCIONESToolStripMenuItem;
        private ToolStripMenuItem aLTAToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private ToolStripMenuItem cERRARTABLAToolStripMenuItem;
    }
}
