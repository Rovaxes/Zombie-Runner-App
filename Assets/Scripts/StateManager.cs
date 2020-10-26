using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public bool Grounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGrounded();
    }


    //IMPLEMENT THIS LATER
    void UpdateGrounded() {
        Grounded = true;
    }

}
