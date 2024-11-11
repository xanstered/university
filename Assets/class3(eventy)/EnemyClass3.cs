using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ManagerEvents.Instance.SomethingHappened += DoSomething

        ManagerEvents.Instance.DataChanged += OnDataChanged;
        ManagerEvents.Instance.unityEvent.AddListener(DoSomething);
    }

    private void OnDestroy()
    {
        // ManagerEvents.Instance.SomethingHappened -= DoSomething;

        ManagerEvents.Instance.DataChanged -= OnDataChanged;
        ManagerEvents.Instance.unityEvent.RemoveListener(DoSomething);
    }

    public void DoSomething() => Debug.Log($"{gameObject.name} is doing something");

    public void OnDataChanged(int data)
    {
        Debug.Log($"{gameObject.name} data changed: {data}");
    }
}
