
namespace ScreenSaver
{
    partial class Config
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
            this.ColorPickerBtn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Entite = new System.Windows.Forms.TextBox();
            this.systeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classification = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.couleurClassif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mentions = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imgPath = new System.Windows.Forms.TextBox();
            this.ImageBrowsBtn = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ColorPickerBtn
            // 
            this.ColorPickerBtn.Location = new System.Drawing.Point(347, 86);
            this.ColorPickerBtn.Name = "ColorPickerBtn";
            this.ColorPickerBtn.Size = new System.Drawing.Size(32, 23);
            this.ColorPickerBtn.TabIndex = 0;
            this.ColorPickerBtn.Text = "...";
            this.ColorPickerBtn.UseVisualStyleBackColor = true;
            this.ColorPickerBtn.Click += new System.EventHandler(this.ColorPickerBtn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(527, 260);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de l\'entité";
            // 
            // Entite
            // 
            this.Entite.Location = new System.Drawing.Point(154, 10);
            this.Entite.Name = "Entite";
            this.Entite.Size = new System.Drawing.Size(363, 20);
            this.Entite.TabIndex = 2;
            // 
            // systeme
            // 
            this.systeme.Location = new System.Drawing.Point(154, 36);
            this.systeme.Name = "systeme";
            this.systeme.Size = new System.Drawing.Size(363, 20);
            this.systeme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom du SI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Niveau de classification";
            // 
            // classification
            // 
            this.classification.Location = new System.Drawing.Point(154, 62);
            this.classification.Name = "classification";
            this.classification.Size = new System.Drawing.Size(363, 20);
            this.classification.TabIndex = 4;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.Red;
            this.colorDialog1.FullOpen = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Couleur de la mention de classification";
            // 
            // couleurClassif
            // 
            this.couleurClassif.BackColor = System.Drawing.Color.White;
            this.couleurClassif.Location = new System.Drawing.Point(227, 88);
            this.couleurClassif.Name = "couleurClassif";
            this.couleurClassif.ReadOnly = true;
            this.couleurClassif.Size = new System.Drawing.Size(113, 20);
            this.couleurClassif.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mentions légales";
            // 
            // mentions
            // 
            this.mentions.Location = new System.Drawing.Point(154, 115);
            this.mentions.Multiline = true;
            this.mentions.Name = "mentions";
            this.mentions.Size = new System.Drawing.Size(363, 83);
            this.mentions.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Image principale";
            // 
            // imgPath
            // 
            this.imgPath.BackColor = System.Drawing.SystemColors.Info;
            this.imgPath.Location = new System.Drawing.Point(154, 204);
            this.imgPath.Name = "imgPath";
            this.imgPath.ReadOnly = true;
            this.imgPath.Size = new System.Drawing.Size(363, 20);
            this.imgPath.TabIndex = 4;
            // 
            // ImageBrowsBtn
            // 
            this.ImageBrowsBtn.Location = new System.Drawing.Point(524, 202);
            this.ImageBrowsBtn.Name = "ImageBrowsBtn";
            this.ImageBrowsBtn.Size = new System.Drawing.Size(32, 23);
            this.ImageBrowsBtn.TabIndex = 0;
            this.ImageBrowsBtn.Text = "...";
            this.ImageBrowsBtn.UseVisualStyleBackColor = true;
            this.ImageBrowsBtn.Click += new System.EventHandler(this.ImageBrowsBtn_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(446, 260);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 295);
            this.Controls.Add(this.couleurClassif);
            this.Controls.Add(this.mentions);
            this.Controls.Add(this.classification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imgPath);
            this.Controls.Add(this.systeme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Entite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ImageBrowsBtn);
            this.Controls.Add(this.ColorPickerBtn);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ColorPickerBtn;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Entite;
        private System.Windows.Forms.TextBox systeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classification;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox couleurClassif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mentions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imgPath;
        private System.Windows.Forms.Button ImageBrowsBtn;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}