namespace Views.Home;
using ViewModels.Home;
public partial class HomePrincipal : ContentPage
{

    private readonly HomePrincipalViewModel _viewModel;
    public HomePrincipal()
    {
        _viewModel = new HomePrincipalViewModel(Dispatcher);
        _viewModel!._drawable = new ProgresoCircularDrawable();
        _viewModel._grafico = new GraphicsView
        {
            Drawable = _viewModel._drawable,
            HeightRequest = 300,
            WidthRequest = 300
        };

        var botonIniciar = new Button
        {
            Text = "Iniciar Pomodoro",
            HorizontalOptions = LayoutOptions.Center
        };

        botonIniciar.Clicked += (s, e) => _viewModel.IniciarPomodoro();

        Content = new StackLayout
        {
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Spacing = 30,
            Children = { _viewModel._grafico, botonIniciar }
        };
         
         _viewModel.UpdateProgress();
    }

}