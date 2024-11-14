using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PassManager", menuName = "ScriptableObject/PassManager")]
public class PassManager : ScriptableObject{
public bool PassBought = false;
public int PassCost;
public int Passlevel;

}