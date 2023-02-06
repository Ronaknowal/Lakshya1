
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFn : MonoBehaviour
{
    [SerializeField] Color originalColor = Color.white;
    [SerializeField] Color hoverColor = Color.blue;
    [SerializeField] Color clickedColor = Color.red;
    

    [SerializeField] bool isClicked = false;

    MeshRenderer renderer;
    Resource resources;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    //Changes originalColor to hoverColor when hovered over
    private void OnMouseEnter()
    {
        renderer.material.color = hoverColor;
    }

    //Changes originalColor to clickedColor or hoveredColor when hovered out
    private void OnMouseExit()
    {
        if (isClicked)
        {
            renderer.material.color = clickedColor;

        }
        else
        {
            renderer.material.color = originalColor;
            
        }
    }


    //Changes originalColor to clickedColor when the object is clicked and gets unclicked when some other object is clicked. 
    private void OnMouseDown()
    {
       
            foreach (var button in FindObjectsOfType<MouseFn>())
            {
                button.renderer.material.color = originalColor;
                button.isClicked = false;
            }

            this.renderer.material.color = clickedColor;
            this.isClicked = true;
        


    }

}









