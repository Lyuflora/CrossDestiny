using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisualNovel { 
public class BlockerManager : MonoBehaviour
{
        public static BlockerManager m_Instance;
        public Blocker[] m_BlockerArrays;
        private void Awake()
        {
            m_Instance = this;
        }
        public void GenerateBlockers()
        {
                for (int i = 0; i < 3; i++)
                {
                    Debug.Log("Generate Blocker: " + i);
                }
            
        }
        public void ClearBlocks()
        {
                Debug.Log("Clear Blocker");
        }
}
}
