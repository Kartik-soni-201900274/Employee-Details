using Employee_Details;
using System;
using System.Runtime.CompilerServices;

namespace Employee_Details
{
    public class EmployeeCardModel
    {
        private string _name;
        private string _gender;
        private string _email;
        private string _title;
        private string _joiningDate;
        private int _age;
        private int _experience;
        private byte[] _image;
        private string _phone;
        private string _location;
        public EmployeeCardModel(object[] row)
        {
            _name = row[1].ToString();
            _gender = row[2].ToString();
            _email = row[3].ToString();
            _title = row[4].ToString();
            _joiningDate = row[5].ToString();
            _age = int.Parse(row[6].ToString());
            _experience = int.Parse(row[7].ToString());

        }

        public EmployeeCardModel(string name, string gender, string email, string title, string joiningDate, int age, int experience, byte[] image, string phone, string location = null)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _gender = gender ?? throw new ArgumentNullException(nameof(gender));
            _email = email ?? throw new ArgumentNullException(nameof(email));
            _title = title ?? throw new ArgumentNullException(nameof(title));
            _joiningDate = joiningDate ?? throw new ArgumentNullException(nameof(joiningDate));
            _age = age;
            _experience = experience;
            _image = image;
            _phone = phone;
            _location = location;
        }



        public string Name { get => _name; set => _name = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Email { get => _email; set => _email = value; }
        public string Title { get => _title; set => _title = value; }
        public string JoiningDate { get => _joiningDate; set => _joiningDate = value; }
        public int Age { get => _age; set => _age = value; }
        public int Experience { get => _experience; set => _experience = value; }
        public byte[] Image { get => _image; set => _image = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Location { get => _location; set => _location = value; }
    }
}