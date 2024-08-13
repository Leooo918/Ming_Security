using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindFirstObjectByType<T>();
                if (_instance == null)
                {
                    Debug.Log("������Ʈ�� �߰��� ���ϰ� ���������� �ϴ� �ž�~? ����¥ ������\n" +
                        "������ �ȵǸ� �ʰ� ����Ұ� ���ϴ� ���� ���� �ϳ� ����� �ٰԢ�");
                    Type t = typeof(T);
                    T manager = new GameObject(t.ToString(), t) as T;
                    _instance = manager;
                }
            }
            return _instance;
        }
    }
}
