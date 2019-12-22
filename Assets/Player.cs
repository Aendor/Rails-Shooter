using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [Tooltip("In ms^-1")][SerializeField] float speed = 12f;
    [SerializeField] float xRange = 6f;
    [SerializeField] float yRange = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float xOffset = xThrow * speed * Time.deltaTime;
        float yOffset = yThrow * speed * Time.deltaTime;

        float newRawXPos = transform.localPosition.x + xOffset;
        float newRawYPos = transform.localPosition.y + yOffset;

        float clampedXPos = Mathf.Clamp(newRawXPos, -xRange, xRange);
        float clampedYPos = Mathf.Clamp(newRawYPos, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);

    }
}
