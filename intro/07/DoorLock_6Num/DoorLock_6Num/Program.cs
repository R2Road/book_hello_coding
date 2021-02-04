using System;

namespace DoorLock_6Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int passcodenumbers1 = 6;
            int passcodenumbers2 = 2;
            int passcodenumbers3 = 1;
            int passcodenumbers4 = 9;
            int passcodenumbers5 = 4;
            int passcodenumbers6 = 7;

            Console.WriteLine("첫 번째 숫자를 넣어주세요.");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 넣어주세요.");
            int userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine("세 번째 숫자를 넣어주세요.");
            int userInput3 = int.Parse(Console.ReadLine());
            Console.WriteLine("네 번째 숫자를 넣어주세요.");
            int userInput4 = int.Parse(Console.ReadLine());
            Console.WriteLine("다섯 번째 숫자를 넣어주세요.");
            int userInput5 = int.Parse(Console.ReadLine());
            Console.WriteLine("여섯 번째 숫자를 넣어주세요.");
            int userInput6 = int.Parse(Console.ReadLine());

            if (userInput1 == passcodenumbers1 && userInput2 == passcodenumbers2 && userInput3 == passcodenumbers3 && userInput4 == passcodenumbers4 && userInput5 == passcodenumbers5 && userInput6 == passcodenumbers6)
            {
                Console.WriteLine("문이 열렸습니다.");
            }
            else
            {
                Console.WriteLine("비밀번호가 틀렸습니다.");
            }
        }
    }
}
