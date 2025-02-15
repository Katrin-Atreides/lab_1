using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        #region Level 1 classes

            #region Task_5 classes
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
            #endregion

            #region Task_3 classes
            class Answer
            {
                public string person;
                public double count=0;
                public Answer(string person) { this.person = person; }
            }
            #endregion

            #region Task_4 classes
            class Sportsman
            {
                public double[] results = new double[2];
                public double bestResult;
                public Sportsman(double[] results)
                {
                    this.results = results;
                    this.bestResult = (results[0] > results[1]) ? results[0] : results[1];
                }
            }
        #endregion

        #endregion

        #region Level 2 classes

        #region Task_4
        class Jumper
        {
            public double grade;
            public string name;
            public Jumper(string name)
            {
                this.name = name;
            }
        }
        #endregion

        #endregion

        static void Main(string[] args)
        {
            #region Level 1

            #region Task_5

            //List<Student> students = new List<Student>
            //{
            //  new("Leonova", 0, 8),
            //  new("Bugaenko", 3, 9),
            //  new("Sokov", 2, 30),
            //  new("Tesheva", 4, 56),
            //  new("Mescheryakov", 5, 24),
            //  new("Andreev", 2, 37),
            //  new("Ivanov", 2, 42),
            //  new("Sidorov", 2, 73),
            //};

            //List<Student> lazyStudents = new List<Student>();

            //foreach (Student stud in students) // вносим неуспевающих студентов в отдельный список
            //{
            //    if (stud.mark == 2) lazyStudents.Add(stud);
            //}

            //int index = 0;
            //while (index < lazyStudents.Count) // сортируем студентов по кол-ву пропущенных занятий
            //{
            //    if (index == 0)
            //        index++;
            //    if (lazyStudents[index].classesSkipped >= lazyStudents[index - 1].classesSkipped)
            //        index++;
            //    else
            //    {
            //        Student tempStudent = lazyStudents[index];
            //        lazyStudents[index] = lazyStudents[index - 1];
            //        lazyStudents[index - 1] = tempStudent;
            //        index--;
            //    }
            //}

            //for (int i = lazyStudents.Count - 1; i >= 0; i--) // выводим неуспевающих студентов в таблице 
            //{
            //    if (lazyStudents[i].mark == 2) // проверяем является ли студент неуспевающим
            //    {
            //        Console.WriteLine($"\n Surname: {lazyStudents[i].surname}, classes skipped: {lazyStudents[i].classesSkipped}");
            //    }
            //}

            #endregion

            #region Task_3

            //Random rand = new Random();
            //Answer[] ans =  // создаём массив примеров ответов
            //{
            //    new("Ryan Gosling"),
            //    new("Sokov Yaroslav"),
            //    new("Ivan Ivanov"),
            //    new("Chikatillo"),
            //    new("Jesus"),
            //    new("Keanu Reeves"),
            //    new("Katy Perry"),
            //    new("Nile Red"),
            //    new("myself")
            //};

            //string[] answers = new string[55];

            //for (int i=0; i < answers.Length; i++) // создаём и рандомно заполняем массив ответов людей на опрос
            //{
            //    int personIndex = rand.Next(ans.Length);
            //    answers[i] = ans[personIndex].person;
            //    ans[personIndex].count++; // увеличиваем счётчик ответов для человека с добавленным именем
            //}

            //for (int i = 0; i < ans.Length; i++) // считаем и записываем доли ответов
            //{
            //    ans[i].count *= (double)100 / (double)answers.Length;
            //}

            //int index = 0;
            //while (index < ans.Length) // сортируем массив возможных ответов по долям
            //{
            //    if (index == 0)
            //        index++;
            //    if (ans[index].count <= ans[index - 1].count)
            //        index++;
            //    else
            //    {
            //        Answer temp = ans[index];
            //        ans[index] = ans[index - 1];
            //        ans[index - 1] = temp;
            //        index--;
            //    }
            //}

            //double sum = 0;
            //for (int i = 0; i < ans.Length; i++) // считаем и записываем доли ответов
            //{
            //    sum += ans[i].count;
            //}

            //for (int i = 1; i<=5; i++) // считаем и записываем доли ответов
            //{
            //    Console.WriteLine($"\n{i}) Person: {ans[i].person}\nPercent: {Math.Round(ans[i].count, 2)}");
            //}

            #endregion

            #region Task_4

            //Random rand = new Random();
            //Sportsman[] sportsmen = new Sportsman[30];

            //for (int i=0; i<sportsmen.Length; i++) // создаём и заполняем массив спортсменов
            //{
            //    sportsmen[i] = new Sportsman([rand.Next(20) + rand.NextDouble(), rand.Next(20) + rand.NextDouble()]);
            //}

            //int index = 0;
            //while (index < sportsmen.Length) // сортируем массив спортсменов по лучшему результату
            //{
            //    if (index == 0)
            //        index++;
            //    if (sportsmen[index].bestResult <= sportsmen[index - 1].bestResult)
            //        index++;
            //    else
            //    {
            //        Sportsman temp = sportsmen[index];
            //        sportsmen[index] = sportsmen[index - 1];
            //        sportsmen[index - 1] = temp;
            //        index--;
            //    }
            //}

            //for (int i =0; i<sportsmen.Length; i++) // выводим отсортированные результаты
            //{
            //    Console.WriteLine($"\nplace #{i + 1}, result: {Math.Round(sportsmen[i].bestResult, 2)}");
            //}

            #endregion

            #endregion

            #region Level 2

            #region Task_4

            //Random rand = new Random();
            //Jumper[] jumpers = new Jumper[] // создаём массив прыгунов
            //{
            //    new("John"),
            //    new("Billy"),
            //    new("Carry"),
            //    new("Andrey"),
            //    new("Svetlana"),
            //    new("Pavel"),
            //    new("Liam"),
            //    new("Stanley"),
            //    new("Irina")
            //};

            //double[] difficulty = new double[6];
            //for (int i = 0; i < difficulty.Length; i++) // заполняем массив коэффициентов сложности прыжка
            //{
            //    difficulty[i] = rand.Next(2, 4) + rand.Next(5, 10) / 10;
            //}

            //for (int i = 0; i < jumpers.Length; i++) // вносим оценки каждого спортсмена в массиве
            //{
            //    double[] finalGrades = new double[4]; // массив для финальных оценок за прыжки

            //    for (int k = 0; k < finalGrades.Length; k++) // вычисляем финальную оценку для каждого прыжка
            //    {
            //        List<double> grades = new List<double>();
            //        for (int m = 0; m < 7; m++) grades.Add(rand.Next(7)); // заполняем массив оценок судей

            //        // вычисляем финальную оценку за этот прыжок
            //        double dif = difficulty[rand.Next(difficulty.Length)];
            //        finalGrades[k] = (grades.Sum() - grades.Max() - grades.Min()) * dif;
            //    }

            //    jumpers[i].grade = finalGrades.Sum(); // вносим спорсмену его финальную оценку
            //}

            //int index = 0;
            //while (index < jumpers.Length) // сортируем массив спортсменов финальной оценке
            //{
            //    if (index == 0)
            //        index++;
            //    if (jumpers[index].grade <= jumpers[index - 1].grade)
            //        index++;
            //    else
            //    {
            //        Jumper temp = jumpers[index];
            //        jumpers[index] = jumpers[index - 1];
            //        jumpers[index - 1] = temp;
            //        index--;
            //    }
            //}

            //for (int i=0; i<jumpers.Length; i++) // выводим результаты и места спортсменов
            //{
            //    Console.WriteLine($"\nplace #{i+1}, Name: {jumpers[i].name}\nResult: {jumpers[i].grade}");
            //}

            #endregion

            #region Task_5



            #endregion

            #endregion
        }

    }
}
