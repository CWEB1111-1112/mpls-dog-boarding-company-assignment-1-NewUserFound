using System;

namespace Assignment
{
    /**Lucas
        2/4/2021
    **/
    class Program
    {
        static void Main(string[] args)
        {
             //INPUT DATA FOR CLIENT
            Console.WriteLine("Enter your ID Number: ");
            var idNum = Console.ReadLine();
            Console.WriteLine("Enter your dogs name: ");
            var dogName = Console.ReadLine();
            Console.WriteLine("Enter your dogs breed: ");
            var dogBreed = Console.ReadLine();
            Console.WriteLine("Enter your dogs age: ");
            var dogAge = Console.ReadLine();
            Console.WriteLine("Enter the number of weeks you need care for: ");
            var weeksOfCare = Console.ReadLine();
            Console.WriteLine("Enter your dogs current weight: ");
            var dogWeight = Console.ReadLine();

            //VARIABLES FOR COST ACCORDING TO DOG SIZE
            var cost = x;
            int s = 55;
            int m = 75;
            int l = 105;
            int xl = 125;

            //DETERMINING DOG WEIGHT VS SIZE TO FIND COST
            if(dogWeight<15){
                cost = s;
            }
            else if(15<dogWeight<=30){
                cost = m;
            }
            else if(31<dogWeight<=80){
                cost = l;
            }
            else if(dogWeight>80){
                cost = xl;
            }
            
            //FINDING DAYCARE FEE
            
        }
    }
}
