using TMPro;
using UnityEngine;

public class Box : MonoBehaviour
{
    public TextMeshProUGUI Txt;

    private static int countBoxes;
    public int totalBoxes = 3;
    private bool isCounted;


    private void Start()
    {
        countBoxes = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WinArea") & !isCounted )// is not Counted
        {
            if ( totalBoxes > countBoxes) 
            {
                
              AddBox();
              AudioManager.instance.BoxSound();
              isCounted = true;
              Debug.Log("box");
            }
          
        }
    }

    public void AddBox()
    {

        countBoxes++;
        Txt.text = countBoxes + "/" + totalBoxes;

        if (countBoxes == 3)
        {
            GameManager.instance.WinScreen();
            countBoxes = 0;
        }

    }

}
