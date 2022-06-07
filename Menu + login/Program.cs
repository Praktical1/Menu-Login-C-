Boolean menu = true;
List<string> loginInfo = new List<string>();
Boolean loggedIn = false;
while (menu)
{
    Console.ForegroundColor = ConsoleColor.Gray;            //Resets console text colour
    Console.WriteLine("Welcome to the Menu\n");
    Console.Write(              //Options
    "|1 Register an account\n" +
    "|2 Log into account\n" +
    "|3 Dwelve into the abyss\n" +
    "|4 Discover the secrets of the world\n" +
    "|5 Exit back to reality\n");
    Boolean choice=false;       //Responsible ensuring a menu option has been selected
    while (!choice)
    {
        Console.WriteLine("Please select either option 1, 2, 3, 4 or 5");
        String? selection = Console.ReadLine();
        Console.WriteLine("Option " + selection + " selected\n");
        if (selection != null)
        {
            choice = true;
        }
        switch (selection)      //Switch statement for menu
        {
            case "1":
                Console.WriteLine("You have selected to register an account");
                Boolean found = true;
                while (found)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    found = false;
                    Console.Write("New Username:");
                    String? newUser = Console.ReadLine();
                    Console.Write("New Password:");
                    String? newPass = Console.ReadLine();
                    Console.Write("Confirm Password:");
                    String? passConfirm = Console.ReadLine();
                    if (newUser != null && newPass != null)     //Confirms username and password is not null
                    {
                        if (newPass.Equals(passConfirm))
                        {
                            for (int i = 0; i < loginInfo.Count; i += 2)
                            {
                                if (loginInfo[i].Equals(newUser))
                                {
                                    found = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please try a different username");
                                }
                            }
                            if (!found)
                            {
                                loginInfo.Add(newUser);         //adds user to login list
                                loginInfo.Add(newPass);
                            }
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The two passwords do not match");
                            found = true;
                        }
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Make sure you have entered a username and password");
                        found = true;
                    }
                }
                
                break;
            case "2":
                Console.WriteLine("You have selected to log into account");
                if (loginInfo.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please create an account first\n");
                    break;
                } else
                {
                    while (!loggedIn)
                    {
                        Console.Write("Username:");
                        String? user = Console.ReadLine();
                        Console.Write("Password:");
                        String? pass = Console.ReadLine();
                        for (int i = 0; i < loginInfo.Count; i += 2)
                        {
                            if (loginInfo[i].Equals(user))
                            {
                                if (pass.Equals(loginInfo[i + 1]))
                                {
                                    loggedIn = true;
                                }
                            }
                        }
                    }
                    if (loggedIn)
                    {
                        Console.WriteLine("Awesome you logged in now");
                    } else { Console.WriteLine("Wrong credentials"); }
                    break;
                }
                
            case "3":
                Console.WriteLine("You have selected to dwelve into the abyss");
                int delay = 2000;
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 10; i++)
                {
                    delay -= 150;
                    Console.WriteLine("...");
                    Thread.Sleep(delay);                //Delays chat
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You found nothing\n");
                break;
            case "4":
                Console.WriteLine("You have selected to discover the secrets of the world\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lack sufficient privileges\n");
                break;
            case "5":
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You have selected to exit back to reality\n");
                menu = false;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This option is invalid. Hit ENTER to acknowledge and return to the menu.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadLine();
                choice = false;
                break;
        }
    }
    
}