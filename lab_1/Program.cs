using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Level 1, task 5

        class Student
        {
            public string surname;
            public int mark;
            public int classesSkipped;

            public Student(string surname, int mark, int classesSkipped)
            {
                this.surname = surname;
                this.mark = mark;
                this.classesSkipped = classesSkipped;
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int studentsAmount = rand.Next(5); // определяем кол-во студентов
            Student[] student = new Student[studentsAmount]; // список студентов

            int index = 0;

            for (int i = 0; i <= studentsAmount; i++) // вносим студентов в список
            {
                string[] surnames = new string[]
                {"Абабков",
                 "Абаимов",
                 "Абакишин",
                 "Абакулин",
                 "Абакулов" };

                int[] marks = new int[] { }


                student[index] = new Student(surnames[rand.Next(4)], )
            }

            while (index < studentsAmount) // сортируем студентов по кол-ву пропущенных занятий
            {
                if (student[index].mark == 2) // проверяем является ли студент неуспевающим
                {
                    if (index == 0)
                        index++;
                    if (student[index].classesSkipped >= student[index - 1].classesSkipped)
                        index++;
                    else
                    {
                        Student tempStudent = student[index];
                        student[index] = student[index - 1];
                        student[index - 1] = tempStudent;
                        index--;
                    }
                }
            }

            for (int i = 0; i <= studentsAmount; i++) // выводим неуспевающих студентов в таблице 
            {
                if (student[index].mark == 2) // проверяем является ли студент неуспевающим
                {
                    Console.WriteLine($"\n Surname: {student[index].surname}, classes skipped: {student[index].classesSkipped}");
                }
            }


        }
    }
}
