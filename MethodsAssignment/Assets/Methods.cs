//////////////////////////////////////////////////////
// Assignment/Lab/Project: Methods Assignment
//Name: Ethan Fisher
//Section: 2023FA.SGD.113.2102
//Instructor: Ven Lewis
// Date: 10/18/2023
//////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PickupCube;
    void Start()
    {
        Debug.Log(Add(6, 6));
        Debug.Log(Multiply(4.5f, 9.5f));
        Debug.Log(GetDifference(17, 9));
        Debug.Log(GetQuotient(10.5f, 3.5f));
        DisplayGreeting();
        Debug.Log(GetAverage(70, 75, 80));
        GeneratePickup(3.6f, 6.1f);
        GeneratePickup(4.7f, 1.2f);
        GeneratePickup(2.4f, 8.5f);
    }
    void DisplayGreeting()
    {
        int open = Random.Range(1,6);
        switch (open)
        {
            case 1:
                Debug.Log("Hi");
                break;
            case 2:
                Debug.Log("Hola");
                break;
            case 3:
                Debug.Log("Aloha");
                break;
            case 4:
                Debug.Log("Ciao");
                break;
            case 5:
                Debug.Log("Bonjour");
                break;
            default:
                Debug.Log("Error");
                break;
                    
        }
    }

    private int Add(int numberOne, int numberTwo)
    {
        int sum = numberOne + numberTwo;
        return sum;
    }

    private float Multiply (float decOne, float decTwo)
    {
        float multiply = decOne * decTwo;
        return multiply;
    }

    private int GetDifference(int keyOne, int keyTwo)
    {
        int subtract = keyOne - keyTwo;
        return subtract;
    }

    private float GetQuotient (float unitOne, float unitTwo)
    {
        float divide = unitOne / unitTwo;
        return divide;
    }
    private float GetAverage(float intOne,float intTwo, float intThree )
    {
        float middle = (intOne + intTwo + intThree) / 3;
        return middle;
    }
    private void GeneratePickup(float X, float Z)
    {
        Instantiate(PickupCube, new Vector3(X, 0, Z), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
