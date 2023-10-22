using UnityEngine;
public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    public ChaosGoalScript chaos;
    private float elapsedTime = 0;
    private bool isRunning = false;
    private bool isGameOver = true;
    void Start ()
    {
        elapsedTime = 0;
        isRunning = true;
    }
    
    void Update ()
    {
        // If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;
        if (isRunning)
        {
              elapsedTime = elapsedTime + Time.deltaTime;
        }
    }
    void OnGUI()
    {
       if(isGameOver)
       {
           isRunning = false;
           GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
           GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
       }
       else if(isRunning)
       {
              GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
              GUI.Label(new Rect(Screen.width / 2 -10, Screen.height - 100, 20,30), ((int)elapsedTime).ToString());
       }
    }
}