using System;
using Interfaces;

namespace UI_UNITY
{
    class TransformDataWindow : TransformDataIntoNewDataOuput
    {
        TransformDataIntoNewDataInput businessRule;

        public TransformDataWindow(TransformDataIntoNewDataInput businessRule)
        {
            this.businessRule = businessRule;
        }

        public void OnOKUseButtonPressed()
        {
            this.businessRule.NewExecuteBusinessRuleInput("mystring");
        }

        public void ShowNewData(string newData)
        {
            Console.WriteLine(newData);
        }

        //Implementando assinatura da interface
        public void ShowInformation(string newData)
        {
            Console.WriteLine(newData + "UNITY");
        }
    }
}
