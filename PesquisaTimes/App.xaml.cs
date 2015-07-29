using PesquisaTimes.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace PesquisaTimes
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

            Times = new List<TimeViewModel>()
            {
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/atletico-mineiro-logo.png?w=700&h=", Nome = "Atlético-MG", Estado="MG"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/cruzeiro-logo.png?w=700&h=", Nome = "Cruzeiro", Estado="MG"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/sao-paulo-logo.png?w=700&h=", Nome = "São Paulo", Estado="SP"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/portuguesa-de-desportos-logo.png?w=700&h=", Nome = "Portuguesa", Estado="SP"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/corinthians-logo.png?w=700&h=", Nome = "Corinthians", Estado="SP"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/palmeiras-logo.png?w=700&h=", Nome = "Palmeiras", Estado="SP"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/america-mineiro-logo.png?w=700&h=", Nome = "América", Estado="MG"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/gremio-logo.png?w=700&h=", Nome = "Grêmio", Estado="RS"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/internacional-logo.png?w=700&h=", Nome = "Internacional", Estado="RS"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/santos-logo.png?w=700&h=", Nome = "Santos", Estado="SP"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/flamengo-logo.png?w=700&h=", Nome = "Flamengo", Estado="RJ"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/vasco-da-gama-logo.png?w=700&h=", Nome = "Vasco", Estado="RJ"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/sport-recife-logo.png?w=700&h=", Nome = "Sport", Estado="RE"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/atletico-goianiense-logo.png?w=700&h=", Nome = "Atlético-GO", Estado="GO"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/atletico-pr-logo.png?w=700&h=", Nome = "Atlético-PR", Estado="PR"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/avai-logo.png?w=700&h=", Nome = "Avaí", Estado="SC"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/botafogo-logo.png?w=700&h=", Nome = "Botafogo", Estado="RJ"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/ceara-logo.png?w=700&h=", Nome = "Ceará", Estado="CE"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/coritiba-logo.png?w=700&h=", Nome = "Coritiba", Estado="PR"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/esporte-clube-bahia-logo.png?w=700&h=", Nome = "Bahia", Estado="BA"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/figueirense-logo.png?w=700&h=", Nome = "Figueirense", Estado="SC"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/fluminense-logo.png?w=700&h=", Nome = "Fluminense", Estado="RJ"},
                new TimeViewModel(){ Imagem="https://hdlogo.files.wordpress.com/2011/11/nautico-capibaribe-logo.png?w=700&h=", Nome = "Náutico", Estado="PE"},
                
            };
        }


        public static List<TimeViewModel> Times { get; set; }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {

#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();
                // Set the default language
                rootFrame.Language = Windows.Globalization.ApplicationLanguages.Languages[0];

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                rootFrame.Navigate(typeof(MainPage), e.Arguments);
            }
            // Ensure the current window is active
            Window.Current.Activate();



        }

        

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
