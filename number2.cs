using System;

class Program {
  public static void Main (string[] args) {

    string user1, user2;
    Console.WriteLine("Choose from rock, paper, and scissors for user 1");

    user1=Console.ReadLine();

     Console.WriteLine("Choose from rock, paper, and scissors for user 2");

    user2=Console.ReadLine();

    if(user1=="rock")
    {                     //opening
      if(user2=="paper")
      {
        Console.WriteLine("user 2 wins");
      }
    
      if(user2=="scissors")// never put "" after if
      {
        Console.WriteLine("user 1 wins");
      }                  // closing
    
  
    
      if(user2=="rock")
      {
        Console.WriteLine("tie");
      }
  }

    else if(user1=="paper")// else if for when we have multiple choices for example there are choices between 3 options like rock, paper, and scissors
    {
      
      if(user2=="scissors")//== is comparing and = is direct value
      {
        Console.WriteLine("user2 wins");
      }
      if(user2=="rock")
      {
        Console.WriteLine("user 1 wins");
      }
   if(user2=="paper")
      {
        Console.WriteLine("tie");
      }   
}

  else if(user1=="scissors")
    {
      if(user2=="paper")
      {
        Console.WriteLine("user1 wins");
      }   
    

      if(user2=="rock")
      {
        Console.WriteLine("user2 wins");
      }   
    

   
      if(user2=="scissors")
      {
        Console.WriteLine("tie");
      }   
}
  
  
 
  
  }
 }
