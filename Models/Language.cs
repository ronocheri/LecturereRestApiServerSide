namespace LecturereRestApi.Models
{
    public class Language
    {
        

        public Language(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

    }
}


