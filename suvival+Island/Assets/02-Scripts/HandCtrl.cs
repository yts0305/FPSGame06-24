using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HandCtrl : MonoBehaviour
{
    public Animation comBatSgAni;
    public Light flashLight;
    public AudioClip flashSound; // 소리파일
    public AudioSource A_source; // 오디오 소스

    void Start() // 게임시작전 호출되는 공간
    {
        
    }

    void Update() // 게임 시작후 계속 호출되는 공간
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
            //소리 파일 , 소리 불륨
        }
    }

    private void GunCtrl()
    {
        // 왼쪽 쉬프트 키와 W키를 동시에 눌렀다면
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            comBatSgAni.Play("running");
        }
        // 왼쪽 쉬프트 키를 띄었다면
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            comBatSgAni.Play("runStop");
        }
        //GetKey() : 누르는 동안
        //GetKeyDown() : 눌렀다면 총알 발사
        //GetKeyUp() : 누른 후 띄었다면
    }
}
