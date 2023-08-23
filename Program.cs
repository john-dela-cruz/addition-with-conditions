using System;

class IntegerSum{
    public static void Main(string[] args){
        int num1;
        int num2;
        int sum;
        int finalSum;

        Console.Write("Enter 1st Integer: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd Integer: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 == num2){ // Multiply the Sum by 3 if the integers are equal
            sum = num1 + num2;
            finalSum = sum * 3;

            Console.Write("The sum is equal to " + finalSum);
        }
        else{ // Prints the Sum of two integers that are not equal
            sum = num1 + num2;

            Console.Write("The sum is equal to " + sum);
        }
    }
}