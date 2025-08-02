namespace Views.Home;
using ViewModels.Home;
public partial class HomePrincipal : ContentPage
{
    Label titleLabel;
    private readonly HomePrincipalViewModel _viewModel;
    public HomePrincipal()
    {
         // ✅ Crear instancia del ViewModel
        _viewModel = new HomePrincipalViewModel();
        titleLabel = new Label
        {
            Text = _viewModel.Title,
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        Content = new StackLayout
        {
            Children = { titleLabel }
        };
    }
}