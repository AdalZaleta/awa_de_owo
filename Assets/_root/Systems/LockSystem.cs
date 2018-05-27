using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSystem : MonoBehaviour {

	public GameObject[] keys;
	public bool[] locks;
	public GameObject door;
	bool doorState = false;

	void OnTriggerEnter(Collider _col)
	{
		if (_col.gameObject.CompareTag("Door"))
		{
			Debug.Log ("Open!");
			checkLocks ();
		}
	}

	public void unLock(GameObject obj)
	{
		Debug.Log ("Unlocking" + obj);
		for (int i = 0; i < locks.Length; i++)
		{
			Debug.Log ("Obj: " + obj + " | key[" + i + "]: " + keys [i]);
			if (keys[i] == obj)
			{
				locks [i] = true;
			}
		}
	}

	public void checkLocks()
	{
		doorState = true;
		for (int i = 0; i < locks.Length; i++)
		{
			if (!locks[i])
			{
				doorState = false;
			}
		}
		openDoor ();
	}

	public void openDoor()
	{
		if (doorState)
		{
			door.GetComponent<MeshCollider> ().enabled = false;
			door.GetComponent<MeshRenderer> ().enabled = false;
		}
	}
}
