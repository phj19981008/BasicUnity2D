using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour  //��ũ��Ʈ�̸��� Ŭ�������� ���ƾ��Ѵ�
{
    // Start is called before the first frame update
    void Start() //������ ���ŵǾ �ѹ��� ����
    {
        this.transform.Translate(10.0f, 0, 0); //�� ��ũ��Ʈ�� �����ִ� ���ӿ��������� Ʈ������������Ʈ�� �̵���Ų��. x�������� 1.0��ŭ(f�� �Ǽ�float�� �ǹ�)
    }

    // Update is called once per frame
    void Update() //�����Ӹ��� ��ӵǾ� ������Ʈ�� ����
    {
        
    }
}
