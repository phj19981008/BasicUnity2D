using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    public int speed = 5; //public => 공개를 의미,private =>비공개를 의미. 데이터형(int(정수),float(실수)). 변수이름. = 변수값;.이런식으로 변수선언
    public float speedf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed / 50.0f, 0, 0);
    }
}
