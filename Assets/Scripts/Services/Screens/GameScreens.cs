
using UnityEngine.UI;
using UnityEngine;

public class GameScreens : MonoBehaviour
{
    
        [SerializeField] private GameObject _winScreen;

          public void ShowWinScreen()
        {
            _winScreen.SetActive(true);
        }

}
