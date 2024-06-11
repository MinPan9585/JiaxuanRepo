using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAppear : MonoBehaviour
{
    float afterPos = -5.83f;
    public float speed;
    private void Update()
    {
        if (transform.position.x < afterPos)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
