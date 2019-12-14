using System;
using Interfaces;

namespace UI_QT
{
    class TransformNumberWindow : TransformNumberIntoNewNumberOutput
    {
        //TransformDataIntoNewData businessRule;
        TransformNumberIntoNewNumberInput businessRule;

        public TransformNumberWindow(TransformNumberIntoNewNumberInput businessRule)
        {
            this.businessRule = businessRule;
        }

        public void OnOKUseButtonPressed()
        {
            this.businessRule.NewExecuteBusinessRuleInput(10);
        }

        public void ShowNewData(int newData)
        {
            Console.WriteLine(newData);
        }

        //Implementando assinatura da interface
        public void ShowInformation(int newData)
        {
            Console.WriteLine(newData + "QT");
        }
    }
}
