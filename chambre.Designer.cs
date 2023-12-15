namespace gestion_hotel
{
    partial class chambre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvChambre = new System.Windows.Forms.DataGridView();
            this.labelChambreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textChambreType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textChambrePrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textChambreDispo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textChambreDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(-303, -46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1603, 70);
            this.panel1.TabIndex = 37;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modifier";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 110;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(747, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 70);
            this.button1.TabIndex = 40;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvChambre
            // 
            this.dgvChambre.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvChambre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChambre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChambre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChambre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labelChambreId,
            this.textChambreType,
            this.textChambrePrix,
            this.textChambreDispo,
            this.textChambreDescription,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChambre.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChambre.EnableHeadersVisualStyles = false;
            this.dgvChambre.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvChambre.Location = new System.Drawing.Point(78, 192);
            this.dgvChambre.Name = "dgvChambre";
            this.dgvChambre.RowHeadersVisible = false;
            this.dgvChambre.RowHeadersWidth = 51;
            this.dgvChambre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChambre.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChambre.RowTemplate.Height = 24;
            this.dgvChambre.Size = new System.Drawing.Size(973, 442);
            this.dgvChambre.TabIndex = 38;
            this.dgvChambre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChambre_CellContentClick);
            // 
            // labelChambreId
            // 
            this.labelChambreId.HeaderText = "ID";
            this.labelChambreId.MinimumWidth = 6;
            this.labelChambreId.Name = "labelChambreId";
            // 
            // textChambreType
            // 
            this.textChambreType.HeaderText = "Type chambre";
            this.textChambreType.MinimumWidth = 6;
            this.textChambreType.Name = "textChambreType";
            // 
            // textChambrePrix
            // 
            this.textChambrePrix.HeaderText = "Prix";
            this.textChambrePrix.MinimumWidth = 6;
            this.textChambrePrix.Name = "textChambrePrix";
            // 
            // textChambreDispo
            // 
            this.textChambreDispo.HeaderText = "Disponible";
            this.textChambreDispo.MinimumWidth = 6;
            this.textChambreDispo.Name = "textChambreDispo";
            // 
            // textChambreDescription
            // 
            this.textChambreDescription.HeaderText = "Description";
            this.textChambreDescription.MinimumWidth = 6;
            this.textChambreDescription.Name = "textChambreDescription";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Modifier";
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Supprimer";
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(141, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 46);
            this.label2.TabIndex = 41;
            this.label2.Text = "Espace Chambres";
            // 
            // chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvChambre);
            this.Controls.Add(this.label2);
            this.Name = "chambre";
            this.Text = "chambre";
            this.Load += new System.EventHandler(this.chambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelChambreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn textChambreType;
        private System.Windows.Forms.DataGridViewTextBoxColumn textChambrePrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn textChambreDispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn textChambreDescription;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label2;
    }
}