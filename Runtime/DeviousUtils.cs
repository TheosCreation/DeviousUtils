using UnityEngine;

namespace DeviousDevs
{
    public static class DeviousUtils
    {
        // Layer mask checking if a layer is inside the mask
        public static bool Contains(this LayerMask mask, int layer)
        {
            return (mask & (1 << layer)) != 0;
        }
    }
}
