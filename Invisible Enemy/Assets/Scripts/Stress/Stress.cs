using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class Stress : MonoBehaviour
{
	public Text text;
    public int stress;
	void Start()
	{
		DisplayStress();
	}
	void AddStress(int ammount)
	{
		stress += ammount;
		DisplayStress();
	}
	void RemoveStress(int ammount)
	{
		stress -= ammount;
		DisplayStress();
	}
	void DisplayStress()
	{
		text.text = stress.ToString();
	}
}
