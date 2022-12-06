using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__8__тест_на_скорость_печати_
{
    public class Result
    {
        public static List<statistika> res = new List<statistika>();

        public static void result()
        {
            Console.Clear();
            Console.WriteLine("Время вышло!");
            Console.WriteLine("Таблица результатов:");

            foreach (var item in res)
            {
                Console.WriteLine("Имя:" + item.name);
                Console.WriteLine("Символов в минуту" + item.Res_1);
                Console.WriteLine("Символов в секунду" + item.Res_2);
                Console.WriteLine("Количество ошибок:" + item.Exc);
            }
            Serialize();
        }
        private static void Serialize()
        {
            string json = JsonConvert.SerializeObject(res);
            File.WriteAllText("C:\\Users\\maksi\\OneDrive\\Рабочий стол\\Статиcтика.json", json);
        }
        public static void Deserialize()
        {
            string text = File.ReadAllText("C:\\Users\\maksi\\OneDrive\\Рабочий стол\\Статистика.json");
            res = JsonConvert.DeserializeObject<List<statistika>>(text) ?? new List<statistika>();
        }


    }
}
