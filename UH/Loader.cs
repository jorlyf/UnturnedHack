using System;
using UnityEngine;

namespace UH
{
    public class Loader
    {
        public static GameObject GameObject;
        public static void Load()
		{
            GameObject = new GameObject();
            Main main = GameObject.AddComponent<Main>();
            GameObject.DontDestroyOnLoad(main);
        }
        public static void Unload()
        {
            GameObject.Destroy(GameObject);
        }
    }
}
