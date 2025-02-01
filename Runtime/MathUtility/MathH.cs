using UnityEngine;

namespace HermitsWorlds.Core.Math
{
    public static class MathH
    {
        /// <summary>
        /// Checks if a float value is between a Vector2's X and Y.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="range"><br/>X: min (inclusive)<br/>Y: max (inclusive)</param>
        /// <returns></returns>
        public static bool InRange(float value, Vector2 range)
        {
            return value >= range.x && value <= range.y;
        }
    }
}