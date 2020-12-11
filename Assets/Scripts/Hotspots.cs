using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotspots : MonoBehaviour
{
    //Spheres Gameobjects
    public GameObject LivingRoom;
    public GameObject Cantina;
    public GameObject Cube;
    public GameObject Mezz;
    
    // Fade Animator
    public Animator anim;

    IEnumerator la(GameObject one, GameObject two)
    {
        yield return new WaitForSeconds(2);
        one.SetActive(false);
        two.SetActive(true);  
        
       
    }

    public void FromStartToCantina()
    {     
        anim.SetTrigger("fadingout");
        
        StartCoroutine(la(LivingRoom, Cantina));
           
    }

    public void FromStartToCube()
    {
        anim.SetTrigger("fadingout");  
        StartCoroutine(la(LivingRoom, Cube));
    }

    public void FromCantinaToLivingRoom()
    {
        anim.SetTrigger("fadingout");
        StartCoroutine(la(Cantina, LivingRoom));    
    }

    public void FromCantinaToCube()
    {
        anim.SetTrigger("fadingout");
        StartCoroutine(la(Cantina, Cube));    
    }

    public void FromCubeToLivingRoom()
    {
        anim.SetTrigger("fadingout");
        StartCoroutine(la(Cube, LivingRoom));
    }

    public void FromCubeToCantina()
    {
        anim.SetTrigger("fadingout");
        StartCoroutine(la(Cube, Cantina));
    }

    public void FromCubeToMezz()
    {
        anim.SetTrigger("fadingout");
        StartCoroutine(la(Cube, Mezz));
    }
    public void FromMezzToCube()
    {
        anim.SetTrigger("fadingout");
        StartCoroutine(la(Mezz, Cube));
    }

}
