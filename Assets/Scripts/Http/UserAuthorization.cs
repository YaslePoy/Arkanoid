using ArkanoidApi.Model;

namespace ArkanoidApi.Contracts
{
    public class UserAuthorization : User
    {
        public string Token { get; set; }
    }
}