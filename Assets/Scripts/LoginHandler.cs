using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LoginHandler : MonoBehaviour
{
    public TextField LoginField;
    public TextField PassowrdField;
    public void OnLogin()
    {
        var login = LoginField.text;
        var pass = PassowrdField.text;
        
        
    }
}
