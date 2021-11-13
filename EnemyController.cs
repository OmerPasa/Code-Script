using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Pathfinding;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    public Transform EnemyTurtleGF;
    public float speed = 50f;
    public float NextWayPointDistance = 3f;
    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        Seeker seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("UpdatePath", 0f, .5f);
    }void UpdatePath()
    {
        if (seeker != null)
        {
            if (seeker.IsDone())
        {
            seeker.StartPath(rb.position, target.position, OnPathComplete);
        }   
        }else
        {
            Console.WriteLine("nullseeker");
        }
        
    }
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
        {
            return;
        }
        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        } else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;
        rb.AddForce(force);
        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if (distance < NextWayPointDistance)
        {
            currentWaypoint++;
            
        }
        if (rb.velocity.x >= 0.01f)
        {
            EnemyTurtleGF.localScale = new Vector3(-1f, 1f, 1f);
        } else if (rb.velocity.x <= -0.01f)
        {
            EnemyTurtleGF.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
