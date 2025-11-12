using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlayground.Views;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}