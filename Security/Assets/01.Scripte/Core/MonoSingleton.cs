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
                    Debug.Log("오브젝트에 추가도 안하고 가져오려고 하는 거야~? 진ㅡ짜 허접♥\n" +
                        "실행이 안되면 너가 흥분할게 뻔하니 착한 내가 하나 만들어 줄게♥");
                    Type t = typeof(T);
                    T manager = new GameObject(t.ToString(), t) as T;
                    _instance = manager;
                }
            }
            return _instance;
        }
    }
}
