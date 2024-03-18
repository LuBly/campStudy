/// 1 - 1,2
/// 변수를 생성하고 데이터 입력
{
    int level = 20;
    int count = 5;

    float percentage = 99.9f;
    float speed = 2.3f;

    string nickname = "chad";
    string description = "무언가를 설명하는 글입니다.";
}

/// 1 - 3 
/// 형변환 - 숫자를 숫자로
{
    int iTen = 10;
    float fTen = (float)iTen; // (float) 를 붙이지 않아도 된다. - 참고 Link

    float fFive = 5.5f;
    int iFive = (int)fFive;
}

/// 1 - 4 
/// 형변환 - 숫자를 문자로
{
    int n = 10;
    float f = 0.5f;

    string strN = n.ToString();
    string strF = f.ToString();
}

/// 1 - 5 
/// 형변환 - 문자를 숫자로
{
    string strTen = "10";
    string strSix = "6.2";

    // Convert 를 이용한 방식
    int C_iTen = Convert.ToInt32(strTen);
    float C_fSix = Convert.ToSingle(strSix);

    // Parse 를 이용한 방식
    int P_iTen = int.Parse(strTen);
    float P_fSix = float.Parse(strSix);
}