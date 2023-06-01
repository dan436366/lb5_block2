using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_lab_student
{
    public partial class Krasilnikov
    {
        public static void runMenu(Student[] studs)
        {
            double sum = 0;
            Student student;
            double[] array = new double[studs.Length];

            Console.WriteLine("Середнє арифметичне кожного учня окремо: ");

            for (int i = 0; i < studs.Length; i++)
            {
                student = studs[i];
                if (student.mathematicsMark == '-')
                {
                    student.mathematicsMark = '2';
                }

                if (student.physicsMark == '-')
                {
                    student.physicsMark = '2';
                }

                if (student.informaticsMark == '-')
                {
                    student.informaticsMark = '2';
                }

                sum += char.GetNumericValue(student.mathematicsMark);
                sum += char.GetNumericValue(student.physicsMark);
                sum += char.GetNumericValue(student.informaticsMark);
                array[i] = (sum / 3);
                Console.WriteLine(student.surName + " = " + array[i]);
                sum = 0;
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / studs.Length;
            Console.WriteLine("Середнє арифметичне всiх учнiв = " + average);

            Console.WriteLine();

            bool pointer = false;

            Console.WriteLine("Прiзвища студентiв, середнiй бал яких бiльше, нiж загальний середнiй бал:");
            for (int j = 0; j < array.Length; j++)
            {
                student = studs[j];
                if (array[j] > average)
                {
                    pointer = true;
                    Console.WriteLine(student.surName);
                }
            }


            if (pointer == false)
            {
                Console.WriteLine("Немає жодного учня ");
            }
        }
    }
}
