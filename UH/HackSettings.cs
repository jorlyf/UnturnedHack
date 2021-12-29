using UnityEngine;

namespace UH
{
    public static class UHSettings
    {
        #region Colors
        public static Color EnemyVisibleBoxColor = Color.cyan;
        public static Color EnemyUnvisibleBoxColor = Color.blue;
        #endregion

        #region ESP
        public static float MaxESPDistance = 300f;
        public static bool ESPBoxesEnable = true;
        public static bool ESPLinesEnable = true;
        #endregion

        #region Keys
        public static KeyCode OpenMenuKey = KeyCode.F8;
        #endregion

        #region Debug
        public static bool DebugIsEnabled = true;
        public static bool DebugLogCrosshairGameObject = false;
        #endregion
    }
}
