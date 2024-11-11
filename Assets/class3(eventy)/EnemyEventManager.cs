using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class EnemyEventManager : MonoBehaviour
{
    public static EnemyEventManager Instance;

    public UnityEvent unityEvent;
    public Action SomethingHappened;
    public Action<int> DataChanged;

    [SerializeField] private int data;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
        {
            Destroy(Instance.gameObject);
            Instance = this;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) data++;
        if (Input.GetKeyDown(KeyCode.S)) data--;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //OnSomethingHappened?.Invoke();

            DataChanged?.Invoke(data);
            unityEvent?.Invoke();
        }
    }

}
