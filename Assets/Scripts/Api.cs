using System;
using System.Collections;
using System.Web;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UserAuthorization = ArkanoidApi.Contracts.UserAuthorization;

namespace DefaultNamespace
{
    public class Api
    {
        private const string ApiPath = "http://localhost:5251/api/";

        public static IEnumerator GetUser(string login, string password, Action<UserAuthorization> successCallback,
            Action failureCallback)
        {
            using UnityWebRequest uwr =
                UnityWebRequest.Get($"{ApiPath}users/authorize?login={login}&password={password}");
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

        public static IEnumerator UpdateUser()
        {
            
            using (var request = UnityWebRequest.Put(
                       $"{ApiPath}users/{GameManager.Instance.CurrentUser.id}?score={GameManager.Instance.CurrentUser.balance}&property={HttpUtility.UrlEncode(GameManager.Instance.CurrentUser.property)}&selected={HttpUtility.UrlEncode(GameManager.Instance.CurrentUser.selectedSkin)}", string.Empty))

            {
                yield return request.SendWebRequest();
            }
        }
    }
}