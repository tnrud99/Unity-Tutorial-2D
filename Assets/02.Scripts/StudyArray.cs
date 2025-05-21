using UnityEngine;

public class StudyArray : MonoBehaviour
{
    int[] arrayNumber = new int[5]; // 배열 선언

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
    }

}