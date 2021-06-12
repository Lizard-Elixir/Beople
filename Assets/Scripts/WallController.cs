using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WallController : MonoBehaviour
{
    [SerializeField] float beopleRequirement = 5f;
    [SerializeField] private VarObject recruitedBeopleVar;
    [SerializeField] private TextMeshProUGUI requirementHUD;

    private void Start()
    {
        requirementHUD.text = beopleRequirement.ToString();
    }

    private void Update()
    {
        if (recruitedBeopleVar.currentNum >= beopleRequirement)
        {
            Destroy(gameObject);
        }
    }


    /** for some reason OnCoillisionEnter isn't working?
    //When gets bumped by something, checks if it was the player, then if they have enough people it is destroyed
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("has been collided");
        if (collision.gameObject.tag == "Player")
        {
            if (recruitedBeopleVar.currentNum >= beopleRequirement)
            {
                Destroy(gameObject);
            }
        }
    }
    */
}
