using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private MainCube main;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        Debug.Log("Start Game");
        main.startGame = true;
        startButton.gameObject.SetActive(false);
    }
}
