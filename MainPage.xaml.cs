namespace ClarityPom;

public partial class MainPage : ContentPage
{
	int count = 0;

	 Label PruebaLabel;

	public MainPage()
	{
		InitializeComponent();
		PocLabelInCode();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	private void PocLabelInCode()
	{

		PruebaLabel = new Label
		{
			Text = "Hola, soy una etiqueta creada en código",
			FontSize = 20,
			TextColor = Colors.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};
		
		MainLayout.Children.Add(PruebaLabel);
		
	}
}
