using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("FX prefab on enemy")] [SerializeField] GameObject deathFX;
    [SerializeField] Transform  parent;
    ScoreBoard scoreBoard;
    [SerializeField] int scorePerHit = 12;

    // Start is called before the first frame update
    void Start()
    {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddBoxCollider()
    {
        BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnParticleCollision(GameObject other)
    {
        scoreBoard.ScoreHit(scorePerHit);

        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.SetParent(parent);

        Destroy(gameObject);
    }
}
