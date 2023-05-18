using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupcakes : MonoBehaviour
{
    public GameObject[] cupcakes;
    private int activeIndex = 0;

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
            cupcakes[activeIndex].SetActive(true);
            activeIndex++;
        }

    }
}
