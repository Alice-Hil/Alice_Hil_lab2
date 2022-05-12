using System;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICandy chocolateC = new Chocolate();
            ICandy caramelC = new Caramel();
            ICandy jellyC = new Jelly();
            Gift gift = new Gift();

            Console.WriteLine("Add new candy: 1 - jelly, 2 - caramel, 3 - chocolate; 0 - next step");
            int status = 1;
            while (status != 0)
            {
                int candy = Convert.ToInt32(Console.ReadLine());
                switch (candy)
                {
                    case 1:
                        gift.AddNewCandy(jellyC);
                        break;
                    case 2:
                        gift.AddNewCandy(caramelC);
                        break;
                    case 3:
                        gift.AddNewCandy(chocolateC);
                        break;
                    case 0:
                        status = 0;
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }

            status = 1;
            while (status != 0)
            {
                Console.WriteLine("Choose option:\n1 - show list,\n2 - sort(name),\n3 - sort(weight),\n4 - sort(sugar),\n5 - find candy,\n6 - total weight;\n0 - exit");
                int mode = Convert.ToInt32(Console.ReadLine());
                switch (mode)
                {
                    case 1:
                        gift.ShowList();
                        break;
                    case 2:
                        gift.SortByName();
                        break;
                    case 3:
                        gift.SortByWeight();
                        break;
                    case 4:
                        gift.SortBySugarPercentage();
                        break;
                    case 5:
                        int startValue = Convert.ToInt32(Console.ReadLine());
                        int finishValue = Convert.ToInt32(Console.ReadLine());
                        gift.FindCandy(startValue, finishValue);
                        break;
                    case 6:
                        Console.WriteLine(gift.GetTotalWeight() + " g");
                        break;
                    case 0:
                        status = 0;
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
        }
    }
}
