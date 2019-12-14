using UI;
using BusinessRules;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessRule = new TransformDataIntoNewData();
            var ui = new MyDialog(businessRule);
            businessRule.Output = ui;


            // simulate user pressing button
            ui.OnOKUseButtonPressed();


            System.Console.ReadKey(); // prevent console from closing
        }
    }
}
