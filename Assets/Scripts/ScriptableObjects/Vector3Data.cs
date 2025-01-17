﻿using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
   public Vector3 value;

   public void SetValueFromVector3(Vector3 obj)
   {
      value = obj;
   }
   
   public void SetValueFromPosition(Transform obj)
   {
      value = obj.position;
   }
   
   public void SetPositionFromValue(Transform obj)
   {
      obj.position = value;
   }
}
