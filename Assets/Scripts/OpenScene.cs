using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour, IPointerClickHandler, IPointerDownHandler

 {
	 public int index;
	 public void OnPointerClick(PointerEventData eventData)
	 {
		 Debug.Log("Clicked:" + eventData.pointerCurrentRaycast.gameObject.name);
		SceneManager.LoadScene(index);
	 }
	 public void OnPointerDown(PointerEventData eventData)
	 {
		 Debug.Log("MouseDown:" + eventData.pointerCurrentRaycast.gameObject.name);
		 
	 }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
