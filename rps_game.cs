public static void rpsGame()
        {
            Console.Write("How many time would you play the game 3,5,7,9: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int draw = 0;
            int userWin = 0;
            int computerWin = 0;

            if (n % 2 != 0)
            {
                for (int i = 1; i <= n;i++)
                {
                    Console.Write("choose rock = 1, paper = 2, scissors = 3 : ");
                    int round = Convert.ToInt32(Console.ReadLine());

                    Random random = new Random();
                    int number = random.Next(1, 4);

                    Console.WriteLine("Computer choose is " + number);

                    if (round.Equals(number))
                    {
                        if (round == number)
                        {
                            Console.WriteLine("-----match is draw-----");
                            draw = draw + 1;
                        }
                    }
                    else
                    {
                        if (round > number)
                        {
                                if (round == 3 && number == 1)
                                {
                                    Console.WriteLine("----- computer is win -----");
                                    computerWin = computerWin + 1;
                                }
                                else if (round == 3 && number == 2)
                                {
                                    Console.WriteLine("----- user is win -----");
                                    userWin = userWin + 1;
                                }
                                else if (round == 2 && number == 1)
                                {
                                    Console.WriteLine("----- user is win -----");
                                    userWin = userWin + 1;
                                }
                                else
                                {
                                    Console.WriteLine("enter 1 & 2 & 3 only");
                                }
                        }
                        else if (round < number)
                        {
                            if (round == 1 && number == 3)
                            {
                                Console.WriteLine("----- user is win -----");
                                userWin = userWin + 1;
                            }
                            else if (round == 1 && number == 2)
                            {
                                Console.WriteLine("----- computer is win -----");
                                computerWin = computerWin + 1;
                            }
                            else if (round == 2 && number == 3)
                            {
                                Console.WriteLine("----- computer is win ------");
                                computerWin = computerWin + 1;
                            }
                            else
                            {
                                Console.WriteLine("enter 1 & 2 & 3 only");
                            }
                        }
                    }
                }
                Console.WriteLine("draw " + draw + " User Win " + userWin + " Computer Win " + computerWin);
                if (draw > userWin)
                {
                    if (draw > computerWin)
                    {
                        Console.WriteLine("########## This Match is draw ##########");
                    }
                    else if (computerWin > draw)
                    {
                        if (computerWin > userWin)
                        {
                            Console.WriteLine("########## Computer is Win This Match ##########");
                        }
                    }
                }
                else if (userWin > draw)
                {
                    if (userWin > computerWin)
                    {
                        Console.WriteLine("########## User is Win This Match ##########");
                    }
                }
            }
            else
            {
                Console.WriteLine("choose 3,5,7,9 only");
            }
        }