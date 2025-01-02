using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.ClassesDemo.Classes.PersonDemo;

namespace PersonDemo
{
    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            _idNumber = "STU-"+ RandomNumberGenerator.GetInt32(10000,999999).ToString();
        }
    }
}