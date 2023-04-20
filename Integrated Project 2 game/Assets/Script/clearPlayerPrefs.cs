using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearPlayerPrefs : MonoBehaviour
{
   public void clearPrefs()
{
    PlayerPrefs.DeleteAll();
}
}
