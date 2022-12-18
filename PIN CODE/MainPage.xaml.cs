

namespace ДЗ5;

public partial class MainPage : ContentPage
{
	private string _password = "123";
	private char _action = 'V';
    public MainPage()
	{
		InitializeComponent();
	}

    private void DigitClicked(object sender, EventArgs e)
    {
        if (DisplayLabel.Text != "Correct Password")
        {
            DisplayLabel.Text += (sender as Button).Text;
        }
       
    }

	private void InputClicked(object sender, EventArgs e)
	{
        if (DisplayLabel.Text != "Correct Password")
        {
            _action = Convert.ToChar((sender as Button).Text);
            if (_action == 'V' && DisplayLabel.Text == _password)
            {
                DisplayLabel.Text = "Correct Password";

            }
            else
            {
                DisplayLabel.Text = "";
            }
        }
        
	}
}

