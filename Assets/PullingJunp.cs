using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJunp : MonoBehaviour
{
    private Vector3 ClickPosition;
    [SerializeField]
    private float JumpPower = 10;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickPosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            //クリックした座標と話した座標の差分を取得
            Vector3 dist = ClickPosition - Input.mousePosition;
            //クリックとリリースが同じ座標ならば無視
            if(dist.sqrMagnitude == 0) { return; }
            //差分を標準化し、JumpPowerを掛け合わせた値を移動量とする
            rb.velocity = dist.normalized * JumpPower;
        }
    }
}
