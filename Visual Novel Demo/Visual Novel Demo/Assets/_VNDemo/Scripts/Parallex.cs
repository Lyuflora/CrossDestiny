using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisualNovel
{
    public class Parallex : MonoBehaviour
    {
        public Vector3 pz;
        public Vector3 StartPos;

        public float moveModifier;
        public bool moveReverse;

        // Use this for initialization
        void Start()
        {
            StartPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 pz = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            pz.z = 0;
            gameObject.transform.position = pz;
            Debug.Log("Mouse Position: " + pz);

            if(!moveReverse)
                transform.position = new Vector3(StartPos.x + (pz.x * moveModifier), StartPos.y + (pz.y * moveModifier), 0);
            else
                transform.position = new Vector3(StartPos.x - (pz.x * moveModifier), StartPos.y - (pz.y * moveModifier), 0);
            //move based on the starting position and its modified value.
        }
    }
}