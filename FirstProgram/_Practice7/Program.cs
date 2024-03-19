// 7 - 1
// 이름 입력하기
{
    Console.WriteLine("이름을 입력해주세요. (3 ~ 10글자)");
    string name = Console.ReadLine();
    int nameLength = name.Length;

    if (nameLength < 3 || nameLength > 10) Console.WriteLine("이름을 확인해주세요");
    else Console.WriteLine("안녕하세요! 제 이름은 " + name + " 입니다.");
}

// 7 - 2
// 조건에 맞을때 까지 이름 입력
{
    while (true)
    {
        Console.WriteLine("이름을 입력해주세요. (3 ~ 10글자)");
        string name = Console.ReadLine();
        int nameLength = name.Length;

        if (nameLength < 3 || nameLength > 10) Console.WriteLine("이름을 확인해주세요. \n");
        else
        {
            Console.WriteLine("안녕하세요! 제 이름은 " + name + " 입니다.");
            break;
        }
    }
}

// 7 - 3
// 반복시 기존 내용 지우기
// 처음 보는 명령어
// Console.Clear(); << 기존에 콘솔에 표시되던 메세지를 지울 수 있다.
{
    while (true)
    {
        Console.WriteLine("이름을 입력해주세요. (3 ~ 10글자)");
        string name = Console.ReadLine();
        int nameLength = name.Length;

        Console.Clear();
        if (nameLength < 3 || nameLength > 10) Console.WriteLine("이름을 확인해주세요. \n");
        else
        {
            Console.WriteLine("안녕하세요! 제 이름은 " + name + " 입니다.");
            break;
        }
    }
}
