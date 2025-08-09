
namespace ViewModels.Home;

public class HomePrincipalViewModel(IDispatcher dispatcher)
{
      public string Title { get; set; } = "Bienvenido a ClarityPom";
      public GraphicsView _grafico;
      public ProgresoCircularDrawable _drawable;
      public DateTime _inicio;
      public IDispatcherTimer _timer;
      public TimeSpan _duracion = TimeSpan.FromMinutes(5);

    // Inicializa cualquier dato necesario para la vista.

    public void IniciarPomodoro()
      {
            _inicio = DateTime.Now;
            _drawable.Progreso = 0f;
            _timer.Start();
      }

      public void UpdateProgress(
            int fromMilliseconds = 100)
      {
            _timer = dispatcher.CreateTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(fromMilliseconds); // actualiza cada 100 ms, lo cual da un progreso suave.
            _timer.Tick += (s, e) => ActualizarProgreso();
      }

      public void ActualizarProgreso()
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



      // Puedes agregar comandos o métodos para manejar eventos de la vista.


}