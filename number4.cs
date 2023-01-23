using System;   // number 2 in for statement 

class Program {
  public static void Main (string[] args) {

    int sum = 0;
    
  for(int n = 1; n < 51; n+=2){
    sum += n;
  }
  Console.WriteLine(sum);
  }
}  


/*using System;     //number 2 in while statement 

class Program {
  public static void Main (string[] args) {

    int sum = 0;
  int n=1;
    while(n<51){
  
    
      sum += n;
    
      n+=2;
      
   }
Console.WriteLine(sum);
  
  }
}  */


/*using System;     //number 2 in do while statement 

class Program {
  public static void Main (string[] args) {

    int sum = 0;
    int n=1;

do{

  sum += n;
    
      n+=2;
} while(n<51);

    Console.WriteLine(sum);
  
  
  }
}   */
