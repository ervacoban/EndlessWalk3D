using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    public Transform character;
    private Vector3 offset;
       
    private void Awake()
    {
        offset = transform.position - character.position;
    }

    private void LateUpdate()
    {
        transform.position = character.position + offset;
    }
}
