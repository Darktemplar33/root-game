using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

	private Vector3 PlayerMovementInput;
	private Vector2 PlayerMouseInput;
	private float xRot;
	
	[SerializeField] private LayerMask FloorMask;
	[SerializeField] private Transform FeetTransform;
	[SerializeField] private Transform PlayerCamera;
	[SerializeField] private Rigidbody PlayerBody;
	
	[SerializeField] private float Speed;
	[SerializeField] private float Sensitivity;
	[SerializeField] private float Jumpforce;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	
	PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
	PlayerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
	
	MovePlayer();
	MovePlayerCamera();
        
    }
	
	
	private void MovePlayer()
	{
		Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
		PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(Physics.CheckSphere(FeetTransform.position, 0.1f, FloorMask))
			{
				PlayerBody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
			}
			
		}
	
	
	}
	
	private void MovePlayerCamera(){
	
		xRot -= PlayerMouseInput.y * Sensitivity;
		xRot = Mathf.Clamp(xRot, -90f, 90f);

		transform.Rotate(0f, PlayerMouseInput.x * Sensitivity, 0f);
		PlayerCamera.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
	
	}
}
