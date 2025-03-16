namespace ArkanoidApi.Model
{
    public class User : DbEntity
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public string Property { get; set; }
    }
}