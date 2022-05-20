using System;
using System.Reactive.Disposables;

namespace IObservableT_type
{//RxDemos.KeyInterfaces.ObservableBriefly
    public class Market : IObservable<float>
    {
        public IDisposable Subscribe(IObserver<float> observer)
        {
            // todo
            return Disposable.Empty;
        }
    }

    public class Demo : IObserver<float>
    {
        static void Main(string[] args) //MainOB
        {
            var market = new Market();
            var demo = new Demo();
            market.Subscribe(demo);
        }

        public void OnNext(float value)
        {

        }

        public void OnError(Exception error)
        {

        }

        public void OnCompleted()
        {

        }
    }
}