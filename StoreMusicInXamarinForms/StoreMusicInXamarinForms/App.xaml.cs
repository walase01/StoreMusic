using Prism;
using Prism.Ioc;
using Prism.Unity;
using StoreMusicInXamarinForms.ViewModels;
using StoreMusicInXamarinForms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoreMusicInXamarinForms
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer Initializer=null) : base(Initializer)
        {

        }
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MenuMusicTabbedPage");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MenuMusicTabbedPage,HomeViewModel>();
        }
    }
}
