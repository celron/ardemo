using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionScript : MonoBehaviour {
	public float latitude;
	public float longitude;
	public Text output = null;
	// Use this for initialization
	// based on the latitude and longitude, the location of the object is changed...
	void Start () {
		// this is done in the main camera, in the GPS script... get the instance information to set the LocalOrigin
		Debug.Log("Initial lat"+GPS.Instance.latitude);
		Debug.Log("Initial lng"+GPS.Instance.longitude);
		
		GPSEncoder.SetLocalOrigin( new Vector2(GPS.Instance.latitude, GPS.Instance.longitude));
		Vector3 position = GPSEncoder.GPSToUCS(latitude,longitude);
		float multiplier = 1;
		if(Application.platform == RuntimePlatform.Android)
			multiplier=-1;
		transform.position = new Vector3(position.x* multiplier, position.y* multiplier, position.z * multiplier);
		Debug.Log("start x"+transform.position.x+':'+ transform.position.y+':'+transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start update");
		GPSEncoder.SetLocalOrigin( new Vector2(GPS.Instance.latitude, GPS.Instance.longitude));		
		transform.position = GPSEncoder.GPSToUCS(latitude,longitude);
        float distance = GPSEncoder.CurrentDistance(latitude, longitude);

        if (output!=null){
			//output.text = this.name+ " Lat: "+latitude.ToString()+" Lon:"+longitude.ToString() + "dis:"+distance;
			output.text = this.name +" Dis:"+distance;
            Debug.Log("output something");
        }
        else
        {
            Debug.Log("Outptu nothing");
        }
		//Debug.Log("update x"+transform.position.x + ':'+transform.position.y);
	
	}
}
