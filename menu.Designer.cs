namespace gestion_hotel
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlafficher = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.btnreservation = new System.Windows.Forms.Button();
            this.btnfacture = new System.Windows.Forms.Button();
            this.btnchambre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(615, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pnlafficher);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(329, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 628);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnlafficher
            // 
            this.pnlafficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlafficher.BackColor = System.Drawing.SystemColors.Control;
            this.pnlafficher.Location = new System.Drawing.Point(-79, 42);
            this.pnlafficher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlafficher.Name = "pnlafficher";
            this.pnlafficher.Size = new System.Drawing.Size(758, 584);
            this.pnlafficher.TabIndex = 10;
            this.pnlafficher.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlafficher_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(587, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 33);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclient.Image = ((System.Drawing.Image)(resources.GetObject("btnclient.Image")));
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(0, 297);
            this.btnclient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(325, 62);
            this.btnclient.TabIndex = 4;
            this.btnclient.Text = "Clients";
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btnreservation
            // 
            this.btnreservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreservation.FlatAppearance.BorderSize = 0;
            this.btnreservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreservation.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreservation.Image = ((System.Drawing.Image)(resources.GetObject("btnreservation.Image")));
            this.btnreservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreservation.Location = new System.Drawing.Point(0, 118);
            this.btnreservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreservation.Name = "btnreservation";
            this.btnreservation.Size = new System.Drawing.Size(325, 62);
            this.btnreservation.TabIndex = 5;
            this.btnreservation.Text = "Réservations";
            this.btnreservation.UseVisualStyleBackColor = false;
            this.btnreservation.Click += new System.EventHandler(this.btnreservation_Click);
            // 
            // btnfacture
            // 
            this.btnfacture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfacture.FlatAppearance.BorderSize = 0;
            this.btnfacture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnfacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacture.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfacture.Image = ((System.Drawing.Image)(resources.GetObject("btnfacture.Image")));
            this.btnfacture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacture.Location = new System.Drawing.Point(0, 202);
            this.btnfacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfacture.Name = "btnfacture";
            this.btnfacture.Size = new System.Drawing.Size(325, 77);
            this.btnfacture.TabIndex = 7;
            this.btnfacture.Text = "factures";
            this.btnfacture.UseVisualStyleBackColor = false;
            this.btnfacture.Click += new System.EventHandler(this.btnfacture_Click);
            // 
            // btnchambre
            // 
            this.btnchambre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnchambre.FlatAppearance.BorderSize = 0;
            this.btnchambre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnchambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchambre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchambre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchambre.Image = ((System.Drawing.Image)(resources.GetObject("btnchambre.Image")));
            this.btnchambre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchambre.Location = new System.Drawing.Point(0, 377);
            this.btnchambre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnchambre.Name = "btnchambre";
            this.btnchambre.Size = new System.Drawing.Size(325, 62);
            this.btnchambre.TabIndex = 6;
            this.btnchambre.Text = "Chambres";
            this.btnchambre.UseVisualStyleBackColor = false;
            this.btnchambre.Click += new System.EventHandler(this.btnchambre_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(329, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnchambre);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnreservation);
            this.panel1.Controls.Add(this.btnfacture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 638);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(267, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 33);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "menu";
            this.Text = "menu";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlafficher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnfacture;
        private System.Windows.Forms.Button btnchambre;
        private System.Windows.Forms.Button btnreservation;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}