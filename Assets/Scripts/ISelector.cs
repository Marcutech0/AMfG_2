using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public interface ISelector
{
    void Check(Ray ray);
    Transform GetSelection();
}
