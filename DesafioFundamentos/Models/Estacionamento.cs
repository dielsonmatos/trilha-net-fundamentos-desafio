namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pedir para usuário digitar placa e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine().ToUpper());
        }

        public void RemoverVeiculo()
        {
            // Pedir para usuário digitar a placa e adicionar na armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");           
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                // Realizar cálculo para exibir valor a ser pago
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Remover a placa digitada da lista de veículos
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo de placa {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Realizar laço de repetição, exibindo os veículos estacionados
                foreach(string item in veiculos)
                {
                    Console.Write($"Placa: {item}\n");
                    
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
