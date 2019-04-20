using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Talalaykina.Task2_1_
{
    class Employee : User
    {//work experience position
        private int _workExperience;
        private string _position;
        
        public Employee(string secondName, string name, string patronymic, DateTime dateOfBirth, int age, int workExperience, string position) : 
            base(secondName, name, patronymic, dateOfBirth, age)
        {
            _workExperience = workExperience;
            _position = position;
        }
        public int WorkExperience
        {
            get
            {
                return _workExperience;
            }
            set
            {
                _workExperience = value;
            }
        }
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $" Work Experience: {WorkExperience} | Position: {Position}";
        }
    }
}
