namespace Projecto_Gestão
{
    partial class frmLoginUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginUser));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.fotoUser = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.txtnome = new System.Windows.Forms.ComboBox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.fotoUser});
            this.shapeContainer1.Size = new System.Drawing.Size(469, 335);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.rectangleShape1.BorderWidth = 4;
            this.rectangleShape1.CornerRadius = 2;
            this.rectangleShape1.Location = new System.Drawing.Point(138, 157);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(209, 28);
            // 
            // fotoUser
            // 
            this.fotoUser.BackColor = System.Drawing.Color.White;
            this.fotoUser.BackgroundImage = global::Projecto_Gestão.Properties.Resources.photo;
            this.fotoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotoUser.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.fotoUser.BorderColor = System.Drawing.Color.SeaGreen;
            this.fotoUser.Enabled = false;
            this.fotoUser.Location = new System.Drawing.Point(170, 10);
            this.fotoUser.Name = "fotoUser";
            this.fotoUser.Size = new System.Drawing.Size(130, 121);
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.txtnome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtnome.DropDownWidth = 209;
            this.txtnome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.FormattingEnabled = true;
            this.txtnome.Location = new System.Drawing.Point(138, 157);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(209, 28);
            this.txtnome.TabIndex = 1;
            this.txtnome.SelectedIndexChanged += new System.EventHandler(this.txtnome_SelectedIndexChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSenha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSenha.BorderThickness = 1;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.isPassword = true;
            this.txtSenha.Location = new System.Drawing.Point(138, 193);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(209, 27);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnVoltar
            // 
            this.btnVoltar.ActiveBorderThickness = 1;
            this.btnVoltar.ActiveCornerRadius = 20;
            this.btnVoltar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnVoltar.ActiveForecolor = System.Drawing.Color.White;
            this.btnVoltar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnVoltar.Location = new System.Drawing.Point(375, 288);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 42);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.ActiveBorderThickness = 1;
            this.btnEntrar.ActiveCornerRadius = 20;
            this.btnEntrar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEntrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnEntrar.Location = new System.Drawing.Point(198, 230);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(87, 45);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(140, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(469, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLoginUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape fotoUser;
        private System.Windows.Forms.ComboBox txtnome;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVoltar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntrar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}