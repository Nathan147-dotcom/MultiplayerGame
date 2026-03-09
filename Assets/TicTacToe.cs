using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using System;

public class TicTacToe : NetworkBehaviour
{
    //Track turn
    private NetworkVariable<int> currentPlayer = new NetworkVariable<int>(0);
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
    public Text msgFeedback = null;
    public Text txtPlayerX;
    public Text txtPlayerO;

    //Host
    public void StartHost(){
        NetworkManager.Singleton.StartHost();
    }
    //Client
    public void StartClient(){
       NetworkManager.Singleton.StartClient(); 
    }

    //All win combinations
    public void score(){
        if (!IsServer){
            return;
        }
        if(btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X"){
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player X Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X"){
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player X Wins", txtPlayerX.text, txtPlayerO.text);
        }

         if(btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X"){
            btnText1.color = Color.green;
            btnText5.color = Color.green;
            btnText9.color = Color.green;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player X Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X"){
            btnText3.color = Color.gray;
            btnText5.color = Color.gray;
            btnText7.color = Color.gray;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player X Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X"){
            btnText2.color = Color.yellow;
            btnText5.color = Color.yellow;
            btnText8.color = Color.yellow;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player X Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X"){
            btnText3.color = Color.cyan;
            btnText6.color = Color.cyan;
            btnText9.color = Color.cyan;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player X Wins", txtPlayerX.text, txtPlayerO.text);
        }

         if(btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X"){
            btnText4.color = Color.green;
            btnText5.color = Color.green;
            btnText6.color = Color.green;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player X Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X"){
            btnText7.color = Color.blue;
            btnText8.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedback.text = "Player X Wins";
            plusOne = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player X Wins", txtPlayerX.text, txtPlayerO.text);
        }

        //***************************PlayerO*******************************************
        if(btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O"){
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player O Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O"){
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player O Wins", txtPlayerX.text, txtPlayerO.text);
        }

         if(btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O"){
            btnText1.color = Color.green;
            btnText5.color = Color.green;
            btnText9.color = Color.green;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player O Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O"){
            btnText3.color = Color.gray;
            btnText5.color = Color.gray;
            btnText7.color = Color.gray;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player O Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O"){
            btnText2.color = Color.yellow;
            btnText5.color = Color.yellow;
            btnText8.color = Color.yellow;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player O Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O"){
            btnText3.color = Color.cyan;
            btnText6.color = Color.cyan;
            btnText9.color = Color.cyan;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player O Wins", txtPlayerX.text, txtPlayerO.text);
        }

         if(btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O"){
            btnText4.color = Color.green;
            btnText5.color = Color.green;
            btnText6.color = Color.green;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player O Wins", txtPlayerX.text, txtPlayerO.text);
        }

        if(btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O"){
            btnText7.color = Color.blue;
            btnText8.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedback.text = "Player O Wins";
            plusOne = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusOne + 1);
            updateWinnerClientRpc("Player O Wins", txtPlayerX.text, txtPlayerO.text);
        }
        
    }

    //Send clicks/move to server
    public void btnText1_Click(){ 
        sendMoveServerRpc(0); 
    }
    public void btnText2_Click(){ 
        sendMoveServerRpc(1); 
    }
    public void btnText3_Click(){ 
        sendMoveServerRpc(2);
    }
    public void btnText4_Click(){ 
        sendMoveServerRpc(3); 
    }
    public void btnText5_Click(){ 
        sendMoveServerRpc(4); 
    }
    public void btnText6_Click(){ 
        sendMoveServerRpc(5); 
    }
    public void btnText7_Click(){ 
        sendMoveServerRpc(6); 
    }
    public void btnText8_Click(){ 
        sendMoveServerRpc(7); 
    }
    public void btnText9_Click(){ 
        sendMoveServerRpc(8);
    }

    //Server updates board where button was clicked
    [ServerRpc(RequireOwnership = false)]
    void sendMoveServerRpc(int index)
    {
        if (!IsServer) return;
        Text selected = getButton(index);
        if (selected.text != "") return;

        if (currentPlayer.Value == 0)
            selected.text = "X";
        else
            selected.text = "O";
        updateBoardClientRpc(index, selected.text);
        score();
        currentPlayer.Value = 1 - currentPlayer.Value;
    }
    [ClientRpc]
    void updateBoardClientRpc(int index, string value)
    {
        if (IsServer){
            return;
        } 
        Text selected = getButton(index);
        selected.text = value;
    }

    //Update win message to client
    [ClientRpc]
    void updateWinnerClientRpc(string message, string scoreX, string scoreO)
    {
        msgFeedback.text = message;
        txtPlayerX.text = scoreX;
        txtPlayerO.text = scoreO;
    }

    //Reset board to all clients
    public void btnResetGame_Click()
    {
        resetBoardServerRpc();
    }
    [ServerRpc]
    void resetBoardServerRpc()
    {
        currentPlayer.Value = 0;
        resetBoardClientRpc();
    }
    [ClientRpc]
    void resetBoardClientRpc(){
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";
        msgFeedback.text = "";

        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;
    }

    //New game and score reset
    public void btnNewGame_Click(){
        resetBoardServerRpc();

        if (IsServer)
        {
            txtPlayerX.text = "0";
            txtPlayerO.text = "0";
            updateWinnerClientRpc("", "0", "0");
        }
    }

    Text getButton(int index)
    {
        switch (index)
        {
            case 0: 
            return btnText1;
            case 1: 
            return btnText2;
            case 2: 
            return btnText3;
            case 3: 
            return btnText4;
            case 4: 
            return btnText5;
            case 5: 
            return btnText6;
            case 6: 
            return btnText7;
            case 7: 
            return btnText8;
            case 8: 
            return btnText9;
        }
        return null;
    }

}