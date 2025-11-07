using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Toshmatovv.Classes
{
    using System.Collections.Generic;

    namespace Constructors.Classes
    {
        public class RepoStudents
        {
            public static List<Student> AllStudents()
            {
                {
                    List<Student> allStudents = new List<Student>();

                    allStudents.Add(new Student("Болотов", "Евгений", "Олегович"));
                    allStudents.Add(new Student("Григорьев", "Роман", "Владимирович"));
                    allStudents.Add(new Student("Гудков", "Георгий", "Константинович", false, 3));
                    allStudents.Add(new Student("Исипова", "Алёна", "Александровна", true));
                    allStudents.Add(new Student("Мутин", "Павел", "Алексеевич", false, 3));
                    allStudents.Add(new Student("Ишимов", "Виктор", "Алексеевич"));
                    allStudents.Add(new Student("Калюжный", "Артём", "Евгеньевич"));
                    allStudents.Add(new Student("Кусакина", "Полина", "Олеговна", true));
                    allStudents.Add(new Student("Ленченков", "Александр", "Дмитриевич"));
                    allStudents.Add(new Student("Лекникова", "Мария", "Михайловна", true));
                    allStudents.Add(new Student("Лихачева", "Татьяна", "Яковлевна"));
                    allStudents.Add(new Student("Мокрушина", "Надежда", "Владимировна", true));
                    allStudents.Add(new Student("Мутагаров", "Даниил", "Ринатович"));
                    allStudents.Add(new Student("Нарюжный", "Данил", "Владислович"));
                    allStudents.Add(new Student("Никонов", "Арсений", "Дмитриевич", false, 3));
                    allStudents.Add(new Student("Оборин", "Даниил", "Артёмович"));
                    allStudents.Add(new Student("Посадских", "Дарья", "Андреевна"));
                    allStudents.Add(new Student("Сторожев", "Денис", "Романович", true));
                    allStudents.Add(new Student("Суслов", "Егор", "Владимирович"));
                    allStudents.Add(new Student("Токмаков", "Даниил", "Сергеевич", true));
                    allStudents.Add(new Student("Тронин", "Александр", "Владиславович"));
                    allStudents.Add(new Student("Халилов", "Дамир", "Ринатович"));
                    allStudents.Add(new Student("Шестаков", "Дмитрий", "Андреевич"));

                    return allStudents;
                }
            }
        }
    }
}