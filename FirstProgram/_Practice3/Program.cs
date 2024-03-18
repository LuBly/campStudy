/// 3-1
/// 입력받은 데이터가 숫자인지 문자열인지 판단
{
    string input = Console.ReadLine();

    int num;
    bool isInt = int.TryParse(input, out num);

    if (isInt)
    {
        Console.WriteLine("숫자입니다.");
    }
    else
    {
        Console.WriteLine("문자열입니다.");
    }
}

/// 3-2
/// 입력받은 데이터가 숫자인지 문자열인지 불리언인지 판단
{
    string input = Console.ReadLine();

    int num;
    bool isInt = int.TryParse(input, out num);

    bool b;
    bool isBool = bool.TryParse(input, out b);

    if (isInt)
    {
        Console.WriteLine("숫자 입니다.");
    }
    else if (isBool)
    {
        Console.WriteLine("불리언 입니다.");
    }
    else
    {
        Console.WriteLine("문자열 입니다.");
    }
}

/// 3-3
/// 입력받은 데이터가 숫자라면 100 보다 큰지 작은지 알려주는 프로그램 만들기
{
    string input = Console.ReadLine();

    int num;
    bool isInt = int.TryParse(input, out num);

    if (isInt)
    {
        if (num >= 100)
        {
            Console.WriteLine(num + " 은(는) 100 보다 같거나 큰 수 입니다.");
        }
        else
        {
            Console.WriteLine(num + " 은(는) 100 보다 작은 수 입니다.");
        }
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}

/// 3-4
/// 입력받은 데이터가 숫자라면 짝수인지 홀수인지 알려주는 프로그램 만들기
{
    string input = Console.ReadLine();

    int num;
    bool isInt = int.TryParse(input, out num);

    if (isInt)
    {
        int remainder = num % 2;
        if (remainder == 0)
        {
            Console.WriteLine(num + " 은(는) 짝수 입니다.");
        }
        else
        {
            Console.WriteLine(num + " 은(는) 홀수 입니다.");
        }
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}