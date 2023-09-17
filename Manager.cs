using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public string anime;
    public Word[] words;
    public Color wrongColor;
    public Color rightColor;
    public Color yellow;
    KeyButton[] keyButtons;
    
    int Index;
    int letterIndex;
    int wordIndex;
    // Start is called before the first frame update
    void Start()
    {
        Index=Random.Range(0,wordList.Length);
        chosenWord = wordList[Index];
        anime = Categoria[Index];
        DisplayText.text=anime;
        keyButtons = FindObjectsOfType<KeyButton>();
    }
    void Update()
{
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

    if(Input.GetKeyDown(KeyCode.Escape))
    {
        Application.Quit();
    }
}

   public void SetLetter(string letter)
   {
    if(letterIndex > 4){
        return;
    }
    words[wordIndex].letters[letterIndex].text = letter;
    letterIndex++;
   }
   
   public void BackSpace()
   {
    if(letterIndex == 0){
        return;
    }
    letterIndex--;
    words[wordIndex].letters[letterIndex].text = "";
   }
   
   public void Enter()
   {
    if(letterIndex <= 4)
        return;
    
    string newWord = chosenWord;
    char[] newWordArray = newWord.ToCharArray();

    List<int> rightLetters = new List<int>();

    for(int i=0; i<5;i++){
        if(words[wordIndex].letters[i].text ==chosenWord[i].ToString()){
            words[wordIndex].letterBg[i].color = rightColor;
            newWordArray[i]= ' ';
            rightLetters.Add(i);
            SetKeyColor(words[wordIndex].letters[i].text,rightColor, true);
        }
    }

    newWord = new string(newWordArray);
    for(int i=0; i<5;i++){
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
    wordIndex++;
    letterIndex = 0;
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
