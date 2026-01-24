using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalLocationController : MonoBehaviour
{
    public List<GameObject> goals;
    private int _selectedGoal;

    private void Start()
    {
        _selectedGoal = Random.Range(0, goals.Count);   // returns 1, 2, or 3
        goals[_selectedGoal].SetActive(true);
        Debug.Log(goals[_selectedGoal]);
    }
}
