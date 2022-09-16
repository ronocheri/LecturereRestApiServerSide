namespace LecturereRestApi.Models
{
    public class Lecturer
    {
        public Lecturer(int id, string name, string? email, List<Language>? languages)
        {
            Id = id;
            Name = name;
            Email = email;
            Languages = languages;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string? Email { get; set; }

        public List<Language>? Languages{ get; set; }
    }
}