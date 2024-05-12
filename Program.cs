using System.Text;
using System;

namespace net8._0Testing;

class Program
{
    static void Main(string[] args)
    {

        bool understands = false;

        while (!understands) //short for while understands == false, the inverse would be while(understands), which means true
        {

            // string manipulation
            string name = "John";
            Console.WriteLine("First Char in a string: " + name[0]); // J
            Console.WriteLine("Find the index of a character in a string (zero based index): " + name.IndexOf('o')); // 1
            Console.WriteLine("Find the index of a char combo in a string: " + name.IndexOf("hn")); // 2
            Console.WriteLine("Use substring to get part of a string: " + name.Substring(1)); // ohn
            Console.WriteLine(); 

            string number = "123";
            Console.WriteLine("Unsafe conversion to an integer, this will throw an exception if the string is not an int, ex if you input blah instead of a number: " + int.Parse(number) + 1); // 124
            Console.WriteLine("So will this: " + Convert.ToInt32(number) + 1); // 124     
            Console.WriteLine("Safe conversion to an integer, this will return a boolean result as to if the string is an int: " + int.TryParse(number, out int resultSafe)); // True
            Console.WriteLine("The result of the safe conversion: " + resultSafe); // 123
            Console.WriteLine("Simple string contactination, not to be confused with arithmetic in this case: " + number + 1); // 1231
            Console.WriteLine();

            string result = name + number;
            Console.WriteLine("String concatenation: " + result); // John123
            Console.WriteLine("Another form of string concat, we use exactly this kind when we write logs to splunk: " + string.Format("{0} {1}", name, number)); // John 123
            Console.WriteLine("And yet another: " + $"{name} {number}"); // John 123
            Console.WriteLine();

            string result2 = string.Concat(name, number);
            Console.WriteLine("String.Concat does the same as string + string: " + result2); // John123
            // There is an error right here.  Fix it based on what you see in this program.  Its outputting false only and not the string I tried to concatenate.
            // maybe create a variable to hold the result of name == "John" and then concatenate that with the string you are trying to output.
            Console.WriteLine("compare two strings to see if the same with a boolean result, this will be fale if they are not exactly the same (case): " + name == "John"); // True
            Console.WriteLine("same thing using equals method: " + name.Equals("John")); // True
            Console.WriteLine("Strings take up memory, this is how much memory this is how many bytes: " + Encoding.Unicode.GetByteCount(result)); 
            Console.WriteLine();

            var stringBuilder = new StringBuilder();
            stringBuilder.Append(name);
            stringBuilder.Append(number);
            string result3 = stringBuilder.ToString();

            Console.WriteLine("String builder, new shit: " + result3); // John123
            Console.WriteLine("String builders are best used in loops when you need to build up a string: " + result3.Length); // 7
            Console.WriteLine(result3.ToLower()); // john123
            Console.WriteLine(result3.ToUpper()); // JOHN123
            Console.WriteLine();

            // case safe string comparison
            var string1 = "blahblah";
            var string2 = "BLAHBLAH";
            Console.WriteLine("Compare them for the contents (case matters) : " + string1 == string2); //false
            Console.WriteLine("Compare them for the contents without caring about case : " + String.Equals(string1, string2, StringComparison.OrdinalIgnoreCase)); // true;
            Console.Write("This entire thing is a demonstration of string concatenation on its own, that is what is happening everytime I use Console.WriteLine with the variables ");
            Console.Write(Environment.NewLine);
            Console.Write("And so is this last part, I used Console.Write and concatenated a new line, instead of WriteLine, the same thing a WriteLine would do.  It is not magic, it is just different forms string concatenation.");
            Console.WriteLine("Do you understand? Y or N?");
            Console.WriteLine();
            var understandsResult = Console.ReadLine();
            if (understandsResult == "Y")
            {
                understands = true;
                Console.WriteLine("Awesome, try it yourself, but differently with your own variables.");
            }
            else
            {
                Console.WriteLine("Do it again.");
            }
        }
    }
}
