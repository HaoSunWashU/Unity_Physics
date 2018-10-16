using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Incapacitate : MonoBehaviour
{
    public Animator anim;
    public Rigidbody charRigidbody;
    public CapsuleCollider capsuleCollider;
    public NavMeshAgent navMeshAgent;

    private Rigidbody[] rigidbodies;
    private Collider[] colliders;


	// Use this for initialization
	void Awake ()
    {
        rigidbodies = GetComponentsInChildren<Rigidbody>();
        colliders = GetComponentsInChildren<Collider>();

        SetCollidersEnabled(false);
        SetRigidBodiesKinematic(true);
	}

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            ActivateRagdoll();
        }
    }
	
	private void SetCollidersEnabled(bool enabled)
    {
        foreach (Collider collider in colliders)
        {
            collider.enabled = enabled;
        }
    }

    private void SetRigidBodiesKinematic(bool kinematic)
    {
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = kinematic;
        }
    }

    private void ActivateRagdoll()
    {
        capsuleCollider.enabled = false;
        charRigidbody.isKinematic = true;
        anim.enabled = false;
        navMeshAgent.enabled = false;

        SetCollidersEnabled(true);
        SetRigidBodiesKinematic(false);
    }
}
