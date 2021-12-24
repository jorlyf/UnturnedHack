using UnityEngine;
namespace UH.Features.ESP
{
    public static class Utils
    {
        public static bool IsInDistance(Vector3 cam, Vector3 obj, float maxDistance) => Vector3.Distance(cam, obj) <= maxDistance;
        public static bool IsVisible(Camera cam, Vector3 targetPos, GameObject target)
        {
            Ray ray = cam.ScreenPointToRay(targetPos);
            Physics.Raycast(ray, out RaycastHit hit);

            if (hit.collider?.gameObject == target) return true;
            return false;
        }
    }
}
