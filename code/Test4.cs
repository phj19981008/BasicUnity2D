using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    public int speed = 5; //public => ������ �ǹ�,private =>������� �ǹ�. ��������(int(����),float(�Ǽ�)). �����̸�. = ������;.�̷������� ��������
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
