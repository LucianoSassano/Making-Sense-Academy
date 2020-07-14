
namespace Ms_Udemy_Course.Section5
{
    public class rangeCounter
    {
        public rangeCounter() { }

        public int count()
        {
            int acum = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {

                    acum++;
                }
            }

            return acum;
        }
    }
}

