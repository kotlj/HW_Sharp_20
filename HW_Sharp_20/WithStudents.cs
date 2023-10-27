using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_20
{
    internal class WithStudents
    {
        static public IEnumerable<Student> ReturnAll(Student[] students)
        {
            IEnumerable<Student> result = from student in students select student;
            return result;
        }
        static public IEnumerable<Student> Boris(Student[] students)
        {
            IEnumerable<Student> result = from student in students where student.Name.ToUpper() == "BORIS" select student;
            return result;
        }
        static public IEnumerable<Student> SN_Start_Bro(Student[] students)
        {
            IEnumerable<Student> result = from student in students where student.SecondName.StartsWith("Bro") select student;
            return result;
        }
        static public IEnumerable<Student> Nineteen(Student[] students)
        {
            IEnumerable<Student> result = from student in students where student.Age == 19 select student;
            return result;
        }
        static public IEnumerable<Student> Twenty_To_TwentyThree(Student[] students)
        {
            IEnumerable<Student> result = from student in students where student.Age > 20 && student.Age < 23 select student;
            return result;
        }
        static public IEnumerable<Student> MITStudents(Student[] students)
        {
            IEnumerable<Student> result = from student in students where student.Institut == "MIT" select student;
            return result;
        }
        static public IEnumerable<Student> OxfordNewby(Student[] students)
        {
            IEnumerable<Student> result = from student in students where student.Institut == "Oxford" && student.Age == 18
                                          orderby student.Age select student;
            result = Enumerable.Reverse(result);
            return result;
        }
    }
}
