namespace LotyPlus.Views;

public partial class EditProfilePage : ContentPage
{
    string PhotoPath;

    public EditProfilePage()
    {
        InitializeComponent();
    }

    private void Back_Tapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
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
                datePicker.Focus();
            }
            if (entry.ClassId == "5")
            {
                genderPicker.Focus();
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
            datePicker.Unfocus();
        }
        if (entry.ClassId == "5")
        {
            genderPicker.Unfocus();
        }
    }

    private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        datePickerEntry.Text = datePicker.Date.ToString("dd-MM-yyyy");
        datePickerEntry.Unfocus();
    }

    private void genderPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        genderPickerEntry.Text = genderPicker.SelectedItem.ToString();
        genderPickerEntry.Unfocus();
    }

    private void Update_Tapped(object sender, EventArgs e)
    {

    }

    private async void EditPicture_Tapped(object sender, EventArgs e)
    {
        string action = await DisplayActionSheet("Upload Profile Photo", "Cancel", null, "Take a photo", "Select from gallery");
        if (action == "Take a photo")
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();


                if (photo == null)
                {
                    PhotoPath = null;
                    return;
                }
                // save the file into local storage
                var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
                using (var stream = await photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(newFile))
                    await stream.CopyToAsync(newStream);

                PhotoPath = newFile;

                ProfilePicture.Source = PhotoPath;
                EditBtn.IsVisible = true;

                //Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");

            }
            catch (Exception ex)
            {

            }
        }
        else if (action == "Select from gallery")
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();


                if (photo == null)
                {
                    PhotoPath = null;
                    return;
                }
                // save the file into local storage
                var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
                using (var stream = await photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(newFile))
                    await stream.CopyToAsync(newStream);

                PhotoPath = newFile;

                ProfilePicture.Source = PhotoPath;
                EditBtn.IsVisible = true;
                //Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");


            }
            catch (Exception ex)
            {

            }
        }
    }
}
