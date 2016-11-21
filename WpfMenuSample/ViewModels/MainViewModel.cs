using System.Collections.Generic;
using System.Windows.Input;
using Prism.Commands;

namespace WpfMenuSample.ViewModels
{
    internal class MainViewModel
    {
        public MainViewModel()
        {
            RaptManager = new RaptManager
            {
                RaptConfiguration = new RaptConfiguration
                {
                    RecentFiles = new List<string>
                    {
                        "Recent File 1",
                        "Recent File 2"
                    }
                }
            };

            NewFileCommand = new DelegateCommand(() =>
            {
                //Dummy command handler
            });

            OpenFileCommand = new DelegateCommand(OpenFile);
        }

        private void OpenFile()
        {
        }

        public RaptManager RaptManager { get; set; }

        public ICommand NewFileCommand { get; set; }

        public ICommand OpenFileCommand { get; set; }
    }

    internal class RaptManager
    {
        public RaptManager()
        {
            RaptConfiguration = new RaptConfiguration();
        }

        public RaptConfiguration RaptConfiguration { get; set; }
    }

    internal class RaptConfiguration
    {
        public IEnumerable<string> RecentFiles { get; set; }
    }
}