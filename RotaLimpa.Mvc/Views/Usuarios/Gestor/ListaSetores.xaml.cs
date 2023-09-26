namespace RotaLimpa.Mvc.Views.Usuarios.Gestor;

public partial class ListaSetores : ContentPage
{
	public ListaSetores()
	{
		InitializeComponent();
        DropDown.SelectedIndexChanged += DropDown_SelectedIndexChanged;
    }
    private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Obtenha a op��o selecionada pelo usu�rio
        string selectedOption = (string)DropDown.SelectedItem;

        // Navegue para a p�gina correspondente com base na sele��o
        if (selectedOption == "SETORES")
        {
            Navigation.PushAsync(new CadastroSetor());
        }
        else if (selectedOption == "VEICULOS")
        {
            Navigation.PushAsync(new CadastroVeiculo());
        }
        else if (selectedOption == "COLABORADORES")
        {
            Navigation.PushAsync(new CadastroColaborador());
        }
        else if (selectedOption == "MENU")
        {
            Navigation.PushAsync(new ListaSetores());
        }
    }
}