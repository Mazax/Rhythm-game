using UnityEngine;
using System.Collections;

    public class SpawnController2: MonoBehaviour
    {
        public Object prefab;
        GameObject clone;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CreateNote()
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }

