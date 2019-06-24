using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_script : MonoBehaviour
{
    public GameObject[] background_suits;
    private int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    float elapsedTime = 0f; // Counts up to repeatTime
    float repeatTime = 2f; // Time taken to repeat in seconds
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= repeatTime)
        {
            // Do something here
            NewRandomObject();
             // Subtract repeat time
             elapsedTime -= repeatTime;
        }
    }

    public void NewRandomObject()
    {
        int newIndex = Random.Range(0, background_suits.Length);
        // Deactivate old gameobject
        background_suits[currentIndex].SetActive(false);
        // Activate new gameobject
        currentIndex = newIndex;
        background_suits[currentIndex].SetActive(true);
    }

}
