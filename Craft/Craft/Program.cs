using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Инструкция по пользованию:
//1) нажать добавить предмет, ввести тип предмета (строго из базово прописанных типов)
//2) Нажать 4 ,просмотреть инвентарь добавился ли продукт ,и запомнить его код
//3)Нажать 3, Вбить расположение элементов в верстаке, данное действие выполняется в несколько подходов, правильность проверять с помощью команды 2
//4) Нажать 5 скрафтить и роверить инвентарь
//    все работает если что могу показать 
namespace Craft
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[,] table = new Object[3, 3];
            Object two = new Object();
            List<Object> inventory = new List<Object>();
            int pos;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                     table[i, j]=two;
                }
                
            }


            do
            {
                Console.Clear();

                Console.WriteLine("Menu");
                Console.WriteLine("1. Add to inventory");
                Console.WriteLine("2. Show Craft Table");
                Console.WriteLine("3. Enter elements to table");
                Console.WriteLine("4. Show inventory");
                Console.WriteLine("5. Complete Craft");
                Console.Write("\n" + "Enter num: ");



                char ch = char.Parse(Console.ReadLine());
               
                
               
                switch (ch)
                {
                    case '1':
                        Console.Clear();
                        Object one = new Object();
                        Console.WriteLine("Choose Basic elemnts to add: Wood|Stone|Gold|Dimond|Iron|Stick");
                        Console.Write("Type(Choose only from basic elements! Spaces prohibited!): ");
                        one.Type = Console.ReadLine();
                        Console.Write("Image: ");
                        one.Image = Console.ReadLine();
                       
                        inventory.Add(one);
                        Console.ReadKey();
                        break;

                    case '2':
                        Console.Clear();
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                
                                Console.Write("{0}\t", table[i, j].Type);



                            }
                            Console.WriteLine();
                        }
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();

                        Console.WriteLine(" 0|1|2");
                        Console.WriteLine("0 | | ");
                        Console.WriteLine("1 | | ");
                        Console.WriteLine("2 | | ");
                        Console.Write("Inventory position code: ");
                        pos = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter table poition (Row: 0 1 2): ");
                        inventory[pos].Xcoord= Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter table poition (Column: 0 1 2): ");
                        inventory[pos].Ycoord = Convert.ToInt32(Console.ReadLine());
                        table[inventory[pos].Xcoord, inventory[pos].Ycoord] = inventory[pos];
                        Console.ReadKey();
                        break;
                    case '4':
                        Console.Clear();
                        foreach (Object obj in inventory)
                        {
                            Console.Write("Code: ");
                            Console.Write(inventory.IndexOf(obj));
                            Console.WriteLine();
                            Console.Write("Type: ");
                            Console.Write(obj.Type);
                            Console.WriteLine();
                            Console.Write("Image: ");
                            Console.Write(obj.Image);
                            Console.WriteLine();
                            
                           
                        }
                        Console.ReadKey();
                        break;
                    case '5':
                        Console.Clear();
                      if((table[1,1].Type=="Wood")&&(table[2, 1].Type == "Wood") && (table[0, 0].Type == "Space") && (table[0, 1].Type == "Space") && (table[0, 2].Type == "Space")
                            && (table[1, 0].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add(table[1, 1]+ table[2, 1]);
                            inventory.Add(table[1, 1] + table[2, 1]);
                            inventory.Add(table[1, 1] + table[2, 1]);
                            inventory.Add(table[1, 1] + table[2, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }

                      else if ((table[0, 0].Type == "Wood") && (table[0, 1].Type == "Wood") && (table[0, 2].Type == "Wood") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[1, 0].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1]+ table[0, 2])+(table[1, 1]+ table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[0, 2]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Stone") && (table[0, 1].Type == "Stone") && (table[0, 2].Type == "Stone") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[1, 0].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[0, 2]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[0, 2]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Iron") && (table[0, 1].Type == "Iron") && (table[0, 2].Type == "Iron") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[1, 0].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[0, 2]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[0, 2]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Gold") && (table[0, 1].Type == "Gold") && (table[0, 2].Type == "Gold") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[1, 0].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[0, 2]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[0, 2]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Diamond") && (table[0, 1].Type == "Diamond") && (table[0, 2].Type == "Diamond") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[1, 0].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[0, 2]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[0, 2]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }




                        else if ((table[0, 0].Type == "Wood") && (table[0, 1].Type == "Wood") && (table[1, 0].Type == "Wood") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[1, 0]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 0]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Stone") && (table[0, 1].Type == "Stone") && (table[1, 0].Type == "Stone") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[1, 0]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 0]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Iron") && (table[0, 1].Type == "Iron") && (table[1, 0].Type == "Iron") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[1, 0]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 0]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Gold") && (table[0, 1].Type == "Gold") && (table[1, 0].Type == "Gold") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[1, 0]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 0]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Diamond") && (table[0, 1].Type == "Diamond") && (table[1, 0].Type == "Diamond") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] + table[1, 0]) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 0]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }





                        else if ((table[0, 0].Type == "Wood") && (table[0, 1].Type == "Wood") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1]  + (table[1, 1] + table[2, 1])));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Stone") && (table[0, 1].Type == "Stone") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] ) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Iron") && (table[0, 1].Type == "Iron") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] ) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Gold") && (table[0, 1].Type == "Gold") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] ) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Diamond") && (table[0, 1].Type == "Diamond") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 0] + table[0, 1] ) + (table[1, 1] + table[2, 1]));
                            inventory.Remove(table[0, 0]);
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }





                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Wood") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add(( table[0, 1] + (table[1, 1] + table[2, 1])));
                            
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Stone") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add(( table[0, 1]) + (table[1, 1] + table[2, 1]));
                            
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Iron") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add(( table[0, 1]) + (table[1, 1] + table[2, 1]));
                            
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Gold") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add(( table[0, 1]) + (table[1, 1] + table[2, 1]));
                            
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Diamond") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stick") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add(( table[0, 1]) + (table[1, 1] + table[2, 1]));
                            
                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }




                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Wood") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Wood") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 1] + table[1, 1]) + table[2, 1]);

                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Stone") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Stone") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 1] + table[1, 1]) + table[2, 1]);

                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Iron") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Iron") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 1] + table[1, 1]) + table[2, 1]);

                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Gold") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Gold") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 1] + table[1, 1]) + table[2, 1]);

                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }
                        else if ((table[0, 0].Type == "Space") && (table[0, 1].Type == "Diamond") && (table[1, 0].Type == "Space") && (table[1, 1].Type == "Diamond") && (table[2, 1].Type == "Stick") && (table[0, 2].Type == "Space") && (table[1, 2].Type == "Space") && (table[2, 0].Type == "Space") && (table[2, 2].Type == "Space"))
                        {
                            inventory.Add((table[0, 1] + table[1, 1]) + table[2, 1]);

                            inventory.Remove(table[0, 1]);
                            inventory.Remove(table[1, 1]);
                            inventory.Remove(table[2, 1]);
                        }







                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                table[i, j] = two;
                            }
                        }
                        Console.WriteLine("Completed");
                        Console.ReadKey();
                        break;

                }
               
            } while (true);

            //Console.WriteLine(table2[0].Type);




            Console.ReadKey();
        }
    }
}
