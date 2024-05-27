using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SelectorManager : MonoBehaviour
{
    ISelectionMode ISelectionMode;
    ISelector iselector;
    IRaycastProvider iraycastprovider;

    private Transform currentSelection;

    private void Awake()
    {
        ISelectionMode= GetComponent<ISelectionMode>();
        iselector= GetComponent<ISelector>();
        iraycastprovider= GetComponent<IRaycastProvider>();
    }

    private void Update()
    {
        if (currentSelection!=null) 

        ISelectionMode.OnDeselect(currentSelection);
        iselector.Check(iraycastprovider.createRay());
        currentSelection=iselector.GetSelection();

        if (currentSelection!=null) 
        ISelectionMode.OnSelect(currentSelection);  
    }
}
