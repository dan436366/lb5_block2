using System;
using System.Text;
using System.Linq;

namespace struct_lab_student
{
    public struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            // TODO   you SHOULD IMPLEMENT constructor with exactly this signature
            // lineWithAllData is string contating all data about one student, as described in statement
            string[] data = lineWithAllData.Trim().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            surName = data[0];
            firstName = data[1];
            patronymic = data[2];
            sex = Convert.ToChar(data[3]);
            dateOfBirth = data[4];
            mathematicsMark = Convert.ToChar(data[5]);
            physicsMark = Convert.ToChar(data[6]);
            informaticsMark = Convert.ToChar(data[7]);
            scholarship = Convert.ToInt32(data[8]);

        }

    }
}
