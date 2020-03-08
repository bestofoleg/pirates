using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string dummyTag = "Dummy";

    public int damage;

    public int lifeTime = 10;

    private void Awake() {
        //Destroy(this.gameObject, lifeTime);
    }
}
