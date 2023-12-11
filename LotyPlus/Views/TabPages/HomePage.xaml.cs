﻿using LotyPlus.Models;
using LotyPlus.ViewModels;

namespace LotyPlus.Views.TabPages;

public partial class HomePage : ContentPage
{
    RunningCouponPageViewModel viewModel ;
    public HomePage()
    {
        InitializeComponent();
        PrimaryContentView.IsVisible = true;
        ResultsContentView.IsVisible = false;
        BindingContext = viewModel = new RunningCouponPageViewModel();
    }
    void Search_Focused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {


        PrimaryContentView.IsVisible = false;
        ResultsContentView.IsVisible = true;
    }

    void Search_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)

    {
        PrimaryContentView.IsVisible = true;
        ResultsContentView.IsVisible = false;

    }

    void CancelBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Search.Unfocused += Unfocused();
       
    }

    private EventHandler<FocusEventArgs> Unfocused()
    {

        PrimaryContentView.IsVisible = true;
        ResultsContentView.IsVisible = false;
        return null;
    }
    private void ViewAll_Clicked(object sender, EventArgs e)
    {

    }
    private async void Cart_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CartPage));
    }
    private void Menu_Tapped(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
    private void OnResult_Tapped(object sender, EventArgs e)
    {
        Grid grid = sender as Grid;
        SearchCategory searchCategory = grid.BindingContext as SearchCategory;

        switch (searchCategory.Id)
        {
            case 0:
                Shell.Current.GoToAsync(nameof(ScanCodePage));
                break;
            case 1:
                Shell.Current.GoToAsync(nameof(CodeRedeemPage));
                break;
            case 2:
                Shell.Current.GoToAsync(nameof(LimitedCouponPage));
                break;
        }
    }

    private async void RewardShop_Tapped(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(ShopEntryScanPage));
        await Shell.Current.GoToAsync(nameof(RewardClaimPage));

    }
}
