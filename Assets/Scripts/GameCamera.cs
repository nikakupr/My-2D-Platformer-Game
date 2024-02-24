using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public GameObject player;
    public float speed;


    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.z = -10f;
        transform.position = pos;
    }
}
