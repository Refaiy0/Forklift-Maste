using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip menuClip;
    void Start()
    {
        AS.PlayOneShot(menuClip,1);
    }

    void Update()
    {
        
    }


    public void StartJop() 
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame() 
    {
        Application.Quit();
        Debug.Log("exit");
    
    }

}
