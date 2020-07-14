using System;
using System.Collections.Generic;


namespace Ms_Udemy_Course.Section6
{
    public class FacebookInteraction

    {
        public FacebookInteraction() { }

        public void PostNotification()
        {
            List<string> userNames = new List<string>();


            int flag = 0;

            while (flag == 0)
            {

                Console.WriteLine("Enter a username or type exit to end");
                string option = Console.ReadLine();

                if (option == "exit")
                {
                    Console.WriteLine("Exit");
                    flag += 1;

                }
                if (option != "exit")
                {

                    userNames.Add(option);
                    Console.WriteLine("User added -> " + option);
                }

            }

            string[] usersToArray = userNames.ToArray();
            /*foreach (string user in usersToArray)
            {
                Console.WriteLine("User in collection -> " + user);
            }*/

            switch (usersToArray.Length)
            {

                case 0:
                    break;
                case 1:
                    Console.WriteLine(usersToArray[0] + " liked your post ");
                    break;

                case 2:
                    Console.WriteLine(usersToArray[0] + " and " + usersToArray[1] + " liked you post ");
                    break;

                default:
                    int usersAmount = usersToArray.Length;
                    int otherPeople = usersAmount - 2;
                    Console.WriteLine(usersToArray[0] + " , " + usersToArray[1] + " and " + otherPeople + " more liked your post ");
                    break;
            }


        }


    }
}
