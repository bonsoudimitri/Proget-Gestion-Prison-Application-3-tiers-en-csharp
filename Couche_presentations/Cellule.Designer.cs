namespace Couche_presentations
{
    partial class Cellule
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
            this.dgvCellule = new System.Windows.Forms.DataGridView();
            this.idcel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbcel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapacite = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNomcel = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeletecel = new System.Windows.Forms.Button();
            this.btnUpdatecel = new System.Windows.Forms.Button();
            this.btnAddcellule = new System.Windows.Forms.Button();
            this.txtNombre_cel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCellule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCellule
            // 
            this.dgvCellule.AllowUserToAddRows = false;
            this.dgvCellule.AllowUserToDeleteRows = false;
            this.dgvCellule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCellule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcel,
            this.nomcel,
            this.caCel,
            this.nbcel});
            this.dgvCellule.Location = new System.Drawing.Point(487, 300);
            this.dgvCellule.Name = "dgvCellule";
            this.dgvCellule.ReadOnly = true;
            this.dgvCellule.RowHeadersWidth = 51;
            this.dgvCellule.RowTemplate.Height = 24;
            this.dgvCellule.Size = new System.Drawing.Size(763, 309);
            this.dgvCellule.TabIndex = 20;
            this.dgvCellule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellule_CellContentClick);
            // 
            // idcel
            // 
            this.idcel.HeaderText = "Id";
            this.idcel.Name = "idcel";
            this.idcel.ReadOnly = true;
            // 
            // nomcel
            // 
            this.nomcel.HeaderText = "Nom";
            this.nomcel.Name = "nomcel";
            this.nomcel.ReadOnly = true;
            this.nomcel.Width = 200;
            // 
            // caCel
            // 
            this.caCel.HeaderText = "Capacite";
            this.caCel.Name = "caCel";
            this.caCel.ReadOnly = true;
            // 
            // nbcel
            // 
            this.nbcel.HeaderText = "Nombre Prisonnier";
            this.nbcel.Name = "nbcel";
            this.nbcel.ReadOnly = true;
            this.nbcel.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Capacité";
            // 
            // txtCapacite
            // 
            this.txtCapacite.BackColor = System.Drawing.Color.White;
            this.txtCapacite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacite.Location = new System.Drawing.Point(35, 561);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(241, 30);
            this.txtCapacite.TabIndex = 18;
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(35, 365);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(241, 30);
            this.txtNum.TabIndex = 17;
            // 
            // txtNomcel
            // 
            this.txtNomcel.BackColor = System.Drawing.Color.White;
            this.txtNomcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomcel.Location = new System.Drawing.Point(35, 459);
            this.txtNomcel.Name = "txtNomcel";
            this.txtNomcel.Size = new System.Drawing.Size(241, 30);
            this.txtNomcel.TabIndex = 16;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(35, 334);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(174, 29);
            this.lblNum.TabIndex = 15;
            this.lblNum.Text = "Numero Cellule";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Gainsboro;
            this.lbId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbId.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(35, 428);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(62, 29);
            this.lbId.TabIndex = 14;
            this.lbId.Text = "Nom";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(25, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 115);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "FORMULAIRE CELLULE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndeletecel
            // 
            this.btndeletecel.BackColor = System.Drawing.Color.Gray;
            this.btndeletecel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletecel.FlatAppearance.BorderSize = 0;
            this.btndeletecel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndeletecel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletecel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecel.ForeColor = System.Drawing.Color.Black;
            this.btndeletecel.Image = global::Couche_presentations.Properties.Resources.Agrandir;
            this.btndeletecel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndeletecel.Location = new System.Drawing.Point(1089, 699);
            this.btndeletecel.Name = "btndeletecel";
            this.btndeletecel.Size = new System.Drawing.Size(233, 60);
            this.btndeletecel.TabIndex = 43;
            this.btndeletecel.Text = "Supprimer";
            this.btndeletecel.UseVisualStyleBackColor = false;
            this.btndeletecel.Click += new System.EventHandler(this.btndeletecel_Click);
            // 
            // btnUpdatecel
            // 
            this.btnUpdatecel.BackColor = System.Drawing.Color.Gray;
            this.btnUpdatecel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatecel.FlatAppearance.BorderSize = 0;
            this.btnUpdatecel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdatecel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatecel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatecel.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatecel.Image = global::Couche_presentations.Properties.Resources.Agrandir;
            this.btnUpdatecel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdatecel.Location = new System.Drawing.Point(835, 699);
            this.btnUpdatecel.Name = "btnUpdatecel";
            this.btnUpdatecel.Size = new System.Drawing.Size(209, 60);
            this.btnUpdatecel.TabIndex = 42;
            this.btnUpdatecel.Text = "Modifier";
            this.btnUpdatecel.UseVisualStyleBackColor = false;
            this.btnUpdatecel.Click += new System.EventHandler(this.btnUpdatecel_Click);
            // 
            // btnAddcellule
            // 
            this.btnAddcellule.BackColor = System.Drawing.Color.Gray;
            this.btnAddcellule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddcellule.FlatAppearance.BorderSize = 0;
            this.btnAddcellule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddcellule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddcellule.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcellule.ForeColor = System.Drawing.Color.Black;
            this.btnAddcellule.Image = global::Couche_presentations.Properties.Resources.Agrandir;
            this.btnAddcellule.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddcellule.Location = new System.Drawing.Point(577, 699);
            this.btnAddcellule.Name = "btnAddcellule";
            this.btnAddcellule.Size = new System.Drawing.Size(209, 60);
            this.btnAddcellule.TabIndex = 41;
            this.btnAddcellule.Text = "Ajouter";
            this.btnAddcellule.UseVisualStyleBackColor = false;
            this.btnAddcellule.Click += new System.EventHandler(this.btnAddcellule_Click);
            // 
            // txtNombre_cel
            // 
            this.txtNombre_cel.BackColor = System.Drawing.Color.White;
            this.txtNombre_cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_cel.Location = new System.Drawing.Point(35, 636);
            this.txtNombre_cel.Name = "txtNombre_cel";
            this.txtNombre_cel.Size = new System.Drawing.Size(241, 30);
            this.txtNombre_cel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre Cellule";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(507, 210);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(537, 43);
            this.txtsearch.TabIndex = 63;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1041, 210);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 43);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Cellule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btndeletecel);
            this.Controls.Add(this.btnUpdatecel);
            this.Controls.Add(this.btnAddcellule);
            this.Controls.Add(this.dgvCellule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre_cel);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtNomcel);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Cellule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cellule";
            this.Load += new System.EventHandler(this.Cellule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCellule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCellule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapacite;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNomcel;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeletecel;
        private System.Windows.Forms.Button btnUpdatecel;
        private System.Windows.Forms.Button btnAddcellule;
        private System.Windows.Forms.TextBox txtNombre_cel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn caCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbcel;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnSearch;
    }
}