using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LoginHandler : MonoBehaviour
{
    
    public TMP_InputField LoginField;
    public TMP_InputField PassowrdField;
    public void OnLogin()
    {
        var login = LoginField.text;
        var pass = PassowrdField.text;

        StartCoroutine(Api.GetUser(login, pass, authorization =>
        {
            Debug.Log("Authorized");
            GameManager.Instance.CurrentUser = authorization;
            SceneManager.LoadScene(3);
        }, () =>
        {
            Debug.Log("Incorrect auth data");
        }));
    }
}
