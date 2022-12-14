namespace Rekenen
{
    public class Rekenen
    {
        public Single Som(Single x, Single y)
        {
            return x + y;
        }
        public Single Verschil(Single x, Single y)
        {

            return x - y;
        }
        public Single Product(Single x, Single y)
        {

            return x * y;
        }
        public Single Delen(Single x, Single y)
        {
            if (y==0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
    }
}
