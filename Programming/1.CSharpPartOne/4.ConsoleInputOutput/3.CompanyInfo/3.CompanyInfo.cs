using System;



    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter company name :");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter company addres :");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Enter company phone:");
            int companyPhone = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter company fax :");
            int companyFax = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter company website :");
            string website = Console.ReadLine();
            Console.WriteLine("Enter manager first name :");
            string managerNameFirst = Console.ReadLine();
            Console.WriteLine("Enter manager last name :");
            string managerNameLast = Console.ReadLine();
            Console.WriteLine("Enter manager age : ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter manager phone : ");
            int managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine("The company is {0}, its address is {1},"+
                     "its phone is {2}, its fax is {3}, its website is {4}",companyName,companyAddress,companyPhone,companyFax,website);
            Console.WriteLine("Company's manager name is {0} {1} . He is {2} years old ."+
                    " His phone is {3}",managerNameFirst,managerNameLast,managerAge,managerPhone);



        }
    }

