/* ---------------------------------------
 * Author:          Steven Heckman (kit.heckman@gmail.com) (@NK_Cyborg)
 * Project:         FrameRateCheck
 * Date:            1-Jan-21
 * Studio:          Sciumo
 *
 * Git repo:        https://github.com/nkcyborg/fpstool
 *
 * This project is released under the MIT license.
 * -------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

namespace FrameRateCheck
{
    public class GetFrameRate : MonoBehaviour
    {
        public Text text;
        public void GetFPS()
        {
            text.text = (1 / Time.deltaTime).ToString();
        }
        private void Update()
        {
            GetFPS();
        }

    }
}
