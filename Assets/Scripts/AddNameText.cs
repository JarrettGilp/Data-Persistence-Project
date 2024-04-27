using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNameText : MonoBehaviour
{
    public Text displayText;
    public MainManager mainManager;
    public MaxPoints maxPointsObj;
    private TextObject textObj;

    // Start is called before the first frame update
    void Start()
    {
        textObj = FindObjectOfType<TextObject>();
    }

    private void Update()
    {
        int points = mainManager.getPoints();
        int maxPoints = maxPointsObj.getMaxPoints();

        if( maxPoints < points )
        {
            maxPointsObj.setMaxPoints(points);
        }

        if (textObj != null)
        {
            string enteredText = textObj.getNameText();
            displayText.text = "Best Score : " + enteredText + " : " + maxPointsObj.getMaxPoints();
        }
        else
        {
            // do nothing
        }
    }

}
