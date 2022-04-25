using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    public string message;

    private void OnMouseEnter()
    {
        TooltipsManager._instance.SetAndShowToolTip(message);
    }

    private void OnMouseExit()
    {
        TooltipsManager._instance.HideToolTip();
    }
}
