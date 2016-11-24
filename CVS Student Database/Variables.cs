using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CVS_Student_Database
{
    // Program : Christian Values School Student Database
    // Author : Gino Diato | diatogino22@gmail.com
    // This class is where you can set all variables in the program

    // Connection String
    // ConString.conn : MySQL Connection String.
    // SERVER : The name of the server - 127.0.0.1 or localhost if you it is hosted in your computer.
    // Database, UID, PASSWORD - Self Explanatory. 
    public class ConString
    {
    
        public static string connectionString = "SERVER=" + "localhost" + ";"+
            "DATABASE=" +"@DATABASE HERE" + ";" +
            "UID=" + "root" + ";" +
            "PASSWORD=" + "12345" + ";";
    }


    public class Student_Info
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
    }

   public class Variables
    {

    }

 
}
