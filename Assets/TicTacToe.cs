using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour
{
    Boolean checker;
    int plusOne;

    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;

    public Text btnResetGame = null;
    public Text btnNewGame = null;
    public Text msgFeedback = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public void Score(){
        if(btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X"){
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
        }

        if(btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X"){
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
        }

         if(btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X"){
            btnText1.color = Color.green;
            btnText5.color = Color.green;
            btnText9.color = Color.green;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
        }

        if(btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X"){
            btnText3.color = Color.gray;
            btnText5.color = Color.gray;
            btnText7.color = Color.gray;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
        }

        if(btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X"){
            btnText2.color = Color.yellow;
            btnText5.color = Color.yellow;
            btnText8.color = Color.yellow;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
        }

        if(btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X"){
            btnText1.color = Color.cyan;
            btnText4.color = Color.cyan;
            btnText7.color = Color.cyan;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
        }

         if(btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X"){
            btnText4.color = Color.green;
            btnText5.color = Color.green;
            btnText6.color = Color.green;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
        }

        if(btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X"){
            btnText7.color = Color.blue;
            btnText8.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
        }

        //***************************PlayerO*******************************************
        if(btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O"){
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
        }

        if(btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O"){
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
        }

         if(btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O"){
            btnText1.color = Color.green;
            btnText5.color = Color.green;
            btnText9.color = Color.green;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
        }

        if(btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O"){
            btnText3.color = Color.gray;
            btnText5.color = Color.gray;
            btnText7.color = Color.gray;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
        }

        if(btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O"){
            btnText2.color = Color.yellow;
            btnText5.color = Color.yellow;
            btnText8.color = Color.yellow;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
        }

        if(btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O"){
            btnText1.color = Color.cyan;
            btnText4.color = Color.cyan;
            btnText7.color = Color.cyan;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
        }

         if(btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O"){
            btnText4.color = Color.green;
            btnText5.color = Color.green;
            btnText6.color = Color.green;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
        }

        if(btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O"){
            btnText7.color = Color.blue;
            btnText8.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
        }
        
    }
}
