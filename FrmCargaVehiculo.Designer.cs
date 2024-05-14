namespace pryEmilianoFernandezEtapa2
{
    partial class FrmCargaVehiculo
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
            BtnCargar = new Button();
            PctVehiculo = new PictureBox();
            btnMover = new Button();
            txtCantidadVehiculo = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCargar
            // 
            BtnCargar.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCargar.Location = new Point(243, 392);
            BtnCargar.Name = "BtnCargar";
            BtnCargar.Size = new Size(176, 70);
            BtnCargar.TabIndex = 0;
            BtnCargar.Text = "Cargar";
            BtnCargar.UseVisualStyleBackColor = true;
            BtnCargar.Click += BtnCargar_Click;
            // 
            // PctVehiculo
            // 
            PctVehiculo.BackColor = Color.White;
            PctVehiculo.BorderStyle = BorderStyle.Fixed3D;
            PctVehiculo.Location = new Point(12, 12);
            PctVehiculo.Name = "PctVehiculo";
            PctVehiculo.Size = new Size(785, 364);
            PctVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            PctVehiculo.TabIndex = 1;
            PctVehiculo.TabStop = false;
            PctVehiculo.Click += PctVehiculo_Click;
            // 
            // btnMover
            // 
            btnMover.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMover.Location = new Point(579, 392);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(187, 70);
            btnMover.TabIndex = 2;
            btnMover.Text = "Mover";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // txtCantidadVehiculo
            // 
            txtCantidadVehiculo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadVehiculo.Location = new Point(44, 53);
            txtCantidadVehiculo.Name = "txtCantidadVehiculo";
            txtCantidadVehiculo.Size = new Size(100, 27);
            txtCantidadVehiculo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 4;
            label1.Text = "Coloque la cantidad\r\n de vehiculos a crear.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCantidadVehiculo);
            groupBox1.Location = new Point(12, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 89);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // FrmCargaVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(809, 485);
            Controls.Add(groupBox1);
            Controls.Add(btnMover);
            Controls.Add(PctVehiculo);
            Controls.Add(BtnCargar);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCargaVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etapa 6";
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCargar;
        private Button btnMover;
        private TextBox txtCantidadVehiculo;
        private Label label1;
        private GroupBox groupBox1;
        public PictureBox PctVehiculo;
    }
}
