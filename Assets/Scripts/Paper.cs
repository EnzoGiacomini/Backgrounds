using UnityEngine;

public class Paper : MonoBehaviour
{

    GameObject player_obj;
    float dist_player;

    private void Start()
    {
        player_obj = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        dist_player = Vector3.Distance(player_obj.transform.position, this.gameObject.transform.position);
        ColectPaper();
    }

    private void OnMouseOver()
    {
        if (dist_player < 5)
        {
            HUDmanager.Instance.pressE.SetActive(true);
        }
        else
        {
            HUDmanager.Instance.pressE.SetActive(false);
        }

    }

    private void OnMouseExit()
    {
            HUDmanager.Instance.pressE.SetActive(false);
    }

    void ColectPaper()
    {
        if (dist_player < 5 && Input.GetKeyDown(KeyCode.E))
        {
            HUDmanager.Instance.pressE.SetActive(false);

            HUDmanager.Instance.paperCount_void(1);
            Destroy(this.gameObject);
        }
    }

}
