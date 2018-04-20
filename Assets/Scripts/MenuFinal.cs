using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MenuFinal : MonoBehaviour {

    PergResp_Text textoData;
    public GameObject PontuaçãoObj;

	void Start () {
        textoData = GameObject.FindWithTag("Text").GetComponent<PergResp_Text>();
        PontuaçãoObj.GetComponent<Text>().text = textoData.GetPontuacao().ToString();
	}

    public void Reload()
    {
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void Score()
    {

    }
}
