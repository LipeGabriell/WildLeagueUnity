﻿using System;
using Fusion;
using Project.Scripts.Core.Base;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class Spell : Card
{
    public virtual void Use()
    {
        NetworkRunner.GetRunnerForScene(SceneManager.GetActiveScene())
            .Spawn(GameObject.CreatePrimitive(PrimitiveType.Sphere));
    }
}