using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //allow the members of this class to be shown in the Instepector
public class Dialogue
{
    public string name;
    [TextArea(3, 10)]
    public string[] sentences;
}
