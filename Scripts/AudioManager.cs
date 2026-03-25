using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Audio Source")]
    public AudioSource AudioSource;

    [Header("Win")]
    public AudioClip winClip;

    [Header("Game Over")]
    public AudioClip gameOverClip;

    [Header("Vehicle")]
    public AudioSource AS_Vehicle;
    public AudioClip VehicleClip;

  

    [Header("Boxes")]
    public AudioClip BoxClip;






    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WinSound() 
    {
        AudioSource.PlayOneShot(winClip, 1f);
        AudioSource.pitch = 1f;

    }

    public void GameOverSound()
    {
        AudioSource.PlayOneShot(gameOverClip, 1f);
        AudioSource.pitch = 1f;
    }
    public void VehicleSound(bool isMoving)
    {
        if (!AS_Vehicle.isPlaying) 
        {        
            AS_Vehicle.clip = VehicleClip;
            AS_Vehicle.Play();
            AS_Vehicle.volume = 0.03f;
            
        }

        if (!isMoving) 
        {
            AS_Vehicle.pitch = 1f;
        }
        if (isMoving) 
        {
            AS_Vehicle.pitch = 1.2f;
        }
    }

    public void BoxSound()
    {
        AudioSource.PlayOneShot(BoxClip, 1f);
        AudioSource.pitch = 1f;

    }

}
