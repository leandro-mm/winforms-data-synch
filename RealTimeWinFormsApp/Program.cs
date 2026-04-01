using RealTimeWinFormsApp.Models;
using RealTimeWinFormsApp.Plugins;

namespace RealTimeWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var dataModel = new SharedDataModel();

            //create and show multiple views
            var mainForm = new FormMain(dataModel);            
            mainForm.Show();

            CreateSecondaryViewOnSeparetedThread(dataModel);
            //CreateSecondaryViewOnTheMainThread(dataModel);

            LoadPlugins(dataModel);

            Application.Run(mainForm);
        }

        private static void LoadPlugins(SharedDataModel dataModel)
        {
            //scan plugins directory
            var plugin = new ExamplePlugin();
            var pluginExample = plugin.CreateView(dataModel);
            pluginExample.Show();
        }

        private static void CreateSecondaryViewOnTheMainThread(SharedDataModel dataModel)
        {
            var secondaryForm = new FormSecondary(dataModel);
            secondaryForm.Show();
        }

        private static void CreateSecondaryViewOnSeparetedThread(SharedDataModel dataModel)
        {
            Thread secondaryThread = new Thread(() =>
            {
                // Important: Forms need STA apartment state
                var secondaryForm = new FormSecondary(dataModel);

                // Run message loop for this form
                Application.Run(secondaryForm);
            });

            secondaryThread.SetApartmentState(ApartmentState.STA);
            secondaryThread.Start();
        }
    }
}