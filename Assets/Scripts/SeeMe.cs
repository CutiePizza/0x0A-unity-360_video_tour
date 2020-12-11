using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeeMe : MonoBehaviour
{
 public GameObject livingroom_0;
 public GameObject livingroom_1;

 public GameObject cantina;

 public GameObject cube;

 public GameObject mezz0;
 public GameObject mezz1;

 public void see_me()
 {
     livingroom_0.SetActive(true);
 }
 public void not_seet()
 {
     livingroom_0.SetActive(false);
 }
 
 public void see_me_1()
 {
     livingroom_1.SetActive(true);
 }
 public void not_see_1()
 {
     livingroom_1.SetActive(false);
 }

 public void see_me_cantina()
 {
     cantina.SetActive(true);
 }

public void not_see_me_cantina()
 {
     cantina.SetActive(false);
 }

public void see_me_cube()
 {
    cube.SetActive(true);
 }
public void not_see_me_cube()
 {
    cube.SetActive(false);
 }

 public void see_me_mezz0()
 {
    mezz0.SetActive(true);
 }
public void not_see_me_mezz0()
 {
    mezz0.SetActive(false);
 }
 
 public void see_me_mezz1()
 {
    mezz1.SetActive(true);
 }
public void not_see_me_mezz1()
 {
    mezz1.SetActive(false);
 }

}
