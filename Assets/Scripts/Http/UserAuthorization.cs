using System;
using UnityEngine.Serialization;

namespace ArkanoidApi.Contracts
{
    [Serializable]
    public class UserAuthorization
    {
        public int id;
        public string name;
        public string login;
        public string password;
        public int balance;
        public string selectedSkin;
        public string property;
        public string Token;
    }
}