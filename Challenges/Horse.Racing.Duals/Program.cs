namespace Power.Of.Thor.Episode._1
{
  internal static class Program
  {
    static void Main(string[] args)
    {
      int N = int.Parse(Console.ReadLine());
      int[] positions = new int[N];
      int minDiff = int.MaxValue;
      for (int i = 0; i < N; i++)
      {
        int pi = int.Parse(Console.ReadLine());
        positions[i] = pi;
      }
      positions = positions.OrderBy(x => x).ToArray();
      for (int i = 0; i < positions.Length - 1; i++)
      {
        int diff = Math.Abs(positions[i] - positions[i + 1]);
        if (diff < minDiff)
        {
          minDiff = diff;
        }
      }

      Console.WriteLine(minDiff);
    }
  }
}