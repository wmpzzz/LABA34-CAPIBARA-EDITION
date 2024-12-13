namespace N7Pa
{
    partial class TimerForm
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
            StartButton = new Button();
            StopButton = new Button();
            TimerLabel = new Label();
            timerT = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(24, 143);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(159, 28);
            StartButton.TabIndex = 0;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click_1;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(230, 143);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(144, 28);
            StopButton.TabIndex = 1;
            StopButton.Text = "Стоп";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Location = new Point(182, 80);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(38, 15);
            TimerLabel.TabIndex = 2;
            TimerLabel.Text = "label1";
            // 
            // timerT
            // 
            timerT.Tick += Timer_Tick;
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 206);
            Controls.Add(TimerLabel);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Name = "TimerForm";
            Text = "Таймер";
            Load += TimerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Label TimerLabel;
        private System.Windows.Forms.Timer timerT;
    }
}