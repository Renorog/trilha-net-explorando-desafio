namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           
            if (Suite.Capacidade >= hospedes.Count )
            {
                Hospedes = hospedes;
            }
            else
            {
                   Console.WriteLine("Número de hóspedes excede a capacidade");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            int numeroDeHospedes = Hospedes.Count;
            return numeroDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            decimal valor = DiasReservados * (Suite.ValorDiaria);

           
            if (DiasReservados >= 10)
            {
               return valor = (valor - valor / 10);
            }

            return valor;
        }
    }
}