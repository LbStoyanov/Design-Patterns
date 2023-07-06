namespace Interface_Segregation_Principle
{
    public class Document
    {

    }
    public interface IMachine
    {
        void Print(Document document);
        void Scan(Document document);
        void Fax(Document document);
        
    }
    public class OldFashionPrinter
    {
        //This printer must not implement actions, which cannot execute!!!!!

    }


    //So instead of having one big interface, we can create a few smaller(People do not pay for something which they dont use!!!)

    public interface IPrinter
    {
        void Print(Document document);
    }

    public interface IScanner
    {
        void Scann(Document document);
    }

    //With smaller and consistent interfaces we will maintain our code without pointless lines of code
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            throw new NotImplementedException();
        }

        public void Scann(Document document)
        {
            throw new NotImplementedException();
        }
    }

    //All good here, because this fashion printer machine can do every described in the IMachine interface action, BUT If we have old fasion
    //scanner from 1989 which can only print????
    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document document)
        {
            throw new NotImplementedException();
        }

        public void Print(Document document)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document document)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}