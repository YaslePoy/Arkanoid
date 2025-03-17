using ArkanoidApi.Model;
using UnityEngine;
using UserAuthorization = ArkanoidApi.Contracts.UserAuthorization;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public UserAuthorization CurrentUser;
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else
            Destroy(gameObject);
    }
}
