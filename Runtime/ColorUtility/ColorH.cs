using UnityEngine;

namespace HermitsWorlds.Core.Color
{
    public static class ColorH
    {
        public static UnityEngine.Color ColorFromHex(string hexColor)
        {
            if (ColorUtility.TryParseHtmlString(hexColor, out UnityEngine.Color c))
            {
                return c;
            }

            return UnityEngine.Color.magenta;
        }
    
        public static UnityEngine.Color[] ColorFromHex(string[] hexColors)
        {
            UnityEngine.Color[] colors = new UnityEngine.Color[hexColors.Length];

            for (int i = 0; i < hexColors.Length; i++)
            {
                if (ColorUtility.TryParseHtmlString(hexColors[i], out UnityEngine.Color c))
                {
                    colors[i] = c;

                    continue;
                }

                colors[i] = UnityEngine.Color.magenta;
            }

            return colors;
        }
    }
}