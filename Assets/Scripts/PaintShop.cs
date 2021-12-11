using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintShop : MonoBehaviour
{
    /*
     *Paint shop gives the player the ability to spend coins to gain paint up to their maximum
     *If the player has full paint, they cannot buy paint
     *When in the menu, the game is paused
     *When a player tries to buy paint with full paint, a text prompt tells them they cannot
     *When a player tries to buy paint when they do not have enough coins, a text prompt tells them they don't have enough money
    */

    private string wiz = "Wizard Van Gogh: ";
    public PaintShot ps;//This is to add the paint to the player
    //public PauseMenu pm;//This is used to pause the game while in the menu
    public LevelManager lm;//This is used to see the coin amount

    public Text textbox;//Text prompts will appear here

    private string[] PaintFull = new string[5] 
    { 
        "If you have too much magic, you might explode or something, I don't really know. Just use more of your paint." ,
        "I don't know where you keep these, but you have enough of that one.", 
        "I'm not really feeling like making that one right now. You already have quite a few of that one anyways.", 
        "Why don't you use some of that color first?",
        "Now, here's an idea. Use some of that color then buy more of it."
    };
    private string[] NoMoney = new string[5] 
    { 
        "Magic isn't free you know. Gonna need 3 paintings, buddy.",
        "I can't make something out of nothing. Get more lost paintings.",
        "You're a bit short...and you don't have enough paintings either. 3 paintings. Yes more. No less.",
        "I'm gonna need more paintings to be able to do this magic.",
        "Go get more paintings. I need to extract paint from those paintings."
    };
    private string[] BoughtStuff = new string[5]
    {
        "There you go!",
        "Thank you, come again!",
        "And done! There's your paint.",
        "Now let's go paint the world!",
        "That enough for you?"
    };

    // Start is called before the first frame update
    void Start()
    {
        textbox.text = wiz + "Welcome to my paint stand! I'll take your paintings and make them into more magic paint! I made this quickly just for you. You better be grateful!";
    }

    // Update is called once per frame
    void Update()
    {
        //textbox.text = wiz;
    }
    public void BuyRed()
    {
        if (ps.RedCheck())//The player is able to buy paint
        {//Then check money
            if (lm.BuyPaint())//The player has enough money
            {
                lm.SpendMoney();
                ps.RedUp();//Increase Paint
            }
            else 
            {
                NotEnoughMoney();
            }
        }
        else
        {
            FullPaint();
        }
    }
    public void BuyBlue()
    {
        if (ps.BlueCheck())//The player is able to buy paint
        {//Then check money
            if (lm.BuyPaint())//The player has enough money
            {
                lm.SpendMoney();
                ps.BlueUp();//Increase Paint
            }
            else
            {
                NotEnoughMoney();
            }
        }
        else
        {
            FullPaint();
        }
    }
    public void BuyYellow()
    {
        if (ps.YellowCheck())//The player is able to buy paint
        {//Then check money
            if (lm.BuyPaint())//The player has enough money
            {
                lm.SpendMoney();
                ps.YellowUp();//Increase Paint
            }
            else
            {
                NotEnoughMoney();
            }
        }
        else
        {
            FullPaint();
        }
    }
    public void SuccessfulBuy()
    {
        float randomText = Random.Range(0, 5);
        textbox.text = wiz + BoughtStuff[(int)randomText];
    }
    public void FullPaint()
    {//This is the text prompt to tell the player that they are already at maximum paint
        float randomText = Random.Range(0,5);
        textbox.text = wiz + PaintFull[(int)randomText];
    }
    public void NotEnoughMoney()
    {//This is the text prompt to tell the player that they are already at maximum paint
        float randomText = Random.Range(0, 5);
        textbox.text = wiz + NoMoney[(int)randomText];
    }
}
/*
 * Let's transmute coin to color!"
 * "Magic isn't free you know."
 * "If you have too much magic, you might explode or something, I dunno."
 * ""
 */