using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS IS A DUMMY QUERY CARS DATA SCRIPT, IT SHOULD BE LATER IMPLEMENTED WITH THE "SMART API" TO GET THE REAL CAR DATA
//CURRENTLY IT DOES NOTHING

public class QueryData : MonoBehaviour {
	float temp;
	float[] tirePressure = new float[4];
	string geoLocation = "";
	bool lockState = true;

	List<string> carsAround = new List<string>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		getCarsNearby ();
		getCarLookingAtData ();
	}

	float getTemp(){
		return temp;
	}

	bool getLockState(){
		return lockState;
	}

	string getGeoLocation(){
		return geoLocation;
	}

	bool queryCarData(string carId){
		string data = "";
		parseData (data);
		return true;
	}

	void parseData(string data){
		
	}

	void getCarLookingAtData(){
		queryCarData ("#VIN");
	}

	void getCarsNearby(){
	}
}
