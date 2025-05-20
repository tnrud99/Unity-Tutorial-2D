using UnityEngine;

public class Study_Class
{
    public int number;

    public Study_Class(int number)
    {
        this.number = number;
    }
}

public struct Study_Struct
{
    public int number;

    public Study_Struct(int number)
    {
        this.number = number;
    }
}


public class Study_ClassStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("클래스__________");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($"c1:{c1.number}/c2:{c2.number}");
        
        c1.number = 100;
        Debug.Log($"c1:{c1.number}/c2:{c2.number}");
        
        Debug.Log("구조체 _____________");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"s1:{s1.number}/s2:{s2.number}");
        
        s1.number = 100;
        Debug.Log($"s1:{s1.number}/s2:{s2.number}");
        // c1과 c2는 같은 객체를 가리키고 있다.
        // s1과 s2는 서로 다른 객체를 가리키고 있다.
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
