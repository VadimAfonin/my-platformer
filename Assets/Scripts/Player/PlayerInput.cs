using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooter shooter;
    private Animator anim;

    private float horizontalDirection;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        anim = GetComponent<Animator>();
        shooter = GetComponent<Shooter>();
    }

    private void Update()
    {
        horizontalDirection = Input.GetAxisRaw(GlobalStringVars.HORIZONTAL_AXIS);
        bool isSpacePressed = Input.GetButtonDown(GlobalStringVars.JUMP);

        playerMovement.Move(horizontalDirection, isSpacePressed);

        if (!PauseController._isPaused && Input.GetButtonDown(GlobalStringVars.FIRE_1))
        {            
            anim.SetTrigger("Shoot");
        }
    }
}
