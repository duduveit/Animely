using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Word
{
    public Text[] letters;
    public Image[] letterBg;
}

public class Manager : MonoBehaviour
{
    public string[] wordList;
    public string[] Categoria;
    public string chosenWord;
    public Text DisplayText;
    public Text Resposta;
    public string anime;
    public Word[] words;
    public Color wrongColor;
    public Color rightColor;
    public Color yellow;
    public Color Select;
    public Color Invisible;
    public Color Bg;
    public bool Game=true;
    KeyButton[] keyButtons;
    int Unavailable=-1;
    public static int WordLenght;
    public GameObject TutPOP;
    public GameObject CreditPOP;
    public GameObject RespostaPOP;
    int Index;
    bool booltutorial= false;
    bool boolcredito= false;
    int letterIndex;
    int wordIndex;
    // Start is called before the first frame update
    void Start()
    {
        Index=Random.Range(0,wordList.Length);
        chosenWord = wordList[Index];
        TutPOP=GameObject.Find("Tutorial POP UP");
        CreditPOP=GameObject.Find("Creditos");
        RespostaPOP=GameObject.Find("MostrarResultado");
        MostrarResultado();
        Creditos();
        anime = Categoria[Index];
        DisplayText.text=anime;
        WordLenght=chosenWord.Length;
        keyButtons = FindObjectsOfType<KeyButton>();
        for(int i=WordLenght;i<8;i++){
            for(int j=0 ;j<6;j++){
            words[j].letterBg[i].color = Invisible;
        }
        }
        words[wordIndex].letterBg[letterIndex].color = Select;
    }

    void Update(){
    if(Game==true){
    if(Input.GetKeyDown(KeyCode.Q))
    {
        SetLetter("Q");
    }
    if(Input.GetKeyDown(KeyCode.W))
    {
        SetLetter("W");
    }
    if(Input.GetKeyDown(KeyCode.E))
    {
        SetLetter("E");
    }
    if(Input.GetKeyDown(KeyCode.R))
    {
        SetLetter("R");
    }
    if(Input.GetKeyDown(KeyCode.T))
    {
        SetLetter("T");
    }
    if(Input.GetKeyDown(KeyCode.Y))
    {
        SetLetter("Y");
    }
    if(Input.GetKeyDown(KeyCode.U))
    {
        SetLetter("U");
    }
    if(Input.GetKeyDown(KeyCode.I))
    {
        SetLetter("I");
    }
    if(Input.GetKeyDown(KeyCode.O))
    {
        SetLetter("O");
    }
    if(Input.GetKeyDown(KeyCode.P))
    {
        SetLetter("P");
    }
    if(Input.GetKeyDown(KeyCode.A))
    {
        SetLetter("A");
    }
    if(Input.GetKeyDown(KeyCode.S))
    {
        SetLetter("S");
    }
    if(Input.GetKeyDown(KeyCode.D))
    {
        SetLetter("D");
    }
    if(Input.GetKeyDown(KeyCode.F))
    {
        SetLetter("F");
    }
    if(Input.GetKeyDown(KeyCode.G))
    {
        SetLetter("G");
    }
    if(Input.GetKeyDown(KeyCode.H))
    {
        SetLetter("H");
    }
    if(Input.GetKeyDown(KeyCode.J))
    {
        SetLetter("J");
    }
    if(Input.GetKeyDown(KeyCode.K))
    {
        SetLetter("K");
    }
    if(Input.GetKeyDown(KeyCode.L))
    {
        SetLetter("L");
    }
    if(Input.GetKeyDown(KeyCode.Z))
    {
        SetLetter("Z");
    }
    if(Input.GetKeyDown(KeyCode.X))
    {
        SetLetter("X");
    }
    if(Input.GetKeyDown(KeyCode.C))
    {
        SetLetter("C");
    }
    if(Input.GetKeyDown(KeyCode.V))
    {
        SetLetter("V");
    }
    if(Input.GetKeyDown(KeyCode.B))
    {
        SetLetter("B");
    }
    if(Input.GetKeyDown(KeyCode.N))
    {
        SetLetter("N");
    }
    if(Input.GetKeyDown(KeyCode.RightArrow))
    {
        if(letterIndex>=WordLenght-1){
            return;
        }
        else{
        words[wordIndex].letterBg[letterIndex].color = Bg;
        letterIndex++;
        words[wordIndex].letterBg[letterIndex].color = Select;
    }
    }
    if(Input.GetKeyDown(KeyCode.LeftArrow))
    {
        if(letterIndex<=0){
            return;
        }
        else{
            if(letterIndex!=WordLenght){
        words[wordIndex].letterBg[letterIndex].color = Bg;
            }
        letterIndex--;
        words[wordIndex].letterBg[letterIndex].color = Select;
    }
    }
    if(Input.GetKeyDown(KeyCode.M))
    {
        SetLetter("M");
    }
    if(Input.GetKeyDown(KeyCode.Backspace))
    {
        BackSpace();
    }

    if(Input.GetKeyDown(KeyCode.KeypadEnter))
    {
        Enter();
    }

    if(Input.GetKeyDown(KeyCode.Return))
    {
        Enter();
    }
}

if(Game==false){
 MostrarResultado();
}

if(Input.GetKeyDown(KeyCode.Escape))
    {
        Application.Quit();
    }
}
    public void Restart(){
        SceneManager.LoadScene("teste");
    }
   public void SetLetter(string letter)
   {
    if(Game==true ){
    if(letterIndex >WordLenght-1){
        return;
    }
    words[wordIndex].letterBg[letterIndex].color = Bg;
    words[wordIndex].letters[letterIndex].text = letter;
    letterIndex++;
    if(letterIndex!=WordLenght){
    words[wordIndex].letterBg[letterIndex].color = Select;
   }
   }
   }
   public void BackSpace()
   {
    if(Game==true){
    if(letterIndex == -1){
        return;
    }
    if(letterIndex >WordLenght-1){
        return;
    }
    words[wordIndex].letterBg[letterIndex].color = Bg;
    words[wordIndex].letters[letterIndex].text = "";
    if (letterIndex!=0){
    letterIndex--;
    }
    words[wordIndex].letterBg[letterIndex].color = Select;
   }
   }
   
