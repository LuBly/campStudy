/// 4-1 
/// 숫자를 두번 입력 받아서 두번 다 숫자인지 확인
{
    Console.WriteLine("첫번째 수를 입력해 주세요.");
    string input1 = Console.ReadLine();
    int num1;
    bool isInt1 = int.TryParse(input1, out num1);

    Console.WriteLine("두번째 수를 입력해 주세요.");
    string input2 = Console.ReadLine();
    int num2;
    bool isInt2 = int.TryParse(input2, out num2);

    if (isInt1 && isInt2)
    {
        Console.WriteLine("두 데이터는 모두 숫자입니다.");
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}

/// 4-2 
/// 숫자를 두번 입력받아서 두번 다 숫자인지 하나만 숫자인지 확인
{
    Console.WriteLine("첫번째 수를 입력해 주세요.");
    string input1 = Console.ReadLine();
    int num1;
    bool isInt1 = int.TryParse(input1, out num1);

    Console.WriteLine("두번째 수를 입력해 주세요.");
    string input2 = Console.ReadLine();
    int num2;
    bool isInt2 = int.TryParse(input2, out num2);

    if (isInt1 && isInt2)
    {
        Console.WriteLine("두 데이터는 모두 숫자입니다.");
    }
    else if (isInt1 || isInt2)
    {
        Console.WriteLine("하나의 데이터만 숫자입니다.");
    }
    else
    {
        Console.WriteLine("두 데이터 모두 숫자가 아닙니다.");
    }
}

/// 4-3 
/// 숫자를 두번 입력받아서 두 수를 비교
{
    Console.WriteLine("첫번째 수를 입력해 주세요.");
    string input1 = Console.ReadLine();
    int num1;
    bool isInt1 = int.TryParse(input1, out num1);

    Console.WriteLine("두번째 수를 입력해 주세요.");
    string input2 = Console.ReadLine();
    int num2;
    bool isInt2 = int.TryParse(input2, out num2);

    if (isInt1 && isInt2)
    {
        if (num1 == num2)
        {
            Console.WriteLine(num1 + " 와(과) " + num2 + " 은(는) 같습니다.");
        }
        else if (num1 > num2)
        {
            Console.WriteLine(num1 + " 은(는) " + num2 + " 보다 큽니다.");
        }
        else
        {
            Console.WriteLine(num1 + " 은(는) " + num2 + " 보다 작습니다.");
        }
    }
    else
    {
        Console.WriteLine("두 개의 숫자를 입력해주세요.");
    }
}