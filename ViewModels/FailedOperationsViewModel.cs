using ReactiveUI;
using Sikor.Container;

namespace Sikor.ViewModels
{
    public class FailedOperationsViewModel : ReactiveViewServiceProvider
    {
        protected bool loaderVisible = false;

        public bool LoaderVisible
        {
            get => loaderVisible;
            set => this.RaiseAndSetIfChanged(ref loaderVisible, value);
        }

        public void Show()
        {
            LoaderVisible = true;
        }

        public void Hide()
        {
            LoaderVisible = false;
        }
        public FailedOperationsViewModel()
        {
        }
    }
}
