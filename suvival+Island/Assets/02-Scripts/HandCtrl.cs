using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HandCtrl : MonoBehaviour
{
    public Animation comBatSgAni;
    public Light flashLight;
    public AudioClip flashSound; // �Ҹ�����
    public AudioSource A_source; // ����� �ҽ�

    void Start() // ���ӽ����� ȣ��Ǵ� ����
    {
        
    }

    void Update() // ���� ������ ��� ȣ��Ǵ� ����
    {
        GunCtrl();
        flash_LightOnOff();
    }

    private void flash_LightOnOff()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            flashLight.enabled = !flashLight.enabled;
            A_source.PlayOneShot(flashSound, 1.0f);
            //�Ҹ� ���� , �Ҹ� �ҷ�
        }
    }

    private void GunCtrl()
    {
        // ���� ����Ʈ Ű�� WŰ�� ���ÿ� �����ٸ�
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            comBatSgAni.Play("running");
        }
        // ���� ����Ʈ Ű�� ����ٸ�
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            comBatSgAni.Play("runStop");
        }
        //GetKey() : ������ ����
        //GetKeyDown() : �����ٸ� �Ѿ� �߻�
        //GetKeyUp() : ���� �� ����ٸ�
    }
}
