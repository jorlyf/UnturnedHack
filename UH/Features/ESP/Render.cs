﻿using UnityEngine;

namespace UH.Features.ESP
{
    public class Render : MonoBehaviour
    {
        public static Texture2D lineTex;
        public static GUIStyle StringStyle { get; set; } = new GUIStyle(GUI.skin.label);
        public static void DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width)
        {
            Matrix4x4 matrix = GUI.matrix;
            if (!lineTex)
                lineTex = new Texture2D(1, 1);

            Color color2 = GUI.color;
            GUI.color = color;
            float num = Vector3.Angle(pointB - pointA, Vector2.right);

            if (pointA.y > pointB.y)
                num = -num;

            GUIUtility.ScaleAroundPivot(new Vector2((pointB - pointA).magnitude, width), new Vector2(pointA.x, pointA.y + 0.5f));
            GUIUtility.RotateAroundPivot(num, pointA);
            GUI.DrawTexture(new Rect(pointA.x, pointA.y, 1f, 1f), lineTex);
            GUI.matrix = matrix;
            GUI.color = color2;
        }
        public static void DrawBox(float x, float y, float w, float h, Color color, float thickness)
        {
            DrawLine(new Vector2(x, y), new Vector2(x + w, y), color, thickness);
            DrawLine(new Vector2(x, y), new Vector2(x, y + h), color, thickness);
            DrawLine(new Vector2(x + w, y), new Vector2(x + w, y + h), color, thickness);
            DrawLine(new Vector2(x, y + h), new Vector2(x + w, y + h), color, thickness);
        }
        public static void DrawString(string label, Vector2 pos)
        {
            GUIContent content = new GUIContent(label);
            Vector2 size = StringStyle.CalcSize(content);
            GUI.Label(new Rect(pos, size), content);
        }
    }
}
