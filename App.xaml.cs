namespace ClarityPom;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//MainPage = new Views.Home.HomePrincipal();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new Views.Home.HomePrincipal())
		{
			// Puedes establecer propiedades adicionales de la ventana aquí si es necesario.
			// Por ejemplo, puedes establecer el título de la ventana:
			Title = "ClarityPom"
		};
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