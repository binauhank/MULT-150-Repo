using UnityEngine;
public class ChaosGoalScript : MonoBehaviour
{
    public bool isSolved = false;
    int chaosBalls = 5;
    void OnTriggerEnter (Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            Destroy (collidedWith); chaosBalls--;
        }
        if (chaosBalls <= 0)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
        }
    }

}