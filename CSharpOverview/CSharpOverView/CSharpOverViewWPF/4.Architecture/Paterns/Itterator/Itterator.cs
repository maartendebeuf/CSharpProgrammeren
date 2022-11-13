using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._4.Architecture.Itterator
{
    internal class Itterator
    {
        public interface Iterator
        {
            public bool hasNext();
            public Object next();
        }

        public class FruitsList
        {
            public string[] fruits = { "Banana", "Apple", "Pear", "Peach", "Blueberry" };

            public Iterator getIterator()
            {
                return new FruitIterator();
            }

            private class FruitIterator implements Iterator
            {
           int index;

                @Override
                   public boolean hasNext()
                {
                    return index < fruits.length;
                }

                @Override
                   public Object next()
                {

                    if (this.hasNext())
                    {
                        return names[index++];
                    }
                    return null;
                }
            }
        }
    }

}
