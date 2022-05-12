using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class Gift
    {
        public List<ICandy> candyList ;
        public Gift()
        {
            candyList = new List<ICandy>();
        }

        public void AddNewCandy(ICandy candy)
        {
            candyList.Add(candy);
        }

        public double GetTotalWeight()
        {
            double weight = 0;
            foreach (ICandy aPart in candyList)
            {
                weight += aPart.Weight;
            }
            return weight;
        }

        public void SortByName()
        {
            candyList.Sort(delegate (ICandy candy1, ICandy candy2)
            { return candy1.Name.CompareTo(candy2.Name); });
            ShowList();
        }

        public void SortByWeight()
        {
            candyList.Sort(delegate (ICandy candy1, ICandy candy2)
            { return candy1.Weight.CompareTo(candy2.Weight); });
            
            foreach (ICandy aPart in candyList)
            {
                Console.WriteLine(aPart + ", " + aPart.Weight);
            }
        }

        public void SortBySugarPercentage()
        {
            candyList.Sort(delegate (ICandy candy1, ICandy candy2)
            { return candy1.SugarPercentage.CompareTo(candy2.SugarPercentage); });

            foreach (ICandy aPart in candyList)
            {
                Console.WriteLine(aPart + ", " + aPart.SugarPercentage + "%");
            }
        }

        public void FindCandy(int startValue, int finishValue)
        {
            foreach (ICandy aPart in candyList)
            {
                if (aPart.SugarPercentage > startValue && aPart.SugarPercentage < finishValue)
                {
                    Console.WriteLine(aPart + ", " + aPart.SugarPercentage + "%");
                }
            }
        }

        public void ShowList()
        {
            foreach (ICandy aPart in candyList)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("------------------");
        }
    }
}
