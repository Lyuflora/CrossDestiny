using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VisualNovel{
    public class GameManager : MonoBehaviour
    {
        public void StartButtonOnClick()
        {
            SceneManager.LoadScene("Main");
        }
        public void CreditButtonOnClick()
        {
            // todo
        }
    }
}