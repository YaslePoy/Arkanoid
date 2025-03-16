using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectHandler : MonoBehaviour
{
    public void LevelSelect1()
    {
        SceneManager.LoadScene(0);
    }
    
    public void LevelSelect2()
    {
        SceneManager.LoadScene(1);

    }
    
    public void LevelSelect3()
    {
        SceneManager.LoadScene(2);
    }

    public void GotoShop()
    {
        SceneManager.LoadScene(5);
    }
}
