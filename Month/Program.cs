using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of the month: ");

            string monthInput = Console.ReadLine();
            monthInput = monthInput.Trim();
            string monthName = string.Empty;

            if(monthInput == "1"){
                monthName = "January";
            }
            if(monthInput == "2") {
                monthName = "February";
            }
            if(monthInput == "3")
            {
                monthName = "March";
            }
            if(monthInput == "4")
            {
                monthName = "April";
            }    
            if(monthInput == "5")
            {
                monthName = "May";
            }  
            if(monthInput == "6")
            {
                monthName = "June";
            }
            if(monthInput == "7")
            {
                monthName = "July";
            }
            if(monthInput == "8")
            {
                monthName = "August";
            }
            if(monthInput == "9")
            {
                monthName = "September";
            }
            if(monthInput == "10")
            {
                monthName = "October";
            }
            if(monthInput == "11")
            {
                monthName = "November";
            }
            if (monthInput == "12")
            {
                monthName = "December";
            }
            //else Console.WriteLine($"I'm sorry, {monthInput} is an invalid entry.");
             
            // Use the if statment to update the monthName variable based on the user's input.
            


            Console.WriteLine($"The name of the month you entered is {monthName}");

            Console.ReadLine();
        }
    }
}
