namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblVille = new System.Windows.Forms.Label();
            this.btnVille = new System.Windows.Forms.Button();
            this.txtbVille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBike = new System.Windows.Forms.DataGridView();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabBike)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(81, 72);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(42, 17);
            this.lblVille.TabIndex = 1;
            this.lblVille.Text = "Ville :";
            // 
            // btnVille
            // 
            this.btnVille.Location = new System.Drawing.Point(521, 66);
            this.btnVille.Name = "btnVille";
            this.btnVille.Size = new System.Drawing.Size(134, 25);
            this.btnVille.TabIndex = 2;
            this.btnVille.Text = "Valider";
            this.btnVille.UseVisualStyleBackColor = true;
            this.btnVille.Click += new System.EventHandler(this.btValider_Click);
            // 
            // txtbVille
            // 
            this.txtbVille.Location = new System.Drawing.Point(163, 69);
            this.txtbVille.Name = "txtbVille";
            this.txtbVille.Size = new System.Drawing.Size(302, 22);
            this.txtbVille.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vive le vélo !";
            // 
            // tabBike
            // 
            this.tabBike.AllowUserToAddRows = false;
            this.tabBike.AllowUserToDeleteRows = false;
            this.tabBike.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabBike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabBike.Location = new System.Drawing.Point(12, 189);
            this.tabBike.Name = "tabBike";
            this.tabBike.ReadOnly = true;
            this.tabBike.RowTemplate.Height = 24;
            this.tabBike.Size = new System.Drawing.Size(693, 249);
            this.tabBike.TabIndex = 6;
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(163, 125);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(302, 24);
            this.cbStation.TabIndex = 8;
            this.cbStation.Visible = false;
            this.cbStation.SelectedIndexChanged += new System.EventHandler(this.cbStation_SelectedIndexChanged);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(81, 128);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(60, 17);
            this.lblStation.TabIndex = 9;
            this.lblStation.Text = "Station :";
            this.lblStation.Visible = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(21, 46);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomInfo);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Location = new System.Drawing.Point(734, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 418);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de la station";
            this.groupBox1.Visible = false;
            // 
            // lblNomInfo
            // 
            this.lblNomInfo.AutoSize = true;
            this.lblNomInfo.Location = new System.Drawing.Point(89, 46);
            this.lblNomInfo.Name = "lblNomInfo";
            this.lblNomInfo.Size = new System.Drawing.Size(45, 17);
            this.lblNomInfo.TabIndex = 12;
            this.lblNomInfo.Text = "Nom :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.tabBike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbVille);
            this.Controls.Add(this.btnVille);
            this.Controls.Add(this.lblVille);
            this.Name = "Form1";
            this.Text = "Vive le vélo";
            ((System.ComponentModel.ISupportInitialize)(this.tabBike)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button btnVille;
        private System.Windows.Forms.TextBox txtbVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabBike;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNomInfo;
    }
}

