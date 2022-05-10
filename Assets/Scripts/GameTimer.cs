using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float TimeInRoom;
    private TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeInRoom += Time.deltaTime;
        Text.text = string.Format("{0:0}:{1:00}", Mathf.Floor(TimeInRoom/60), TimeInRoom % 60);
    }
}
