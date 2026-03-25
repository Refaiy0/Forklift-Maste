using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject winScreen;
    public GameObject GameOverScreen;

    public TextMeshProUGUI numTxt;

    public GameObject Vehicle;
    public GameObject ForkController;

    public GameObject ParticleWin;

    public float timer;
    private bool gameEnd;

    private void Awake()
    {
        instance = this;

    }

    private void Update()
    {
        Timer();
    }

    public void WinScreen() 
    {   
        gameEnd = true;
      winScreen.SetActive(true);
      AudioManager.instance.WinSound();
   

       Vehicel_Off();
       Fork_Off();
       Particles_On();
       Debug.Log("Win");
    }

    public void gameOverScreen()
    {
            GameOverScreen.SetActive(true);
            AudioManager.instance.GameOverSound();
            Vehicel_Off();
            Fork_Off();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        winScreen.SetActive(false);
        GameOverScreen.SetActive(false);
        Vehicel_on();
        Fork_on();
        Particles_Off();
    }
    public void Timer()
    {
        if (gameEnd) return;
        numTxt.text = Mathf.RoundToInt(timer).ToString();
        if (timer >= 0f)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0f)
        {
            gameOverScreen();
        }
    }


    public void Vehicel_Off()
    {
        Vehicle.GetComponent<Vehicle>().enabled = false;
    }
    public void Fork_Off()
    {
        ForkController.GetComponent<ForkController>().enabled = false;

    }



    public void Vehicel_on()
    {
        Vehicle.GetComponent<Vehicle>().enabled = true;
    }
    public void Fork_on()
    {
        ForkController.GetComponent<ForkController>().enabled = true;

    }


    
    public void Particles_On()
    {
        ParticleWin.SetActive(true);
    }
    public void Particles_Off()
    {
        ParticleWin.SetActive(false);
    }


    







}
