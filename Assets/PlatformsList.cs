using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "List", menuName = "ScriptableObjects/ListOfPlatform", order = 1)]
public class PlatformsList : ScriptableObject
{
    public List<GameObject> platforms = new List<GameObject>();

}
