namespace Show_Audio_Device
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            refreshActiveAudioDevice = new System.Windows.Forms.Timer(components);
            activeOutputDevice = new Label();
            activeInputDevice = new Label();
            SuspendLayout();
            // 
            // refreshActiveAudioDevice
            // 
            refreshActiveAudioDevice.Interval = 1;
            // 
            // activeOutputDevice
            // 
            activeOutputDevice.AutoSize = true;
            activeOutputDevice.Location = new Point(10, 10);
            activeOutputDevice.Name = "activeOutputDevice";
            activeOutputDevice.Size = new Size(195, 30);
            activeOutputDevice.TabIndex = 2;
            activeOutputDevice.Text = "activeOutputDevice";
            // 
            // activeInputDevice
            // 
            activeInputDevice.AutoSize = true;
            activeInputDevice.Location = new Point(10, 50);
            activeInputDevice.Name = "activeInputDevice";
            activeInputDevice.Size = new Size(178, 30);
            activeInputDevice.TabIndex = 3;
            activeInputDevice.Text = "activeInputDevice";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 96);
            Controls.Add(activeInputDevice);
            Controls.Add(activeOutputDevice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer refreshActiveAudioDevice;
        private Label activeOutputDevice;
        private Label activeInputDevice;
    }
}
