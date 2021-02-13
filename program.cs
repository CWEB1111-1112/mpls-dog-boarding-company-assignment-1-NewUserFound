using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        string dogName, dogBreed;
        int idNum, dogAge, numOfWeeks, dogWeight;
        int totalBill;
        int discountedBill;
        
        discountedBill = 0;
        bool @break;
        
        @break = false;
        string checkOut;
        
        checkOut = "";
        string newCheckout;
        int totalWithDiscount;
        
        totalWithDiscount = 0;
        while (@break == false)
        {
            if (checkOut == "")
            {
                Console.WriteLine("Please enter your ID Number: ");
                idNum = (int) readValue();
                Console.WriteLine("Please enter your dogs name: ");
                dogName = Console.ReadLine();
                Console.WriteLine("Please enter your dogs breed: ");
                dogBreed = Console.ReadLine();
                Console.WriteLine("Please enter your dogs age: ");
                dogAge = (int) readValue();
                Console.WriteLine("Please enter your dogs weight: ");
                dogWeight = (int) readValue();
                Console.WriteLine("Please enter the number of weeks for care: ");
                numOfWeeks = (int) readValue();
                if (dogWeight < 15)
                {
                    totalBill = 55 * numOfWeeks;
                    Console.WriteLine("Your Fee is: " + totalBill);
                }
                else
                {
                    if (dogWeight <= 30)
                    {
                        totalBill = 75 * numOfWeeks;
                        Console.WriteLine("Your Fee is: " + totalBill);
                    }
                    else
                    {
                        if (dogWeight <= 80)
                        {
                            totalBill = 105 * numOfWeeks;
                            Console.WriteLine("Your Fee is: " + totalBill);
                        }
                        else
                        {
                            totalBill = 125 * numOfWeeks;
                            Console.WriteLine("Your Fee is: " + totalBill);
                        }
                    }
                }
                if (totalBill > 125)
                {
                    Console.WriteLine("a 2% discount will be applied to your total bill.");
                    discountedBill = Convert.ToInt32(-(totalBill * 0.02));
                    totalWithDiscount = totalBill + discountedBill;
                }
                else
                {
                    totalWithDiscount = totalBill;
                    discountedBill = 0;
                }
                newCheckout = "Bill for ID NUMBER: " + idNum + (char) 13 + "Dog: " + dogName + (char) 13 + "Breed: " + dogBreed + (char) 13 + "Age: " + dogAge + (char) 13 + "Weight: " + dogWeight + (char) 13 + "Total Bill: " + totalBill + (char) 13 + "Discount: " + discountedBill + (char) 13 + "Total after Discount: " + totalWithDiscount;
                Console.WriteLine(newCheckout);
                Console.WriteLine("Press any key to quit or press enter to continue adding orders");
                checkOut = Console.ReadLine();
            }
            else
            {
                @break = true;
            }
        }
    }
    
    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
