using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Persona
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public int Lanzar()
        {
            Random Roll = new Random();
            int Resp;
            Resp = Roll.Next(0, 3);
            return Resp;
        }

        public Persona(string Name, string LastName)
        {
            this.Name = Name;
            this.LastName = LastName;

        }
        public string MyName()
        {
            return $"{Name}-{LastName}";
        }
    }
}
