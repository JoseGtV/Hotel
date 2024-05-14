using System.Linq.Expressions;

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
            
            // Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception ("Numero de hospedes é maior que a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int numeroDeHospedes = 0;
            // Retorna a quantidade de hóspedes
            for(int hospedes = 0; hospedes < Hospedes.Count; hospedes++)
            {
                numeroDeHospedes = hospedes +1;
            }
            return numeroDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // Retorna o valor da diária
            decimal valor = Suite.ValorDiaria * DiasReservados;
            decimal desconto = 0M;

            if (DiasReservados >= 10 )
            {
                desconto = valor * 0.10M;
                valor = valor - desconto;
            }

            return valor;
        }

        public decimal ObterNumeroDeHospedes()
        {
            int numeroDeHospedes = 0;
            for(int hospedes = 0; hospedes < Hospedes.Count; hospedes++)
            {
                numeroDeHospedes = hospedes +1;
            }
            return numeroDeHospedes;
        }

        public void nomeDosHospedes()
        {
            foreach (var hospede in Hospedes)
            {
                Console.WriteLine(hospede);
            }
        }
    }
}