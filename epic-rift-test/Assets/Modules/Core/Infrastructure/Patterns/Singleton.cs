using UnityEngine;

namespace EpicRiftTest.Modules.Core.Infrastructure.Patterns
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        private static readonly object _lock = new();

        public static T Instance
        {
            get
            {
                lock (_lock)
                {
                    if (IsExists())
                    {
                        if (FindObjectsOfType(typeof(T)).Length > 1)
                        {
                            Debug.LogError("[SINGLETON] Something went really wrong - there should never be more than 1 singleton! Reopening the scene might fix it.");
                            return _instance;
                        }
                    }

                    return _instance;
                }
            }
        }

        private static bool IsExists()
        {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));

                if (_instance != null)
                {
                    return _instance != null;
                }

                CreateInstance();
            }
            
            return _instance != null;
        }

        private static void CreateInstance()
        {
            GameObject singleton = new GameObject();
            _instance = singleton.AddComponent<T>();
            singleton.name = $"[SINGLETON] {typeof(T).Name}";
            DontDestroyOnLoad(singleton);
            Debug.Log($"[SINGLETON] An instance of {typeof(T)}  is needed in the scene, so '{singleton}' was created with DontDestroyOnLoad.");
        }
    }
}
