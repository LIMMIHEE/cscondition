﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscondition
{
    class Program
    {
        static void Main(string[] args)
        {
            //홀수짝수 구분
            /*
            Console.Write("숫자 입력 : ");
            var input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다");
            }else
           // if (input % 2 == 1)
            {
                Console.WriteLine("홀수 입니다");
            }
            */



            // 오전과 오후 구분
            /*
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine(DateTime.Now.Second);

            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else if (DateTime.Now.Hour < 15)
            //if (DateTime.Now.Hour >= 12)
            {
                // if (DateTime.Now.Hour < 15)
                // {
                Console.WriteLine("점심 먹을 시간입니다.");
                // }
            }
            else { 
                Console.WriteLine("저녁 먹을 시간입니다.");
                
            }
            */



            // 스위치 문
            /*
            var input = int.Parse(Console.ReadLine());
            switch (input % 2)
            {
                case 0: Console.WriteLine("짝수 입니다"); break;
                case 1: Console.WriteLine("홀수 입니다"); break;
            }

            Console.Write("이번 달은 몇 월인가요 : ");
            int input2= int.Parse(Console.ReadLine());
            switch (input2)
            {
                case 12: 
                case 2: 
                case 1:  Console.WriteLine("겨울입니다."); break;
                case 3:
                case 4: 
                case 5: Console.WriteLine("봄입니다."); break;
                case 6: 
                case 7: 
                case 8: Console.WriteLine("여름입니다."); break;
                case 9: 
                case 10: 
                case 11: Console.WriteLine("가을입니다."); break;
                default: Console.WriteLine("인식 불가합니다."); break;
            }
             */

            /* 
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(input % 2 == 0 ? "짝수입니다" : "홀수입니다");
            Console.WriteLine(input > 0 ? "자연수입니다" : "자연수가 아닙니다");
            */

            Console.Write("입력 : " );
            String line = Console.ReadLine();
            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요");
            }
            else
            {
                Console.WriteLine("좋은 날이네요.");
            }

          
            ConsoleKeyInfo info =  Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                default:
                    switch (info.KeyChar)
                    {
                        /*
                        case (char)38:
                            Console.WriteLine("위로 이동");
                            break;
                            */
                        case '가':
                            Console.WriteLine("가 입력");
                            break;
                        default:
                            Console.WriteLine("다른 키 입력");
                            break;
                    }
                    //Console.WriteLine("방향키 이외의 키 입력");
                    break;
                    //case ConsoleKey.('가'):
                    // Console.WriteLine("위로 이동");
                    //break;
            }
            /*
            switch (info.KeyChar)
            {
                case 'a':
                    Console.WriteLine("a 입력하겼습니다.");
                    break;
            }

            switch (info.KeyChar)
            {
                case (char) 38:
                    Console.WriteLine("위로 이동");
                    break;
                case '가':
                    Console.WriteLine("위로 이동");
                    break;
            }
            */
        }
    }
}
