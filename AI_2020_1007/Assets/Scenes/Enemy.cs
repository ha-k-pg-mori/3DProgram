using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    float Timer = 0.0f;
    [SerializeField]
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();


        Timer += Time.deltaTime;

        // 左に移動
        if (Timer > 3.0f && Timer <= 5.0f)
        {
            transform.Translate(-speed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Timer > 5.0f && Timer <= 7.0f)
        {
            transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        }

        // 右に移動
        if (Timer > 10.0f && Timer <= 12.0f)
        {
            transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Timer > 12.0f && Timer <= 14.0f)
        {
            transform.Translate(-speed * Time.deltaTime, 0.0f, 0.0f);
        }

        // 下に移動
        if (Timer > 17.0f && Timer <= 19.0f)
        {
            transform.Translate(0.0f, -speed * Time.deltaTime, 0.0f);
        }

        if (Timer > 19.0f && Timer <= 21.0f)
        {
            transform.Translate(0.0f, speed * Time.deltaTime, 0.0f);
        }

        // 上に移動
        if (Timer > 24.0f && Timer <= 26.0f)
        {
            transform.Translate(0.0f, speed * Time.deltaTime, 0.0f);
        }

        if (Timer > 26.0f && Timer <= 28.0f)
        {
            transform.Translate(0.0f, -speed * Time.deltaTime, 0.0f);
        }

        if(Timer > 28.0f)
        {
            Timer = 0;
        }
     
    }

    void FixedUpdate()
    {

    }

}