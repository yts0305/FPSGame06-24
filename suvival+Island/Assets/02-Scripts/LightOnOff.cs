using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light StairLight;
    public AudioSource source;
    public AudioClip clip;
    void Start()
    {
        
    }
    //is Trigger ���� �� ��� �ϸ鼭 �浹 ����
    // �ϴ� �Լ� �ݹ� �Լ���� �� ������ ȣ�� �ϱ� ����
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StairLight.enabled = true;
            source.PlayOneShot(clip, 1.0f);
            //�浹ü�� �±װ˻縦 ���� ������ ����Ʈ ��
        }
    }

    // �ݶ��̴� ������ ���Դٰ� ���� ������ �� 
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StairLight.enabled = false;
        }
    }
    void Update()
    {
        
    }
}
