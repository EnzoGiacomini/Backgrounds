using StarterAssets;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class HUDmanager : MonoBehaviour
{
    public static HUDmanager Instance { get; private set; }

    public Slider staminaSlider;
    public Image staminaColor;

    public GameObject pressE;

    public TMP_Text paperCount;
    public int papers = 0;

    public GameObject monster_obg;

    public GameObject VictoryOBJ;
    GameObject player_obj;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        paperCount_void(0);
        player_obj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void paperCount_void(int num)
    {
        papers += num;
        paperCount.text = papers.ToString() + "/5";

        if (papers == 1)
        {
            monster_obg.SetActive(true);
        }

        if (papers == 5)
        {
            monster_obg.SetActive(false);
            VictoryOBJ.SetActive(true);

            player_obj.GetComponent<FirstPersonController>().enabled = false;
            player_obj.GetComponent<CharacterController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
