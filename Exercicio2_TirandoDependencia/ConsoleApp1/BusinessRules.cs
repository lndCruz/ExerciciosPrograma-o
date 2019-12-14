namespace BusinessRules
{
    class TransformDataIntoNewData : BusinessRulesInput
    {
        //Para enxergar a UI eu uso sua classe MyDialog
        //para retirar a dependencia, eu precisa que minha  logica apenas peça algo a
        //minha interface. Não me interessa quem a implementa
        public BusinessRulesOutput Output { get; set; }

        public void ExecuteBusinessRule(string data)
        {
            var newData = data + "!!!";
            Output.ShowInformation(newData);
        }

        //Implementando o metoda da assinatura da interface input
        public void NewExecuteBusinessRuleInput(string data)
        {
            var newData = data + "!!!";
            Output.ShowInformation(newData);
        }
    }
}
