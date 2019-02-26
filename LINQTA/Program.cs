﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQTA
{
    class Program
    {
        static void Main(string[] args)
        {
            
       
		List<Student> students = new List<Student>();
		
		students.Add(new Student("Chris", "123-456-7891", "123 Delany", -2990));
		students.Add(new Student("Kevin", "512-222-2222", "435 Carolyn", -2500));
		students.Add(new Student("Victoria", "512-827-8498", "701 Brazos St", 0));
		students.Add(new Student("Luke", "555-555-5555", "451 Brody Ln", -500));
		
       IEnumerable <Student> negBalance =
        from student in students
        where student.Balance < 0
        select student;

		foreach(Student s in negBalance)
        {
            Console.WriteLine(s.Balance);
        }
		
        }
    }
}
