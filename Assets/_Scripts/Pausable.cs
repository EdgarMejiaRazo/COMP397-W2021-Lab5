using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public class Pausable : MonoBehaviour
{
    public List<MonoBehaviour> scripts;
    public List<NavMeshAgent> agents;
    public bool isGamePause;
    // Start is called before the first frame update
    void Start()
    {
        isGamePause = false;
    }

  

    public void TogglePause()
    {
        isGamePause = !isGamePause;

        foreach (var script in scripts)
        {
            script.enabled = !isGamePause;
        }

        foreach (var agent in agents)
        {
            agent.enabled = !isGamePause;
        }
    }
}
