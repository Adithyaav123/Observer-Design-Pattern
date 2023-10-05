namespace ObserverDeignPatternPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            ObserverA observerA = new ObserverA();
            ObserverB observerB = new ObserverB();
            subject.Attach(observerA);
            subject.Attach(observerB);
            subject.SetMessage("Welcome observers!");
            Console.WriteLine("========================================================");
            subject.Detach(observerA);
            subject.SetMessage("Goodbye, observerA!");

            Console.ReadLine();
        }
    }
}
//Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically"