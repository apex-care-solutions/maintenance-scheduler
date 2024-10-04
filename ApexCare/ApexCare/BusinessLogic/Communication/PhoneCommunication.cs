using ApexCare.BusinessLogic.Communication.Interfaces;

namespace ApexCare.BusinessLogic.Communication{
    public class PhoneCommunication : ICommunication{
        private string[] Messages;
        public PhoneCommunication(){
            Messages = [];
        }
            public void promptInfo(){
            string[] messages = {};
            int iterations = -1;
            while (true){
                iterations++;
                System.Console.WriteLine("Prompting the user WITH PHONE DIAL MENU...");
                messages[iterations] = "Message " + iterations;
                if (iterations == 10){
                    break;
                }
            }
            submitInfo(messages);
        }
        public void submitInfo(string[] messages){
            this.Messages = messages;
            System.Console.WriteLine("Phone Message: " + string.Join(", ", messages));
            //Call ReportBuilder
        }
    }
}