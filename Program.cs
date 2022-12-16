using System;
using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            // 알파벳 소문자 문자열 S 받아오기
            string S = ReadLine();

            // indexof로 문자 찾기
            for (int i = 0; i < 26; i++)
            {
                Write(S.IndexOf((char)(97 + i)));
                // IndexOf : 문자열의 인덱스번호 출력 (존재하지 않으면 -1)
                Write(' ');
            }


        }
    }