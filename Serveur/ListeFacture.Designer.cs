namespace ApplicationSystemeRestauration.serveur
{
    partial class ListeFacture
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
            this.dgPriceChanges = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalcMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPriceChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPriceChanges
            // 
            this.dgPriceChanges.AllowUserToAddRows = false;
            this.dgPriceChanges.AllowUserToDeleteRows = false;
            this.dgPriceChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPriceChanges.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(83)))));
            this.dgPriceChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPriceChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Selected,
            this.ItemName,
            this.PriceBefore,
            this.PriceAfter,
            this.PriceLevel,
            this.CalcMethod,
            this.PercentChange,
            this.ChangedBy,
            this.DateChange});
            this.dgPriceChanges.Location = new System.Drawing.Point(17, 101);
            this.dgPriceChanges.Margin = new System.Windows.Forms.Padding(5);
            this.dgPriceChanges.Name = "dgPriceChanges";
            this.dgPriceChanges.RowHeadersVisible = false;
            this.dgPriceChanges.RowHeadersWidth = 51;
            this.dgPriceChanges.Size = new System.Drawing.Size(1023, 551);
            this.dgPriceChanges.TabIndex = 142;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            this.ItemID.Width = 125;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.Width = 30;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ID FACTURE";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 125;
            // 
            // PriceBefore
            // 
            this.PriceBefore.HeaderText = "NUM DE TABLE";
            this.PriceBefore.MinimumWidth = 6;
            this.PriceBefore.Name = "PriceBefore";
            this.PriceBefore.Width = 125;
            // 
            // PriceAfter
            // 
            this.PriceAfter.HeaderText = "PRIX FACTURE";
            this.PriceAfter.MinimumWidth = 6;
            this.PriceAfter.Name = "PriceAfter";
            this.PriceAfter.Width = 125;
            // 
            // PriceLevel
            // 
            this.PriceLevel.HeaderText = "PAYEMENT";
            this.PriceLevel.MinimumWidth = 6;
            this.PriceLevel.Name = "PriceLevel";
            this.PriceLevel.Width = 125;
            // 
            // CalcMethod
            // 
            this.CalcMethod.HeaderText = "ID CLIENT";
            this.CalcMethod.MinimumWidth = 6;
            this.CalcMethod.Name = "CalcMethod";
            this.CalcMethod.Width = 125;
            // 
            // PercentChange
            // 
            this.PercentChange.HeaderText = "ID SERVEUR";
            this.PercentChange.MinimumWidth = 6;
            this.PercentChange.Name = "PercentChange";
            this.PercentChange.Width = 125;
            // 
            // ChangedBy
            // 
            this.ChangedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChangedBy.HeaderText = "PAYEMENT";
            this.ChangedBy.MinimumWidth = 6;
            this.ChangedBy.Name = "ChangedBy";
            // 
            // DateChange
            // 
            this.DateChange.HeaderText = "ACTION";
            this.DateChange.MinimumWidth = 6;
            this.DateChange.Name = "DateChange";
            this.DateChange.Width = 125;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(886, 29);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 61);
            this.btnGenerate.TabIndex = 147;
            this.btnGenerate.Text = "Rafraîchir";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(450, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 148;
            this.label1.Text = "Liste Facture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.rafraîchir;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(891, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 45);
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnBack.BackgroundImage = global::ApplicationSystemeRestauration.Properties.Resources.retour;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(29, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 41);
            this.btnBack.TabIndex = 150;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ListeFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(83)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 671);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgPriceChanges);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ListeFacture";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Facture";
            ((System.ComponentModel.ISupportInitialize)(this.dgPriceChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPriceChanges;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalcMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateChange;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
        private Button btnBack;
    }
}