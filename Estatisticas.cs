using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Estatisticas : MonoBehaviour
{
    public static int Streak=0;
    public static int Acertos=0;
    public static int[] Answers={0,0,0,0,0,0,0};
    public static int GamesPlayed=0;
    public Text WinStreak;
    public Text Porcentagem;
    public Text ANRespostas;
    public Text JogosJogados;
    public GameObject Statics;
    bool GAME;

    // Start is called before the first frame update
    void Start()
    {
        Statics=GameObject.Find("Estaticas");
        Statics.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GAME=Manager.Game;
        if(GAME==true){
        Statics.gameObject.SetActive(false);
        }
        if(GAME==false){
            
            WinStreak.text="Win Streak:\n"+Streak.ToString();
            JogosJogados.text="Games Played:\n"+GamesPlayed.ToString();
            Porcentagem.text="Acertos:\n"+Acertos.ToString();
            string result="";

            for(int x=1;x<7;x++){
                result+=x.ToString();
                result+=":       ";
                result+=Answers[x].ToString();
                result+="\n";
            }
            ANRespostas.text=result.ToString();
            Statics.gameObject.SetActive(true);
        }
    }
}
