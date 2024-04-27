using System;

namespace Lab9_10CharpT {
    public class Employee : ICloneable
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            string fullName = $"{LastName} {FirstName} {MiddleName}";
            string genderText = Gender == "Male" ? "male" : "female";
            return $"{fullName}, {genderText}\n{Age} y.o. \nSalary: {Salary}$\n";
        }
    }
}