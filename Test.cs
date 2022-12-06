using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Практическая__8__тест_на_скорость_печати_
{
    public class Test
    {
        public static void test()
        {
            int exception_kol = 0;
            int kol = 0;
            int pos_y = 0;
            int pos_x = 0;
            Console.Clear();
            var a = "Мефедрон - это синтетический наркотик из группы амфетаминов. Вызывает мощную стимуляцию центральной нервной системы" +
                " и отдельных участков головного мозга. Привыкание наступает уже с первого приема, при этом отходняк от препарата тяжелый." +
                "\nСостав вещества" +
                "\nХимический состав мефедрона включает в себя синтезированные молекулы амфетамина и алкалоида катинона. Начал производится еще в начале 20 века, но в широкую продажу поступил в 2003 году. Распространять его начали китайские дилеры, после чего он появился в Европе и США. С 2007 по 2010 год препарат легально продавался в ярких пакетиках под видом соли для ванн в России. Состав такой 'соли' был несколько нетипичным, из-за чего мефедрон  не включался в список запрещенных.";
            Console.Write(a);
            char[] text = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                text[i] = a[i];
            }
            for (int i = 0; i < text.Length && Program.TimerOn;)
            {
                ConsoleKeyInfo klavisha = Console.ReadKey(true);
                if (klavisha.Key == ConsoleKey.Enter)
                {

                    pos_x = 0;
                    pos_y++;
                }
                if (klavisha.KeyChar == '\r' && text[i] == '\n')
                {
                    i++;
                    continue;
                }
                if (klavisha.KeyChar == text[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(pos_x, pos_y);
                    Console.Write(text[i]);
                    pos_x++;
                    kol += 1;
                    if (pos_x == 120)
                    {
                        pos_x = 0;
                        pos_y++;
                    }
                    i++;
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 23);
                    Console.WriteLine(kol);
                }
                else
                {
                    kol += 1;
                    exception_kol += 1;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(pos_x, pos_y);
                    Console.Write(text[i]);
                }
            }
            Program.result.Exc = exception_kol;
            Program.result.Res_1 = kol;
            Program.result.Res_2 = kol/60;
        }
    }
    public class statistika
    {/*
        public statistika (string Name, int result_sec, int result_min, int exc)
        {
            name = Name;
            Res_1 = result_min;
            Res_2 = result_sec;
            Exc = exc;
        }*/
        public int Res_1;
        public int Res_2;
        public string name;
        public int Exc;
    }
}
