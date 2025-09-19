using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Смещение: Y — высота, Z — расстояние назад
    private Vector3 offset = new Vector3(0, 5, -15);

    void Update()
    {
        // Камера будет находиться позади и выше игрока
        transform.position = player.transform.position + offset;
    }
}
