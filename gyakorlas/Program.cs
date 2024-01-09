// See https://aka.ms/new-console-template for more information
Hi hello = new Hi();
IEnumerable<int> numbers = new List<int> { 7,
2,
11, 8, 3, 11, 10 };
hello.Greet(numbers);
public class Hi
{
    public string hello = "hello";
    public void Greet(IEnumerable<int> input)
    {
        int[] inputArr = input.ToArray();
        List<int> aranyLabdasok = new List<int>();
        int biggest = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            int num = inputArr[i];

            if (num > biggest)
            {
                biggest = num;
                aranyLabdasok.Clear();
                aranyLabdasok.Add(i);

            }
            else if (num == biggest)
            {
                aranyLabdasok.Add(i);

            }
        }
        Console.WriteLine(biggest);
        Console.WriteLine(aranyLabdasok.Count);
        Console.WriteLine(string.Join(" ", aranyLabdasok));
        // Console.WriteLine(aranyLabdasok.foreach (a => Console.WriteLine(a)));
    }
}
