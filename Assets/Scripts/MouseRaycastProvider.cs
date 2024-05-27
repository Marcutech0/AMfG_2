using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouseRaycastProvider : MonoBehaviour, IRaycastProvider
{
    public Ray createRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}
