using System;

class CountRepetitiveChar
{
  static void Main (){
    
  string InputStr="Chennai";
  int[] count=new int [256];

  foreach (char c in InputStr) { count [c]++;}

  for(int i=0;i<256;i++)
  {
    if(count[i] > 1)
    {
      Console.WriteLine ($"Element: {(char)i,Count : {count[i]} }");
    }
  }
}
}
