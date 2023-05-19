using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupcakes : MonoBehaviour
{
    public GameObject[] cupcakes;
    private int activeIndex = 0;
    private Animator animator;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Awake()
    {
        foreach (GameObject cupcakes in cupcakes)
        {
            cupcakes.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && activeIndex < cupcakes.Length)
        {
            animator.SetBool("ActivateCupcake", true);
            cupcakes[activeIndex].SetActive(true);
            activeIndex++;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("ActivateCupcake", false);
    }
}
