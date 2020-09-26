using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuestionMark : MonoBehaviour
{
    // Start is called before the first frame update
    private Material myQmaterial;
    public float amplify = 150;
    private float yValue = 1;
    void Start()
    {
        myQmaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        yValue += 1 * amplify * Time.deltaTime;

        if(yValue > 20)
        {
            myQmaterial.mainTextureOffset = new Vector2(1, (myQmaterial.mainTextureOffset.y + .2f) % 1);
            yValue = 0;
        }

        float y = Time.deltaTime * ((myQmaterial.mainTextureOffset.y + .2f) % 1);

        
    }
}
