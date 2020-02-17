using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject spawnplayer;

    public void CreatePlayer ()
    {
        GameObject temp = GameObject.Instantiate(
            spawnplayer, 
            transform.position,
            transform.rotation
        );
        this.GetComponent<spawn>().enabled = false;
    }
    private void Awake()
    {
        if (!FindObjectOfType<Camera>()) {
            CreatePlayer();
        }
    }
}
