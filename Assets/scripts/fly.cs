using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{

    Rigidbody rigiss;
    AudioSource audioss;
    // Start is called before the first frame update
    void Start()
    {
        audioss = GetComponent<AudioSource>();
        rigiss = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        {
            rinput();
            launch();
        }

    }


    void rinput()
    {

        //rigiss.freezeRotation = true;

        if (Input.GetKey(KeyCode.W))
        {
            print("press w");
            rigiss.AddRelativeTorque(new Vector3(1, 0, 0) * 10);

        }

        if (Input.GetKey(KeyCode.W))
        {
            print("press w");
            rigiss.AddForce(new Vector3(0, 0, 1) * 10);

        }

        if (Input.GetKey(KeyCode.S))
        {
            print("press s");
            rigiss.AddRelativeTorque(new Vector3(-1, 0, 0)* 10);
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("press s");
            rigiss.AddForce(new Vector3(0, 0, 1) * 10);

        }

        if (Input.GetKey(KeyCode.A))
        {
            print("press A");
            rigiss.AddForce(new Vector3(-1, 0, 0)* 10);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            print("press D");
            rigiss.AddForce(new Vector3(1, 0, 0) * 10);
        }

        //rigiss.freezeRotation = false;
    }


    void launch()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("press space");
            rigiss.AddForce(Vector3.up * 20);
            if (!audioss.isPlaying)
            {
                audioss.Play();
            }
        }
        else
        {
            audioss.Pause();
        }
    }

}



