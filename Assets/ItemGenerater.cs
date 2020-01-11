using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{

	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPrefabを入れる
	public GameObject conePrefab;
	private GameObject unitychan;
	//スタート地点
	private int startPos = -160;
	//ゴール地点
	private int goalPos = 120;
	//アイテムを出すx方向の範囲
	private float posRange = 3.4f;

	private float difference = 15;
	private int a = 0;
	private int appearanceDistance = 50;


	// Use this for initialization
	void Start()
	{
		this.unitychan = GameObject.Find("unitychan");
	}


	// Update is called once per frame
	void Update()
	{
		if (unitychan.transform.position.z - startPos > difference * a)
		{
			int num = Random.Range(1, 11);
			if (num <= 2)
			{
				for (float j = -1; j <= 1; j += 0.4f)
				{
					GameObject cone = Instantiate(conePrefab) as GameObject;
					cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z + appearanceDistance);
				}
			}
			else
			{

				for (int j = -1; j <= 1; j++)
				{
					int item = Random.Range(1, 11);
					int offsetZ = Random.Range(-5, 6);
					if (1 <= item && item <= 6)
					{
						GameObject coin = Instantiate(coinPrefab) as GameObject;
						coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + appearanceDistance + offsetZ);
					}
					else if (7 <= item && item <= 9)
					{
						GameObject car = Instantiate(carPrefab) as GameObject;
						car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + appearanceDistance + offsetZ);
					}
				}
			}
			a++;


		}
	}
}