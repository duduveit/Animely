using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Estatisticas : MonoBehaviour
{
    public static int Streak=0;
    public static int Acertos=0;
    public static int[] Answers={0,0,0,0,0,0,0,0};
    public static int GamesPlayed=0;
    public Text WinStreak;
    public Text Porcentagem;
    public Text ANRespostas;
    public Text JogosJogados;
    public GameObject Statics;
    public GameObject Nada1;
    public GameObject Nada2;
    public GameObject Nada3;
    public GameObject Nada4;
    public GameObject Nada5;
    public GameObject Nada6;
    public GameObject Nada7;
    bool GAME;
    public Slider um;
    public Slider dois;
    public Slider tres;
    public Slider quatro;
    public Slider cinco;
    public Slider seis;
    public Slider Death;

    // Start is called before the first frame update
    void Start()
    {   
        Nada1.SetActive(false);
        Nada2.SetActive(false);
        Nada3.SetActive(false);
        Nada4.SetActive(false);
        Nada5.SetActive(false);
        Nada6.SetActive(false);
        Nada7.SetActive(false);
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
            float Total=0;
            for(int x=1;x<8;x++){
                result+=x.ToString();
                result+=": ";
                result+=Answers[x].ToString();
                result+="\n";
                Total+=Answers[x];
            }
            ANRespostas.text=result.ToString();
            Statics.gameObject.SetActive(true);
            um.value=(Answers[1]/Total)*100;
            dois.value=(Answers[2]/Total)*100;
            tres.value=(Answers[3]/Total)*100;
            quatro.value=(Answers[4]/Total)*100;
            cinco.value=(Answers[5]/Total)*100;
            seis.value=(Answers[6]/Total)*100;
            Death.value=(Answers[7]/Total)*100;
            if(Answers[1]==0){
                Nada1.SetActive(true);
            }
            if(Answers[2]==0){
                Nada2.SetActive(true);
            }
            if(Answers[3]==0){
                Nada3.SetActive(true);
            }
            if(Answers[4]==0){
                Nada4.SetActive(true);
            }
            if(Answers[5]==0){
                Nada5.SetActive(true);
            }
            if(Answers[6]==0){
                Nada6.SetActive(true);
            }
            if(Answers[7]==0){
                Nada7.SetActive(true);
            }
        }
    }
}
