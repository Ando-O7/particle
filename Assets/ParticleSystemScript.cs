using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemScript : MonoBehaviour {

	GameObject obj1;
	GameObject obj2;
	GameObject obj3;

	ParticleSystem ps1;
	ParticleSystem ps2;
	ParticleSystem ps3;

	// Use this for initialization
	void Start () {
		obj1 = GameObject.Find ("Spiral_02.1.3 Noise");
		obj2 = GameObject.Find ("Liberate_05.1 Fairydust cheap");
		obj3 = GameObject.Find ("Liberate_04.2 Darkness");

		ps1 = obj1.GetComponent<ParticleSystem> ();
		ps2 = obj2.GetComponent<ParticleSystem> ();
		ps3 = obj3.GetComponent<ParticleSystem> ();

		obj1.SetActive (false);
		obj2.SetActive (false);
		obj3.SetActive (false);
	}

	public void Ps1Start()
	{
		ps2.Stop ();
		ps3.Stop ();
		obj1.SetActive (true);
		obj2.SetActive (false);
		obj3.SetActive (false);

		ps1.Play ();
	}

	public void Ps2Start()
	{
		obj1.SetActive (false);
		obj2.SetActive (true);
		obj3.SetActive (false);
		ps1.Stop ();
		ps3.Stop ();

		ps2.Play ();
	}

	public void Ps3Start()
	{
		obj1.SetActive (false);
		obj2.SetActive (false);
		obj3.SetActive (true);
		ps1.Stop ();
		ps2.Stop ();

		ps3.Play ();
	}
}
