using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stat 
{
   [SerializeField] private float baseValue;

   public List<float> modifiers;

   public float getValue()
   {
        float finalValue = baseValue;

        foreach(float modifier in modifiers)
        {
            finalValue += modifier;
        }

        return finalValue;
   }    

   public void addModifiers(float newModifier)
   {
        modifiers.Add(newModifier);
   }

   public void removeModifier(float newModifier)
   {
        modifiers.Remove(newModifier);
   }
}
