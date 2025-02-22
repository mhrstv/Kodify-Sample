namespace SampleApp.Models
{
    public class Person
    {
        private string _id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address HomeAddress { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}