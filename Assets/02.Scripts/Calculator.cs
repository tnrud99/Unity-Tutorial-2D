using Unity.VisualScripting;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;
    void Start()
    {
        int addResult = AddMethod();
        int subtractResult = SubtractMethod();
        
        Debug.Log($"Add: {addResult} / Subtract: {subtractResult}");
    }

    int AddMethod()
    {
        int result = number1 + number2;
        
        return result;
    }

    int SubtractMethod()
    {
        int result = number1 - number2;
        
        return result;
    }
    
}
