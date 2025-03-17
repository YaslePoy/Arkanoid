using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    private List<string> _currentProperty;
    
    private void Start()
    {
        _currentProperty = GameManager.Instance.CurrentUser.property.Split(", ").ToList();
        foreach (var property in _currentProperty)
        {
            var go = GameObject.Find(property + "Text");
            var text = go.GetComponent<TMP_Text>();
            text.text = GameManager.Instance.CurrentUser.selectedSkin == property ? "Уже одето" : "Одеть";
        }

        var balance = GameObject.Find("BalanceText").GetComponent<TMP_Text>().text =
            GameManager.Instance.CurrentUser.balance.ToString();
    }

    public void GoBack()
    {
        SceneManager.LoadScene(3);
    }

    public void SkinClick(string parameter)
    {
        var split = parameter.Split(',');
        var id = split[0];
        var cost = int.Parse(split[1]);

        if (GameManager.Instance.CurrentUser.selectedSkin == id)
            return;
        
        if (!_currentProperty.Contains(id))
        {
            if (GameManager.Instance.CurrentUser.balance < cost)
                return;

            _currentProperty.Add(id);
            
            GameManager.Instance.CurrentUser.balance -= cost;
            GameManager.Instance.CurrentUser.property = string.Join(", ", _currentProperty);
        }

        GameManager.Instance.CurrentUser.selectedSkin = id;
        Start();
        StartCoroutine(Api.UpdateUser());
    }
}