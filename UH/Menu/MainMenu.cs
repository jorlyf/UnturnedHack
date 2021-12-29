using System.Text.RegularExpressions;
using UnityEngine;

namespace UH.Menu
{
    public class MainMenu : MonoBehaviour
    {
        private Rect MenuSize = new Rect(0, 0, 300, 500);
        private Regex OnlyNumbers = new Regex("[^0-9]");
        private string _MaxDistance = UHSettings.MaxESPDistance.ToString(); // default value

        public void OnGUI()
        {
            GUI.Window(1, MenuSize, this.Draw, "UH");
        }

        private void Draw(int id)
        {
            // toggles
            UHSettings.ESPBoxesEnable = GUI.Toggle(new Rect(10, 25, 125, 25), UHSettings.ESPBoxesEnable, "ESP_Boxes");
            UHSettings.ESPLinesEnable = GUI.Toggle(new Rect(10, 50, 125, 25), UHSettings.ESPLinesEnable, "ESP_Lines");

            // max esp distance
            GUI.Label(new Rect(15, 75, 125, 25), "MaxESPDistance");
            _MaxDistance = GUI.TextField(new Rect(10, 100, 125, 25), _MaxDistance, 4);
            _MaxDistance = OnlyNumbers.Replace(_MaxDistance, "");
            float.TryParse(_MaxDistance, out UHSettings.MaxESPDistance);
        }
    }
}
