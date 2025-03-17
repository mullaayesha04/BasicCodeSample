Class WordsinRevOrder
{
   static void Main(string[] args)  
    {  
        string strInput = "Mysore is beautiful place";  
        string[] strWords = strInput.Split(' ');
        Array.Reverse(strWords);
        string newStr = string.Join(" ", strWords);
	   
        Console.WriteLine(newStr);  
        Console.ReadLine();  
    }  
}
