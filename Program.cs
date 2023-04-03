using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_struct_class
{
    
    class Program
    {
        enum Products
        {
            Drinks,
            Food,
            Chemicals,
        }
        static void Main(string[] args)
        {
            Article[] Food = new Article[3];
            Article[] Drinks = new Article[3];
            Article[] Chem = new Article[3];
            Food[0].Prod_name = "Apple";
            Food[1].Prod_name = "Meat";
            Food[2].Prod_name = "Milk";
            Drinks[0].Prod_name = "CocaCola";
            Drinks[1].Prod_name = "Fanta";
            Drinks[2].Prod_name = "Mineral Water";
            for (int i = 0; i < 3; i++)
            {
                Food[i].Prod_num = 321 + i;
                Food[i].Prod_price = 3 + (decimal)(i * 1.05);
                Drinks[i].Prod_num = 421 + i;
                Drinks[i].Prod_price = 1 + (decimal)(i * 1.15);

            }
            Console.WriteLine("Chouse Task (...):");
            int x;
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("Welcome to market have 3 lines\n1-Food\n2-Drinks\n3-Chemicals\nchouse:");
                        int y = int.Parse(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                {
                                    Products Prd = Products.Food;
                                    if (Prd == Products.Food)
                                    {
                                        Console.WriteLine($"Welcom to { Prd}line");
                                        for (int i = 0; i < 3; i++)
                                        {
                                            Console.WriteLine(Food[i].ToString());
                                            Console.WriteLine("__________");
                                        }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Products Prd = Products.Drinks;
                                    if (Prd == Products.Drinks)
                                    {
                                        Console.WriteLine($"Welcom to {Prd}  line");
                                        for (int i = 0; i < 3; i++)
                                        {
                                            Console.WriteLine(Drinks[i].ToString());
                                            Console.WriteLine("__________");
                                        }
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    Products Prd = Products.Chemicals;
                                    if (Prd == Products.Chemicals)
                                    {
                                        Console.WriteLine($"Welcom to {Prd}  line");
                                        for (int i = 0; i < 3; i++)
                                        {
                                            Console.WriteLine(Chem[i].ToString());
                                            Console.WriteLine("__________");
                                        }
                                    }
                                    break;
                                }
                            default:
                            break;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Students in some collage inf:");
                        Student A = new Student("Ivan","Ivanov","Ivanovich",18);
                        Student B = new Student("Sidr","Sidorov","Sidorovich",19);
                        for(int i=0;i<3;i++)
                        {
                            A.Set_marks(i);
                            B.Set_marks(i);
                            A.Get_midl_Mark(i);
                            B.Get_midl_Mark(i);
                        }
                        Console.WriteLine(A.ToString());
                        Console.WriteLine("_________");
                        Console.WriteLine(B.ToString());
                        break;
                    }
                case 3:
                    {
                        Some_Figure A = new Some_Figure();
                        A.Sum_all_Perimetr();
                        A.Sum_all_Square();
                        A.Show_All();
                        Console.WriteLine(A.ToString());
                        break;
                    }
                case 4:
                    {
                        Point a = new Point(10, 20);
                        Point b = new Point(22, 11);
                        Console.WriteLine("Point A: "+a.ToString()+"\nPoint B: "+b.ToString());
                        if (a > b)
                        {
                            Console.WriteLine("a>b");
                        }
                        if (a < b)
                        {
                            Console.WriteLine("a<b");
                        }
                        break;
                    }
                default:
                    break;
            }

        }

    }
}
