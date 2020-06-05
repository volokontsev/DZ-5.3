using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPeasant : MonoBehaviour
{
    //[SerializeField] private SpriteRenderer _sprite;
    //[SerializeField] private Animator _animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Movement>())
        {
            Destroy(gameObject);
        }
    }
}
