﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {
    public static CanvasController Instance { set; get; }

    public GameObject panel;
    private GameObject container;
    private GameObject newPanel;

    // Use this for initialization
    void Start () {
        container = GameObject.Find("container");
    }

    public void ShowAddMedicinePanel() {
        newPanel = Instantiate(panel) as GameObject;
        newPanel.transform.SetParent(container.transform, false);
    }
}
