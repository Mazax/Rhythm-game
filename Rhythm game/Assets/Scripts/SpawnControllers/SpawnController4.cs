using UnityEngine;
using System.Collections;
using SynchronizerData;

    public class SpawnController4 : MonoBehaviour
    {

		private BeatObserver beatObserver;
        
		public Object prefab;
        GameObject clone;

        // Use this for initialization
        void Start()
        {
			beatObserver = GetComponent<BeatObserver>();
        }

        // Update is called once per frame
        void Update()
        {
		if ((beatObserver.beatMask & BeatType.OnBeat) == BeatType.OnBeat) {
			CreateNote ();
		}
	}

        public void CreateNote()
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }

