namespace Couche_presentations
{
    partial class Activite
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerActivites = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvActivite = new System.Windows.Forms.DataGridView();
            this.txtLieua = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.lblFIN = new System.Windows.Forms.Label();
            this.lblNomDetenu = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblLieux = new System.Windows.Forms.Label();
            this.lblNomAct = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cmbNomdetenu = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivite)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerActivites
            // 
            this.dateTimePickerActivites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerActivites.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerActivites.Location = new System.Drawing.Point(45, 407);
            this.dateTimePickerActivites.Name = "dateTimePickerActivites";
            this.dateTimePickerActivites.Size = new System.Drawing.Size(184, 30);
            this.dateTimePickerActivites.TabIndex = 31;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(45, 376);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 29);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Date";
            // 
            // dgvActivite
            // 
            this.dgvActivite.AllowUserToAddRows = false;
            this.dgvActivite.AllowUserToDeleteRows = false;
            this.dgvActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivite.Location = new System.Drawing.Point(530, 347);
            this.dgvActivite.Name = "dgvActivite";
            this.dgvActivite.ReadOnly = true;
            this.dgvActivite.RowHeadersWidth = 51;
            this.dgvActivite.RowTemplate.Height = 24;
            this.dgvActivite.Size = new System.Drawing.Size(921, 354);
            this.dgvActivite.TabIndex = 29;
            this.dgvActivite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivite_CellContentClick);
            // 
            // txtLieua
            // 
            this.txtLieua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLieua.Location = new System.Drawing.Point(41, 340);
            this.txtLieua.Name = "txtLieua";
            this.txtLieua.Size = new System.Drawing.Size(412, 30);
            this.txtLieua.TabIndex = 27;
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(25, 716);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(443, 143);
            this.txtdesc.TabIndex = 26;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFin.Location = new System.Drawing.Point(45, 612);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(184, 30);
            this.dateTimePickerFin.TabIndex = 25;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(45, 500);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(184, 30);
            this.dateTimePickerDebut.TabIndex = 24;
            // 
            // lblFIN
            // 
            this.lblFIN.AutoSize = true;
            this.lblFIN.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFIN.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIN.Location = new System.Drawing.Point(45, 581);
            this.lblFIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFIN.Name = "lblFIN";
            this.lblFIN.Size = new System.Drawing.Size(115, 29);
            this.lblFIN.TabIndex = 23;
            this.lblFIN.Text = "Heure Fin";
            this.lblFIN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomDetenu
            // 
            this.lblNomDetenu.AutoSize = true;
            this.lblNomDetenu.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNomDetenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomDetenu.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDetenu.Location = new System.Drawing.Point(41, 205);
            this.lblNomDetenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomDetenu.Name = "lblNomDetenu";
            this.lblNomDetenu.Size = new System.Drawing.Size(173, 29);
            this.lblNomDetenu.TabIndex = 22;
            this.lblNomDetenu.Text = "Nom du detenu";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDebut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDebut.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(44, 470);
            this.lblDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(145, 29);
            this.lblDebut.TabIndex = 21;
            this.lblDebut.Text = "Heure Debut";
            // 
            // lblLieux
            // 
            this.lblLieux.AutoSize = true;
            this.lblLieux.BackColor = System.Drawing.Color.Gainsboro;
            this.lblLieux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLieux.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLieux.Location = new System.Drawing.Point(41, 309);
            this.lblLieux.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLieux.Name = "lblLieux";
            this.lblLieux.Size = new System.Drawing.Size(72, 29);
            this.lblLieux.TabIndex = 20;
            this.lblLieux.Text = "Lieux";
            // 
            // lblNomAct
            // 
            this.lblNomAct.AutoSize = true;
            this.lblNomAct.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNomAct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomAct.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAct.Location = new System.Drawing.Point(25, 672);
            this.lblNomAct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomAct.Name = "lblNomAct";
            this.lblNomAct.Size = new System.Drawing.Size(273, 29);
            this.lblNomAct.TabIndex = 19;
            this.lblNomAct.Text = "Description De L\'Activité";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTitre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitre.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(530, 48);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(542, 47);
            this.lblTitre.TabIndex = 18;
            this.lblTitre.Text = " FORMULAIRE ACTIVITES";
            // 
            // cmbNomdetenu
            // 
            this.cmbNomdetenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomdetenu.FormattingEnabled = true;
            this.cmbNomdetenu.Location = new System.Drawing.Point(40, 251);
            this.cmbNomdetenu.Name = "cmbNomdetenu";
            this.cmbNomdetenu.Size = new System.Drawing.Size(413, 33);
            this.cmbNomdetenu.TabIndex = 38;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Gray;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Image = global::Couche_presentations.Properties.Resources.Agrandir;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndelete.Location = new System.Drawing.Point(1202, 821);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(218, 60);
            this.btndelete.TabIndex = 37;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::Couche_presentations.Properties.Resources.Agrandir;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(933, 821);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 60);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::Couche_presentations.Properties.Resources.Agrandir;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.Location = new System.Drawing.Point(698, 821);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 60);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(583, 241);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(537, 43);
            this.txtsearch.TabIndex = 65;
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
            this.btnSearch.Location = new System.Drawing.Point(1117, 241);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 43);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Activite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1502, 1102);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbNomdetenu);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePickerActivites);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvActivite);
            this.Controls.Add(this.txtLieua);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.lblFIN);
            this.Controls.Add(this.lblNomDetenu);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblLieux);
            this.Controls.Add(this.lblNomAct);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Activite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activite";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerActivites;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvActivite;
        private System.Windows.Forms.TextBox txtLieua;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.Label lblFIN;
        private System.Windows.Forms.Label lblNomDetenu;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblLieux;
        private System.Windows.Forms.Label lblNomAct;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cmbNomdetenu;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

