using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    // Start is called before the first frame update

    Display display;
    void Start()
    {
        display = GameObject.Find("Display").GetComponent<Display>();

    }
    void OnMouseDown()
    {
        // Destroy game object


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject != null)
        {
            // here you need to insert a check if the object is really a tree
            // for example by tagging all trees with "Tree" and checking hit.transform.tag
            GameObject.Destroy(hit.transform.gameObject);

            if(gameObject.name == "QuestionBlock(Clone)")
            {
                display.updateCoin();

            }
        }


    }


    // Update is called once per frame
    void Update()
    {
  
    }
}
