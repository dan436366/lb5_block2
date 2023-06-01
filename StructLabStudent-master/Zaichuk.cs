using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace struct_lab_student
{
    public partial class Zaichuk
    {
        public static void runMenu(Student[] studs)
        {
            int increased = 2980;
            string newfile = "data_new.txt";
            string[] output = new string[studs.Length];
            bool ischange = false;
            for (int i = 0; i < studs.Length; i++)
            {
                Student student = studs[i];

                if (student.mathematicsMark == '5' &&
                    student.physicsMark == '5' &&
                    student.informaticsMark == '5')
                {
                    ischange = true;
                    student.scholarship = increased;
                }
                output[i] = $"{student.ToString()}";
            }
            Console.WriteLine(ischange ? "Данi змiнено" : "Переписались початковi данi");
            File.WriteAllLines(newfile, output);
        }
    }
}
