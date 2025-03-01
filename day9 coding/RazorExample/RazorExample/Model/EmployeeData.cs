namespace RazorExample.Model
{
    public class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public EmployeeData(int id, string name, string gender, string address)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Address = address;
        }
    }
}
