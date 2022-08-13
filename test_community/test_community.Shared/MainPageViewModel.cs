using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace test_community
{
    [ObservableObject]
    public partial class MainPageViewModel
    {
        public ObservableCollection<ItemModel> Items { get; set; }

        [ObservableProperty]
        private ItemModel _selectedItem;

        public MainPageViewModel()
        {
            Items = new ObservableCollection<ItemModel>()
            {
                new ItemModel() {Id = 1, Name = "Item 1"},
                new ItemModel() {Id = 2, Name = "Item 2"},
                new ItemModel() {Id = 3, Name = "Item 3"},
            };
        }
    }
}
