using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNumbersHelper : MonoBehaviour
{
    [SerializeField] private DisplayNumbers DisplayNumbers;

    [SerializeField] private Text NumberText; 

    [SerializeField] private InputField minInputField;
    [SerializeField] private InputField maxInputField;

        public void OnRunButtonClicked()
        {

            int minNumber = int.Parse(minInputField.text);
            int maxNumber = int.Parse(maxInputField.text);

            if (DisplayNumbers != null)
            {
                NumberText.text = "";
                
                string result = DisplayNumbers.Generate(minNumber, maxNumber);
                
                LogToConsole(result);
            }
        }

        private void LogToConsole(string text)
        {
            if (NumberText != null)
                NumberText.text = NumberText.text + text + "\n";
        }
}
