﻿/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге из решения урока 005_Book. При вызове этого метода, производится последовательный поиск строки в книге. 
*/
using System;

namespace Task2
{
    static class FindAndReplaceManager
    {
        static string _longLine;

        public static string SetText { set { _longLine = value; } }

        public static void FindNext(string str)
        {
            if (_longLine.Contains(str))
                Console.WriteLine($"Строка найдена!\nПервое включение в текст на {_longLine.IndexOf(str)} символе.");
            else
                Console.WriteLine("Строка отсутствует.");
        }
    }

    class Book
    {
        const string QUOTE = "Я как-то слышал анекдот. " +
                "Мужчина приходит к врачу, жалуется на депрессию, говорит, жизнь груба и жестока, что он чувствует себя одиноким в угрожающем мире. " +
                "Врач предлагает простой рецепт — великий клоун Пальячи сегодня в городе, сходите, это вас подбодрит. " +
                "Мужчина взрывается слезами. «Но доктор, — говорит он, — я и есть Пальячи».";

        public void FindNext(string str)
        {
            Console.WriteLine("Исходный текст:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{QUOTE}\n");
            Console.ResetColor();

            Console.WriteLine("Поиск строки:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{str}\n");
            Console.ResetColor();

            FindAndReplaceManager.SetText = QUOTE;
            FindAndReplaceManager.FindNext(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.FindNext("Мужчина приходит к врачу, жалуется на депрессию");

            Console.ReadKey();
        }
    }
}

