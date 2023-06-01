using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_lab_student
{
    public partial class Popilevych
    {
        public static void runMenu(Student[] studs)
        {
            Console.WriteLine("Студенти, які здали всі предмети на \"5\":");
            bool foundStudents = false;

            for (int i = 0; i < studs.Length; i++)
            {
                Student student = studs[i];
                if (student.mathematicsMark == '5' &&
                    student.physicsMark == '5' &&
                    student.informaticsMark == '5')
                {
                    foundStudents = true;
                    Console.WriteLine($"Прізвище: {student.surName}");
                    Console.WriteLine($"Ім'я: {student.firstName}");
                    Console.WriteLine($"По батькові: {student.patronymic}");
                    Console.WriteLine($"Дата народження: {student.dateOfBirth}");
                    Console.WriteLine($"Математика: {student.mathematicsMark}");
                    Console.WriteLine($"Фізика: {student.physicsMark}");
                    Console.WriteLine($"Інформатика: {student.informaticsMark}");
                    Console.WriteLine($"Стипендія: {student.scholarship}");
                    Console.WriteLine();
                }
            }
            if (!foundStudents)
            {
                Console.WriteLine("Немає студентів, які здали всі предмети на \"5\".");
            }
        }
    }
}