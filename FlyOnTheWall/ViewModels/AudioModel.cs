using System;
using System.Windows;
using System.Windows.Input;

using FlyOnTheWall.Commands;
using FlyOnTheWall.Models;

namespace FlyOnTheWall.ViewModels
{
    internal class AudioModel : ViewModelBase
    {
        private ICommand _recordCommand;
        private ICommand _stopCommand;

        private AudioHandler _audioHandler;

        private AudioModel()
        {
            _audioHandler = AudioHandler.Instance;
        }

        public ICommand RecordCommand()
        {
            if (_recordCommand == null)
            {
                _recordCommand = new RelayCommand(RecordAction);
            }
            return _recordCommand;
        }

        public ICommand StopCommand()
        {
            if (_stopCommand == null)
            {
                _stopCommand = new RelayCommand(StopAction);
            }
            return _stopCommand;
        }

        public void RecordAction()
        {
            _audioHandler.StartRecording();
        }

        public void StopAction()
        {

        }
    }
}
