namespace NgPa
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToTimerButton = new Button();
            ToGameButton = new Button();
            ToFieldButton = new Button();
            SuspendLayout();
            // 
            // ToTimerButton
            // 
            ToTimerButton.Location = new Point(111, 59);
            ToTimerButton.Name = "ToTimerButton";
            ToTimerButton.Size = new Size(127, 63);
            ToTimerButton.TabIndex = 0;
            ToTimerButton.Text = "Таймер";
            ToTimerButton.UseVisualStyleBackColor = true;
            ToTimerButton.Click += ToTimerButton_click;
            // 
            // ToGameButton
            // 
            ToGameButton.Location = new Point(111, 161);
            ToGameButton.Name = "ToGameButton";
            ToGameButton.Size = new Size(127, 54);
            ToGameButton.TabIndex = 1;
            ToGameButton.Text = "Игра";
            ToGameButton.UseVisualStyleBackColor = true;
            ToGameButton.Click += ToGameButton_Click;
            // 
            // ToFieldButton
            // 
            ToFieldButton.Location = new Point(111, 243);
            ToFieldButton.Name = "ToFieldButton";
            ToFieldButton.Size = new Size(127, 55);
            ToFieldButton.TabIndex = 2;
            ToFieldButton.Text = "Генерация поля";
            ToFieldButton.UseVisualStyleBackColor = true;
            ToFieldButton.Click += ToFieldButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 368);
            Controls.Add(ToFieldButton);
            Controls.Add(ToGameButton);
            Controls.Add(ToTimerButton);
            Name = "MainForm";
            Text = "Основная форма";
            ResumeLayout(false);
        }

        #endregion

        private Button ToTimerButton;
        private Button ToGameButton;
        private Button ToFieldButton;
    }
}
