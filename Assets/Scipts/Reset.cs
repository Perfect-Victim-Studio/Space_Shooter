using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main_Game");
    }
}
