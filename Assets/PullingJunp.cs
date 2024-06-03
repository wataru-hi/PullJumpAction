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
            //�N���b�N�������W�Ƙb�������W�̍������擾
            Vector3 dist = ClickPosition - Input.mousePosition;
            //�N���b�N�ƃ����[�X���������W�Ȃ�Ζ���
            if(dist.sqrMagnitude == 0) { return; }
            //������W�������AJumpPower���|�����킹���l���ړ��ʂƂ���
            rb.velocity = dist.normalized * JumpPower;
        }
    }
}
