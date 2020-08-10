namespace Projecto_Gestão
{
    partial class frmLoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginAdmin));
            this.txtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fotoAdmin = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtSenha.BorderColorIdle = System.Drawing.Color.White;
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtSenha.BorderThickness = 1;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSenha.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSenha.isPassword = true;
            this.txtSenha.Location = new System.Drawing.Point(135, 182);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(209, 27);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fotoAdmin
            // 
            this.fotoAdmin.BackColor = System.Drawing.Color.White;
            this.fotoAdmin.BackgroundImage = global::Projecto_Gestão.Properties.Resources.photo;
            this.fotoAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotoAdmin.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.fotoAdmin.BorderColor = System.Drawing.Color.SeaGreen;
            this.fotoAdmin.Enabled = false;
            this.fotoAdmin.Location = new System.Drawing.Point(170, 7);
            this.fotoAdmin.Name = "fotoAdmin";
            this.fotoAdmin.Size = new System.Drawing.Size(130, 121);
            // 
            // lblnome
            // 
            this.lblnome.BackColor = System.Drawing.Color.SeaGreen;
            this.lblnome.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblnome.Location = new System.Drawing.Point(-1, 135);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(486, 41);
            this.lblnome.TabIndex = 10;
            this.lblnome.Text = "label1";
            this.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.ActiveBorderThickness = 1;
            this.btnEntrar.ActiveCornerRadius = 20;
            this.btnEntrar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEntrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.ButtonText = "Entrar";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.IdleBorderThickness = 1;
            this.btnEntrar.IdleCornerRadius = 20;
            this.btnEntrar.IdleFillColor = System.Drawing.Color.White;
            this.btnEntrar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.Location = new System.Drawing.Point(198, 209);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(87, 45);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ActiveBorderThickness = 1;
            this.btnVoltar.ActiveCornerRadius = 20;
            this.btnVoltar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnVoltar.ActiveForecolor = System.Drawing.Color.White;
            this.btnVoltar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.ButtonText = "Voltar";
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnVoltar.IdleBorderThickness = 1;
            this.btnVoltar.IdleCornerRadius = 20;
            this.btnVoltar.IdleFillColor = System.Drawing.Color.White;
            this.btnVoltar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnVoltar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoltar.Location = new System.Drawing.Point(384, 269);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 42);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 318);
            this.panel1.TabIndex = 11;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.fotoAdmin});
            this.shapeContainer2.Size = new System.Drawing.Size(484, 316);
            this.shapeContainer2.TabIndex = 11;
            this.shapeContainer2.TabStop = false;
            // 
            // frmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(486, 318);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLoginAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnVoltar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntrar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha;
        private Microsoft.VisualBasic.PowerPacks.OvalShape fotoAdmin;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}