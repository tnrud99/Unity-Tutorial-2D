using UnityEngine;

public class StudyLog1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start 함수 실행"); //일반적인 로그
        Debug.LogWarning("Start 함수 실행");
        Debug.LogError("Start 함수 실행");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
