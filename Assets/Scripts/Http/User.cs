using System;

namespace ArkanoidApi.Model
{
    [Serializable]
    public class User : DbEntity
    {
        public string Name;
        public string Login;
        public string Password;
        public int Balance;
        public string SelectedSkin;
        public string Property;
    }
}