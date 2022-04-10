using ExampleObserverPattern.Interfaces;

namespace ExampleObserverPattern
{
    public class NovasAgenciasDeNoticias : IObserver
    {
        public string NomeAgencia { get; set; }

        public NovasAgenciasDeNoticias(string nomeAgencia)
        {
            NomeAgencia = nomeAgencia;
        }
        public void Update(ISubject subject)
        {
            if (subject is EstacaoMeriologica estacaoMeteorologica)
            {
                Console.WriteLine(string.Format("{0} reportando a temperatura {1} graus celsius", NomeAgencia, estacaoMeteorologica.Temperatura));
                Console.WriteLine();
            }
        }
    }
}
