using UnityEngine;

public class PersistanceManager : MonoBehaviour
{
    private static PersistanceManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this) { Destroy(gameObject); }
    }
}
