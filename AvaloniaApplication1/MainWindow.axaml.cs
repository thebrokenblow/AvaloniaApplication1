using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click_FirstQuestion(object? sender, RoutedEventArgs e)
    {
        if (Russia.IsChecked.Value &&
            UK.IsChecked.Value &&
            France.IsChecked.Value &&
            !Germany.IsChecked.Value &&
            !Austria_Hungary.IsChecked.Value &&
            !Turkey.IsChecked.Value
            )
        {
            FirstResult.Text = "Ответ правильный";
        }
        else
        {
            FirstResult.Text = "Ответ неверный";
        }
    }


    private void Button_Click_SecondQuestion(object? sender, RoutedEventArgs e)
    {
        if (SecondAnswer988.IsChecked.Value)
        {
            SecondResult.Text = "Ответ правильный";
        }
        else
        {
            SecondResult.Text = "Ответ неверный";
        }
    }
}