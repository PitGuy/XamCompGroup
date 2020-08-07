using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinCompetenceGroup.PageModels
{
    public class MainPageModel : FreshMvvm.FreshBasePageModel
    {
        private ICommand navigateCommand;
        public ICommand NavigateCommand => navigateCommand ?? (navigateCommand = new Command<String>(async (name) => await NavigateToPage(name)));

        private async Task NavigateToPage(string name)
        {
            switch (name)
            {
                case "StackLayout": await CoreMethods.PushPageModel<StackLayoutPageModel>(); break;
                case "AbsoluteLayout": await CoreMethods.PushPageModel<AbsoluteLayoutPageModel>(); break;
                case "RelativeLayout": await CoreMethods.PushPageModel<RelativeLayoutPageModel>(); break;
                case "CarouselView": await CoreMethods.PushPageModel<CarouselViewPageModel>(); break;
                case "ListView": await CoreMethods.PushPageModel<ListViewPageModel>(); break;
                case "CollectionView": await CoreMethods.PushPageModel<CollectionViewPageModel>(); break;
                case "BindableObjcetPage": await CoreMethods.PushPageModel<BindableObjcetPageModel>(); break;
                case "Recources" : await CoreMethods.PushPageModel<RecourcesPageModel>(); break;
                default: break;
            }
        }
    }
}
