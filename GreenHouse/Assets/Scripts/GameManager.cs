using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool isHolding;
    public float distanceBetween;
    public GameObject player;
    const float DISTANCE_THRESHOLD = 3f;
    public Dictionary<string, AudioClip> sounds = new Dictionary<string, AudioClip>();

    public AudioClip arpeg1;
    public AudioClip arpeg2;
    public AudioClip arpeg3;
    public AudioClip organC;
    public AudioClip organC2;
    public AudioClip organC3;
    public AudioClip organCM;
    public AudioClip spaceHook;
    public AudioClip stringC2;
    public AudioClip stringC3;
    public AudioClip vibeBass;


    // Use this for initialization
    void Start () {

        isHolding = false;
        sounds.Add("arpeg1", arpeg1);
        sounds.Add("arpeg2", arpeg2);
        sounds.Add("arpeg3", arpeg3);
        sounds.Add("organC", organC);
        sounds.Add("ogranC2", organC2);
        sounds.Add("organC3", organC3);
        sounds.Add("organCM", organCM);
        sounds.Add("spaceHook", spaceHook);
        sounds.Add("stringC2", stringC2);
        sounds.Add("stringC3", stringC3);
        sounds.Add("vibeBass", vibeBass);

    }
	
	// Update is called once per frame
	void Update () {
        foreach (string key in sounds.Keys)
        {
            //Debug.Log("key: " + key + " value: " + sounds[key]);
        }

        Cursor.lockState = CursorLockMode.Locked;

        RaycastHit rayhit;

        //Debug.Log("is holding = " + isHolding);

        if (Input.GetMouseButtonDown(0))
        {
            if (isHolding == false && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayhit, DISTANCE_THRESHOLD, CheckLayerMask()))
            {
                distanceBetween = Vector3.Distance(player.transform.position, rayhit.transform.position);
                if (distanceBetween < DISTANCE_THRESHOLD && rayhit.transform.GetComponent<Interactable>().IsUsable() == false)
                {
                    Debug.Log("hitting " + rayhit.collider.gameObject.name);
                    rayhit.rigidbody.isKinematic = true;
                    rayhit.transform.parent = Camera.main.transform;
                    isHolding = true;
                }
                else if(distanceBetween < DISTANCE_THRESHOLD && rayhit.transform.GetComponent<Interactable>().IsUsable() == true)
                {
                    rayhit.transform.GetComponent<Interactable>().AttachToHand(rayhit.collider.gameObject);
                }
            }
            else if (isHolding == true)
            {
                isHolding = false;
                GameObject heldItem = Camera.main.transform.GetChild(0).gameObject;
                heldItem.GetComponent<Interactable>().DetachFromHand(heldItem);
                //Camera.main.transform.GetChild(0).GetComponent<Rigidbody>().isKinematic = false;
                //Camera.main.transform.GetChild(0).transform.parent = null;
            }
        }

        if (Input.GetMouseButtonDown(1) && Camera.main.transform.GetChild(0).gameObject.layer == 9)
        {
            GameObject heldItem = GameObject.FindGameObjectWithTag("heldItem");
            heldItem.GetComponent<UsableItem>().UseItem();
        }

    }

    int CheckLayerMask()
    {
        int layerMask1 = 1 << 8;
        int layerMask2 = 1 << 9;
        return layerMask1 | layerMask2;
    }
}
