﻿using UnityEngine;
using UnityEngine.UI;

public class STCAOGPanelControl : MonoBehaviour {
	public RawImage STCPanel = null;
	private bool isShowingSTC = false;

    // private Material mediaMaterial = null;

    // // holds the image texture to display
    // private Texture2D mediaTexture = null;

    private string currentActionName;


	public void toggleSTCPanel(){
		isShowingSTC = !isShowingSTC;
		STCPanel.gameObject.SetActive(isShowingSTC);
		if (isShowingSTC){
			// when the panel first pops up
			// show it to the right of the AOG planner panel
			STCPanel.transform.parent.position = transform.position + new Vector3(0.5f, 0, 0);
			loadImage();
		}
	}

	public void loadNewImage(string action){
		currentActionName = action;
		loadImage();
	}

	private void loadImage(){
		if(isShowingSTC){
			if (currentActionName == null){
				return;
			}
			Texture2D mediaTexture = (Texture2D)Resources.Load("stc_aog/" + currentActionName);
			STCPanel.texture = mediaTexture;

			// Debug.Log("new stc-aog displayed");
		}
	}

	// Use this for initialization
	void Start () {
		STCPanel.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
