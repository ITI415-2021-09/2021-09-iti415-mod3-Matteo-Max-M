using UnityEngine;

public class Restart : MonoBehaviour
{

    void Start()
    {
    }
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Application.LoadLevel(0);
        }



    }

 
}