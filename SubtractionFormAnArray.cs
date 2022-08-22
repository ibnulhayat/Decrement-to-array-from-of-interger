// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class SubtractionFormAnArray{

    public static void Main(string[] args){
        var digits = new int[]{1, 2, 3};
        var value = 2;
        // we are print the input array and decremnts value
        Print("Input",digits);
        Console.Write("\t decrements = "+value+"\n");
        // we are calling Decrease method for calculation
        Decrease(digits, value);
        // we are print the last output after decrease value
        Print("Output",digits);
    }
    
    // this method time complexcity is O(n)
    // space complexcity is O(1)
    // this approach is Schoolbook subtraction
    private static void Decrease(int[] digits, int decreaseValue){
        var carry = 0;
        for(var i = digits.Length-1; i >= 0; i--){
            var deVal = (decreaseValue % 10) + carry;
            if(digits[i] < deVal){
                digits[i] = (digits[i] + 10) - deVal;
                carry = 1;
            }else{
                digits[i] = digits[i] - deVal;
                carry = 0;
            }
            decreaseValue /= 10;
        }
    }
    
    // this method time complexcity is O(n)
    // space complexcity is O(n)
    // this approach is caluletor subtraction
    private static void Decrease(int[] digits, int decreaseValue){
        var num = 0;
        for(var i = 0; i < digits.Length; i++){
            num = num * 10 + digits[i];
        }
        num -= decreaseValue;
        for(var i = digits.Length-1; i >= 0; i--){
            digits[i] = num % 10;
            num /= 10;
        }
    }
    
    private static void Print(string type,int[] digits){
        Console.Write(type+" = ");
        for(int i=0; i< digits.Length; i++){
            if(i == 0)
                Console.Write("["+digits[i]+",");
            else if(i == digits.Length-1)
                Console.Write(digits[i]+"]");
            else 
                Console.Write(digits[i]+",");
        }
    }
}
