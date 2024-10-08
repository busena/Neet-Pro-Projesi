using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fire : MonoBehaviour
{

    public int RightMax = 30;
    public int LeftMax = 30;
    public TMP_Text BulletText;
    public GameObject Bullet;
    public float ForceFactor = 1.0f;
    public AudioSource fireSound;
    public bool isRight = true;

    int RightRemain = 0;
    int LeftRemain = 0;
    // Start is called before the first frame update
    void Start()
    {
        RightRemain = RightMax;
        LeftRemain = LeftMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (RightRemain > 0)
            {
                Ates();
                RightRemain--;
                BulletText.text = RightRemain.ToString() + "/" + RightMax.ToString();
            }
        }

        if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger))
        {
            if (isRight)
            {
                if (RightRemain > 0)
                {
                    Ates();
                    RightRemain--;
                    BulletText.text = RightRemain.ToString() + "/" + RightMax.ToString();
                }
            }
            //GameObject go = GameObject.Instantiate(Bullet);
            //go.transform.position = transform.position;

            //Rigidbody rb = go.GetComponent<Rigidbody>();

            //Vector3 vec = transform.forward;
            //rb.AddForce(vec * 1000 * ForceFactor);
            //fireSound.Play();
        }

        if (OVRInput.GetUp(OVRInput.RawButton.LIndexTrigger))
        {
            if (!isRight)
            {
                if (LeftRemain > 0)
                {
                    Ates();
                    RightRemain--;
                    BulletText.text = LeftRemain.ToString() + "/" + LeftMax.ToString();

                }
            }
        }

        if(OVRInput.GetUp(OVRInput.Button.One) || Input.GetKeyUp(KeyCode.R))
        {
            if(isRight)
            {
                if(RightRemain != RightMax)
                {
                    RightRemain = RightMax;
                    BulletText.text = RightRemain.ToString() + "/" + RightMax.ToString();
                }
            }
        }

        if (OVRInput.GetUp(OVRInput.Button.Three))
        {
            if (!isRight)
            {
                if (LeftRemain != LeftMax)
                {
                    LeftRemain = LeftMax;
                    BulletText.text = LeftRemain.ToString() + "/" + LeftMax.ToString();
                }
            }
        }


    }

    private void Ates()
    {
        GameObject go = GameObject.Instantiate(Bullet);
        go.transform.position = transform.position;
        go.transform.rotation = transform.rotation;

        Rigidbody rb = go.GetComponent<Rigidbody>();


        //Vector3 vec = Vector3.forward;
        Vector3 vec = transform.forward;

        rb.AddForce(vec * 1000 * ForceFactor);
        if (fireSound != null)
        {
            fireSound.Play();
        }
    }
}

