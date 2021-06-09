namespace ASP_NET_Start.Models
{
    public class User
    {
        public User()
        {
            
        }
        public User(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Fullname => $"Name: {Name}; Lastname: {Lastname} ";
    }
}