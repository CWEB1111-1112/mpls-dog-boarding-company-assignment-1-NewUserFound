using System;

namespace Assignment
{
    /**Lucas
        2/4/2021
    **/
    class Program
    {
        static void main(string[] args)
        {
            //NEED TO ADD CONVERT METHOD FOR INPUT STRINGS TO CONVERT TO THE RIGHT DATA TYPE
            int idNum;
            string idNumString;
            string dogName;
            string dogBreed;
            double dogAge;
            string weeksOfCareString;
            double weeksOfCare;
            string dogWeightString;
            int dogWeight;
            //string careFeeString;

             //INPUT DATA FOR CLIENT
            Console.WriteLine("Enter your ID Number: ");
            idNumString = Console.ReadLine();
            idNum = Convert.ToInt16(idNumString);
            Console.WriteLine("Enter your dogs name: ");
            dogName = Console.ReadLine();
            Console.WriteLine("Enter your dogs breed: ");
            dogBreed = Console.ReadLine();
            Console.WriteLine("Enter your dogs age: ");
            dogAge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of weeks you need care for: ");
            weeksOfCareString = Console.ReadLine();
            weeksOfCare = Convert.ToDouble(weeksOfCareString);
            Console.WriteLine("Enter your dogs current weight: ");
            dogWeightString = Console.ReadLine();
            dogWeight = Convert.ToInt16(dogWeightString);
            
            //VARIABLES FOR COST ACCORDING TO DOG SIZE
            int s = 55;
            int m = 75;
            int l = 105;
            int xl = 125;
            double careFee;
            //DETERMINING DOG WEIGHT VS SIZE TO FIND COST
            if(dogWeight<15){
                careFee = s*weeksOfCare;
            }
            else if(dogWeight<=30){
                careFee = m*weeksOfCare;
            }
            else if(dogWeight<=80){
                careFee = l*weeksOfCare;
            }
            else if(dogWeight>80){
                careFee = xl*weeksOfCare;
            }

            Console.WriteLine($"CLIENT ID: {idNum}\nDOGS NAME: {dogName}\nDOGS BREED: {dogBreed}\nDOGS AGE: {dogAge}\nNUMBER OF WEEKS OF CARE: {weeksOfCare}\nDOG WEIGHT: {dogWeight}\nTOTAL BILL: {careFee}");
        }
    }
}
