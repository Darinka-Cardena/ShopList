using ShopList.Maui.View;

namespace ShopList.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Registra las rutas de navegación de las páginas de la aplicación
            Routing.RegisterRoute(nameof(EditShopListItemPage), typeof(EditShopListItemPage));
        }
    }
}
