using System.Collections;
using System.Collections.Generic;
using fpstool;
using UnityEngine;
using UnityEngine.UI;

namespace fpstool
{
    public class example : MonoBehaviour
    {
        public Text text;
        public string mystring;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //mystring.showfps();
            text.text = mystring.showfps();
            Debug.Log("hello".showfps());
            //Debug.Log(showfps());
        }
    }
}