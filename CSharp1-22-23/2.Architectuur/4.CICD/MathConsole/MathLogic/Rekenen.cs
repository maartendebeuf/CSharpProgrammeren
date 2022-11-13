namespace MathLogic
{
    public class Rekenen
    {
        public Rekenen() { }

        public int som(int a, int b)
        {
            return a + b;
        }

        public int verschil(int a, int b)
        {
            if (a < b) throw new ArgumentException("a moet groter zijn dan b");
            return a - b;
        }

        public int delen(int teller, int noemer)
        {
            if (noemer == 0) throw new ArgumentException("Delen door nul gaat niet!");
            return teller / noemer;
        }

        public int product(int a, int b)
        {
            return a * b;
        }
    }
}