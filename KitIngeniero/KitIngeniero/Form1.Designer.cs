namespace KitIngeniero
{
    partial class home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.footer = new System.Windows.Forms.Panel();
            this.btnFisica = new System.Windows.Forms.PictureBox();
            this.btnFormGene = new System.Windows.Forms.PictureBox();
            this.btnCalculadora = new System.Windows.Forms.PictureBox();
            this.btnConvertUnid = new System.Windows.Forms.PictureBox();
            this.btnGaussJordan = new System.Windows.Forms.PictureBox();
            this.lblFisica = new System.Windows.Forms.Label();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblGaussJordan = new System.Windows.Forms.Label();
            this.lblFormGene = new System.Windows.Forms.Label();
            this.lblConvertUnid = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.converUnidades = new KitIngeniero.Conversion_de_Unidades();
            this.formGene = new KitIngeniero.Formula_General();
            this.gaussJordan = new KitIngeniero.Gauss_Jordan();
            this.calculadora = new KitIngeniero.Calculadora();
            this.fisica = new KitIngeniero.Fisica();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormGene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConvertUnid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGaussJordan)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.footer.Controls.Add(this.btnFisica);
            this.footer.Controls.Add(this.btnFormGene);
            this.footer.Controls.Add(this.btnCalculadora);
            this.footer.Controls.Add(this.btnConvertUnid);
            this.footer.Controls.Add(this.btnGaussJordan);
            this.footer.Controls.Add(this.lblFisica);
            this.footer.Controls.Add(this.lblCalculadora);
            this.footer.Controls.Add(this.lblGaussJordan);
            this.footer.Controls.Add(this.lblFormGene);
            this.footer.Controls.Add(this.lblConvertUnid);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 442);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(359, 58);
            this.footer.TabIndex = 0;
            // 
            // btnFisica
            // 
            this.btnFisica.Image = ((System.Drawing.Image)(resources.GetObject("btnFisica.Image")));
            this.btnFisica.Location = new System.Drawing.Point(299, 8);
            this.btnFisica.Name = "btnFisica";
            this.btnFisica.Size = new System.Drawing.Size(28, 28);
            this.btnFisica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFisica.TabIndex = 10;
            this.btnFisica.TabStop = false;
            this.btnFisica.Click += new System.EventHandler(this.pictureBox5_Click);
            this.btnFisica.MouseLeave += new System.EventHandler(this.btnFisica_MouseLeave);
            this.btnFisica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFisica_MouseMove);
            // 
            // btnFormGene
            // 
            this.btnFormGene.Image = ((System.Drawing.Image)(resources.GetObject("btnFormGene.Image")));
            this.btnFormGene.Location = new System.Drawing.Point(95, 5);
            this.btnFormGene.Name = "btnFormGene";
            this.btnFormGene.Size = new System.Drawing.Size(35, 35);
            this.btnFormGene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFormGene.TabIndex = 8;
            this.btnFormGene.TabStop = false;
            this.btnFormGene.Click += new System.EventHandler(this.pictureBox2_Click);
            this.btnFormGene.MouseLeave += new System.EventHandler(this.btnFormGene_MouseLeave);
            this.btnFormGene.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFormGene_MouseMove);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.Location = new System.Drawing.Point(232, 8);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(28, 28);
            this.btnCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCalculadora.TabIndex = 9;
            this.btnCalculadora.TabStop = false;
            this.btnCalculadora.Click += new System.EventHandler(this.pictureBox4_Click);
            this.btnCalculadora.MouseLeave += new System.EventHandler(this.btnCalculadora_MouseLeave);
            this.btnCalculadora.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCalculadora_MouseMove);
            // 
            // btnConvertUnid
            // 
            this.btnConvertUnid.Image = global::KitIngeniero.Properties.Resources.imgUnidadesBlanca;
            this.btnConvertUnid.Location = new System.Drawing.Point(31, 8);
            this.btnConvertUnid.Name = "btnConvertUnid";
            this.btnConvertUnid.Size = new System.Drawing.Size(28, 28);
            this.btnConvertUnid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConvertUnid.TabIndex = 7;
            this.btnConvertUnid.TabStop = false;
            this.btnConvertUnid.Click += new System.EventHandler(this.btn_Click);
            this.btnConvertUnid.MouseLeave += new System.EventHandler(this.btnConvertUnid_MouseLeave);
            this.btnConvertUnid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnConvertUnid_MouseMove);
            // 
            // btnGaussJordan
            // 
            this.btnGaussJordan.Image = ((System.Drawing.Image)(resources.GetObject("btnGaussJordan.Image")));
            this.btnGaussJordan.Location = new System.Drawing.Point(165, 8);
            this.btnGaussJordan.Name = "btnGaussJordan";
            this.btnGaussJordan.Size = new System.Drawing.Size(28, 28);
            this.btnGaussJordan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGaussJordan.TabIndex = 8;
            this.btnGaussJordan.TabStop = false;
            this.btnGaussJordan.Click += new System.EventHandler(this.pictureBox3_Click);
            this.btnGaussJordan.MouseLeave += new System.EventHandler(this.btnGaussJordan_MouseLeave);
            this.btnGaussJordan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGaussJordan_MouseMove);
            // 
            // lblFisica
            // 
            this.lblFisica.AutoSize = true;
            this.lblFisica.BackColor = System.Drawing.Color.Transparent;
            this.lblFisica.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFisica.ForeColor = System.Drawing.Color.White;
            this.lblFisica.Location = new System.Drawing.Point(296, 39);
            this.lblFisica.Name = "lblFisica";
            this.lblFisica.Size = new System.Drawing.Size(35, 15);
            this.lblFisica.TabIndex = 8;
            this.lblFisica.Text = "Física";
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.BackColor = System.Drawing.Color.Transparent;
            this.lblCalculadora.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.ForeColor = System.Drawing.Color.White;
            this.lblCalculadora.Location = new System.Drawing.Point(214, 39);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(65, 15);
            this.lblCalculadora.TabIndex = 6;
            this.lblCalculadora.Text = "Calculadora";
            // 
            // lblGaussJordan
            // 
            this.lblGaussJordan.AutoSize = true;
            this.lblGaussJordan.BackColor = System.Drawing.Color.Transparent;
            this.lblGaussJordan.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaussJordan.ForeColor = System.Drawing.Color.White;
            this.lblGaussJordan.Location = new System.Drawing.Point(153, 39);
            this.lblGaussJordan.Name = "lblGaussJordan";
            this.lblGaussJordan.Size = new System.Drawing.Size(53, 15);
            this.lblGaussJordan.TabIndex = 4;
            this.lblGaussJordan.Text = "G. Jordan";
            // 
            // lblFormGene
            // 
            this.lblFormGene.AutoSize = true;
            this.lblFormGene.BackColor = System.Drawing.Color.Transparent;
            this.lblFormGene.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormGene.ForeColor = System.Drawing.Color.White;
            this.lblFormGene.Location = new System.Drawing.Point(83, 39);
            this.lblFormGene.Name = "lblFormGene";
            this.lblFormGene.Size = new System.Drawing.Size(58, 15);
            this.lblFormGene.TabIndex = 2;
            this.lblFormGene.Text = "F. General";
            // 
            // lblConvertUnid
            // 
            this.lblConvertUnid.AutoSize = true;
            this.lblConvertUnid.BackColor = System.Drawing.Color.Transparent;
            this.lblConvertUnid.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertUnid.ForeColor = System.Drawing.Color.White;
            this.lblConvertUnid.Location = new System.Drawing.Point(19, 39);
            this.lblConvertUnid.Name = "lblConvertUnid";
            this.lblConvertUnid.Size = new System.Drawing.Size(53, 15);
            this.lblConvertUnid.TabIndex = 1;
            this.lblConvertUnid.Text = "Unidades";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.header.Controls.Add(this.label6);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(359, 45);
            this.header.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(161)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(89, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kit básico de Ingeniería";
            // 
            // converUnidades
            // 
            this.converUnidades.AutoScroll = true;
            this.converUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.converUnidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.converUnidades.Location = new System.Drawing.Point(500, 46);
            this.converUnidades.Name = "converUnidades";
            this.converUnidades.Size = new System.Drawing.Size(385, 401);
            this.converUnidades.TabIndex = 2;
            this.converUnidades.Visible = false;
            // 
            // formGene
            // 
            this.formGene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.formGene.Location = new System.Drawing.Point(500, 46);
            this.formGene.Name = "formGene";
            this.formGene.Size = new System.Drawing.Size(359, 397);
            this.formGene.TabIndex = 3;
            this.formGene.Visible = false;
            // 
            // gaussJordan
            // 
            this.gaussJordan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.gaussJordan.Location = new System.Drawing.Point(500, 46);
            this.gaussJordan.Name = "gaussJordan";
            this.gaussJordan.Size = new System.Drawing.Size(359, 397);
            this.gaussJordan.TabIndex = 4;
            this.gaussJordan.Visible = false;
            // 
            // calculadora
            // 
            this.calculadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.calculadora.Location = new System.Drawing.Point(500, 46);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(359, 397);
            this.calculadora.TabIndex = 5;
            this.calculadora.Visible = false;
            // 
            // fisica
            // 
            this.fisica.AutoScroll = true;
            this.fisica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.fisica.Location = new System.Drawing.Point(500, 46);
            this.fisica.Name = "fisica";
            this.fisica.Size = new System.Drawing.Size(376, 397);
            this.fisica.TabIndex = 6;
            this.fisica.Visible = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(359, 500);
            this.Controls.Add(this.fisica);
            this.Controls.Add(this.calculadora);
            this.Controls.Add(this.gaussJordan);
            this.Controls.Add(this.formGene);
            this.Controls.Add(this.header);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.converUnidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormGene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConvertUnid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGaussJordan)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label lblFisica;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Label lblGaussJordan;
        private System.Windows.Forms.Label lblFormGene;
        private System.Windows.Forms.Label lblConvertUnid;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label6;
        private Conversion_de_Unidades converUnidades;
        private Formula_General formGene;
        private Gauss_Jordan gaussJordan;
        private Calculadora calculadora;
        private Fisica fisica;
        private System.Windows.Forms.PictureBox btnConvertUnid;
        private System.Windows.Forms.PictureBox btnFormGene;
        private System.Windows.Forms.PictureBox btnFisica;
        private System.Windows.Forms.PictureBox btnCalculadora;
        private System.Windows.Forms.PictureBox btnGaussJordan;
    }
}

