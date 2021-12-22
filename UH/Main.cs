using UnityEngine;

namespace UH
{
    internal class Main : MonoBehaviour
    {
        public void Start()
        {
            ESP esp = Loader.GameObject.AddComponent<ESP>();
            GameObject.DontDestroyOnLoad(esp);

            HotKeys hotKeys = Loader.GameObject.AddComponent<HotKeys>();
            GameObject.DontDestroyOnLoad(hotKeys);
        }
    }
}
