// See https://aka.ms/new-console-template for more information
using School_Teachers_Students;

#region Teachers Details

Teacher lecturer = new Teacher() { FullName = "Jacob Richard" };
Console.WriteLine(lecturer.FullName);
Console.WriteLine();

#endregion

#region Student details

Student std = new Student() { Gender = "Male", Age = 11, FullName = "Edoghotu Gideon" };
std.GetDetails();
Console.WriteLine();

#endregion


#region School Details

School sch = new School() { NameOfSchool = "Uniport" };
sch.AdmitStudent(std);
sch.EmployTeacher(lecturer);
sch.PaySalary(50000, lecturer);

sch.GetDetails();
Console.WriteLine();

#endregion