using UnityEngine;

namespace UH
{
    internal class HotKeys : MonoBehaviour
    {
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.F8))
            {
                ESP esp = GameObject.FindObjectOfType<ESP>();
                esp.IsActive = !esp.IsActive;
            }
            if (Input.GetKeyDown(KeyCode.F9))
            {
                Loader.Unload();
            }
        }
    }
}
