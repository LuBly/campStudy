/// 5-1
/// 퀴즈를 내서 정답을 맞추는 프로그램 작성

{
    Console.WriteLine("Q. 대한민국의 수도는 어디인가요?");
    Console.WriteLine("1.인천   2.평창   3.서울   4.부산");

    string input = Console.ReadLine();
    bool isInt = int.TryParse(input, out int value);

    if (!isInt)
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
    else
    {
        if(value > 4 || value < 1)
        {
            Console.WriteLine("1~4의 숫자를 입력해주세요");
        }
        else
        {
            if(value == 3)
            {
                Console.WriteLine("정답입니다.");
            }
            else
            {
                Console.WriteLine("오답입니다!");
            }
        }
    }
}
/// 5-2
/// 주어진 보기를 선택하면 해당하는 선택지에 맞는 메시지 출력
{
    Console.WriteLine("어디로 여행을 가고 싶나요?");
    Console.WriteLine("1.제주도   2.코타키나발루   3.싱가포르   4.태국");

    string input = Console.ReadLine();

    if (int.TryParse(input, out int value))
    {
        switch (value)
        {
            case 1:
                Console.WriteLine("제주도는 한국의 섬으로 비교적 방문이 쉽고 다양한 놀거리/먹거리가 준비되어 있습니다.");
                break;
            case 2:
                Console.WriteLine("코타키나발루는 말레이시아 사바주의 주도로, 말레이시아 동부 보르네오섬 최대의 도시입니다.");
                break;
            case 3:
                Console.WriteLine("싱가포르는 동남아시아, 말레이 반도의 끝에 위치한 섬나라이자 항구 도시로 이루어진 도시 국가입니다.");
                break;
            case 4:
                Console.WriteLine("태국은 중국문화, 말레이문화, 불교문화, 힌두문화, 이슬람 문화가 혼재되어 있습니다. 불교적인 모습을 많이 띄지만, 문화 자체는 색다르고 스펙트럼이 넓은 형태를 띄고 있어요.");
                break;
        }
    }
    else if (value > 4 || value < 1)
    {
        Console.WriteLine("1~4의 숫자를 입력해주세요.");
    }
    else
    {
        Console.WriteLine("숫자가 아닙니다.");
    }
}