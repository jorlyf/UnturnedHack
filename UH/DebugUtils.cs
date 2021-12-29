using UnityEngine;

namespace UH
{
    internal class DebugUtils : MonoBehaviour
    {
        private Vector3 ScreenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 1);
        private Vector2 CrosshairLogPoint = new Vector2(Screen.width - 500, Screen.height - 350);
        public void OnGUI()
        {
            if (UHSettings.DebugLogCrosshairGameObject)
                LogCrosshairGameObject();
        }
        public void LogCrosshairGameObject()
        {
            Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);

            Physics.Raycast(ray, out RaycastHit hit);
            Features.ESP.Render.DrawString($"{hit.collider.name}, {hit.collider.gameObject.name}", CrosshairLogPoint);
        }
    }
}
