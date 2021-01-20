using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace FrameRate
{
    public static class FrameRateCheck
    {
        Text text;
        // Update is called once per frame
        /*
        public static string showfps(this string text)
        {
            return (1/Time.deltaTime).ToString();
        }
        */
        public static string GetFPS()
        {
            text = (1 / Time.deltaTime);
        }
    }
}
