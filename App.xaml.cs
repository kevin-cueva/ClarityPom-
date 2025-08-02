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
	protected override void OnStart()
	{
		base.OnStart();
	}

    protected override void OnResume()
    {
        base.OnResume();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }
}