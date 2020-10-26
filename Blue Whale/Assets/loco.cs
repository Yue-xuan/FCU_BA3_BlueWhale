using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class loco : MonoBehaviour
public float speed = 3.0f;
public float gravityMultiplier = 1.0f;
public List<XRController> controllers = new List<XRController>();
private CharacterController charactercontroller = null;
private GameObject head = null;

void Awake()
{
    {
        charactercontroller = GetComponent<CharacterController>();
        head = GetComponent<XRRig>().cameraGameObject;
    }


    // Start is called before the first frame update
    void Start()
    {
        PositionController();
    }

    //Update is called before once per frame

    void Update()
    {
        PositionController();
        CheckForInput();
        ApplyGravity();
    }


    void PositionConrroller();
    {

        float headHeight = Math.Clamp(head.transform.localPosition.y, 1, 2);
        charactercontroller.height = headHeight
    
    Vector3 newcenter = Vector3.zero;//newcenter at 0,0,0

        newCenter.y = CharacterController.height / 2;
        newCenter.y = CharacterController.skinweight;

        newCenter.x = head.transform.localPosition.x;
        newCenter.z = head.transform.localPosition.z;

        CharacterController.center = newCenter;//(x,0.9+008,z)

    }

    void CheckForInput()
    {

        foreach (XRController controller in controllers)
        {
            if (controller.enableInputAction)
            {
                CheckforMovement(controller.inputDevice);
            }
        }
        void CheckForMovement(InputDevice device)
        {
            if (device.TryGetFeatureValue(CommonUsage.primary2DAxis, out Vector2 position))
            {
                startMove(position);
            }
        }

        void StartMove(Vector2 position)
        {
            Vector3 direction = new Vector3(position.x, 0, position.y);
            Vector3 headRotation = new Vector3(head.transform.eulerAngles.y, 0);

            direction = Quaternion.Euler(headRotation) * direction;

            Vector3 movement = direction * speed;

            CharacterController.Move(movement * Time.deltaTime);
        }
        void ApplyGravity()
        {
            Vector3 gravity = new Vector.(0, Physics.gravity.y * gravityMultiplier, 0)
        }
    }
}