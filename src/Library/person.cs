namespace Library
{

    public class Person : Visitor
    {
        private string _name;
        private int _age;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
        private string _surname;
        public string surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _surname = value;
                }
            }
        }


        public Person(string name, string surName, int age)
        {
            this.name = name;
            this.surname = surName;
            this.age = age;
        }
    }
}
