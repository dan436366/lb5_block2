using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill data inside array of Student            

            string[] lines = File.ReadAllLines(fileName);
            Student[] students = new Student[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                // \s+ - це регулярний вираз який вiдповiдає одному або декiльком пропусковим символам
                string line = Regex.Replace(lines[i], "\\s+", " ");
                students[i] = new Student(line);
            }
            return students;
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");

            int numOfName;

            do
            {
                Console.WriteLine("Введiть номер студента 1(Krasilnikov), 2(Popilevych), 3(Zaichuk) або 0, щоб закрити консоль");
                numOfName = int.Parse(Console.ReadLine());

                switch (numOfName)
                {
                    case 1:
                        Krasilnikov.runMenu(studs);
                        break;

                    case 2:
                        Popilevych.runMenu(studs);
                        break;

                    case 3:
                        Zaichuk.runMenu(studs);
                        break;

                    case 0:
                        Console.WriteLine("Натиснiть ентер ще раз");
                        break;

                    default:
                        Console.WriteLine("Введiть число з перелiчених");
                        break;
                }
            } while (numOfName != 0);

        }
    }
}