using System.Collections;
using UnityEngine.Networking;

namespace DefaultNamespace
{
    public class Api
    {
        public const string ApiPath = "http://localhost:5000/api";
        
        public static IEnumerator GetUser(string login, string password)
        {
            using (UnityWebRequest uwr = UnityWebRequest.Get($"{ApiPath}users/{}"))
            {
                yield return uwr.result;
            }
        }
    }
}