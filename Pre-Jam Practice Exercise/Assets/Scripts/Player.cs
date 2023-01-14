using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.5f; // player speed | プレイヤーの速度
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    // 最初のフレーム更新の前に「Start」が呼び出されます
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //「Update」はフレームごとに 1 回呼び出されます
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // WASD movement | WASD運動
        float h = 0.0f;
        float v = 0.0f;
        if(Input.GetKey("w")) {v = 1.0f;}
        if(Input.GetKey("s")) {v = -1.0f;}
        if(Input.GetKey("a")) {h = -1.0f;}
        if(Input.GetKey("d")) {h = 1.0f;}

        rigidBody.MovePosition(rigidBody.position + 
            (new Vector2(h,v) * speed * Time.fixedDeltaTime));
    }
}
