using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw : MonoBehaviour
{
    [SerializeField]
    private Image arrowImage;

    private Vector3 clickPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�������u��
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
            arrowImage.gameObject.SetActive(true);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            //�x�N�g���̒������Z�o
            float size = dist.magnitude;
            //�x�N�g������p�x(�ʓx�@)���Z�o
            float angleRed = Mathf.Atan2(dist.y, dist.x);
            //���̉摜���N���b�N�����ꏊ�ɉ摜���ړ�
            arrowImage.rectTransform.position = clickPosition;
            //���̉摜���ׂ�������Z�o�����ʓx�@�ɕϊ�����Z����]
            arrowImage.rectTransform.rotation =
                Quaternion.Euler(0, 0, angleRed * Mathf.Rad2Deg);
            //y���̉摜���h���b�O���������ɍ��킹��
            arrowImage.rectTransform.sizeDelta = new Vector2(size, size);
        }
        //�b�����u��
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            Debug.Log(dist);

            arrowImage.gameObject.SetActive(false);
        }

    }
}
