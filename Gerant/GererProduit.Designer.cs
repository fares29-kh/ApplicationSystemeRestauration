namespace ApplicationSystemeRestauration.Gerant
{
    partial class GererProduit
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
            this.listeservice = new System.Windows.Forms.DataGridView();
            this.btnajoutservice = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageservice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtimageservice = new System.Windows.Forms.Label();
            this.listcategorie = new System.Windows.Forms.ListView();
            this.quantiteservice = new System.Windows.Forms.NumericUpDown();
            this.txtprixservice = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtnomservice = new System.Windows.Forms.TextBox();
            this.txtserviceid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listeservice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteservice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listeservice
            // 
            this.listeservice.AutoGenerateColumns = false;
            this.listeservice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.listeservice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeservice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idserviceDataGridViewTextBoxColumn,
            this.nomserviceDataGridViewTextBoxColumn,
            this.descriptionserviceDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.idcategorieDataGridViewTextBoxColumn,
            this.Quantite,
            this.imageDataGridViewTextBoxColumn});
            this.listeservice.DataSource = this.serviceBindingSource;
            this.listeservice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.listeservice.Location = new System.Drawing.Point(12, 71);
            this.listeservice.Name = "listeservice";
            this.listeservice.RowHeadersWidth = 51;
            this.listeservice.RowTemplate.Height = 29;
            this.listeservice.Size = new System.Drawing.Size(756, 500);
            this.listeservice.TabIndex = 0;
            this.listeservice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeservice_CellContentClick);
            // 
            // btnajoutservice
            // 
            this.btnajoutservice.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.content_save;
            this.btnajoutservice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnajoutservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajoutservice.Location = new System.Drawing.Point(816, 542);
            this.btnajoutservice.Name = "btnajoutservice";
            this.btnajoutservice.Size = new System.Drawing.Size(94, 53);
            this.btnajoutservice.TabIndex = 2;
            this.btnajoutservice.UseVisualStyleBackColor = true;
            this.btnajoutservice.Click += new System.EventHandler(this.saveservice_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.delete;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1058, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 53);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Deleteservice_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.ic_edit_white_48dp_1x;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(932, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 53);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.updateservice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(793, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID SERVICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(793, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOM SERVICE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(793, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIPTION";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(793, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "PRIX";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(793, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "CATEGORIE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(793, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "QUANTITE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(793, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "IMAGE";
            // 
            // imageservice
            // 
            this.imageservice.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.content_save;
            this.imageservice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageservice.Location = new System.Drawing.Point(1082, 417);
            this.imageservice.Name = "imageservice";
            this.imageservice.Size = new System.Drawing.Size(94, 53);
            this.imageservice.TabIndex = 13;
            this.imageservice.UseVisualStyleBackColor = true;
            this.imageservice.Click += new System.EventHandler(this.imageservice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(923, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            // 
            // txtimageservice
            // 
            this.txtimageservice.AutoSize = true;
            this.txtimageservice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtimageservice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtimageservice.Location = new System.Drawing.Point(960, 433);
            this.txtimageservice.Name = "txtimageservice";
            this.txtimageservice.Size = new System.Drawing.Size(116, 23);
            this.txtimageservice.TabIndex = 15;
            this.txtimageservice.Text = "ajouter image";
            // 
            // listcategorie
            // 
            this.listcategorie.BackColor = System.Drawing.Color.Bisque;
            this.listcategorie.Location = new System.Drawing.Point(984, 297);
            this.listcategorie.Name = "listcategorie";
            this.listcategorie.Size = new System.Drawing.Size(192, 31);
            this.listcategorie.TabIndex = 16;
            this.listcategorie.UseCompatibleStateImageBehavior = false;
            // 
            // quantiteservice
            // 
            this.quantiteservice.BackColor = System.Drawing.Color.Bisque;
            this.quantiteservice.Location = new System.Drawing.Point(984, 363);
            this.quantiteservice.Name = "quantiteservice";
            this.quantiteservice.Size = new System.Drawing.Size(192, 27);
            this.quantiteservice.TabIndex = 17;
            // 
            // txtprixservice
            // 
            this.txtprixservice.BackColor = System.Drawing.Color.Bisque;
            this.txtprixservice.Location = new System.Drawing.Point(984, 249);
            this.txtprixservice.Name = "txtprixservice";
            this.txtprixservice.Size = new System.Drawing.Size(192, 27);
            this.txtprixservice.TabIndex = 18;
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.Color.Bisque;
            this.txtdescription.Location = new System.Drawing.Point(984, 164);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(192, 55);
            this.txtdescription.TabIndex = 19;
            // 
            // txtnomservice
            // 
            this.txtnomservice.BackColor = System.Drawing.Color.Bisque;
            this.txtnomservice.Location = new System.Drawing.Point(984, 112);
            this.txtnomservice.Name = "txtnomservice";
            this.txtnomservice.Size = new System.Drawing.Size(192, 27);
            this.txtnomservice.TabIndex = 20;
            // 
            // txtserviceid
            // 
            this.txtserviceid.BackColor = System.Drawing.Color.Bisque;
            this.txtserviceid.Location = new System.Drawing.Point(984, 55);
            this.txtserviceid.Name = "txtserviceid";
            this.txtserviceid.Size = new System.Drawing.Size(192, 27);
            this.txtserviceid.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(441, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "GERER SERVICE";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(DaoRestaurant.Entite.Service);
            // 
            // idserviceDataGridViewTextBoxColumn
            // 
            this.idserviceDataGridViewTextBoxColumn.DataPropertyName = "id_service";
            this.idserviceDataGridViewTextBoxColumn.HeaderText = "id_service";
            this.idserviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idserviceDataGridViewTextBoxColumn.Name = "idserviceDataGridViewTextBoxColumn";
            this.idserviceDataGridViewTextBoxColumn.Width = 85;
            // 
            // nomserviceDataGridViewTextBoxColumn
            // 
            this.nomserviceDataGridViewTextBoxColumn.DataPropertyName = "Nom_service";
            this.nomserviceDataGridViewTextBoxColumn.HeaderText = "Nom_service";
            this.nomserviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomserviceDataGridViewTextBoxColumn.Name = "nomserviceDataGridViewTextBoxColumn";
            this.nomserviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionserviceDataGridViewTextBoxColumn
            // 
            this.descriptionserviceDataGridViewTextBoxColumn.DataPropertyName = "description_service";
            this.descriptionserviceDataGridViewTextBoxColumn.HeaderText = "description_service";
            this.descriptionserviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionserviceDataGridViewTextBoxColumn.Name = "descriptionserviceDataGridViewTextBoxColumn";
            this.descriptionserviceDataGridViewTextBoxColumn.Width = 140;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.Width = 60;
            // 
            // idcategorieDataGridViewTextBoxColumn
            // 
            this.idcategorieDataGridViewTextBoxColumn.DataPropertyName = "id_categorie";
            this.idcategorieDataGridViewTextBoxColumn.HeaderText = "id_categorie";
            this.idcategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcategorieDataGridViewTextBoxColumn.Name = "idcategorieDataGridViewTextBoxColumn";
            this.idcategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "id_service";
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.MinimumWidth = 6;
            this.Quantite.Name = "Quantite";
            this.Quantite.Width = 80;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.Width = 80;
            // 
            // GererProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1204, 644);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtserviceid);
            this.Controls.Add(this.txtnomservice);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtprixservice);
            this.Controls.Add(this.quantiteservice);
            this.Controls.Add(this.listcategorie);
            this.Controls.Add(this.txtimageservice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.imageservice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnajoutservice);
            this.Controls.Add(this.listeservice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GererProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.GererProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeservice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteservice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
        private DataGridView listeservice;
        private Button btnajoutservice;
        private Button button2;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button imageservice;
        private Label label8;
        private Label txtimageservice;
        private ListView listcategorie;
        private NumericUpDown quantiteservice;
        private TextBox txtprixservice;
        private TextBox txtdescription;
        private TextBox txtnomservice;
        private TextBox txtserviceid;
        private Label label10;
        private BindingSource serviceBindingSource;
        private DataGridViewTextBoxColumn idserviceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomserviceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionserviceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idcategorieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Quantite;
        private DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
    }
}