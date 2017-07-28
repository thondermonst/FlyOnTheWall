using System.Windows;

using NAudio.Wave;

namespace FlyOnTheWall.Models
{
    internal class AudioHandler : ModelBase
    {
        private static AudioHandler _instance;

        private WaveIn _recorder;
        private BufferedWaveProvider _bufferedWaveProvider;
        private SavingWaveProvider _savingWaveProvider;
        private WaveOut _player;

        private AudioHandler()
        {

        }

        public static AudioHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AudioHandler();
                }
                return _instance;
            }
        }

        private void StartRecording(object sender, RoutedEventArgs e)
        {
            _recorder = new WaveIn();
            _recorder.DataAvailable += RecorderOnDataAvailable;

            _bufferedWaveProvider = new BufferedWaveProvider(_recorder.WaveFormat);
            _savingWaveProvider = new SavingWaveProvider(_bufferedWaveProvider, "temp.wav");

            _player = new WaveOut();
            _player.Init(_savingWaveProvider);

            _player.Play();
            _recorder.StartRecording();
        }

        private void RecorderOnDataAvailable(object sender, WaveInEventArgs waveInEventArgs)
        {
            _bufferedWaveProvider.AddSamples(waveInEventArgs.Buffer, 0, waveInEventArgs.BytesRecorded);
        }

        private void StopRecording(object sender, RoutedEventArgs e)
        {
            _recorder.StopRecording();
            _player.Stop();
            _savingWaveProvider.Dispose();
        }
    }
}
