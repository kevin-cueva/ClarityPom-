namespace ClarityPom;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}

	//Eventos opcionales para implementar en el ciclo de vida de la aplicación. La ventana creada anteriormente 
	//también incluye eventos de ciclo de vida que permiten realizar un seguimiento del ciclo de vida de la ventana.

	/// <summary>
	/// Inicia la aplicación. Este método se llama cuando la aplicación se inicia por primera vez.
	/// Aquí puedes inicializar recursos, configurar servicios, etc.
	/// </summary>
	protected override void OnStart()
	{
		base.OnStart();
	}

	/// <summary>
	/// Se llama cuando la app vuelve a primer plano. Aquí puedes pausar tareas, liberar recursos, etc.
	/// </summary>
	protected override void OnResume()
	{
		base.OnResume();
	}

	/// <summary>
	/// Se llama cuando la app entra en segundo plano. Aquí puedes guardar el estado de la aplicación, liberar recursos, etc.
	/// Si la aplicación se cierra, este método no se llamará.
	/// </summary>
	protected override void OnSleep()
	{
		base.OnSleep();
	}
}