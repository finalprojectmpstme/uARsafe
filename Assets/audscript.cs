using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class audscript : MonoBehaviour
{
	//private TrackableBehaviour mTrackableBehaviour;
	private AudioSource audio;


	public void doit()
	{	audio = GetComponent<AudioSource>();
		
			audio.Play();
		}
		
	  
}