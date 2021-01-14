using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace fpstool
{
    public static class frameRateCheck
    {
        // Update is called once per frame
        public static string showfps(this string text)
        {
            //return $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{text}</color>";
            return (1/Time.deltaTime).ToString();
        }
    }
}
