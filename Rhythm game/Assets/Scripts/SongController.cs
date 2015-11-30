/*using UnityEngine;
using System.Collections;

public class SongController : MonoBehaviour {
	public double BPM = 172;
	public double beatSamples;
	public double nextBeatSamples;
 

	void Start(){
		//44100 are the sample rates, assuming your audio is in 44100hz
		beatSamples = (44100 / (BPM / 60));
		//beatSamples = 22050
		GetComponent<AudioSource>().Play();
	}
	void FixedUpdate(){
		//audio.TimeSamples will increase when the song is playing
		if (GetComponent<AudioSource>().timeSamples >= nextBeatSamples && GetComponent<AudioSource>().isPlaying) {
			//here it increases the nextBeatSamples, so it will not enter the If again and it will wait until the timeSamples get to the new nextBeatSamples
			nextBeatSamples += beatSamples;



		}
	}
}*/