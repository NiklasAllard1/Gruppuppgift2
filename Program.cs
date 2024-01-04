  catch (Exception ex)
            {
                Console.WriteLine($"Invalid expression. Error");
            }

            Console.WriteLine("Do you want to continue (yes/no)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
            {
                break;
            }
        }
    }