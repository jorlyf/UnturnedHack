using UnityEngine;
using SDG.Unturned;

namespace UH.Features.ESP
{
    internal class ESP : MonoBehaviour
    {
        public void OnGUI()
        {
            if (!Provider.isConnected) return; // check connection to server
            foreach (SteamPlayer steamPlayer in Provider.clients)
            {
                Player player = steamPlayer.player;
                if (steamPlayer.playerID.nickName == "jorlyf") continue; // check am I
                if (!Utils.IsInDistance(Camera.main.transform.position,
                    player.transform.position, UHSettings.MaxESPDistance)) continue;
                if (player.life.isDead) continue;

                Vector3 pos = player.transform.position;
                Vector3 playerFootPos = new Vector3 { x = pos.x, z = pos.z, y = pos.y };
                Vector3 playerHeadPos = new Vector3 { x = pos.x, z = pos.z, y = pos.y + 2f };

                Vector3 w2s_footpos = Camera.main.WorldToScreenPoint(playerFootPos);
                Vector3 w2s_headpos = Camera.main.WorldToScreenPoint(playerHeadPos);

                if (w2s_footpos.z < 0) continue;
                DrawBoxESP(w2s_footpos, w2s_headpos, UHSettings.EnemyBoxColor);
            }
        }

        private void DrawBoxESP(Vector3 footpos, Vector3 headpos, Color color)
        {
            float height = headpos.y - footpos.y;
            float widthOffset = 2f;
            float width = height / widthOffset;

            Render.DrawBox(footpos.x - (width / 2), (float)Screen.height - footpos.y - height, width, height, color, 2f);
            Render.DrawLine(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(footpos.x, (float)Screen.height - footpos.y), color, 2f);
        }

    }
}
