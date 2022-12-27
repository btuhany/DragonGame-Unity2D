using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIs
{
    public class MenuCanvas : MonoBehaviour
    {
       public void ExitButtonClick()
       {
            GameManager.Instance.ExitGame();
       }
       public void StartButtonClick()
       {
            GameManager.Instance.StartGame();
       }
    }
}

