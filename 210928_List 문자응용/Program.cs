﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210928_List_문자응용
{
    class Program
    {
        static void Main(string[] args)
        {
            // 선언
            // 이름을 저장할 수 있는 ArrayList를 선언하고 만들어주세요.
            List<string> slist = new List<string>();

            // add()
            // 리스트에 값을 추가해주세요.
            // "홍길동", "이순신", "황진이", "임꺽정", "강감찬", "을지문덕" 을 ArrayList에 추가 해주세요.
            slist.Add("홍길동");
            slist.Add("이순신");
            slist.Add("황진이");
            slist.Add("임꺽정");
            slist.Add("강감찬");
            slist.Add("을지문덕");


            // size()
            // 리스트의 사이즈를 출력해주시고, 값이 6이 맞다면 계속 진행해주세요.
            // 출력결과 : 6
            Console.WriteLine(slist.Count);



            // get()
            // 리스트의 2,3 인덱스의 값을 출력해주세요.
            // 출력결과 : 황진이, 임꺽정
            Console.WriteLine(slist[2]);
            Console.WriteLine(slist[3]);



            // 리스트의 모든 값을 출력해주세요.
            // 출력 결과 : 홍길동 이순신 황진이 임꺽정 강감찬 을지문덕
            for(int i = 0; i < slist.Count; i++)
            {
                Console.WriteLine(slist[i]);
            }



            // remove()
            // 리스트에서 홍길동, 이순신을 지운 뒤, 다시 2,3 인덱스의 값을 출력해주시고 어떤 변화가 있는지 체크해주세요.
            // 출력 결과 : 강감찬, 을지문덕
            slist.RemoveAt(0);
            slist.RemoveAt(0);
            Console.WriteLine(slist[2]);
            Console.WriteLine(slist[3]);


            // 리스트의 모든 값을 출력해주세요.
            // 출력 결과 : 황진이 임꺽정 강감찬 을지문덕
            for (int i = 0; i < slist.Count; i++)
            {
                Console.WriteLine(slist[i]);
            }



            // add()
            // 리스트에 정약용을 추가시켜주세요.
            slist.Add("정약용");



            // 리스트의 모든 값을 출력해주세요.
            // 출력 결과 : 황진이 임꺽정 강감찬 을지문덕 정약용
            for (int i = 0; i < slist.Count; i++)
            {
                Console.WriteLine(slist[i]);
            }



            // set()
            // 임꺽정과 을지문덕을 신사임당과 유관순으로 바꿔주세요.
            slist[1] = "신사임당";
            slist[3] = "유관순";



            // 리스트의 모든 값을 출력해주세요.
            // 출력 결과 : 황진이 신사임당 강감찬 유관순 정약용
            for (int i = 0; i < slist.Count; i++)
            {
                Console.WriteLine(slist[i]);
            }


            // 리스트에서 황진이 신사임당 유관순만 출력해주세요.
            // 출력 결과 : 황진이 신사임당 유관순
            Console.WriteLine(slist[0]);
            Console.WriteLine(slist[1]);
            Console.WriteLine(slist[3]);



            Console.ReadLine();
        }
    }
}
