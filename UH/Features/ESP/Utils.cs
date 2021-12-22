using UnityEngine;
namespace UH.Features.ESP
{
    public static class Utils
    {
        public static bool IsInDistance(Vector3 cam, Vector3 obj, float maxDistance) => Vector3.Distance(cam, obj) <= maxDistance;
    }
}
