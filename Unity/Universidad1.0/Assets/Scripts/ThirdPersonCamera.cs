using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {
	private const float Y_ANGLE_MIN = 5.0f;
	private const float Y_ANGLE_MAX = 50.0f;

	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;
	private float distanceZ=504.578f;
	private float distanceY=226.8625f;
	private float distanceX=70.1564f;
	private float currentX=0.0f;
	private float currentY = 0.0f;
	private float sensiviteX = 4.0f;
	private float sensiviteY = 1.0f;

	private void Start(){
		camTransform = transform;
		cam = Camera.main;

	}

	private void Update(){
	
		currentX += Input.GetAxis ("Mouse X");
		currentY += Input.GetAxis ("Mouse Y");
		currentY = Mathf.Clamp(currentY,Y_ANGLE_MIN,Y_ANGLE_MAX);
	
	}
	private void LateUpdate(){
		Vector3 dir = new Vector3 (-distanceX,distanceY,distanceZ);
		Quaternion rotation = Quaternion.Euler (currentX,currentY,0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt (lookAt.position);
	}

} 
