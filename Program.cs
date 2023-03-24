using System.Collections.Specialized;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace task2_oop 
{
    class blood_bank
    {
        public string volunteer;
        public int age;
        public string type_of_blood;
        public char gender;
        public string city;
        public long NID;
        public int year;
        public string disease;

        public blood_bank()
        {

        }
        public blood_bank( string volunteer , string city , char gender)
        {
            this.volunteer = volunteer;
            this.city = city;
            this.gender = gender;

        }
        public blood_bank(int age , int year , long NID)
        {
            this.age = age;
            this.year = year;
            this.NID = NID;
        }
        public blood_bank( string type_of_blood , string disease )
        {
            this.type_of_blood = type_of_blood;
            this.disease= disease;
       

        }
        public blood_bank( string volunteer , int age , string type_of_blood )
        {
            this.volunteer= volunteer;
            this.age = age;
            this.type_of_blood= type_of_blood;
        }
        public void Changecity ()
        {
            Console.WriteLine("please enter ur new city");
            string newcity = Console.ReadLine();
            Console.WriteLine("ur city changed to " + newcity);
        }
        public void printNameAndAge ()
        {
            Console.WriteLine( "name {0}" , volunteer + " age {0}" ,age );
        }
        public void diseases()
        {
            Console.WriteLine(" the volunteer has " + disease);
        }
        public void change_age ()
        {
           age = age++;
            Console.WriteLine(" ur age changed to " +age );
        }
        public void printage()
        {
            Console.WriteLine("about age " +age + year + NID);
        }
        public void printdetalis()
        {
            Console.WriteLine(" detalis about this volunteer:" +"\n"  +"name: "+ volunteer+ "\n" +"age :"+ age + "\n"
     + "gender: "+ gender + "\n" + "city:" + city + "\n" + "NID: " +NID + "\n" + "disease: " +disease + "\n" + "type of blood:  "+type_of_blood );
            Console.WriteLine("------------------------------------");
        }    
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
           

            blood_bank v1 = new blood_bank();
            v1.volunteer = " ahmed";
            v1.age = 23;
            v1.year = 2000;
            v1.gender = 'm';
            v1.disease = "none";
            v1.NID = 3040506070809010;
            v1.city = "cairo";
            v1.type_of_blood = "A";

            blood_bank v2 = new blood_bank();
            v2.volunteer = " alyaa";
            v2.age = 22;
            v2.year = 2001;
            v2.gender = 'F';
            v2.disease = "none";
            v2.NID = 3040506010203040;
            v2.city = "ALEX";
            v2.type_of_blood = "B";
             
            blood_bank[] volunteer = new blood_bank[2] { v1, v2 };



            foreach (var blood_bank in volunteer)
                {
                    blood_bank.printdetalis();
                }
            
        }   
    }
}