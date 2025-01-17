namespace Teste_App_Pista
{
    public partial class MainPage : TabbedPage
    {
        public string cliente { get; set; }
        public string motorista { get; set; }
        public string placa { get; set; }
        public string km { get; set; }
        public string horimetro { get; set; }
        public string bico { get; set; }
        public string valor { get; set; }
        public string litros { get; set; }
        public string produto { get; set; }
        public string observacoes { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btEnviar_Clicked(object sender, EventArgs e)
        {
            string cliente = entryCliente.Text;
            string motorista = entryMotorista.Text;
            string placa = entryPlaca.Text;
            string km = entryKm.Text;
            string horimetro = entryHorimetro.Text;
            string bico = entryBico.Text;
            string valor = entryReais.Text;
            string litros = entryLitros.Text;
            string produto = entryProduto.Text;
            string observacoes = entryObservacoes.Text;



            await DisplayAlert("Dados Coletados",
                    $"Cliente: {cliente}\n" +
                    $"Motorista: {motorista}\n" +
                    $"Placa: {placa}\n" +
                    $"KM: {km}\n" +
                    $"Horímetro: {horimetro}\n" +
                    $"Bico: {bico}\n" +
                    $"Valor: {valor}\n" +
                    $"Litros: {litros}\n" +
                    $"Produto: {produto}\n" +
                    $"Observações: {observacoes}",
                    "OK");

            LimparCampos();

        }

        private void LimparCampos()
        {
            entryCliente.Text = string.Empty;
            entryMotorista.Text = string.Empty;
            entryPlaca.Text = string.Empty;
            entryKm.Text = string.Empty;
            entryHorimetro.Text = string.Empty;
            entryBico.Text = string.Empty;
            entryReais.Text = string.Empty;
            entryLitros.Text = string.Empty;
            entryProduto.Text = string.Empty;
            entryObservacoes.Text = string.Empty;
        }
    }

}