    public void Dica(){
    if (Unavailable==-1 && Game==true){
    int Index2=Random.Range(0,WordLenght-1);
    words[wordIndex].letterBg[Index2].color = rightColor;
    words[wordIndex].letters[Index2].text =chosenWord[Index2].ToString();
    Unavailable=Index2;
    }
   }

    public void Tutorial(){
    CreditPOP.gameObject.SetActive(false);
    boolcredito=true;
   if(booltutorial==false){
    TutPOP.gameObject.SetActive(false);
    booltutorial=true;
   }
   else{
    TutPOP.gameObject.SetActive(true);
    booltutorial=false;
   }
   }

    public void Creditos(){
    TutPOP.gameObject.SetActive(false);
    booltutorial=true;
   if(boolcredito==false){
    CreditPOP.gameObject.SetActive(false);
    boolcredito=true;
   }
   else{
    CreditPOP.gameObject.SetActive(true);
    boolcredito=false;
   }
   }
   
    public void MostrarResultado(){
   if(Game==true){
    RespostaPOP.gameObject.SetActive(false);
   }
   else{
    RespostaPOP.gameObject.SetActive(true);
    Resposta.text=chosenWord;
   }
   }


   public void Enter()
   {
    if(Game==true){
    int x=0;
    for(int i=0; i<WordLenght;i++){
        if(words[wordIndex].letters[i].text != ""){
            x++;
        }
    }
    if(x!=WordLenght){
        return;
    }
    
    string newWord = chosenWord;
    char[] newWordArray = newWord.ToCharArray();

    List<int> rightLetters = new List<int>();
    int y=0;
    for(int i=0; i<WordLenght;i++){
        if(words[wordIndex].letters[i].text ==chosenWord[i].ToString()){
            words[wordIndex].letterBg[i].color = rightColor;
            newWordArray[i]= ' ';
            rightLetters.Add(i);
            SetKeyColor(words[wordIndex].letters[i].text,rightColor, true);
            y++;
        }
    }
    
    newWord = new string(newWordArray);
    for(int i=0; i<WordLenght;i++){
        if(!rightLetters.Contains(i))
        {
            if(newWord.Contains(words[wordIndex].letters[i].text))
            {
                words[wordIndex].letterBg[i].color  = yellow;
                SetKeyColor(words[wordIndex].letters[i].text,yellow);
            }
            else
            {
                words[wordIndex].letterBg[i].color = wrongColor;
                SetKeyColor(words[wordIndex].letters[i].text,wrongColor);
            }
        }
    }
    
    if(y==WordLenght){
        Game=false;
    }

    wordIndex++;
    if(wordIndex==6){
    Game=false;
    }
    else{
        
    letterIndex = 0;
    words[wordIndex].letterBg[letterIndex].color = Select;
    }
   }
   }

    void SetKeyColor(string letter,Color color, bool correct = false )
    {
        for(int i = 0; i<keyButtons.Length;i++)
        {
            if(keyButtons[i].key == letter)
            {
                keyButtons[i].SetColor(color,correct);
                break;
            }
        }
    }
}
