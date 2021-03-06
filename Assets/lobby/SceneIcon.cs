﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneIcon : Activatable {

    static public bool loading = false;

    public string sceneName;

    public override void onActivate()
    {
        if (loading) return;

        var light = GetComponentInChildren<Light>();
        light.color = Color.green;
        //loading = true;
        SceneManager.LoadSceneAsync(sceneName);
    }

    public override void onEnter()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public override void onExit()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
