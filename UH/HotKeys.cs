using UnityEngine;
using UH.Menu;

namespace UH
{
    public class HotKeys : MonoBehaviour
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
