using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeatController : MonoBehaviour
{
    void Update() {
        display.text = $"HP: {((int)hp)}";

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) {
            print("increased speed");
            speed += impulse;
            transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        }
        if(Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.Mouse0)) {
            transform.localScale = Vector3.one;
        }
    }

    void FixedUpdate() {
        speed += acc * Time.fixedDeltaTime;
        speed = Utils.bound(speed, -maxspeed, maxspeed);
        hp += speed * Time.fixedDeltaTime;
        hp = Utils.bound(hp, 0, 100);
    }

    double hp = 100;
    double speed = 0;
    public double maxspeed = 10;
    public double acc = -1;
    public double impulse = 1;
    public TextMeshProUGUI display;
}
