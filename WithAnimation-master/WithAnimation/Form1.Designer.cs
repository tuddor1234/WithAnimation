namespace WithAnimation
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.photosPanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.bigPicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.videosButton = new System.Windows.Forms.Button();
            this.soundsButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.photosButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.selectedPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.photosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.selectedPanel);
            this.panel1.Controls.Add(this.photosPanel);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 484);
            this.panel1.TabIndex = 0;
            // 
            // photosPanel
            // 
            this.photosPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photosPanel.BackColor = System.Drawing.Color.Transparent;
            this.photosPanel.Controls.Add(this.nextButton);
            this.photosPanel.Controls.Add(this.prevButton);
            this.photosPanel.Controls.Add(this.bigPicture);
            this.photosPanel.Enabled = false;
            this.photosPanel.Location = new System.Drawing.Point(277, 4);
            this.photosPanel.Name = "photosPanel";
            this.photosPanel.Size = new System.Drawing.Size(391, 386);
            this.photosPanel.TabIndex = 3;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(199, 333);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(50, 50);
            this.nextButton.TabIndex = 2;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevButton.BackColor = System.Drawing.Color.Transparent;
            this.prevButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevButton.BackgroundImage")));
            this.prevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.prevButton.FlatAppearance.BorderSize = 0;
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Location = new System.Drawing.Point(120, 333);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(50, 50);
            this.prevButton.TabIndex = 1;
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // bigPicture
            // 
            this.bigPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigPicture.BackColor = System.Drawing.Color.Transparent;
            this.bigPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigPicture.Location = new System.Drawing.Point(3, 0);
            this.bigPicture.Name = "bigPicture";
            this.bigPicture.Size = new System.Drawing.Size(385, 322);
            this.bigPicture.TabIndex = 0;
            this.bigPicture.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(25, 25);
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 322);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.videosButton);
            this.panel2.Controls.Add(this.soundsButton);
            this.panel2.Controls.Add(this.QuitButton);
            this.panel2.Controls.Add(this.photosButton);
            this.panel2.Location = new System.Drawing.Point(1, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 88);
            this.panel2.TabIndex = 2;
            // 
            // videosButton
            // 
            this.videosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.videosButton.AutoSize = true;
            this.videosButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("videosButton.BackgroundImage")));
            this.videosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videosButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.videosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videosButton.ForeColor = System.Drawing.Color.Black;
            this.videosButton.Location = new System.Drawing.Point(94, 3);
            this.videosButton.Name = "videosButton";
            this.videosButton.Size = new System.Drawing.Size(85, 85);
            this.videosButton.TabIndex = 5;
            this.videosButton.UseVisualStyleBackColor = true;
            this.videosButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // soundsButton
            // 
            this.soundsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soundsButton.AutoSize = true;
            this.soundsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundsButton.BackgroundImage")));
            this.soundsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soundsButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.soundsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundsButton.ForeColor = System.Drawing.Color.Black;
            this.soundsButton.Location = new System.Drawing.Point(185, 2);
            this.soundsButton.Name = "soundsButton";
            this.soundsButton.Size = new System.Drawing.Size(85, 85);
            this.soundsButton.TabIndex = 4;
            this.soundsButton.UseVisualStyleBackColor = true;
            this.soundsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitButton.BackgroundImage")));
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(582, 2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(85, 85);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // photosButton
            // 
            this.photosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.photosButton.AutoSize = true;
            this.photosButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("photosButton.BackgroundImage")));
            this.photosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photosButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.photosButton.FlatAppearance.BorderSize = 0;
            this.photosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.photosButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.photosButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.photosButton.Location = new System.Drawing.Point(3, 2);
            this.photosButton.Name = "photosButton";
            this.photosButton.Size = new System.Drawing.Size(85, 85);
            this.photosButton.TabIndex = 0;
            this.photosButton.UseVisualStyleBackColor = true;
            this.photosButton.Click += new System.EventHandler(this.photosButton_Click);
            // 
            // selectedPanel
            // 
            this.selectedPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.selectedPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.selectedPanel.Location = new System.Drawing.Point(4, 377);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.Size = new System.Drawing.Size(85, 10);
            this.selectedPanel.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 508);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.photosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bigPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button photosButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button videosButton;
        private System.Windows.Forms.Button soundsButton;
        private System.Windows.Forms.Panel photosPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        public System.Windows.Forms.PictureBox bigPicture;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel selectedPanel;
    }
}

