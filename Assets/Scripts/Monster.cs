using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{

    GameObject player_obj;
    public GameObject game_overUI;
    public GameObject game_overAnimation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_obj = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player_obj.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            game_overAnimation.SetActive(true);
            game_overUI.SetActive(true);

            player_obj.GetComponent<FirstPersonController>().enabled = false;
            player_obj.GetComponent<CharacterController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;

            Destroy(this.gameObject);
        }
    }
}
