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
            mainMenu.enabled = false;
            GameObject.DontDestroyOnLoad(mainMenu);

            DebugUtils debugUtils = Loader.GameObject.AddComponent<DebugUtils>();
            debugUtils.enabled = false; // debug log
            GameObject.DontDestroyOnLoad(debugUtils);
        }
    }
}
