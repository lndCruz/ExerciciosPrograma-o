

namespace Interfaces
{
    interface TransformDataIntoNewDataInput
    {
        void NewExecuteBusinessRuleInput(string data);
    }

    interface TransformDataIntoNewDataOuput
    {
        void ShowInformation(string newData);
    }
}
