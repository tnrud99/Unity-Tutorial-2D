using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    
   List<int> listNumber = new List<int>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);
        
        Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}");
                 
    }

}