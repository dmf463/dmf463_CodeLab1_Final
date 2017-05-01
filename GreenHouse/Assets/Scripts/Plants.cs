using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants : Interactable {

    GameObject plant;
    protected float transpose = -4;  // transpose in semitones
    protected float note = 0;
    protected bool hasAudio = false;
    //protected AudioClip clip;

    public override bool IsUsable()
    {
        return false;
    }

    public virtual void Grow()
    {
        Debug.Log("Plant is Growing");
        plant = transform.GetChild(0).gameObject;
        plant.transform.position += new Vector3(0, 0.1f, 0);
        plant.transform.localScale += new Vector3(0, 0.15f, 0);
        if(hasAudio == false)
        {
            AudioSource audio = plant.AddComponent<AudioSource>();
            audio.clip = Resources.Load("Sounds/LowNote") as AudioClip;
            audio.loop = true;
            Debug.Log("note + transpose = to -1? or -5 " + (note + transpose));
            if (this.note >= 0)
            {
                Debug.Log("Playing Plant Note");
                audio.pitch = Mathf.Pow(2, (note + transpose) / 12.0f);
                audio.Play();
                audio.spatialBlend = 1;
                audio.volume = .1f;
            }
            hasAudio = true;
        }
        else
        {
            AudioSource audio = plant.GetComponent<AudioSource>();
            audio.volume += .1f;
        }

    }

    public virtual void Cut()
    {
        Debug.Log("Plant is Cut!");
        plant = transform.GetChild(0).gameObject;
        plant.transform.position -= new Vector3(0, 0.1f, 0);
        plant.transform.localScale -= new Vector3(0, 0.15f, 0);
        AudioSource audio = plant.GetComponent<AudioSource>();
        audio.volume -= .1f;
    }
}
