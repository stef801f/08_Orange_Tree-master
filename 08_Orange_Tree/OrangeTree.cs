using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        private int v1;
        private int v2;

        public OrangeTree(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;

        }

        // Age
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
                
        }

        // Height
        private int height = 4;
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        // NumeOranges
        private int numOranges = 0;
        public int NumOranges
        {
            get
            {
                return numOranges;
            }
            set
            {
                numOranges = value;
            }
                
        }

        // Tree Alive
        private bool treealive;
        public bool TreeAlive
        {
            get
            {
                return treealive;
            }
            set
            {
                treealive = value;
            }
        }

        // Oranges Eaten
        private int orangeeaten = 0;
        public int OrangesEaten
        {
            get
            {
                return orangeeaten;
            }
            set
            {
                orangeeaten = value;
            }
                
        }

        public void OneYearPasses()
        {
            Age += 1;
            Height = height * 2;

            if (Age >= 2)
            {
                NumOranges += 5;
            }

        }

        public void EatOrange(int v)
        {
            if ((v == 1) && (Age == 2))
            {
                OrangesEaten = v;
            }
            else if (v == 3)
            {
                OrangesEaten = v + 1;
            }

            else if (v == 1)
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }

        }
    }
}