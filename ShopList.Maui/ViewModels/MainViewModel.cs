using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Maui.View;
using System.Collections.ObjectModel;

namespace ShopList.Maui.ViewModels

{

    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ShopListItem> _items;

        public MainViewModel()

        {
            Items = new ObservableCollection<ShopListItem>();
            LoadItems();
        }

        private void LoadItems()

        {
            Items.Add(new ShopListitem
            {
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false
            });

            Items.Add(new ShopListitem
            {
                Nombre = "Pan",
                Cantidad = 1,
                Comprado = true
            });

            Items.Add(new ShopListitem
            {
                Nombre = "Harina",
                Cantidad = 3,
                Comprado = false
            });

        }
        [RelayCommand]
        private async Task ShowNewItemFormAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditShopListItemPage));
        }
    }

}