using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TrimScript : MonoBehaviour
{
    [MenuItem("GameObject/Prefab/Trim")]
    static void Trim(MenuCommand menuCommand)
    {
        foreach (Transform subt in Selection.transforms)
        {
            Undo.RegisterCompleteObjectUndo(subt, subt.name + " Trim");
            long count = RecursiveTrim(subt);
            Debug.Log("[TRIM]: " + subt.name + " | Trimmed " + count.ToString() + " objects");
        }
    }

    static long RecursiveTrim(Transform t, long index = 0, long level = 0)
    {
        long i = 0;
        long count = 0;
        foreach (Transform subt in t)
        {
            count += RecursiveTrim(subt, i, level + 1);
            ++i;
        }
        if ((i == 0) && (index != 0))
        {
            Debug.Log("[TRIM]: " + t.name);
            GameObject.DestroyImmediate(t.gameObject);
            ++count;
        }
        return count;
    }
}
