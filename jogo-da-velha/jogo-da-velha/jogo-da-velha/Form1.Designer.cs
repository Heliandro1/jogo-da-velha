namespace jogo_da_velha
{
    partial class Form1
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
            this.gbPlacar = new System.Windows.Forms.GroupBox();
            this.lblJogadorO = new System.Windows.Forms.Label();
            this.lblJogadorX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJogou = new System.Windows.Forms.Label();
            this.btnResetar = new Guna.UI2.WinForms.Guna2Button();
            this.btnL0C0 = new Guna.UI2.WinForms.Guna2Button();
            this.btnL2C1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnL2C2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnL2C0 = new Guna.UI2.WinForms.Guna2Button();
            this.btnL1C2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnL1C1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnL1C0 = new Guna.UI2.WinForms.Guna2Button();
            this.btnL0C2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnL0C1 = new Guna.UI2.WinForms.Guna2Button();
            this.gbPlacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlacar
            // 
            this.gbPlacar.Controls.Add(this.lblJogadorO);
            this.gbPlacar.Controls.Add(this.lblJogadorX);
            this.gbPlacar.Controls.Add(this.label2);
            this.gbPlacar.Controls.Add(this.label1);
            this.gbPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlacar.Location = new System.Drawing.Point(12, 365);
            this.gbPlacar.Name = "gbPlacar";
            this.gbPlacar.Size = new System.Drawing.Size(166, 127);
            this.gbPlacar.TabIndex = 0;
            this.gbPlacar.TabStop = false;
            this.gbPlacar.Text = "Placar";
            // 
            // lblJogadorO
            // 
            this.lblJogadorO.AutoSize = true;
            this.lblJogadorO.ForeColor = System.Drawing.Color.Red;
            this.lblJogadorO.Location = new System.Drawing.Point(103, 70);
            this.lblJogadorO.Name = "lblJogadorO";
            this.lblJogadorO.Size = new System.Drawing.Size(17, 18);
            this.lblJogadorO.TabIndex = 3;
            this.lblJogadorO.Text = "0";
            // 
            // lblJogadorX
            // 
            this.lblJogadorX.AutoSize = true;
            this.lblJogadorX.ForeColor = System.Drawing.Color.Blue;
            this.lblJogadorX.Location = new System.Drawing.Point(103, 34);
            this.lblJogadorX.Name = "lblJogadorX";
            this.lblJogadorX.Size = new System.Drawing.Size(17, 18);
            this.lblJogadorX.TabIndex = 2;
            this.lblJogadorX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogador O:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador X:";
            // 
            // lblJogou
            // 
            this.lblJogou.AutoSize = true;
            this.lblJogou.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogou.Location = new System.Drawing.Point(271, 399);
            this.lblJogou.Name = "lblJogou";
            this.lblJogou.Size = new System.Drawing.Size(0, 18);
            this.lblJogou.TabIndex = 4;
            // 
            // btnResetar
            // 
            this.btnResetar.BorderRadius = 5;
            this.btnResetar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetar.FillColor = System.Drawing.Color.Gainsboro;
            this.btnResetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetar.ForeColor = System.Drawing.Color.Black;
            this.btnResetar.Location = new System.Drawing.Point(231, 435);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(180, 45);
            this.btnResetar.TabIndex = 5;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnL0C0
            // 
            this.btnL0C0.BorderRadius = 5;
            this.btnL0C0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL0C0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL0C0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL0C0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL0C0.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL0C0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL0C0.ForeColor = System.Drawing.Color.Maroon;
            this.btnL0C0.Location = new System.Drawing.Point(15, 12);
            this.btnL0C0.Name = "btnL0C0";
            this.btnL0C0.Size = new System.Drawing.Size(131, 107);
            this.btnL0C0.TabIndex = 6;
            this.btnL0C0.Tag = "0,0";
            this.btnL0C0.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // btnL2C1
            // 
            this.btnL2C1.BorderRadius = 5;
            this.btnL2C1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL2C1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL2C1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL2C1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL2C1.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL2C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2C1.ForeColor = System.Drawing.Color.Maroon;
            this.btnL2C1.Location = new System.Drawing.Point(152, 238);
            this.btnL2C1.Name = "btnL2C1";
            this.btnL2C1.Size = new System.Drawing.Size(131, 107);
            this.btnL2C1.TabIndex = 7;
            this.btnL2C1.Tag = "2,1";
            this.btnL2C1.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // btnL2C2
            // 
            this.btnL2C2.BorderRadius = 5;
            this.btnL2C2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL2C2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL2C2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL2C2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL2C2.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL2C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2C2.ForeColor = System.Drawing.Color.Maroon;
            this.btnL2C2.Location = new System.Drawing.Point(289, 238);
            this.btnL2C2.Name = "btnL2C2";
            this.btnL2C2.Size = new System.Drawing.Size(131, 107);
            this.btnL2C2.TabIndex = 8;
            this.btnL2C2.Tag = "2,2";
            this.btnL2C2.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // btnL2C0
            // 
            this.btnL2C0.BorderRadius = 5;
            this.btnL2C0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL2C0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL2C0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL2C0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL2C0.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL2C0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2C0.ForeColor = System.Drawing.Color.Maroon;
            this.btnL2C0.Location = new System.Drawing.Point(15, 238);
            this.btnL2C0.Name = "btnL2C0";
            this.btnL2C0.Size = new System.Drawing.Size(131, 107);
            this.btnL2C0.TabIndex = 9;
            this.btnL2C0.Tag = "2,0";
            this.btnL2C0.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // btnL1C2
            // 
            this.btnL1C2.BorderRadius = 5;
            this.btnL1C2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL1C2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL1C2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL1C2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL1C2.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL1C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL1C2.ForeColor = System.Drawing.Color.Maroon;
            this.btnL1C2.Location = new System.Drawing.Point(289, 125);
            this.btnL1C2.Name = "btnL1C2";
            this.btnL1C2.Size = new System.Drawing.Size(131, 107);
            this.btnL1C2.TabIndex = 10;
            this.btnL1C2.Tag = "1,2";
            this.btnL1C2.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // btnL1C1
            // 
            this.btnL1C1.BorderRadius = 5;
            this.btnL1C1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL1C1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL1C1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL1C1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL1C1.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL1C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL1C1.ForeColor = System.Drawing.Color.Maroon;
            this.btnL1C1.Location = new System.Drawing.Point(152, 125);
            this.btnL1C1.Name = "btnL1C1";
            this.btnL1C1.Size = new System.Drawing.Size(131, 107);
            this.btnL1C1.TabIndex = 11;
            this.btnL1C1.Tag = "1,1";
            this.btnL1C1.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // btnL1C0
            // 
            this.btnL1C0.BorderRadius = 5;
            this.btnL1C0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL1C0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL1C0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL1C0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL1C0.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL1C0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL1C0.ForeColor = System.Drawing.Color.Maroon;
            this.btnL1C0.Location = new System.Drawing.Point(15, 125);
            this.btnL1C0.Name = "btnL1C0";
            this.btnL1C0.Size = new System.Drawing.Size(131, 107);
            this.btnL1C0.TabIndex = 12;
            this.btnL1C0.Tag = "1,0";
            this.btnL1C0.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // btnL0C2
            // 
            this.btnL0C2.BorderRadius = 5;
            this.btnL0C2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL0C2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL0C2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL0C2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL0C2.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL0C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL0C2.ForeColor = System.Drawing.Color.Maroon;
            this.btnL0C2.Location = new System.Drawing.Point(289, 12);
            this.btnL0C2.Name = "btnL0C2";
            this.btnL0C2.Size = new System.Drawing.Size(131, 107);
            this.btnL0C2.TabIndex = 13;
            this.btnL0C2.Tag = "0,2";
            this.btnL0C2.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // btnL0C1
            // 
            this.btnL0C1.BorderRadius = 5;
            this.btnL0C1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL0C1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnL0C1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnL0C1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnL0C1.FillColor = System.Drawing.Color.Gainsboro;
            this.btnL0C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL0C1.ForeColor = System.Drawing.Color.Maroon;
            this.btnL0C1.Location = new System.Drawing.Point(152, 12);
            this.btnL0C1.Name = "btnL0C1";
            this.btnL0C1.Size = new System.Drawing.Size(131, 107);
            this.btnL0C1.TabIndex = 14;
            this.btnL0C1.Tag = "0,1";
            this.btnL0C1.Click += new System.EventHandler(this.btnL0C1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(432, 500);
            this.Controls.Add(this.btnL0C1);
            this.Controls.Add(this.btnL0C2);
            this.Controls.Add(this.btnL1C0);
            this.Controls.Add(this.btnL1C1);
            this.Controls.Add(this.btnL1C2);
            this.Controls.Add(this.btnL2C0);
            this.Controls.Add(this.btnL2C2);
            this.Controls.Add(this.btnL2C1);
            this.Controls.Add(this.btnL0C0);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.lblJogou);
            this.Controls.Add(this.gbPlacar);
            this.Name = "Form1";
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPlacar.ResumeLayout(false);
            this.gbPlacar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlacar;
        private System.Windows.Forms.Label lblJogadorO;
        private System.Windows.Forms.Label lblJogadorX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJogou;
        private Guna.UI2.WinForms.Guna2Button btnResetar;
        private Guna.UI2.WinForms.Guna2Button btnL0C0;
        private Guna.UI2.WinForms.Guna2Button btnL2C1;
        private Guna.UI2.WinForms.Guna2Button btnL2C2;
        private Guna.UI2.WinForms.Guna2Button btnL2C0;
        private Guna.UI2.WinForms.Guna2Button btnL1C2;
        private Guna.UI2.WinForms.Guna2Button btnL1C1;
        private Guna.UI2.WinForms.Guna2Button btnL1C0;
        private Guna.UI2.WinForms.Guna2Button btnL0C2;
        private Guna.UI2.WinForms.Guna2Button btnL0C1;
    }
}

