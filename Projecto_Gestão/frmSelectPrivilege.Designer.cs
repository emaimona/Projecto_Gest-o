namespace Projecto_Gestão
{
    partial class frmSelectPrivilege
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPrivilege));
            this.btnSair = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.b1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.b2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.ActiveBorderThickness = 1;
            this.btnSair.ActiveCornerRadius = 20;
            this.btnSair.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSair.ActiveForecolor = System.Drawing.Color.White;
            this.btnSair.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.ButtonText = "Sair";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSair.IdleBorderThickness = 1;
            this.btnSair.IdleCornerRadius = 20;
            this.btnSair.IdleFillColor = System.Drawing.Color.White;
            this.btnSair.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSair.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSair.Location = new System.Drawing.Point(378, 286);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 42);
            this.btnSair.TabIndex = 3;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdmin.color = System.Drawing.Color.SeaGreen;
            this.btnAdmin.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImagePosition = 20;
            this.btnAdmin.ImageZoom = 50;
            this.btnAdmin.LabelPosition = 41;
            this.btnAdmin.LabelText = "Administrador";
            this.btnAdmin.Location = new System.Drawing.Point(64, 97);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(151, 141);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUser.color = System.Drawing.Color.SeaGreen;
            this.btnUser.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImagePosition = 20;
            this.btnUser.ImageZoom = 50;
            this.btnUser.LabelPosition = 41;
            this.btnUser.LabelText = "Usuário";
            this.btnUser.Location = new System.Drawing.Point(295, 97);
            this.btnUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(151, 141);
            this.btnUser.TabIndex = 5;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.b1,
            this.b2});
            this.shapeContainer1.Size = new System.Drawing.Size(507, 342);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b1.BorderColor = System.Drawing.Color.SeaGreen;
            this.b1.BorderWidth = 12;
            this.b1.CornerRadius = 3;
            this.b1.Location = new System.Drawing.Point(64, 97);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(151, 141);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b2.BorderColor = System.Drawing.Color.SeaGreen;
            this.b2.BorderWidth = 12;
            this.b2.CornerRadius = 3;
            this.b2.Location = new System.Drawing.Point(295, 97);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(151, 141);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSelectPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(507, 342);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelectPrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnSair;
        private Bunifu.Framework.UI.BunifuTileButton btnAdmin;
        private Bunifu.Framework.UI.BunifuTileButton btnUser;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape b1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape b2;
        private System.Windows.Forms.Timer timer1;
    }
}

