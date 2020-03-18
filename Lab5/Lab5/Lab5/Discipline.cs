using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    [Serializable]
    public class Lector
    {
        public Lector()
        {
        }

        public Lector(string pulpit, string fullName)
        {
            this.pulpit = pulpit;
            FullName = fullName;
        }

        public string pulpit { get; set; }
        public string FullName { get; set; }
    }

    [Serializable]
    public class Discipline
    {
        public Discipline()
        {
        }

        public Discipline(string title, int semester, int course, string specialty, int quantityOfLectures, int quantityOfLabs, string typeOfControl)
        {
            Title = title;
            this.semester = semester;
            this.course = course;
            this.specialty = specialty;
            this.quantityOfLectures = quantityOfLectures;
            this.quantityOfLabs = quantityOfLabs;
            this.typeOfControl = typeOfControl;
        }

        public Discipline(string title, int semester, int course, string specialty, int quantityOfLectures, int quantityOfLabs, string typeOfControl, Lector dLector)
        {
            Title = title;
            this.semester = semester;
            this.course = course;
            this.specialty = specialty;
            this.quantityOfLectures = quantityOfLectures;
            this.quantityOfLabs = quantityOfLabs;
            this.typeOfControl = typeOfControl;
            DLector = dLector;
        }


        public string Title { get; set; }
        public int semester { get; set; }
        public int course { get; set; }
        public string specialty { get; set; }
        public int quantityOfLectures { get; set; }
        public int quantityOfLabs { get; set; }
        public string typeOfControl { get; set; }
        public Lector DLector = new Lector();

        public override string ToString()
        {
            if (DLector.FullName == "" || DLector.FullName == null)
                return "Title :" + Title + "\n" +
                    "Course :" + course + "\n" +
                    "Semester :" + semester + "\n" +
                    "Specialty :" + specialty + "\n" +
                    "Lectures :" + quantityOfLectures + "\n" +
                    "Labs :" + quantityOfLabs + "\n";
            else
                return "Title :" + Title + "\n" +
                "Course :" + course + "\n" +
                "Semester :" + semester + "\n" +
                "Specialty :" + specialty + "\n" +
                "Lectures :" + quantityOfLectures + "\n" +
                "Labs :" + quantityOfLabs + "\n" +
                "Lector name :" + DLector.FullName + "\n" +
                "Lector pulpit :" + DLector.pulpit + "\n";
        }
    }
}
