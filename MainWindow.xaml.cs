using System.Collections.ObjectModel;
using System.Net.Mime;
using System.Windows;
using System.Windows.Controls;

namespace Lista;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
   public ObservableCollection< string> nomes { get; set; }= new();

    

    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;
    }

    private void btnAdicionaNome_OnClick(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tbNome.Text))
        {
            MessageBox.Show("Escreva um nome valido!");
            return;
        }
        
        nomes.Add(tbNome.Text);
    }
}