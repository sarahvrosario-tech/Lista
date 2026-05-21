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

    private void btnRemoverNome_OnClick(object sender, RoutedEventArgs e)
    {
        if (!nomes.Contains(tbNome.Text, StringComparer.CurrentCultureIgnoreCase)) 
        {
            MessageBox.Show("Esse nome não existe!");
            return; 
            
        }

        var nomeEncontrado = nomes.FirstOrDefault(nomePessoa =>
            nomePessoa.Equals(tbNome.Text, StringComparison.CurrentCultureIgnoreCase));
        
        nomes.Remove(nomeEncontrado);
        
        
        
    }

    private void btnEncontrarNomes_OnClick(object sender, RoutedEventArgs e)
    {
        
       if (string.IsNullOrWhiteSpace(tbNome.Text))
       {
           MessageBox.Show("Encontrar nomes");
       }
       lbNomes.SelectedItems.Clear();
       string minusculas = tbNome.Text.ToLower();

       foreach (var nome in nomes)
       {
           if (nome.Contains(minusculas, StringComparison.CurrentCultureIgnoreCase))

           {
               lbNomes.SelectedItems.Add(nome);
           }
       }

    }
}