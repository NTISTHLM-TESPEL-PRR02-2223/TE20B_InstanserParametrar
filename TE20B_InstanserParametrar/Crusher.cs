using System;

public class Crusher
{
  
  public void Crush(Rock target)
  {
    Console.WriteLine("CRUSH");
    target.isCrushed = true;
  }

}
