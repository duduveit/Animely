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
    public string wordX;
    public Text DisplayText;
    public Text Resposta;
    bool dica=true;
    public string anime;
    public Word[] words;
    public Color wrongColor;
    public Color rightColor;
    public Color yellow;
    public Color Select;
    public Color Invisible;
    public Color Bg;
    public Color Used;
    public Image dicaImage;
    public Image desisto;
    public int[] DicasP;
    public static bool Game=true;
    KeyButton[] keyButtons;
    int Unavailable=-1;
    public static int WordLenght;
    public GameObject TutPOP;
    public GameObject Invalid;
    public GameObject CreditPOP;
    public GameObject RespostaPOP;
    public GameObject NewGame;
    public GameObject Table;
    public GameObject Controles;

    int Index;
    bool booltutorial= false;
    bool boolcredito= false;
    bool boolcontrol=false;
    int letterIndex;
    int wordIndex;
    // Start is called before the first frame update
    void Start()
    { 
        Game=true;
        Index=Random.Range(0,wordList.Length);
        chosenWord = wordList[Index];
        TutPOP=GameObject.Find("Tutorial POP UP");
        CreditPOP=GameObject.Find("Creditos");
        RespostaPOP=GameObject.Find("MostrarResultado");
        Controles=GameObject.Find("Controle");
        Invalid=GameObject.Find("Invalid");
        MostrarResultado();
        Creditos();
        NewGame.SetActive(false);
        Invalid.SetActive(false);
        Controles.SetActive(false);
        anime = Categoria[Index];
        DisplayText.text=anime;
        WordLenght=chosenWord.Length;
        //int change=(8-WordLenght)*25;
        //Table.transform.position = new Vector3(790+change, 625, 0);
        keyButtons = FindObjectsOfType<KeyButton>();
        for(int i=WordLenght;i<8;i++){
            for(int j=0 ;j<6;j++){
            words[j].letterBg[i].color = Invisible;
            DicasP[i]=1;
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
    if(Input.GetKeyDown(KeyCode.Delete))
    {
        letterIndex=WordLenght-1;
        BackSpace();
    }
    if(Input.GetKeyDown(KeyCode.Minus))
    {
        letterIndex=WordLenght-1;
        for(int i=0;i<WordLenght+1;i++){
            BackSpace();
            if(letterIndex==Unavailable){
              if(letterIndex<=0){
            words[wordIndex].letterBg[letterIndex].color = Bg;
            letterIndex=WordLenght-1;
            words[wordIndex].letterBg[letterIndex].color = Select;
        }
        if(letterIndex-1==Unavailable){
            if(letterIndex<0 ||Unavailable==0){
            }
        words[wordIndex].letterBg[letterIndex].color = Bg;
        letterIndex-=2;
        words[wordIndex].letterBg[letterIndex].color = Select;
        }
        else{
            if(letterIndex!=WordLenght){
        words[wordIndex].letterBg[letterIndex].color = Bg;
            }
        letterIndex--;
        words[wordIndex].letterBg[letterIndex].color = Select;
    
    }  
            }
    }

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
    if(Input.GetKeyDown(KeyCode.UpArrow))
    {
        words[wordIndex].letterBg[letterIndex].color = Bg;
        if(Unavailable==0){
            letterIndex=1;
        }
        else{
            letterIndex=0;
        }
        words[wordIndex].letterBg[letterIndex].color = Select;
        return;
    }
    if(Input.GetKeyDown(KeyCode.DownArrow))
    {
        words[wordIndex].letterBg[letterIndex].color = Bg;
        if(Unavailable==WordLenght-1){
            letterIndex=WordLenght-2;
        }
        else{
            letterIndex=WordLenght-1;
        }
        words[wordIndex].letterBg[letterIndex].color = Select;
        return;
    }
    if(Input.GetKeyDown(KeyCode.RightArrow))
    {
        if(letterIndex>=WordLenght-1){
            if(WordLenght-1==letterIndex){
            words[wordIndex].letterBg[letterIndex].color = Bg;
            }
            if(Unavailable==0){
            letterIndex=1;
            words[wordIndex].letterBg[letterIndex].color = Select;
            return;
            }
            letterIndex=0;
            words[wordIndex].letterBg[letterIndex].color = Select;
            return;
        }
        if(letterIndex+1==Unavailable){
            if(Unavailable==WordLenght-1){
            return;
            }
            words[wordIndex].letterBg[letterIndex].color = Bg;
        letterIndex+=2;
        words[wordIndex].letterBg[letterIndex].color = Select;
        }
        else{
        words[wordIndex].letterBg[letterIndex].color = Bg;
        letterIndex++;
        if(letterIndex==WordLenght){
            letterIndex=0;
        }
        words[wordIndex].letterBg[letterIndex].color = Select;
    }
    }
     if(Input.GetKeyDown(KeyCode.Space))
    {
        if(letterIndex>=WordLenght-1){
            if(WordLenght-1==letterIndex){
            words[wordIndex].letterBg[letterIndex].color = Bg;
            }
            if(Unavailable==0){
            letterIndex=1;
            words[wordIndex].letterBg[letterIndex].color = Select;
            return;
            }
            letterIndex=0;
            words[wordIndex].letterBg[letterIndex].color = Select;
            return;
        }
        if(letterIndex+1==Unavailable){
            if(Unavailable==WordLenght-1){
            return;
            }
            words[wordIndex].letterBg[letterIndex].color = Bg;
        letterIndex+=2;
        words[wordIndex].letterBg[letterIndex].color = Select;
        }
        else{
        words[wordIndex].letterBg[letterIndex].color = Bg;
        letterIndex++;
        if(letterIndex==WordLenght){
            letterIndex=0;
        }
        words[wordIndex].letterBg[letterIndex].color = Select;
    }
    }
    if(Input.GetKeyDown(KeyCode.LeftArrow))
    {
        if(letterIndex<=0){
            words[wordIndex].letterBg[letterIndex].color = Bg;
            letterIndex=WordLenght-1;
            words[wordIndex].letterBg[letterIndex].color = Select;
            return;
        }
        if(letterIndex-1==Unavailable){
            if(letterIndex<0 ||Unavailable==0){
            return;
            }
        words[wordIndex].letterBg[letterIndex].color = Bg;
        letterIndex-=2;
        words[wordIndex].letterBg[letterIndex].color = Select;
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
    NewGame.SetActive(true);
    words[wordIndex].letterBg[letterIndex].color = Bg;
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
    Invalid.SetActive(false);
    if(Game==true ){
    if(letterIndex >WordLenght-1){
        return;
    }
    words[wordIndex].letterBg[letterIndex].color = Bg;
    words[wordIndex].letters[letterIndex].text = letter;
    if(letterIndex!=WordLenght-1){
    letterIndex++;
    }
    else{
        letterIndex=0;
    }
    if(letterIndex==Unavailable){
        if(Unavailable==WordLenght-1){
            return;
            }
            letterIndex++;
    }
    if(letterIndex!=WordLenght){
    words[wordIndex].letterBg[letterIndex].color = Select;
   }
   }
   }
   public void BackSpace()
   {
    if(Game==true){
        Invalid.SetActive(false);
    if(letterIndex == -1 || letterIndex== WordLenght){
        return;
    }
    if(letterIndex >WordLenght){
        return;
    }
    if (letterIndex==WordLenght){
        letterIndex=WordLenght-1;
        words[wordIndex].letterBg[letterIndex].color = Select;
        return;
    }
    words[wordIndex].letterBg[letterIndex].color = Bg;
    words[wordIndex].letters[letterIndex].text = "";
    if (letterIndex!=0){
    letterIndex--;
    if(letterIndex==Unavailable && Unavailable!=0){
        letterIndex--;
    }
    if (Unavailable==0 && letterIndex==0){
        letterIndex++;

    }
    }
    if(letterIndex>WordLenght){
    words[wordIndex].letterBg[letterIndex].color = Invisible;
    letterIndex=WordLenght-1;
    }
    words[wordIndex].letterBg[letterIndex].color = Select;
   }
   }
   
    public void Dica(){
    int x=0;
    for(int i=0; i<WordLenght-1;i++){
    if(DicasP[i]==1){
    x++;
    }
    }
    if (x==WordLenght){
        Unavailable=10;
    }
    else if (Unavailable==-1 && Game==true && dica==true){
    int Index2=Random.Range(0,WordLenght-1);
    if(DicasP[Index2]==1){
    for(int a=0;a<WordLenght;a++){
        if(DicasP[a]==0){
            Index2=a;
        }
    }
    }
    words[wordIndex].letterBg[Index2].color = rightColor;
    words[wordIndex].letters[Index2].text =chosenWord[Index2].ToString();
    Unavailable=Index2;
    DicasP[Index2]=1;
    if(Index2==0){
        letterIndex++;
    }
    if(letterIndex==Unavailable){
        if(Unavailable==0){
            letterIndex=1;
        }
        else{
            letterIndex=0;
        }
        words[wordIndex].letterBg[letterIndex].color = Select;
    }
    dica=false;
    dicaImage.color=Used;
    }
   }

    public void Tutorial(){
    if(Game==true){
    CreditPOP.gameObject.SetActive(false);
    Controles.gameObject.SetActive(false);
    boolcredito=true;
    boolcontrol=true;
   if(booltutorial==false){
    TutPOP.gameObject.SetActive(false);
    booltutorial=true;
   }
   else{
    TutPOP.gameObject.SetActive(true);
    booltutorial=false;
   }
   }
    }

    public void Control(){
    if(Game==true){
    CreditPOP.gameObject.SetActive(false);
    TutPOP.gameObject.SetActive(false);
    boolcredito=true;
   if(boolcontrol==false){
    Controles.gameObject.SetActive(false);
    boolcontrol=true;
   }
   else{
    Controles.gameObject.SetActive(true);
    boolcontrol=false;
   }
   }
    }


    public void GiveUp(){
        if(Game!=false){
            desisto.color=Used;
        Game=false;
        Invalid.gameObject.SetActive(false);
        Estatisticas.GamesPlayed++;
        Estatisticas.Streak=0;
        Estatisticas.Answers[7]++;
    }
    }

    public void Creditos(){
    if(Game==true){
    TutPOP.gameObject.SetActive(false);
    Controles.gameObject.SetActive(false);
    booltutorial=true;
    boolcontrol=true;
   if(boolcredito==false){
    CreditPOP.gameObject.SetActive(false);
    boolcredito=true;
   }
   else{
    CreditPOP.gameObject.SetActive(true);
    boolcredito=false;
   }
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

    public bool VerifyWord(){
        for (int j=0;j<wordList.Length;j++){
            wordX= wordList[j];
            int size=wordX.Length;
            int V=0;
            int X=0;
        for(int i=0; i<size;i++){
        if(words[wordIndex].letters[i].text ==wordX[i].ToString()){
            V++;
        }
        X++;
        }
        
        if(V==size && X==WordLenght){
            return false;
        }
        }
        return true;
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
    if(VerifyWord()){
        Invalid.SetActive(true);
        return;
    }
    Invalid.SetActive(false);
    string newWord = chosenWord;
    char[] newWordArray = newWord.ToCharArray();

    List<int> rightLetters = new List<int>();
    int y=0;
    for(int i=0; i<WordLenght;i++){
        if(words[wordIndex].letters[i].text ==chosenWord[i].ToString()){
            words[wordIndex].letterBg[i].color = rightColor;
            DicasP[i]=1;
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
        Estatisticas.GamesPlayed++;
        Estatisticas.Acertos++;
        Estatisticas.Streak++;
        Estatisticas.Answers[wordIndex+1]++;
    
    }

    wordIndex++;
    if(wordIndex==6){
    Game=false;
    Estatisticas.GamesPlayed++;
    Estatisticas.Streak=0;
    Estatisticas.Answers[7]++;
    }
    else{
        
    letterIndex = 0;
    words[wordIndex].letterBg[letterIndex].color = Select;
    }
   }
   if(dica==false){
    Unavailable=10;
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
