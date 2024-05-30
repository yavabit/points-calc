using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRcalc
{
    public static class DataSource
    {
        public static readonly int maxPointsItems1 = 160;//Items1.Sum(item => item.Points);
        public static readonly int maxPointsItems2 = 100;//Items2.Sum(item => item.Points);
        public static readonly int maxPointsItems3 = 0;//Items3.Sum(item => item.Points);

        public static readonly List<DataGridViewModel> Items1 = new List<DataGridViewModel>
        {
            new DataGridViewModel
            {
                Description = "Ненужные логи",
                Points = 4,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Плохая структура проекта",
                Points = 8,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Нет задержки для поиска",
                Points = 8,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Нет декомпозиции больших функций или файлов (там, где это уместно)",
                Points = 12,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Повторяющийся код",
                Points = 16,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Плохое именование функций или переменных",
                Points = 8,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Нечитабельное форматирование файла с кодом ",
                Points = 12,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Неверное использование циклов JS (map вместо forEach или наоборот)",
                Points = 14,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Ненужное объявление переменной/ объявление в циклах/условиях",
                Points = 8,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Нет деструктуризации, там, где она уместна или наоборот есть там, где она неуместна (например в функцию передают 100 полей по юзеру вместо объекта)",
                Points = 4,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Ошибки в консоли",
                Points = 12,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Ошибки в запросах при обращении к серверу",
                Points = 16,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Нет проверки на данные/приложение ломается при отсутствии данных",
                Points = 16,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Дублирование запроса к серверу",
                Points = 12,
                IsSelected = false
            }
        };

        public static readonly List<DataGridViewModel> Items2 = new List<DataGridViewModel>
        {
            new DataGridViewModel
            {
                Description = "Нет сообщений об ошибке ответа сервера",
                Points = 5,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Нет сообщений о том что ничего не найдено",
                Points = 8,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Модальное окно не закрывается при клике вне",
                Points = 8,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Поиск реализован через фронт",
                Points = 16,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Поиск не работает при вводе",
                Points = 12,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Общий список не выводится при заходе на страницу",
                Points = 16,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Неверный результат по поиску",
                Points = 20,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Для получения всего списка юзеров отправляется запрос с параметрами, а не без",
                Points = 8,
                IsSelected = false
            }
        };

        public static readonly List<DataGridViewModel> Items3 = new List<DataGridViewModel>
        {
            new DataGridViewModel
            {
                Description = "Scss, sass, less или модульное подключение",
                Points = 10,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Дебаунс или задержка для поиска",
                Points = 15,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Vite",
                Points = 5,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "React Query",
                Points = 15,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Redux Toolkit",
                Points = 15,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "useContext/useMemo",
                Points = 10,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Резиновая верстка",
                Points = 10,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "axios",
                Points = 5,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Bootstrap/tailwind или др ui библиотеки",
                Points = 10,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Хорошее описание README на git",
                Points = 5,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Есть Комментарии по коду (без фанатизма)",
                Points = 5,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Предусмотрено закрытие попапа по клавишам",
                Points = 10,
                IsSelected = false
            },
            new DataGridViewModel
            {
                Description = "Нет прокрутки при открытии попапа",
                Points = 5,
                IsSelected = false
            }
        };
    }
}
