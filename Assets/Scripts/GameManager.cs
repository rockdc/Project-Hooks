using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //making GameManager a Singleton
    public static GameManager  instance;

    [Header("Global Access ")]
    public ConnonManager ConnonManager;
    public PersonProjectileManager PersonProjectileManager;

    private void Awake()
    {
        // Checks if there more then one instance if so destroy one of them
        if (instance != null && instance != this)
        {
            Destroy(instance.gameObject);
            instance = this;
            DontDestroyOnLoad(instance.gameObject);
        }
        else
        {
            instance = this;
            //do not destroy gameMannager on load of next level
            DontDestroyOnLoad(instance.gameObject);
        }
    }

    private void Start()
    {
        instance = this;
    }


}
