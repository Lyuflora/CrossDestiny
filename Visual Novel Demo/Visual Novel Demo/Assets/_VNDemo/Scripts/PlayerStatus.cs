using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisualNovel {
public class PlayerStatus : MonoBehaviour
{
        public static PlayerStatus m_Instance;
        private int m_Strength;
        private float m_Luck;

        private void Awake()
        {
            m_Instance = this;
            DontDestroyOnLoad(this);
        }

        public int GetStrength()
        {
            return m_Strength;
        }

        public float GetLuck()
        {
            return m_Luck;
        }
}
}