class Program
{
    private static Queue<Char> queueB = new Queue<char>();
    private static CircularLinkedList<char> pool = new CircularLinkedList<char>();

    static void Main(string[] args)
    {
        pool.Add('L');
        pool.Add('M');
        pool.Add('S');
        char currentInput = char.Parse(Console.ReadLine());
        while (checkInput(currentInput))
        {
            queueB.Push(currentInput);
            currentInput = char.Parse(Console.ReadLine());
        }
        while (queueB.GetLength() != 0)
        {
            checkNode();
        }

    }
    static bool checkInput(char currentInput)
    {
        for (int i = 0; i < 3; i++)
        {
            if (currentInput == pool.Get(i))
            {
                return true;
            }
        }
        return false;
    }
    static void checkNode()
    {
        switch (queueB.Pop())
        {
            case 'L':
                checkConditionL();
                break;
            case 'M':
                checkConditionM();
                break;
            case 'S':
                checkConditionS();
                break;
            default:
                break;
        }
    }

    static void checkConditionL()
    {
        queueB.Push('M');
        queueB.Push('M');
        Console.Write('1');
    }

    static void checkConditionM()
    {
        queueB.Push('S');
        queueB.Push('S');
        queueB.Push('S');
        Console.Write('2');
    }
    static void checkConditionS()
    {
        Console.Write('3');
    }

}