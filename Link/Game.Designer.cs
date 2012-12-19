namespace Link
{
    partial class Game
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
            this.board = new System.Windows.Forms.Panel();
            this.locLabel = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.PictureBox();
            this.board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.link)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.Transparent;
            this.board.BackgroundImage = global::Link.Properties.Resources.background;
            this.board.Controls.Add(this.locLabel);
            this.board.Controls.Add(this.link);
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(257, 211);
            this.board.TabIndex = 0;
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLabel.ForeColor = System.Drawing.Color.White;
            this.locLabel.Location = new System.Drawing.Point(3, 198);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(41, 13);
            this.locLabel.TabIndex = 1;
            this.locLabel.Text = "label1";
            // 
            // link
            // 
            this.link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link.BackColor = System.Drawing.Color.Transparent;
            this.link.Image = global::Link.Properties.Resources.link_down1;
            this.link.Location = new System.Drawing.Point(125, 145);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(15, 16);
            this.link.TabIndex = 2;
            this.link.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 236);
            this.Controls.Add(this.board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.board.ResumeLayout(false);
            this.board.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.link)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Label locLabel;
        private System.Windows.Forms.PictureBox link;
    }
}

