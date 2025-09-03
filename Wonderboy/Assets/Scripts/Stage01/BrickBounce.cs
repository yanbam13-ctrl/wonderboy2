using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBounce : MonoBehaviour
{
    [SerializeField] float amplitude = 0.35f;
    [SerializeField] float speed = 6f;

    Vector3 basePos;
    bool active;

    void Awake()
    {
        basePos = transform.position;
    }

    public void EnableBounce(bool on)
    {
        active = on;
        if (!on) transform.position = basePos;
        
    }

    void Update()
    {
        if (!active) return;
        var y = Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = basePos + new Vector3(0, y, 0);
    }
}
