using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressManager : MonoBehaviour
{
	public int Stress;
    public Text text;

    // Update is called once per frame
    void Update()
    {
		DisplayStress();
        if(Stress < 0)
			Stress = 0;
		if(Stress > 100)
			DeathState();
    }
	public void AddStress(int  ammount)
	{
		Stress += ammount;
	}
	public void RemoveStress(int ammount)
	{
		Stress -= ammount;
	}
	void DisplayStress()
	{
		text.text = Stress.ToString();
	}
	void DeathState()
	{
		//DeathState
	}
}
