namespace publicAccessModifier
{
    class Student
    {

        // Declaring members rollNo 
        // and name as public 
        public int rollNo;
        public string name;

        // Constructor 
        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        // methods getRollNo and getName 
        // also declared as public 
        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }
}
