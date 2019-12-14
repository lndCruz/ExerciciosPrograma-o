using System;
using BusinessRules;

namespace UI
{
    class MyDialog : BusinessRulesOutput
    {
        //TransformDataIntoNewData businessRule;
        BusinessRulesInput businessRule;

        public MyDialog(BusinessRulesInput businessRule)
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
            Console.WriteLine(newData);
        }
    }
}
