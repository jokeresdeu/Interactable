using System;
using UnityEngine;

public class UpdateProvider : MonoBehaviour
{
    public event Action OnUpdate;
    public event Action OnFixedUpdate;
    public event Action OnLateUpdate;

    public static UpdateProvider Instance;

    public void Awake()
    {
        if (Instance == null)
            Instance = this;
        else 
            Destroy(gameObject);
        
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        OnUpdate?.Invoke();
    }

    private void FixedUpdate()
    {
        OnFixedUpdate?.Invoke();
    }

    private void LateUpdate()
    {
        OnLateUpdate?.Invoke();
    }
}
