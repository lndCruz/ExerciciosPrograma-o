using BusinessRules;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //##### using QT ##### //
            var transformData = new TransformDataIntoNewData();
            var transformName = new TransformNameIntoNewName();
            var transformNumber = new TransformNumberIntoNewNumber();


            var qtData = new UI_QT.TransformDataWindow(transformData);
            var qtName = new UI_QT.TransformNameWindow(transformName);
            var qtNumber = new UI_QT.TransformNumberWindow(transformNumber);


            transformData.Output = qtData;
            transformName.Output = qtName;
            transformNumber.Output = qtNumber;

            // simulate user pressing button
            qtData.OnOKUseButtonPressed();
            qtName.OnOKUseButtonPressed();
            qtNumber.OnOKUseButtonPressed();


            //##### using UNITY ##### //
            var unityData = new UI_UNITY.TransformDataWindow(transformData);
            var unityName = new UI_UNITY.TransformNameWindow(transformName);
            var unityNumber = new UI_UNITY.TransformNumberWindow(transformNumber);

            transformData.Output = unityData;
            transformName.Output = unityName;
            transformNumber.Output = unityNumber;

            unityData.OnOKUseButtonPressed();
            unityName.OnOKUseButtonPressed();
            unityNumber.OnOKUseButtonPressed();


            System.Console.ReadKey(); // prevent console from closing
        }
    }
}
