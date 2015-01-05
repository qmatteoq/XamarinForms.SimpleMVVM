using System;
using Microsoft.Practices.ServiceLocation;
using SimpleMVVM.Core.Helpers;
using SimpleMVVM.Core.Services;
using SimpleMVVM.Core.ViewModels;
using Xamarin.Forms;

namespace SimpleMVVM.Core.Infrastructure
{
    public class PageLocator : IPageLocator
    {
        protected virtual Page CreatePage(Type pageType)
        {
            return Activator.CreateInstance(pageType) as Page;
        }

        protected virtual IViewModel CreateViewModel(Type viewModelType)
        {
            return ServiceLocator.Current.GetInstance(viewModelType) as IViewModel;
        }

        protected virtual Type FindPageForViewModel(Type viewModelType)
        {
            var pageTypeName = viewModelType
                .AssemblyQualifiedName
                .Replace("ViewModel", "View");

            var pageType = Type.GetType(pageTypeName);
            if (pageType == null)
                throw new ArgumentException(pageTypeName + " type not exist");

            return pageType;
        }

        public NavigationPage ResolveNavigationPageAndViewModel(Type viewModelType, object args)
        {
            var viewModel = this.CreateViewModel(viewModelType);
            viewModel.OnInit(args);
            return this.ResolveNavigationPage(viewModel);
        }

        public NavigationPage ResolveNavigationPage(IViewModel viewModel)
        {
            var pageType = this.FindPageForViewModel(viewModel.GetType());
            var page = this.CreatePage(pageType);

            NavigationPage navigationPage = new NavigationPage(page) {Title = page.Title};
            NavigationService navigationService = new NavigationService {Navigation = navigationPage.Navigation};
            viewModel.NavigationService = navigationService;
            page.BindViewModel(viewModel);
            return navigationPage;
        }

        public Page ResolvePageAndViewModel(Type viewModelType, object args, INavigationService navigationService)
        {
            var viewModel = this.CreateViewModel(viewModelType);
            viewModel.OnInit(args);
            viewModel.NavigationService = navigationService;
            return this.ResolvePage(viewModel);
        }

        public Page ResolvePage(IViewModel viewModel)
        {
            var pageType = this.FindPageForViewModel(viewModel.GetType());
            var page = this.CreatePage(pageType);
            page.BindViewModel(viewModel);
            return page;
        }
    }
}
