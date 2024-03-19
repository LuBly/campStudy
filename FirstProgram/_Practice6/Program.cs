// 6-1
// 구구단 2단 만들기
/*
{
    int start = 2;
    for(int k = 2; k < 10; k++)
    {
        Console.WriteLine(start + " x " + k + " = " + start * k);
    }
}

// 6-2
// 입력받은 데이터로 구구단 만들기
{
    string input = Console.ReadLine();

    if(int.TryParse(input, out int start))
    {
        for (int k = 2; k < 10; k++)
        {
            Console.WriteLine(start + " x " + k + " = " + start * k);
        }
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다");
    }
}

// 6-3
// 피보나치 수열 구하기
{
    int cnt = 10;
    int first = 0;
    int second = 1;
    for(int k = 0; k < cnt; k++)
    {
        Console.Write(second + " ");
        int res = first + second;
        first = second;
        second = res;
    }
}
*/
// 6-4
// 입력받은 수만큼 피보나치 수열 구하기 
{
    string input = Console.ReadLine();
    if(!int.TryParse(input, out int value))
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
    else
    {
        if(value < 1)
        {
            Console.WriteLine("양수를 입력해주세요");
        }
        else if(value > 46)
        {
            Console.WriteLine("숫자가 너무 큽니다");
        }
        else
        {
            int first = 0;
            int second = 1;
            for (int k = 0; k < value; k++)
            {
                Console.Write(second + " ");
                int res = first + second;
                first = second;
                second = res;
            }
        }
    }
}