using System;

namespace _02.Company_Info
{
    class Program
    {
        static void Main()
        {
            //input mainly text 
            string cName = Console.ReadLine();
            string cAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string mFirstName = Console.ReadLine();
            string mLastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string mPhone = Console.ReadLine();


            //output 
            Console.WriteLine(cName);
            Console.WriteLine("Address: " + cAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber.Length == 0 ? "(no fax)" : faxNumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", mFirstName, mLastName, age, mPhone);
            
        }
    }
}
