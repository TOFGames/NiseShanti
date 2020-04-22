using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class KUZURERUYUKA : MonoBehaviour {
    //=============================================================
    [SerializeField]
    private Animator _animator;

    private float liveTime = 0.99f;
    private bool colideFlag = false;

    //=============================================================
    private void Init () {
    }

    private void Awake () {
        Init();
    }

    private void Start () {
        _animator.speed = 0;
    }

    private void Update () {
        if(colideFlag) {
            _animator.speed = 1;
        }

        if(_animator.GetCurrentAnimatorStateInfo(0).normalizedTime > liveTime) {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        if(collision.gameObject.tag.Equals("Player")) {
            colideFlag = true;
        }
    }
}