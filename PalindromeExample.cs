class StrPalindrome
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter Input String");
    string inputStr=Console.ReadLine();

    string reversedStr=new string(inputStr.Reverse().ToArray());

    if(inputStr.Equals(reversedStr))
    {
      Console.WriteLine("String is Palindrome");
    }
    else
    {
      Console.WriteLine("String is NOT Palindrome");
    }

    Console.WriteLine("Reversed String is:" + reversedStr);
  }
}
