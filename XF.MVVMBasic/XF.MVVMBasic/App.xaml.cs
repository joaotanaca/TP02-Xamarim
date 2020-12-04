using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVMBasic.View;


namespace XF.MVVMBasic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AlunoViewPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
