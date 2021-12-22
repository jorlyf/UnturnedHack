using UnityEngine;
using UH.Features.ESP;
using UH.Menu;

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

            MainMenu mainMenu = Loader.GameObject.AddComponent<MainMenu>();
            GameObject.DontDestroyOnLoad(mainMenu);
        }
    }
}
