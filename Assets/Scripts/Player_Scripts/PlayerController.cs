using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerMovement movement;
    PlayerAnimation animation;
    StateManager states;
    InputManager inputs;

    // Start is called before the first frame update
    void Start()
    {
        movement = this.GetComponent<PlayerMovement>();
        animation = this.GetComponent<PlayerAnimation>();
        states = this.GetComponent<StateManager>();
        animation = this.GetComponent<PlayerAnimation>();
        inputs = this.GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.HandleMovement(inputs.Vertical, inputs.Horizontal, states.Grounded);
    }
}
