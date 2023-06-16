using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipeGroup;
    public float height;
    private float _timer = 0f;
    public float maxInterval;

    private void Start()
    {
        var newGroup = Instantiate(pipeGroup);
        newGroup.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    private void Update()
    {
        if (_timer > maxInterval)
        {
            var newGroup = Instantiate(pipeGroup);
            newGroup.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newGroup, 10f);
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
