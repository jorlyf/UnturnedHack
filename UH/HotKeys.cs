using UnityEngine;
using UH.Features.ESP;
using UH.Menu;

namespace UH
{
    internal class HotKeys : MonoBehaviour
    {
        public void Update()
        {
            if (Input.GetKeyDown(UHSettings.OpenMenuKey))
            {
                MainMenu menu = GameObject.FindObjectOfType<MainMenu>();
                menu.enabled = !menu.enabled;
            }
            if (Input.GetKeyDown(KeyCode.F10)) Loader.Unload();
        }
    }
}
