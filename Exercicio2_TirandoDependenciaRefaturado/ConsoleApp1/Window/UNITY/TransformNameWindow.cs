using System;
using Interfaces;

namespace UI_UNITY
{
    class TransformNameWindow : TransformNameIntoNewNameOutput
    {
        //TransformDataIntoNewData businessRule;
        TransformNameIntoNewNameInput businessRule;

        public TransformNameWindow(TransformNameIntoNewNameInput businessRule)
        {
            this.businessRule = businessRule;
        }

        public void OnOKUseButtonPressed()
        {
            this.businessRule.NewExecuteBusinessRuleInput("mystring");
        }

        public void ShowNewData(string newData)
        {
            Console.WriteLine(newData + "UNITY");
        }

        //Implementando assinatura da interface
        public void ShowInformation(string newData)
        {
            Console.WriteLine(newData);
        }
    }
}
