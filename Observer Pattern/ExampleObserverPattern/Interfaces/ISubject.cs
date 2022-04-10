using System;

namespace ExampleObserverPattern.Interfaces
{
    public interface ISubject
    {
        void Anexar(IObserver observable);
        void Notificar();
    }
}
