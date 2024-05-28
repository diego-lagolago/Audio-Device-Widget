using NAudio.CoreAudioApi;

namespace Show_Audio_Device
{
    public partial class Form1 : Form
    {
        private MMDeviceEnumerator enumerator;
        private MMDevice defaultOutputDevice;
        private MMDevice defaultInputDevice;
        public Form1()
        {
            InitializeComponent();
            enumerator = new MMDeviceEnumerator();
            refreshActiveAudioDevice.Interval = 1000; // Check every second
            refreshActiveAudioDevice.Tick += refreshActiveAudioDevice_Tick;
            refreshActiveAudioDevice.Start();
            UpdateActiveAudioDevice();
        }
        private void refreshActiveAudioDevice_Tick(object sender, EventArgs e)
        {
            UpdateActiveAudioDevice();
        }
        private void UpdateActiveAudioDevice()
        {
            var newDefaultOutputDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            if (newDefaultOutputDevice != null && (defaultOutputDevice == null || newDefaultOutputDevice.ID != defaultOutputDevice.ID))
            {
                defaultOutputDevice = newDefaultOutputDevice;
                activeOutputDevice.Text = $"Active Audio Device: {defaultOutputDevice.FriendlyName}";
            }

            var newDefaultInputDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);

            if (newDefaultInputDevice != null && (defaultInputDevice == null || newDefaultInputDevice.ID != defaultInputDevice.ID))
            {
                defaultInputDevice = newDefaultInputDevice;
                activeInputDevice.Text = $"Active Input Device: {defaultInputDevice.FriendlyName}";
            }
        }
    }
}