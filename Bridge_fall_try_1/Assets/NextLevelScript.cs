using UnityEngine;
using TMPro;
public class NextLevelScript : MonoBehaviour
{
    public GameManager NextLevel;

    public void ButtonPress()
    {
        print("Button pressed");
        NextLevel.NextGame();
    }
 
}
