namespace N7Pa
{
    partial class AnimationForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationForm));
            Timer = new System.Windows.Forms.Timer(components);
            PlayerPictureBox = new PictureBox();
            ImageList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)PlayerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // PlayerPictureBox
            // 
            PlayerPictureBox.Location = new Point(238, 162);
            PlayerPictureBox.Name = "PlayerPictureBox";
            PlayerPictureBox.Size = new Size(111, 66);
            PlayerPictureBox.TabIndex = 0;
            PlayerPictureBox.TabStop = false;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = ColorDepth.Depth32Bit;
            ImageList.ImageStream = (ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = Color.Transparent;
            ImageList.Images.SetKeyName(0, "charlieTheCapybaraAnimationSheet (8).png");
            ImageList.Images.SetKeyName(1, "charlieTheCapybaraAnimationSheet (7).png");
            ImageList.Images.SetKeyName(2, "charlieTheCapybaraAnimationSheet (6).png");
            ImageList.Images.SetKeyName(3, "charlieTheCapybaraAnimationSheet (5).png");
            ImageList.Images.SetKeyName(4, "charlieTheCapybaraAnimationSheet (4).png");
            ImageList.Images.SetKeyName(5, "charlieTheCapybaraAnimationSheet (3).png");
            ImageList.Images.SetKeyName(6, "charlieTheCapybaraAnimationSheet (2).png");
            ImageList.Images.SetKeyName(7, "charlieTheCapybaraAnimationSheet (1).png");
            // 
            // AnimationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 344);
            Controls.Add(PlayerPictureBox);
            Name = "AnimationForm";
            Text = "AnimForm";
            ((System.ComponentModel.ISupportInitialize)PlayerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private PictureBox PlayerPictureBox;
        private ImageList ImageList;
    }
}