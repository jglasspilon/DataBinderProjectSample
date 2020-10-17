using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SetActiveBinder : GenericBinder<GameObject>
{
    public override bool TryBindData(Dictionary<string, string> data)
    {
        if (base.TryBindData(data))
        {
            foreach (GameObject target in m_targets)
            {
                target.SetActive(data[m_key].IsTrue());
            }
            return true;
        }
        else
            return false;
    }

    public override void ClearData()
    {
        foreach (GameObject target in m_targets)
        {
            target.SetActive(false);
        }
    }
}
