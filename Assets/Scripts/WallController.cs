using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WallController : MonoBehaviour
{
    [SerializeField] float beopleRequirement = 5f;
    [SerializeField] private VarObject recruitedBeopleVar;
    [SerializeField] private TextMeshProUGUI requirementHUD;
    [SerializeField] private GameObject breakParticles;

    private void Start()
    {
        requirementHUD.text = beopleRequirement.ToString();
    }



    // for some reason OnCoillisionEnter isn't working?
    //When gets bumped by something, checks if it was the player, then if they have enough people it is destroyed
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (recruitedBeopleVar.currentNum >= beopleRequirement)
            {
                GameObject particles = Instantiate(breakParticles);
                particles.transform.position = gameObject.transform.position;
                particles.GetComponent<ParticleSystem>().Play();
                Destroy(particles,1000);
                Destroy(gameObject);
            }
        }
    }
}
