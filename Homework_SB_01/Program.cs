﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание базы данных из 20 сотрудников
            Repository repository = new Repository(20);

            // Печать в консоль всех сотрудников
            repository.Print("База данных из 20 сотрудников");

            //Нажать любую клавишу для перехода к следующему этапу
            repository.NextStep();  



            // Создание базы данных из 40 сотрудников
            repository = new Repository(40);

            // Печать в консоль всех сотрудников
            repository.Print("База данных из 40 сотрудников");
            // Увольнение всех до нужного количества
            repository.DeleteWorkerUntil(30);

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после преобразования");

            //Нажать любую клавишу для перехода к следующему этапу
            repository.NextStep();



            // Создание базы данных из 50 сотрудников
            repository = new Repository(50);

            // Печать в консоль всех сотрудников
            repository.Print("База данных из 50 сотрудников");
            // Увольнение всех до нужной зарплаты
            repository.DeleteWorkerBySalary(30000);

            // Печать в консоль сотрудников, чья зарплата не превышает 30000руб
            repository.Print("База данных после преобразования");
                        
            Console.ReadKey();


            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе болжно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб



            #endregion

        }
    }
}
