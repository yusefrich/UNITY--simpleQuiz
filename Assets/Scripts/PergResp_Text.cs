using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PergResp_Text : MonoBehaviour {

    public string[] titulo;
    public string[] pergunta;
    public string[] resposta1;
    public string[] resposta2;
    public string[] resposta3;
    public string[] resposta4;
    public int[] respostaCorreta;

    private int pontuacao;
    private int[] respostaSelecionada = new int[4];

    //This script saves data from the quiz
	void Start () {
        //code for the object not get destroyed
        Object.DontDestroyOnLoad(gameObject);
	}
    public void SetPontuacao(int value)
    {
        pontuacao = value;
        Debug.Log("pontuacao salva = " + pontuacao);
    }
    public void SetRespostaSelecionada(int value, int contador)
    {
        respostaSelecionada[contador] = value;
        Debug.Log("resposta selecionada = " + respostaSelecionada[contador]);
    }
    public int GetPontuacao()
    {
        return pontuacao;
    }
    public int GetRespostaSelecionada(int value)
    {
        return respostaSelecionada[value];
    } 
}
