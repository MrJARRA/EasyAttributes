using UnityEngine;

namespace EasyAttributes
{
        public static class DebugColor /*: MonoBehaviour*/
    {
        // Start is called before the first frame update
      
        public  static  void Log(string Text , SetColor myColor)
        {
            Text = string.Format("<color={0}>{1}</color>", myColor.ToString() , Text);
            Debug.Log(Text);
        }
        public static void LogError(string Text, SetColor myColor)
        {
            Text = string.Format("<color={0}>{1}</color>", myColor.ToString(), Text);
            Debug.LogError(Text);
        }
        public static void LogWarning(string Text, SetColor myColor)
        {
            Text = string.Format("<color={0}>{1}</color>", myColor.ToString(), Text);
            Debug.LogWarning(Text);
        }
    }
    public enum SetColor
    {
            blue,
            aqua ,	
            black,
            brown,	
            cyan ,
            darkblue,
            fuchsia,	
            green,
            grey,
            lightblue,	
            lime,
            magenta,
            maroon,
            navy,
            olive,	
            orange,	
            purple,	
            red,	
            silver,	
            teal,	
            white,	
            yellow
    }
}
