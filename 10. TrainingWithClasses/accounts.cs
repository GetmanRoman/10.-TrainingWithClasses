using System;
using System.Collections.Generic;
using System.Text;

namespace _10._TrainingWithClasses
{
    enum TypesOfDostup
    {
        Администратор,
        Пользователь
    }

    internal class accounts
    {
        
        private string name;
        private int age;
        private TypesOfDostup dostup2 = TypesOfDostup.Пользователь;
        private int money;
        private bool wasAccountCreatedRight = false;

        public accounts(
            string name = "Без имени",
            int age = 0,
            TypesOfDostup dostup2 = TypesOfDostup.Пользователь,
            int money = 0
            )
        {
            this.name = name;
            this.age = age;
            this.dostup2 = dostup2;
            this.money = money;
        }

        public void CheckAccount() 
        {
            if (name != "Без имени") 
            {
                wasAccountCreatedRight = true; 
            }
            if (age != 0) { wasAccountCreatedRight = true; }
            
        }

        public void PrintInfo() 
        {
            CheckAccount();
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Уровень пользователя: {dostup2}");
            Console.WriteLine($"Денег на счету: {money}");
            Console.WriteLine($"Был ли аккаунт создан правильно: {wasAccountCreatedRight}");
        }
    }
    public static class accountsExtension 
    {
        // Доделай + узнай о public string Title { get; set; }
    }
}
