using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UserAuthorization = ArkanoidApi.Contracts.UserAuthorization;

namespace DefaultNamespace
{
    public class Api
    {
        private const string ApiPath = "http://localhost:5251/api/";
        
        public static IEnumerator GetUser(string login, string password, Action<UserAuthorization> successCallback, Action failureCallback)
        {
            using UnityWebRequest uwr = UnityWebRequest.Get($"{ApiPath}users/authorize?login={login}&password={password}");
            yield return uwr.SendWebRequest();
            switch (uwr.result)
            {
                case UnityWebRequest.Result.Success:
                    successCallback(JsonUtility.FromJson<UserAuthorization>(uwr.downloadHandler.text));
                    break;
                default:
                    failureCallback();
                    break;
            }
        }
    }
}