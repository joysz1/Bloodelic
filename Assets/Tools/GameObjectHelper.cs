using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectHelper
{
    public static GameObject GetParentGameObject(GameObject gameObject) {
        Transform parent = gameObject.transform.parent;
        if (parent != null) {
            return GetParentGameObject(parent.gameObject);
        } else {
            return gameObject;
        }
    }
}
