using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using System.IO;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    private const int MaxLengthMessage = 140;
    private const string FilePath = "C:\\Users\\artem\\Desktop\\test.txt";

    public MainWindow()
    {
        InitializeComponent();

        var messageFromFile = File.ReadAllText(FilePath);
        SendMessage.Text = messageFromFile;
    }

    private void TextBox_TextChanged(object? sender, TextChangedEventArgs e)
    {
        CounterSymbols.Text = $"{TextFiled?.Text?.Length} / {MaxLengthMessage}";
    }

    private void TextBox_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            SaveMessage();
            ResetCounter();
        }
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        SaveMessage();
        ResetCounter();
    }

    private void SaveMessage()
    {
        SendMessage.Text = TextFiled.Text;
        File.WriteAllText(FilePath, TextFiled.Text);
    }

    private void ResetCounter()
    {
        TextFiled.Text = "";
        CounterSymbols.Text = $"0 / {MaxLengthMessage}";
    }
}