using ExampleObserverPattern.Interfaces;

namespace ExampleObserverPattern
{
    public class EstacaoMeriologica : ISubject
    {
        private List<IObserver> observers;

        private float _temperatura;
        public float Temperatura
        {
            get { return _temperatura; }
            set { _temperatura = value; Notificar(); }
        }

        public EstacaoMeriologica()
        {
            this.observers = new List<IObserver>();
        }

        public void Anexar(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notificar()
        {
            observers.ForEach(observer => observer.Update(this));
        }
    }
}
