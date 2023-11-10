namespace zwierzeta;

public partial class MainPage : ContentPage
{
	int pieslicznik = 0;
    int kotlicznik = 0;
    int krowalicznik = 0;

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if(guzik.IsToggled == true)
		{
			if (TopButton.IsChecked == true)
			{
				pieslicznik++;
			}
			else if (MiddleButton.IsChecked == true)
			{
				kotlicznik++;
			}
			else if(DownButton.IsChecked == true)
			{
				krowalicznik++;
			}
		}
		else
		{
            if (TopButton.IsChecked == true)
            {
                pieslicznik--;
            }
            else if (MiddleButton.IsChecked == true)
            {
                kotlicznik--;
            }
            else if (DownButton.IsChecked == true)

            {
                krowalicznik--;
            }
        }


		if(pieslicznik >= 0 && kotlicznik >= 0 && krowalicznik >= 0)
		{
		pies.Text = "PIES: " + pieslicznik;
		kot.Text = "KOT: " + kotlicznik;
		krowa.Text = "KROWA: " + krowalicznik;
		}
		
    }
}

