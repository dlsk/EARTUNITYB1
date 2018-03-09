using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {

    public MovieTexture movie;
    RawImage rawImageComp;

	// Use this for initialization
	void Start () {
        rawImageComp = GetComponent<RawImage>();

	}
	void PlayClip()
    {
        rawImageComp.texture = movie;
        movie.Play();
    }

}
