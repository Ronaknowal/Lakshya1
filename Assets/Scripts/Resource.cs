using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    [SerializeField] ResourceSlot[] resourceSlots;

    [System.Serializable]
    private class ResourceSlot
    {
        public ResourceType resourceType;
        public int resourceAmount;
    }

    //Gets the resourceAmount for the given resourceType
    public int GetCurrentResource(ResourceType resourceType)
    {
        return GetResourceSlot(resourceType).resourceAmount;
    }

    //Decreases the resourceAmount for the given resourceType
    public void ReduceCurrentResource(ResourceType resourceType)
    {
        GetResourceSlot(resourceType).resourceAmount--;
    }

    //Increases the resourceAmount for the given resourceType
    public void IncreaseCurrentResource(ResourceType resourceType, int resourceAmount)
    {
        GetResourceSlot(resourceType).resourceAmount += resourceAmount;
    }

    //Gets or returns the given resourceSlot
    private ResourceSlot GetResourceSlot(ResourceType resourceType)
    {
        foreach (ResourceSlot slot in resourceSlots)
        {
            if (slot.resourceType == resourceType)
            {
                return slot;
            }
        }

        return null;
    }
}
