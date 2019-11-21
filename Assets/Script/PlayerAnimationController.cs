using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animControlller;
    // Start is called before the first frame update
    void Start()
    {
        animControlller = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            animControlller.SetBool("Swing", true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            animControlller.SetBool("Swing", false);
        }
        float h = Input.GetAxis("Horizontal");

        animControlller.SetFloat("walk",h);
        Debug.Log(h);
    }
}
