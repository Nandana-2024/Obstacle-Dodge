using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float movespeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();

        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    void MovePlayer(){
        float valuex = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float valuey = 0f;
        float valuez = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(valuex,valuey,valuez);
        
        
    }

    void PrintInstructions(){
        Debug.Log("Welcome to the game!");
        Debug.Log( "Follow the instructions and awsd!");
        Debug.Log("Don't bump into big blocks!");

    }
}
