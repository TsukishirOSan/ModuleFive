using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Module Five Assignment

In this assignment, you need to convert your objects for the application into class files.   Create a class file for:

A Student
A Teacher
A UProgram (C# uses Program as the name of the class that contains Main() so we must use a different class name here)
A Degree
A Course
Transfer the variables you created in Module 1 into these class files.  Ensure that you encapsulate
 your member variables in the class files using properties.

The Course object should contain
 * an array of Student objects so ensure that you create 
 * an array inside the Course object to hold Students as well as
 * an array to contain Teacher objects as each course may have more than one teacher or TAs.
 
 For this assignment,
  * create arrays of size 3 for students and the same for teachers.
  * The UProgram object should be able to contain degrees and the degrees should be able to contain courses
as well but for the purposes of this assignment,
  * just ensure you have a single variable in UProgram to hold
a Degree and single variable in Degree to hold a Course.  

Use this diagram as an example of how the objects relate to each other.

Class diagram showing the Program, Degree, Course, Student, and Teacher classes in a hiearchy where
a Program is at the top, and contains Degrees which in turn contain Courses, which include students and teachers.

--Add a static class variable to the Student class to track the number of students currently enrolled in a school. 
--Increment a student object count every time a Student is created.

  *In the Main() method of Program.cs:

--Instantiate three Student objects.
--Instantiate a Course object called Programming with C#.
--Add your three students to this Course object.
--Instantiate at least one Teacher object.
--Add that Teacher object to your Course object
--Instantiate a Degree object, such as Bachelor.
--Add your Course object to the Degree object.
--Instantiate a UProgram object called Information Technology.
--Add the Degree object to the UProgram object.
--Using Console.WriteLine statements, output the following information to the console window:
--The name of the program and the degree it contains
--The name of the course in the degree
--The count of the number of students in the course.
--Your output should look similar to this:

Console window showing the output from the program code
 * */


namespace ModuleFive
{
    class CreateClassesInfo
    {
        static void Main(string[] args)
        {
            

            var student1 = new Student("Faïza", "Harbi", "faiza.harbi@mic.edu", new DateTime(1982, 3, 6), "797 code Avenue",
                "Residence bar", "Montpellier", "Hérault", "34070", "FRANCE", 'F', 3.9f, 100.02m, 4);
            List<Student> students = new List<Student>();
            students.Add(student1);
            
            var student2 = new Student("Ivan", "Joule", "ivan.joule@foo.edu", new DateTime(1982, 9, 24), "2 Main Street",
                    "", "Stropia", "", "0407", "MACEDONIA", 'M', 3.8f, 500.60m, 3);
            students.Add(student2);
            
            var student3 = new Student("Ana", "Blake", "ana.blake@foo.edu", new DateTime(1989, 4, 17), "24 Bazinga Road", "Residence Cooper", "Moscow", "", "101000", "RUSSIA",
                    'F', 3.9f, 300.20m, 3);
            students.Add(student3);

            int c = Student.Counter;
            
            var teacher1 = new Teacher("Julien", "Mazet", "julien.mazet@cs.mic.edu", new DateTime(1981, 3, 7), "33 Oxford Street",
                "Building 50", "Cambridge", "MA", "3143",
                "USA", 'M', "Computer Science DEV204", 80);
            
            var teachers = new List<Teacher>();
            teachers.Add(teacher1);

            var course1 = new Course("Programming with C#", "Computer Science DEV204", 80);
            var courses = new List<Course>();
            courses.Add(course1);

            var degree1 = new Degree("Bachelor Of Science", "Computer Science", 80, courses);
            var degrees = new List<Degree>();
            degrees.Add(degree1);

            var uprogram1 = new UProgram("Information Technology", "Dean Winchester", degrees);
            
            WriteProgramInfo(uprogram1, courses);
            Console.WriteLine("Press a key to continue.....");
            Console.ReadKey();
        }
        
        private static void WriteProgramInfo(UProgram uprogram1, List<Course> courses)
       {
            
            try
            {
                var deg = uprogram1.UDegreesProposed.First();
                var crse = courses.First().Cname;
                Console.WriteLine("The {0} contains the {1} degree.{2}", uprogram1.Uname, deg.Dname, Environment.NewLine); 
                Console.WriteLine("The {0} degree contains the course {1}.{2}", deg.Dname, crse, Environment.NewLine);
                Console.WriteLine("The {0} course contains {1} student(s).{2}", crse, Student.Counter, Environment.NewLine);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Invalid type operation", ioe.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("No input", ane.Message);
            }
        }

        #region dedicated to the abstract class Person inherited by the classes Student and Teacher
        abstract internal class Person
        {
            
            // this is the type of the encapsulated getter setter related to the first name
            private string first;
            public string First
            {
                get
                {
                    return first;
                }
                set
                {
                    if(value != null)
                        first = value;
                }
            }
           
            // this is the type of the encapsulated getter setter related to the last name same for below
            private string last;
            public string Last
            {
                get
                {
                    return last;
                }
                set
                {
                    if(value != null)
                        last = value;
                }
            }
            
            private string email;
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    if(value != null)
                        email = value;
                }
            }
            
            private DateTime birthdate;
            
            public DateTime Birthdate
            { 
                get
                {
                    return birthdate;
                }
                    
                private set
                {
                    if(value != null)
                        birthdate = value;
                }       
            }
                              

            private string addressLine1;
            public string AddressLine1
            { 
                get
                {
                       return addressLine1;
                }
                set
                {
                    if(value != null)
                        addressLine1 = value;
                }
            }

            private string addressLine2;
            public string AddressLine2
            {
                get
                {
                        return addressLine2;
                }
                set
                {
                    if(value != null)
                        addressLine2 = value;
                }
            }

            private string city;
            public string City 
            { 
                get
                {
                       return city;
                }
                private set
                {
                    if(value != null)
                        city = value;
                }
            }
           
            private string stateOrProvince;
            public string StateOrProvince
            {
                get
                {
                    return stateOrProvince;
                }
                set
                {
                    if(value != null)
                        stateOrProvince = value;
                }
            }

            private string zipPostal;
            public string ZipPostal
            {
                get
                {
                    return zipPostal;
                }
                set
                {
                    if(value != null)
                        zipPostal = value;
                }
            }

            private string country;
            public string Country
            {
                get
                {
                    return country;
                }
                set
                {
                    if(value != null)
                        country = value;
                }
            }
            
            private char gender;
            public char Gender
            {
                get
                {
                    return gender;
                }
                set
                {
                    if(value != '\0')
                        gender = value;
                }
            }
           
            internal Person(string first, string last, string email, DateTime birthdate, string addressLine1, 
                string addressLine2, string city, string stateOrProvince, string zipPostal,
                string country, char gender)
            {
                this.First = first;
                this.Last = last;
                this.Email = email;
                this.Birthdate = birthdate;
                this.AddressLine1 = addressLine1;
                this.AddressLine2 = addressLine2;
                this.City = city;
                this.StateOrProvince = stateOrProvince;
                this.ZipPostal = zipPostal;
                this.Country = country;
                this.Gender = gender;
            }

            public override string ToString()
            {
 	            return String.Format("{0}{1} {2}",Environment.NewLine, First, Last);
            }


        }
        #endregion
        //create and initialize the number of students counter
        #region dedicated to the class Student
        internal class Student: Person
        {
            private static int counter = 0;
            public static int Counter
            {
                get
                {
                    return counter;
                }
                set 
                { 
                    counter = value; 
                }
            }

            private float OverallGPA;
            public float overallGPA
            {
                get
                {
                    return OverallGPA;
                }
                set
                {
                    if(value > 0.0)
                        OverallGPA = value;
                }
            }

            private Decimal AccountBalance;
            public Decimal accountBalance
            {
                get
                {
                    return AccountBalance;
                }
                set
                {
                    AccountBalance = value;
                }
            }

            private int NumCoursesTaken;
            public int numCoursesTaken
            {
                get
                {
                    return NumCoursesTaken;
                }
                set
                {
                    if(value >= 0)
                       this.NumCoursesTaken = value;
                }
            }
            
            internal Student(string first, string last, string email, DateTime birthdate, string addressLine1, 
                string addressLine2, string city, string stateOrProvince, string zipPostal,
                string country, char gender, float overallGPA, Decimal accountBalance, int numCoursesTaken)
            : base(first, last, email, birthdate, addressLine1, addressLine2, city, stateOrProvince,
                zipPostal, country, gender)
            {
                this.AccountBalance = accountBalance;
                this.OverallGPA = overallGPA;
                this.NumCoursesTaken = numCoursesTaken;
                // increment the number of Student instanciated
                counter++;
            }
            
            
            // override methode to output the proper fields according the class being handled
            public override string ToString()
            {
                return String.Format(
                "email: {0}{1}" +
                "Address  {2}{1}" + "{3}{1}" +
                "{4}, {5}{1}" +
                "{6}, {7}{1}{1}" +
                "------------{1}" +
                "Overall GPA: {8}{1}" +
                "Account Balance: {9}{1}" +
                "Gender: {10}{1}" +
                "Number of courses taken: {11}{1}"+
                "{1}Courses taken: {12}{1}{1}",
                Email, Environment.NewLine, AddressLine1, AddressLine2, City, StateOrProvince, ZipPostal, Country,
                overallGPA, accountBalance, Gender, numCoursesTaken
                );
            }       
        }
        #endregion

        #region Dedicated to the class Teacher
        internal class Teacher: Person
        {
            private string pField;
            public string Pfield
            {
                get
                {
                    return pField;
                }
                set
                {
                    if(value != null)
                        pField = value;
                }
            }

            private int pNumOfCourses;
            public int PnumOfCourses
            {
                get
                {
                    return pNumOfCourses;
                }
                set
                {
                    if(value > 0)
                        pNumOfCourses = value;
                }
            }
        
            internal Teacher(string first, string last, string email, DateTime birthdate, string addressLine1,
                string addressLine2, string city, string stateOrProvince, string zipPostal,
                string country, char gender, string pField, int pNumOfCourses)
                : base(first, last, email, birthdate, addressLine1, addressLine2, city, stateOrProvince,
                    zipPostal, country, gender)
            {
                this.Pfield = pField;
                this.PnumOfCourses = pNumOfCourses;
            }

        }
        #endregion

        #region Dedicated to the class Course
        internal class Course
        {
            private string cName; // i.e. "DEV204x"
            public string Cname 
            {
                get
                {
                    return cName;
                }
                set
                {
                    if(value != null)
                        cName = value;
                }
            }

            private string cField; // i.e. "Computer Science and Programming; Data processing" 
            public string Cfield
            {
                get
                {
                    return cField;
                }
                set
                {
                    if(value != null)
                        cField = value;
                }
            }
            
            private int cCredits;
            public int Ccredits
            {
                get
                {
                    return cCredits;
                }
                set
                {
                    if(value > 0)
                        cCredits = value;
                }
            }
            
            private List<Student> studentsArray = new List<Student>();

            public List<Student> getStudsList()
            {
                return studentsArray;
            }
            
            public void setStudsList(List<Student> studentsArray)
            {
                    this.studentsArray = studentsArray;
            }
            

            private List<Teacher> professorsArray = new List<Teacher>();
            
            public List<Teacher> getProfList()
            {
                return professorsArray;
            }
            
            public void setProfList(List<Teacher> professorsArray)
            {
                    this.professorsArray = professorsArray;
            }

            internal Course(string cName, string cField, int cCredits)
            {
                this.Cname = cName;
                this.Cfield = cField;
                this.Ccredits = cCredits;
            }
            
            public void addStudentToStudentsArray(Student student)
            {
                studentsArray.Add(student);
            }

            public void addProfessorToProfessorsArray(Teacher teacher)
            {
                professorsArray.Add(teacher);
            }

            
            /*public override string ToString()
            {
 	            return String.Format("{0}Course's name: {1}"+"{0}Course's Field: {2}"+"{0}Number of credits needed: {3}", Environment.NewLine,
                    Cname, Cfield, Ccredits);
            }*/
        }
        #endregion

        #region Dedicated to the class Degree
        internal class Degree
        {
            private string dName;
            public string Dname
            {
                get
                {
                    return dName;
                }
                set
                {
                    if(value != null)
                        dName = value;
                }
            }

            private string dField;
            public string Dfield
            {
                get
                {
                    return dField;
                }
                set
                {
                    if(value != null)
                        dField = value;
                }
            }
            
            private int dCredits;
            public int Dcredits
            {
                get
                {
                    return dCredits;
                }
                set
                {
                    if(value >= 0)
                        dCredits = value;
                }
            }

            private List<Course> dCourses = new List<Course>();
            public List<Course> Dcourses = new List<Course>();
            
            public List<Course> getCourseList()
            {
                return Dcourses;
            }
            public void setCourseList(List<Course> dCourses)
            {
                if(dCourses != null)
                    this.Dcourses = dCourses;
            }

            
            internal Degree(string dName, string dField, int dCredits, List<Course> dCourses)
            {
                this.Dname = dName;
                this.Dfield = dField;
                this.Dcredits = dCredits;
                this.Dcourses = getCourseList();
            }
            
            public void addCourseToDegree(Course course)
            {
                Dcourses.Add(course);
            }
            
           /* public override string ToString()
            {
                return String.Format("{0}Name of the degree: {1}" + "{0}Degree's field: {2}"+
                    "{0}Number of credits needed:  {3}"+"{0}List Of Courses: {4}", Environment.NewLine, Dname, Dfield, Dcredits, Dcourses);
            }*/
            
        }
        #endregion

        #region Dedicated to the class UProgram
        internal class UProgram
        {
            private string uName;
            public string Uname
            {
                get
                {
                    return uName;
                }
                set
                {
                    if(value != null)
                        uName = value;
                }
            }
            
            private string uDean;
            public string Udean
            {
                get
                {
                    return uDean;
                }
                set
                {
                    if(value != null)
                        uDean = value;
                }
            }
            
            private List<Degree> uDegreesProposed = new List<Degree>();
            public List<Degree> UDegreesProposed = new List<Degree>();
            List<Degree> getUDegreesProposed()
            {
                return uDegreesProposed;
            }

            public void setUDegrees(Degree degree)
            {
                UDegreesProposed.Add(degree);
            }

            public UProgram(string uName, string uDean, List<Degree> uDegreesProposed)
            {
                this.Uname = uName;
                this.Udean = uDean;
                this.UDegreesProposed = uDegreesProposed;
            }
            
    
            /*public override string ToString()
            {
 	            return String.Format("{0}University name: {1}"+"{0}University Dean: {2}"+
                    "{0}Degrees available: {3}", Environment.NewLine, Uname, Udean, UDegreesProposed);
            }*/
        }
        #endregion
    }

}
