namespace oizoMusicPlayerCsharp
{
    partial class NewPlaylist
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbPLaylistName = new System.Windows.Forms.TextBox();
            this.BtOK = new System.Windows.Forms.Button();
            this.BtRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrer le nom";
            // 
            // TbPLaylistName
            // 
            this.TbPLaylistName.Location = new System.Drawing.Point(12, 40);
            this.TbPLaylistName.Name = "TbPLaylistName";
            this.TbPLaylistName.Size = new System.Drawing.Size(324, 20);
            this.TbPLaylistName.TabIndex = 1;
            // 
            // BtOK
            // 
            this.BtOK.Location = new System.Drawing.Point(93, 66);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(75, 23);
            this.BtOK.TabIndex = 2;
            this.BtOK.Text = "OK";
            this.BtOK.UseVisualStyleBackColor = true;
            this.BtOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // BtRetour
            // 
            this.BtRetour.Location = new System.Drawing.Point(174, 66);
            this.BtRetour.Name = "BtRetour";
            this.BtRetour.Size = new System.Drawing.Size(75, 23);
            this.BtRetour.TabIndex = 3;
            this.BtRetour.Text = "Retour";
            this.BtRetour.UseVisualStyleBackColor = true;
            this.BtRetour.Click += new System.EventHandler(this.BtRetour_Click);
            // 
            // NewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 94);
            this.Controls.Add(this.BtRetour);
            this.Controls.Add(this.BtOK);
            this.Controls.Add(this.TbPLaylistName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NewPlaylist";
            this.Text = "New Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPLaylistName;
        private System.Windows.Forms.Button BtOK;
        private System.Windows.Forms.Button BtRetour;
    }
}