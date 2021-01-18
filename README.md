https://github.com/nkcyborg/fpstool/tree/main/images/Screenshot_9.png
# fpstool
> A tool for measuring the frame rate
Steven Heckman 1/14/2021
Contact at kit.heckman@gmail.com.

A very simple Unity custom package; converts a string into the current framerate. 

## Instructions
- Drag this into your packages folder of your unity project in your folder inspector.
- Make sure to include *using fpstool;* at the top of your file.
- Make sure to include *namespace fpstool* with brackets surrounding your entire class.

You can also visit the [website](https://nkcyborg.github.io/fpstool/) to see more, included a video demonstration. This site was built using [GitHub Pages](https://pages.github.com/).

https://github.com/nkcyborg/fpstool/tree/main/images/Screenshot_10.png

## Code Examples

Here is an example of code:
```
using System.Collections;
using System.Collections.Generic;
using fpstool;
using UnityEngine;

namespace fpstool
{
    public class debugFPS : MonoBehaviour
    {
        public string mystring;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(mystring.showfps());//These all do the same thing
            Debug.Log("hello".showfps());
	    Debug.Log("".showfps());
        }
    }
}
```
**Note: If you call this function every frame, the exact fps will be hard to read because it will constantly be updating.**

https://github.com/nkcyborg/fpstool/tree/main/images/Screenshot_2.png

Here is the code used in the video demonstration:
```
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
        public GameObject myprefab;
        public int counter;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //mystring.showfps();
            counter += 1;
            text.text = mystring.showfps();
            Debug.Log("hello".showfps());
            if(counter > 100)//this is just to prevent the spawning from beginning the instant the scene loads
                Instantiate(myprefab, new Vector3(0.289796233f, -0.649999976f, -4.44117355f), Quaternion.identity);
            //Debug.Log(showfps());
        }
    }
}
```

## Art Citations
**[Unity Custom Packages YouTube tutorial](https://www.youtube.com/watch?v=mgsLb3TKljk)**

**[Custom Packages Tutorial by "Dapper Dino"](https://www.youtube.com/watch?v=q6IDmmiLoBg)**

## Legal
The code in this project is licensed under MIT license, which can be read in the LICENSE file under fpstool.