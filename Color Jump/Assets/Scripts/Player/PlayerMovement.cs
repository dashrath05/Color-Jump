using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerJumpForce;
    public float playerSideForce;

    public Rigidbody2D playerRigidbody;
    public RectTransform playerRectTransform;
    public Vector3 playerPoS;


    private void Start()
    {
        //freeze player
        playerPoS = playerRectTransform.position;
        playerRigidbody.velocity = Vector2.zero;
        playerRigidbody.gravityScale = 0f;

    }

    //player jump
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            playerRigidbody.velocity = new Vector2(playerSideForce, playerJumpForce);
           
        } 
    }

    public void PlayerFreeze()
    {

        playerRigidbody.velocity = Vector2.zero;
        playerRigidbody.gravityScale = 0f;
    }

    public void PlayerUnfreeze()
    {
        playerRectTransform.position = playerPoS;
        playerRigidbody.gravityScale = 380f;
        if(playerSideForce<0)
        {
            playerSideForce = 400;
        }
    }

    //player direction change
    public void GivePlayerForce(float force,float jump)
    {
        playerRigidbody.velocity = new Vector2(force, jump);
    }

}
