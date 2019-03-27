namespace TDWebServices_WindowsForms
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
            this.textboxVille = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.buttonGetStations = new System.Windows.Forms.Button();
            this.labelStations = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStation = new System.Windows.Forms.Label();
            this.textboxStations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxVille
            // 
            this.textboxVille.Location = new System.Drawing.Point(209, 79);
            this.textboxVille.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxVille.Name = "textboxVille";
            this.textboxVille.Size = new System.Drawing.Size(384, 22);
            this.textboxVille.TabIndex = 0;
            this.textboxVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxVille_KeyPress);
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(161, 82);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(42, 17);
            this.labelVille.TabIndex = 1;
            this.labelVille.Text = "Ville :";
            this.labelVille.Click += new System.EventHandler(this.labelVille_Click);
            // 
            // buttonGetStations
            // 
            this.buttonGetStations.Location = new System.Drawing.Point(267, 132);
            this.buttonGetStations.Name = "buttonGetStations";
            this.buttonGetStations.Size = new System.Drawing.Size(253, 23);
            this.buttonGetStations.TabIndex = 2;
            this.buttonGetStations.Text = "Récupérer les stations";
            this.buttonGetStations.UseVisualStyleBackColor = true;
            this.buttonGetStations.Click += new System.EventHandler(this.buttonGetStations_Click);
            // 
            // labelStations
            // 
            this.labelStations.AutoSize = true;
            this.labelStations.Location = new System.Drawing.Point(13, 201);
            this.labelStations.Name = "labelStations";
            this.labelStations.Size = new System.Drawing.Size(71, 17);
            this.labelStations.TabIndex = 4;
            this.labelStations.Text = "Stations : ";
            this.labelStations.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLUS JAMAIS A PIED ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // labelStation
            // 
            this.labelStation.Location = new System.Drawing.Point(0, 0);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(100, 23);
            this.labelStation.TabIndex = 0;
            // 
            // textboxStations
            // 
            this.textboxStations.Location = new System.Drawing.Point(145, 195);
            this.textboxStations.Multiline = true;
            this.textboxStations.Name = "textboxStations";
            this.textboxStations.ReadOnly = true;
            this.textboxStations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxStations.Size = new System.Drawing.Size(574, 117);
            this.textboxStations.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxStations);
            this.Controls.Add(this.labelStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStations);
            this.Controls.Add(this.buttonGetStations);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.textboxVille);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxVille;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Button buttonGetStations;
        private System.Windows.Forms.Label labelStations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.TextBox textboxStations;
    }
}

