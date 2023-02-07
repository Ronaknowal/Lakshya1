
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFn : MonoBehaviour
{
    public Material materialOriginal;
    public Material materialHover;
    public Material materialClick;


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
        renderer.material = materialHover;
    }

    //Changes originalColor to clickedColor or hoveredColor when hovered out
    private void OnMouseExit()
    {
        if (isClicked)
        {
            renderer.material = materialClick;

        }
        else
        {
            renderer.material = materialOriginal;
            
        }
    }


    //Changes originalColor to clickedColor when the object is clicked and gets unclicked when some other object is clicked. 
    private void OnMouseDown()
    {
       
            foreach (var button in FindObjectsOfType<MouseFn>())
            {
                button.renderer.material = materialOriginal;
                button.isClicked = false;
            }

            this.renderer.material = materialClick;
            this.isClicked = true;
        


    }

}









