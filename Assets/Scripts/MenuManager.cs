using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
  public void LoadLVL1()
  {
      SceneManager.LoadScene("Nivel1");
  }
}
