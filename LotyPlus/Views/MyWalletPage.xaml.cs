namespace LotyPlus.Views;

public partial class MyWalletPage : ContentPage
{
	public MyWalletPage()
	{
		InitializeComponent();
	}
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
    {

    }

    private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {

    }

    private void BorderlessEntry_Focused(object sender, FocusEventArgs e)
    {
        try
        {
            Entry entry = (Entry)sender;
            StackLayout stackLayout = entry.Parent as StackLayout;
            Frame frame = stackLayout.Parent as Frame;
            frame.BorderColor = (Color)Application.Current.Resources["SecondoryColor"];

            if (entry.ClassId == "4")
            {
                //datePicker.Focus();
            }
            if (entry.ClassId == "5")
            {
                typePicker.Focus();
            }
        }
        catch (Exception ex)
        {

        }
    }

    private void BorderlessEntry_Unfocused(object sender, FocusEventArgs e)
    {
        Entry entry = (Entry)sender;
        StackLayout stackLayout = entry.Parent as StackLayout;
        Frame frame = stackLayout.Parent as Frame;
        frame.BorderColor = (Color)Application.Current.Resources["GreyColor"];

        if (entry.ClassId == "4")
        {
            //datePicker.Unfocus();
        }
        if (entry.ClassId == "5")
        {
            typePickerEntry.Unfocus();
        }
    }

    private void TypePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        typePickerEntry.Text = typePicker.SelectedItem.ToString();
        typePicker.Unfocus();
    }

    private void AddCart_Tapped(object sender, EventArgs e)
    {

    }
}
