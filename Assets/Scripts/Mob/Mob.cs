using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Mob : MonoBehaviour
{
    public UnityEvent OnCreated;
    public UnityEvent OnDestroyed;

    private bool isDestroyed = false;

    public float destroyDelay = 1f;


    private void Start()
    {
        OnCreated?.Invoke();
    }

    public void Destroy()
    {
        if (isDestroyed)
            return;

        isDestroyed = true;

        Destroy(gameObject, destroyDelay);

        OnDestroyed?.Invoke();
    }
}
