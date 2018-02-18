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
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnidFisic = new Controles.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculadora = new Controles.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGaussJordan = new Controles.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFrmGene = new Controles.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvUnid = new Controles.Button();
            this.header = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.conversion_de_Unidades1 = new KitIngeniero.Conversion_de_Unidades();
            this.footer.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.footer.Controls.Add(this.label5);
            this.footer.Controls.Add(this.btnUnidFisic);
            this.footer.Controls.Add(this.label4);
            this.footer.Controls.Add(this.btnCalculadora);
            this.footer.Controls.Add(this.label3);
            this.footer.Controls.Add(this.btnGaussJordan);
            this.footer.Controls.Add(this.label2);
            this.footer.Controls.Add(this.btnFrmGene);
            this.footer.Controls.Add(this.label1);
            this.footer.Controls.Add(this.btnConvUnid);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 442);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(359, 58);
            this.footer.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(296, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Física";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnUnidFisic
            // 
            this.btnUnidFisic.BackColor = System.Drawing.Color.Transparent;
            this.btnUnidFisic.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUnidFisic.ButtonImage")));
            this.btnUnidFisic.Location = new System.Drawing.Point(299, 8);
            this.btnUnidFisic.Name = "btnUnidFisic";
            this.btnUnidFisic.onHoverImage = ((System.Drawing.Image)(resources.GetObject("btnUnidFisic.onHoverImage")));
            this.btnUnidFisic.Size = new System.Drawing.Size(28, 28);
            this.btnUnidFisic.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(214, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calculadora";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.ButtonImage")));
            this.btnCalculadora.Location = new System.Drawing.Point(232, 8);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.onHoverImage = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.onHoverImage")));
            this.btnCalculadora.Size = new System.Drawing.Size(28, 28);
            this.btnCalculadora.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(153, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "G. Jordan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGaussJordan
            // 
            this.btnGaussJordan.BackColor = System.Drawing.Color.Transparent;
            this.btnGaussJordan.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnGaussJordan.ButtonImage")));
            this.btnGaussJordan.Location = new System.Drawing.Point(165, 8);
            this.btnGaussJordan.Name = "btnGaussJordan";
            this.btnGaussJordan.onHoverImage = ((System.Drawing.Image)(resources.GetObject("btnGaussJordan.onHoverImage")));
            this.btnGaussJordan.Size = new System.Drawing.Size(28, 28);
            this.btnGaussJordan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "F. General";
            // 
            // btnFrmGene
            // 
            this.btnFrmGene.BackColor = System.Drawing.Color.Transparent;
            this.btnFrmGene.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnFrmGene.ButtonImage")));
            this.btnFrmGene.Location = new System.Drawing.Point(95, 5);
            this.btnFrmGene.Name = "btnFrmGene";
            this.btnFrmGene.onHoverImage = ((System.Drawing.Image)(resources.GetObject("btnFrmGene.onHoverImage")));
            this.btnFrmGene.Size = new System.Drawing.Size(35, 35);
            this.btnFrmGene.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unidades";
            // 
            // btnConvUnid
            // 
            this.btnConvUnid.BackColor = System.Drawing.Color.Transparent;
            this.btnConvUnid.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnConvUnid.ButtonImage")));
            this.btnConvUnid.Location = new System.Drawing.Point(31, 8);
            this.btnConvUnid.Name = "btnConvUnid";
            this.btnConvUnid.onHoverImage = ((System.Drawing.Image)(resources.GetObject("btnConvUnid.onHoverImage")));
            this.btnConvUnid.Size = new System.Drawing.Size(28, 28);
            this.btnConvUnid.TabIndex = 1;
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
            // conversion_de_Unidades1
            // 
            this.conversion_de_Unidades1.AutoScroll = true;
            this.conversion_de_Unidades1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.conversion_de_Unidades1.Location = new System.Drawing.Point(0, 44);
            this.conversion_de_Unidades1.Name = "conversion_de_Unidades1";
            this.conversion_de_Unidades1.Size = new System.Drawing.Size(359, 397);
            this.conversion_de_Unidades1.TabIndex = 2;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(359, 500);
            this.Controls.Add(this.conversion_de_Unidades1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel footer;
        private Controles.Button btnConvUnid;
        private System.Windows.Forms.Label label5;
        private Controles.Button btnUnidFisic;
        private System.Windows.Forms.Label label4;
        private Controles.Button btnCalculadora;
        private System.Windows.Forms.Label label3;
        private Controles.Button btnGaussJordan;
        private System.Windows.Forms.Label label2;
        private Controles.Button btnFrmGene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label6;
        private Conversion_de_Unidades conversion_de_Unidades1;
    }
}

