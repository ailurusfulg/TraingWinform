using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100, y = 5, value = 0;
            // value = x / y;
            // Console.WriteLine("{0} / {1} = {2}", x, y, value);
            //Console.WriteLine($"{ x} / { y} = { value}");

            try
            {
                value = x / y;
                Console.WriteLine($"{ x} / { y} = { value}");
                throw new Exception("1, 사용자에러");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("2, y의 값을 0보다 크게 입력하세요");
            }
            catch (Exception ex) // 에러 시 출력
            {
                Console.WriteLine("3, " + ex.Message);
            }
            finally // 에러 유무 상관 없이 출력
            {
                Console.WriteLine("4, 프로그램이 종료되었습니다.");
            }
        }
    }
}
