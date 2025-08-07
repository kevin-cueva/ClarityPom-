namespace Views.Home;
using ViewModels.Home;
public partial class HomePrincipal : ContentPage
{
    #region Graphics
    private readonly GraphicsView _grafico;
    private readonly ProgresoCircularDrawable _drawable;
    private readonly TimeSpan _duracion = TimeSpan.FromMinutes(5);
    private DateTime _inicio;
    private readonly IDispatcherTimer _timer;
    #endregion
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


        _drawable = new ProgresoCircularDrawable();
        _grafico = new GraphicsView
        {
            Drawable = _drawable,
            HeightRequest = 300,
            WidthRequest = 300
        };

        var botonIniciar = new Button
        {
            Text = "Iniciar Pomodoro",
            HorizontalOptions = LayoutOptions.Center
        };

        botonIniciar.Clicked += (s, e) => IniciarPomodoro();

        Content = new StackLayout
        {
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Spacing = 30,
            Children = { _grafico, botonIniciar }
        };

        _timer = Dispatcher.CreateTimer();
        _timer.Interval = TimeSpan.FromMilliseconds(100); // actualiza cada 100 ms, lo cual da un progreso suave.
        _timer.Tick += (s, e) => ActualizarProgreso();
    }
    

    private void IniciarPomodoro()
    {
        _inicio = DateTime.Now;
        _drawable.Progreso = 0f;
        _timer.Start();
    }

    private void ActualizarProgreso()
{
    var transcurrido = DateTime.Now - _inicio;
    var tiempoRestante = _duracion - transcurrido;

    // Evitar tiempos negativos
    if (tiempoRestante.TotalSeconds < 0)
        tiempoRestante = TimeSpan.Zero;

    var progreso = transcurrido.TotalSeconds / _duracion.TotalSeconds;
    _drawable.Progreso = (float)Math.Min(progreso, 1.0f);
    _grafico.Invalidate(); // Redibuja el gráfico

    // Formato mm:ss
    string tiempoFormateado = tiempoRestante.ToString(@"mm\:ss");
     _drawable.TiempoRestante = tiempoFormateado;
    Console.WriteLine($"⏳ Tiempo restante: {tiempoFormateado}");

    if (progreso >= 1.0)
    {
        _timer.Stop();
        Console.WriteLine("✅ ¡Tiempo completado!");
    }
}

}