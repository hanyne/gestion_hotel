namespace gestion_hotel
{
    partial class ChambreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChambreForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textChambrePrix = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textChambreDispo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textChambreType = new System.Windows.Forms.TextBox();
            this.textChambreDescription = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelChambreId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 32);
            this.label5.TabIndex = 103;
            this.label5.Text = "PrixNuit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 102;
            this.label1.Text = "TypeChambre:";
            // 
            // textChambrePrix
            // 
            this.textChambrePrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textChambrePrix.Location = new System.Drawing.Point(408, 204);
            this.textChambrePrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textChambrePrix.Name = "textChambrePrix";
            this.textChambrePrix.Size = new System.Drawing.Size(435, 34);
            this.textChambrePrix.TabIndex = 96;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(475, 485);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 84);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(681, 485);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 84);
            this.btnUpdate.TabIndex = 101;
            this.btnUpdate.Text = "Mise à jour";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 32);
            this.label6.TabIndex = 105;
            this.label6.Text = "Disponibilite:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textChambreDispo
            // 
            this.textChambreDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textChambreDispo.Location = new System.Drawing.Point(408, 293);
            this.textChambreDispo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textChambreDispo.Name = "textChambreDispo";
            this.textChambreDispo.Size = new System.Drawing.Size(435, 34);
            this.textChambreDispo.TabIndex = 98;
            this.textChambreDispo.TextChanged += new System.EventHandler(this.textChambreDispo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 32);
            this.label8.TabIndex = 106;
            this.label8.Text = "Description:";
            // 
            // textChambreType
            // 
            this.textChambreType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textChambreType.Location = new System.Drawing.Point(408, 139);
            this.textChambreType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textChambreType.Name = "textChambreType";
            this.textChambreType.Size = new System.Drawing.Size(435, 34);
            this.textChambreType.TabIndex = 95;
            // 
            // textChambreDescription
            // 
            this.textChambreDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textChambreDescription.Location = new System.Drawing.Point(408, 395);
            this.textChambreDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textChambreDescription.Name = "textChambreDescription";
            this.textChambreDescription.Size = new System.Drawing.Size(435, 34);
            this.textChambreDescription.TabIndex = 99;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 601);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 10);
            this.panel2.TabIndex = 107;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1004, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 47);
            this.button1.TabIndex = 108;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelChambreId
            // 
            this.labelChambreId.AutoSize = true;
            this.labelChambreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChambreId.Location = new System.Drawing.Point(104, 545);
            this.labelChambreId.Name = "labelChambreId";
            this.labelChambreId.Size = new System.Drawing.Size(169, 29);
            this.labelChambreId.TabIndex = 109;
            this.labelChambreId.Text = "ID du chambre";
            this.labelChambreId.Click += new System.EventHandler(this.labelChambreId_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 46);
            this.label4.TabIndex = 110;
            this.label4.Text = "Chambre";
            // 
            // ChambreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelChambreId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textChambreDescription);
            this.Controls.Add(this.textChambreType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textChambreDispo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textChambrePrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "ChambreForm";
            this.Text = "ChambreForm";
            this.Load += new System.EventHandler(this.ChambreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textChambrePrix;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textChambreDispo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textChambreType;
        public System.Windows.Forms.TextBox textChambreDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelChambreId;
        private System.Windows.Forms.Label label4;
    }
}