using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PergResp : MonoBehaviour 
{
    //set up
    private int contador = 0;   //This shows in what question the player is
    private int pontuacao = 0;  //pontuacao do player
    PergResp_Text textoData;    //script onde é guardado os dados das perguntas e respostas


    //gameObjects do quiz(titulo, pergunta, resposta, pontuacao)
    public GameObject titulo;
    public GameObject pergunta;
    public GameObject[] resposta;
    public GameObject pontos;


	void Start () 
    {
        //pegando as os text e oerguntas do quiz
        textoData = GameObject.FindWithTag("Text").GetComponent<PergResp_Text>();
        SetPergResp();



	}

    void SetPergResp()
    {
        pontos.GetComponent<Text>().text = pontuacao.ToString();
        titulo.GetComponent<Text>().text = textoData.titulo[contador];
        pergunta.GetComponent<Text>().text = textoData.pergunta[contador];
        resposta[0].GetComponent<Text>().text = textoData.resposta1[contador];
        resposta[1].GetComponent<Text>().text = textoData.resposta2[contador];
        resposta[2].GetComponent<Text>().text = textoData.resposta3[contador];
        resposta[3].GetComponent<Text>().text = textoData.resposta4[contador];
    }

    //sera selecionado pelos botoes
    public void Selecionar0()
    {
        //comparando respostas pra ver se ta certa
        CompararResposta(0);
        AddContador();
        SetPergResp();
    }
    public void Selecionar1()
    {
        //comparando respostas pra ver se ta certa
        CompararResposta(1);
        AddContador();
        SetPergResp();
    }
    public void Selecionar2()
    {
        //comparando respostas pra ver se ta certa
        CompararResposta(2);
        AddContador();
        SetPergResp();
    }
    public void Selecionar3()
    {
        //comparando respostas pra ver se ta certa
        CompararResposta(3);
        AddContador();
        SetPergResp();
    }
    void CompararResposta(int respostaID)
    {
        //comparacao pra ver se escolheu a resposta certa
        if (respostaID == textoData.respostaCorreta[contador])
        {
            //setando nova pontuacao
            pontuacao += 10;
            //setando pontuacao no pegResp_text para storar a data
            textoData.SetPontuacao(pontuacao);
        }
        textoData.SetRespostaSelecionada(respostaID, contador);

        //caso tenha chegado na ultima pergunta, faz o load da tela final
        if (contador == textoData.pergunta.Length - 1)
        {
            SceneManager.LoadScene(2);
        }
    }

    //funcao para adicionar valores ao contador porem impedindo que ele estoure a array
    void AddContador()
    {
        
        contador++;
        Mathf.Clamp(contador, 0, textoData.pergunta.Length);
    }
}
