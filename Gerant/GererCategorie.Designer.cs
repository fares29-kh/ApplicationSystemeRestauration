namespace ApplicationSystemeRestauration.Gerant
{
    partial class GererCategorie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listecategorie = new System.Windows.Forms.DataGridView();
            this.idcategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.savecategorie = new System.Windows.Forms.Button();
            this.editcategorie = new System.Windows.Forms.Button();
            this.deletecategorie = new System.Windows.Forms.Button();
            this.txtidcategorie = new System.Windows.Forms.TextBox();
            this.txtnomcategorie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listecategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(779, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID  Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(779, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Categorie";
            // 
            // listecategorie
            // 
            this.listecategorie.AllowUserToDeleteRows = false;
            this.listecategorie.AutoGenerateColumns = false;
            this.listecategorie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.listecategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listecategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcategorieDataGridViewTextBoxColumn,
            this.nomcategorieDataGridViewTextBoxColumn});
            this.listecategorie.DataSource = this.categorieBindingSource;
            this.listecategorie.Location = new System.Drawing.Point(85, 123);
            this.listecategorie.Name = "listecategorie";
            this.listecategorie.ReadOnly = true;
            this.listecategorie.RowHeadersWidth = 51;
            this.listecategorie.RowTemplate.Height = 29;
            this.listecategorie.Size = new System.Drawing.Size(606, 538);
            this.listecategorie.TabIndex = 2;
            // 
            // idcategorieDataGridViewTextBoxColumn
            // 
            this.idcategorieDataGridViewTextBoxColumn.DataPropertyName = "id_categorie";
            this.idcategorieDataGridViewTextBoxColumn.HeaderText = "id_categorie";
            this.idcategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcategorieDataGridViewTextBoxColumn.Name = "idcategorieDataGridViewTextBoxColumn";
            this.idcategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomcategorieDataGridViewTextBoxColumn
            // 
            this.nomcategorieDataGridViewTextBoxColumn.DataPropertyName = "nom_categorie";
            this.nomcategorieDataGridViewTextBoxColumn.HeaderText = "nom_categorie";
            this.nomcategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomcategorieDataGridViewTextBoxColumn.Name = "nomcategorieDataGridViewTextBoxColumn";
            this.nomcategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomcategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(ApplicationSystemeRestauration.Entite.Categorie);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(414, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "GERER CATEGORIE";
            // 
            // savecategorie
            // 
            this.savecategorie.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.content_save;
            this.savecategorie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savecategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savecategorie.Location = new System.Drawing.Point(937, 283);
            this.savecategorie.Name = "savecategorie";
            this.savecategorie.Size = new System.Drawing.Size(81, 67);
            this.savecategorie.TabIndex = 4;
            this.savecategorie.UseVisualStyleBackColor = true;
            this.savecategorie.Click += new System.EventHandler(this.savecategorie_Click);
            // 
            // editcategorie
            // 
            this.editcategorie.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.ic_edit_white_48dp_1x;
            this.editcategorie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editcategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editcategorie.Location = new System.Drawing.Point(939, 439);
            this.editcategorie.Name = "editcategorie";
            this.editcategorie.Size = new System.Drawing.Size(79, 67);
            this.editcategorie.TabIndex = 5;
            this.editcategorie.UseVisualStyleBackColor = true;
            this.editcategorie.Click += new System.EventHandler(this.editcategorie_Click);
            // 
            // deletecategorie
            // 
            this.deletecategorie.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.delete;
            this.deletecategorie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletecategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletecategorie.Location = new System.Drawing.Point(937, 591);
            this.deletecategorie.Name = "deletecategorie";
            this.deletecategorie.Size = new System.Drawing.Size(89, 70);
            this.deletecategorie.TabIndex = 6;
            this.deletecategorie.UseVisualStyleBackColor = true;
            this.deletecategorie.Click += new System.EventHandler(this.deletecategorie_Click);
            // 
            // txtidcategorie
            // 
            this.txtidcategorie.Location = new System.Drawing.Point(966, 96);
            this.txtidcategorie.Multiline = true;
            this.txtidcategorie.Name = "txtidcategorie";
            this.txtidcategorie.Size = new System.Drawing.Size(199, 58);
            this.txtidcategorie.TabIndex = 7;
            // 
            // txtnomcategorie
            // 
            this.txtnomcategorie.Location = new System.Drawing.Point(966, 205);
            this.txtnomcategorie.Multiline = true;
            this.txtnomcategorie.Name = "txtnomcategorie";
            this.txtnomcategorie.Size = new System.Drawing.Size(210, 52);
            this.txtnomcategorie.TabIndex = 8;
            // 
            // GererCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1204, 713);
            this.Controls.Add(this.txtnomcategorie);
            this.Controls.Add(this.txtidcategorie);
            this.Controls.Add(this.deletecategorie);
            this.Controls.Add(this.editcategorie);
            this.Controls.Add(this.savecategorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listecategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GererCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            ((System.ComponentModel.ISupportInitialize)(this.listecategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
        private Label label1;
        private Label label2;
        private DataGridView listecategorie;
        private Label label3;
        private Button savecategorie;
        private Button editcategorie;
        private Button deletecategorie;
        private TextBox txtidcategorie;
        private TextBox txtnomcategorie;
        private DataGridViewTextBoxColumn idcategorieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomcategorieDataGridViewTextBoxColumn;
        private BindingSource categorieBindingSource;
    }
}