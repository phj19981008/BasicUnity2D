using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour  //스크립트이름과 클래스명은 같아야한다
{
    // Start is called before the first frame update
    void Start() //프레임 갱신되어도 한번만 실행
    {
        this.transform.Translate(10.0f, 0, 0); //이 스크랩트에 속해있는 게임오브제그의 트랜스폼컴포넌트를 이동시킨다. x방향으로 1.0만큼(f는 실수float를 의미)
    }

    // Update is called once per frame
    void Update() //프레임마다 계속되어 업데이트와 실행
    {
        
    }
}
