using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public Vector2 pos { get => transform.position; set => transform.position = value; }
    public Vector2 vel { get; set; } = Vector2.zero;
    public Vector2 acc { get; set; } = Vector2.zero;
    public float mass { get; set; } = 1;

    public void ApplyForce(Vector2 force)
    {
        acc = force;
    }
}
