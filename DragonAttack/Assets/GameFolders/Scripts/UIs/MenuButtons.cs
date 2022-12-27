using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIs
{
    public class MenuButtons : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.Instance.StartGame();
        }
        public void NoButtonClick()
        {
            Debug.Log("No button");
        }
    }
}

