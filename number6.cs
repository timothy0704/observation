using System;

class Program {
  public static void Main (string[] args) {

    for(int n =1; n<=100; n++)
    {
          n = Convert.ToInt32(Console.ReadLine());
      if(n%2==0){
      Console.WriteLine ("Even number");
    }
    else
    {
      Console.WriteLine ("odd number");
    }
  }
}
  }
