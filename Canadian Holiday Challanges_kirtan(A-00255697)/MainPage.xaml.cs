public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new HolidayViewModel(); // Replace with your ViewModel instance.
    }
}