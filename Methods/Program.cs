namespace Methods
{
    class Program
    {
        //Method Non-Recursive

        //============================Non-Recursive Without Argument==================================================================
        static void stars()
        {
            System.Console.WriteLine("**********");
            System.Console.WriteLine();
        }

        static void dollars()
        {
            System.Console.WriteLine("$$$$$$");
            System.Console.WriteLine();
        }

        static void showstars(int x)
        {
            for (int i = 0; i < x; i++)
            {
                System.Console.Write("*");
                System.Console.Write(" ");

            }
        }

        //============================Non-Recursive With Argument==================================================================

        static void pyramidstarland(int x)
        {

            for (int i1 = 1; i1 <= x; i1++)
            {
                System.Console.WriteLine();

                for (int y1 = 1; y1 <= i1; y1++)
                {

                    System.Console.Write(" * ");

                }

            }

            for (int i2 = x - 1; i2 >= 1; i2--)
            {
                System.Console.WriteLine();

                for (int y2 = i2; y2 >= 1; y2--)
                {

                    System.Console.Write(" * ");

                }

            }

        }

        static void pyramidstarport(int x)
        {
            int Index;
            Index = 0;

            for (int i = x - 1; i >= 0; i--)
            {
                Index++;

                System.Console.WriteLine();

                for (int y = i; y >= 0; y--)
                {

                    System.Console.Write("  ");

                }

                for (int z = 1; z <= Index; z++)
                {

                    System.Console.Write(" *");

                }

                for (int w = Index - 1; w >= 1; w--)
                {

                    System.Console.Write(" *");

                }

            }
        }

        //========================================================================================================================

        //Mothod Recursive

        //============================Recursive Without Argument==================================================================
        static int sum()
        {

            int Result = 50 + 40;

            return Result;
        }

        static int pow()
        {
            int ResultPow = 1;

            for (int i = 1; i < 50; i++)
            {
                ResultPow = i * i;
            }

            return ResultPow;
        }


        //======================================Recursive With Argument==================================================================
        static double squarte(int Number)
        {
            double ResultSqurte=0;
            int Power, Index;

            for (int i = 1; i <= Number; i++)
            {
                Power = i * i;

                if (Power>Number)
                {
                    Index = i;
                    Power = (i - 1) * (i - 1);

                    ResultSqurte = Index + (Number - Power) / (2 * Index);
                    break;                  

                }

                else if(Power==Number)
                {
                    Index = i;
                    Power = i * i;

                    ResultSqurte = Index + (Number - Power) / (2 * Index);
                    break;
                }
            }
            
            return ResultSqurte;            
        }

        static int factorial(int Number)
        {
            int ResultFact = 1;

            for (int i = 1; i <= Number; i++)
            {
                ResultFact = ResultFact * i;
            }

            return ResultFact;
        }



        //========================================================================================================================

        static void Main(string[] args)
        {
            int SelectMet, SelectArg, Number;

            string NumberMet, NumberArg, SelectNumber;

            System.Console.WriteLine("  -----------------------------------------------------------------------");
            System.Console.WriteLine(" |-------------------------------Welcome---------------------------------|");
            System.Console.WriteLine(" |--------------------------Please Select Method-------------------------|");
            System.Console.WriteLine("  -----------------------------------------------------------------------");

            System.Console.WriteLine();
            do
            {

                System.Console.WriteLine
                    ("Non-Recursive[1], Recursive[2], For exit type [Q or q]");

                System.Console.WriteLine();

                System.Console.Write
                    ("Please select method [1-2]: ");

                NumberMet = System.Console.ReadLine();

                System.Console.WriteLine();

                if (NumberMet == "1")
                {

                    System.Console.Clear();

                    SelectMet = int.Parse(NumberMet);

                    System.Console.WriteLine();

                    System.Console.WriteLine
                        ("*<-You are in the non-recursive method. Please specify the method input type->*");

                    System.Console.WriteLine();

                    do
                    {

                        System.Console.Write
                                    ("Non-Recursice with argument[1], Non-Recursive without argument[2], For exit type[Q or q]: ");

                        NumberArg = System.Console.ReadLine();

                        System.Console.WriteLine();

                        if (NumberArg == "1")
                        {

                            System.Console.Clear();

                            System.Console.WriteLine();

                            System.Console.WriteLine("-------------Non-Recursive With Argument-------------");

                            System.Console.WriteLine();

                            int ShowResult;

                            System.Console.WriteLine();
                            System.Console.WriteLine();

                            do
                            {

                                System.Console.WriteLine();
                                System.Console.WriteLine();

                                System.Console.Write
                                    ("Please specify the type of pyramid, Landscape[1] - Portrait[2] - Show Stars[3]: ");

                                SelectNumber = System.Console.ReadLine();

                                System.Console.WriteLine();
                                System.Console.WriteLine();

                                if (SelectNumber == "1")
                                {
                                    System.Console.Write("Please enter a value: ");

                                    ShowResult = int.Parse(System.Console.ReadLine());

                                    System.Console.WriteLine();
                                    System.Console.WriteLine();

                                    pyramidstarland(ShowResult);
                                }

                                else if (SelectNumber == "2")
                                {

                                    System.Console.Write("Please enter a value: ");

                                    ShowResult = int.Parse(System.Console.ReadLine());

                                    System.Console.WriteLine();
                                    System.Console.WriteLine();

                                    pyramidstarport(ShowResult);
                                }

                                else if (SelectNumber == "3")
                                {

                                    System.Console.Write("Please enter a value: ");

                                    ShowResult = int.Parse(System.Console.ReadLine());

                                    System.Console.WriteLine();
                                    System.Console.WriteLine();

                                    showstars(ShowResult);
                                }

                                else if (SelectNumber == "Q" || SelectNumber == "q")
                                {

                                    break;

                                }

                                else
                                {
                                    System.Console.Write("Please select between the items specified.");
                                    System.Console.Clear();
                                }
                            } while (true);

                            System.Console.WriteLine();
                            System.Console.WriteLine();

                        }
                        else if (NumberArg == "2")
                        {
                            System.Console.Clear();

                            System.Console.WriteLine();

                            System.Console.WriteLine("-------------Non-Recursive Without Argument-------------");

                            System.Console.WriteLine();

                            stars();

                            System.Console.WriteLine();

                            dollars();

                            System.Console.WriteLine();

                        }

                        else if (NumberArg == "Q" || NumberArg == "q")
                        {
                            break;
                        }

                        else
                        {
                            System.Console.Clear();
                            
                            System.Console.WriteLine("Please select between the items specified.");                            
                        }

                    } while (true);
                }

                else if (NumberMet == "2")
                {

                    System.Console.Clear();

                    System.Console.WriteLine();

                    SelectMet = int.Parse(NumberMet);

                    System.Console.WriteLine();

                    System.Console.WriteLine
                        ("*<-You are in the recursive method. Please specify the method input type->*");

                    System.Console.WriteLine();

                    do
                    {

                        System.Console.WriteLine();

                        System.Console.WriteLine
                            ("Please Select argument. Wiht Argument[1], Without Armgument[2], Fot exit type[Q or q]: ");

                        NumberArg = System.Console.ReadLine();

                        if (NumberArg == "1")
                        {
                            System.Console.Clear();

                            System.Console.WriteLine();

                            System.Console.WriteLine
                                ("                -------------Recursive With Argument-------------");

                            System.Console.WriteLine();

                            do
                            {
                                
                                System.Console.Write("Please select the sample. Squarte[1] - Factorial[2] - Quit[Q or q]: ");

                                NumberArg = System.Console.ReadLine();

                                System.Console.WriteLine();

                                if (NumberArg=="1")
                                {
                                    System.Console.Clear();
                                    
                                    System.Console.WriteLine
                                        ("         ----------------Show Squarte Of Number----------------");

                                    System.Console.WriteLine();

                                    System.Console.Write("Pleaes enter number for SQUARTE: ");
                                    Number =int.Parse( System.Console.ReadLine());

                                    System.Console.WriteLine();

                                    System.Console.WriteLine("Squarte this number is: "+squarte(Number));
                                }

                                else if (NumberArg=="2")
                                {
                                    System.Console.Clear();

                                    System.Console.WriteLine
                                        ("         ----------------Show Factorial Of Number----------------");

                                    System.Console.WriteLine();

                                    System.Console.Write("Pleaes enter number for FACTORIAL: ");
                                    Number = int.Parse(System.Console.ReadLine());

                                    System.Console.WriteLine();

                                    System.Console.WriteLine("Factorial this number is: " + factorial(Number));
                                }

                                else if (NumberArg=="Q"||NumberArg=="q")
                                {
                                    break;
                                }

                                else
                                {
                                    System.Console.Clear();
                                    System.Console.WriteLine("Please select between the items specified.");
                                }


                            } while (true);



                        }

                        else if (NumberArg == "2")
                        {

                            System.Console.Clear();

                            System.Console.WriteLine();

                            System.Console.WriteLine
                                ("                   -------------Recursive Without Argument-------------");

                            System.Console.WriteLine();

                            System.Console.WriteLine("Result SUM: {0}", sum());

                            System.Console.WriteLine();
                            System.Console.WriteLine();

                            System.Console.WriteLine("Result POWER: {0}", pow());


                        }

                        else if (NumberArg == "Q" || NumberArg == "q")
                        {
                            break;
                        }

                        else
                        {
                            System.Console.Clear();

                            System.Console.WriteLine("Please select between the items specified. ");                            
                        }

                    } while (true);


                }

                else if (NumberMet == "Q" || NumberMet == "q")
                {
                    break;
                }

                else
                {

                    System.Console.WriteLine("Please select between the items specified.");
                    System.Console.WriteLine();

                }

            } while (true);

            System.Console.WriteLine("Please [ENTER] to exit...!");
            System.Console.ReadLine();
        }
    }
}
