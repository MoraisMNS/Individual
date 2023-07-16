using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop01
{
    public class User2
    {
        public string Nationality {get;set;}

        public string Religion { get;set;}

        public string FathersName { get;set;}

        public string MothersName { get;set;}

        public string FathersOccupation { get;set;}

        public string MothersOccupation { get; set;}

        public User2(string nationality, string religion, string fathersName, string mothersName, string fathersOccupation, string mothersOccupation)
        {
            Nationality = nationality;
            Religion = religion;
            FathersName = fathersName;
            MothersName = mothersName;
            FathersOccupation = fathersOccupation;
            MothersOccupation = mothersOccupation;
        }

        public User2()
        {

        }
    }
}
