using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VisualNovel
{
    public class MapManager : MonoBehaviour
    {
        public static MapManager m_Instance;
        private static int m_CurrentRoomID;

        [Header("Rooms and Scenes")]
        public string EastScene = "East";
        public string WestScene = "West";

        private void Awake()
        {
            m_Instance = this;
            DontDestroyOnLoad(this);
        }

        public void LoadEastSpace()
        {
            SceneManager.LoadScene(EastScene);
        }

        public void SetPlayerRoom(int r_target)
        {
            m_CurrentRoomID = r_target;
        }

    }
}