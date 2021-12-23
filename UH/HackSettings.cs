using UnityEngine;

namespace UH
{
    public static class UHSettings
    {
        #region Colors
        public static Color EnemyBoxColor = Color.cyan;
        #endregion

        #region ESP
        public static float MaxESPDistance = 300f;
        public static bool ESPBoxesEnable = true;
        public static bool ESPLinesEnable = true;
        #endregion

        #region Keys
        public static KeyCode OpenMenuKey = KeyCode.F8;
        #endregion
    }
}
