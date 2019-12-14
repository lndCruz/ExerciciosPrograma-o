using Interfaces;

namespace BusinessRules
{
    class TransformNumberIntoNewNumber : TransformNumberIntoNewNumberInput
    {
        //Para enxergar a UI eu uso sua classe MyDialog
        //para retirar a dependencia, eu precisa que minha  logica apenas peça algo a
        //minha interface. Não me interessa quem a implementa
        public TransformNumberIntoNewNumberOutput Output { get; set; }

        public void ExecuteBusinessRule(int data)
        {
            var newData = data;
            Output.ShowInformation(newData);
        }

        //Implementando o metoda da assinatura da interface input
        public void NewExecuteBusinessRuleInput(int data)
        {
            var newData = data;
            Output.ShowInformation(newData);
        }
    }
}
