using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject enemy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if(GameManager.Instance.lives > 0)
            {
                GameManager.Instance.lives--;
                enemy.SetActive(true);
            }
            else
            {
                Destroy(gameObject);

                //GameManager Set Game Over
                GameManager.Instance.GameOver();
            }
            
        }
    }
}
