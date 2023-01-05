namespace Power.Of.Thor.Episode._1
{
  internal static class Program
  {
    static void Main(string[] args)
    {
      // string[] inputs = Console.ReadLine().Split(' ');
      string[] inputs = new string[4]{"36","17","0","0"};
      int lightX = int.Parse(inputs[0]); // the X position of the light of power
      int lightY = int.Parse(inputs[1]); // the Y position of the light of power
      int initialTx = int.Parse(inputs[2]); // Thor's starting X position
      int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

      // game loop
      while (lightX != initialTx || initialTy != lightY)
      {
        string output = string.Empty;
        if (initialTy < lightY)
        {
          output += "S";
          initialTy++;
        }
        else if (initialTy > lightY)
        {
          output += "N";
          initialTy--;
        }

        if (initialTx < lightX)
        {
          output += "E";
          initialTx++;
        }
        else if (initialTx > lightX)
        {
          output += "W";
          initialTx--;
        }
        // A single line providing the move to be made: N NE E SE S SW W or NW
        Console.WriteLine(output);
      }
    }
  }
}