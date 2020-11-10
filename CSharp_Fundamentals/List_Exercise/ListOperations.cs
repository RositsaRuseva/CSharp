using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();


            string input = Console.ReadLine();
            while (input != "End")
            {

                string[] element = input.Split();

                //switch (element[0])
                //{

                    //case "Add":
                        if(element[0] == "Add")
                        {
                            int toAdd = int.Parse(element[1]);
                            list.Add(toAdd);
                        }
                        //break;
                    else if(element[0] == "Remove")
                    //case "Remove":
                        {
                            int index = int.Parse(element[1]);
                            if (index >= 0 && index < list.Count)
                            {
                                list.RemoveAt(index);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                        }
                        //break;
                    else if(element[0] == "Insert")
                    //case "Insert":
                        {
                            int number = int.Parse(element[1]);

                            int index = int.Parse(element[2]);
                            if (index >= 0 && index < list.Count)
                            {
                                list.Insert(index, number);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }


                        }
                        //break;
                    //case "Shift":
                        else if(element[0] == "Shift")
                        {
                            int count = int.Parse(element[2]);
                            string leftOrRight = element[1];

                            if (element[1] == "left")
                            {

                                for (int i = 0; i < count; i++)
                                {
                                    int firstNum = list[0];
                                    list.Add(firstNum);
                                    list.RemoveAt(0);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    int lastNum = list[list.Count - 1];
                                    list.Insert(0, lastNum);
                                    list.RemoveAt(list.Count - 1);
                                }
                            }

                        }
                        //break;
                        input = Console.ReadLine();
                }
                Console.WriteLine(string.Join(" ", list));

            }
        }
    }

