using CommunityToolkit.Mvvm.ComponentModel;

namespace BookmarkOwl.ViewModels
{
    public partial class LinkListViewModel : ObservableObject
    {

        public LinkListViewModel()
        {
            this.Title = "BookmarkOwl";
        }

        [ObservableProperty]
        string _title = string.Empty;


    }
}
