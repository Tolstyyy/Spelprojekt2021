using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControllerScript : MonoBehaviour {

    // Jump
    public float jumpForce = 5f;
    private int distance;

    // Reverse jump
    public bool downJumpEnabled = false;
    public float downForce = 20.0f;

    // Double jump stuff
    private bool IsGrounded = true;
    private const int maxjumps = 2;
    private int currentjump = 0;

    public static float timeScale;

    [Header("Unity Stuff")]
    public Transform target;
    public Text distText;
    public LayerMask groundLayers;
    public SphereCollider col;
    public ParticleSystem jumpPrefab;
    private Rigidbody rb;
    private float GroundDistance;


    // Functions
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
        distance = 0;
        SetDistanceText();
    }

    void Update ()
    {
        #region Jump
        // Normal Jump & double jump
        if ((IsGrounded || maxjumps > currentjump) && Input.GetButtonDown("Jump") || Input.GetButtonDown("Alt Jump")) // If the cube is on the ground and the spacebar is pressed, jump. 
        {           
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpPrefab.Play();
            IsGrounded = false;
            currentjump++;
        }

        // Down Jump
        if (downJumpEnabled & Input.GetButtonDown("Down Jump"))
        {
            rb.AddForce(Vector3.down * downForce, ForceMode.Impulse);           
        }
        #endregion

        if (Time.timeScale == 1)
        {
            Distance();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        IsGrounded = true;
        currentjump = 0;
    }

    void Distance()
    {
        if (target)
        {   
            /*
            distance = Vector3.Distance(target.position, transform.position);          
            distance = distance++;
            distText.text = distance.ToString();
            */
        }     
    }

    void SetDistanceText()
    {
        distText.text = distance.ToString();
    }
}