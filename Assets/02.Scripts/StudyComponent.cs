using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject Obj;

    public string changeName;
    
    void Start()
    {
        Obj = GameObject.Find("Main Camera");

        Obj.name = changeName;
        
    }
    
}
