using ApexCare.Services.Communication.Interfaces;

namespace ApexCare.BusinessLogic.Communication{
    public class EmailCommunication : ICommunication{
        private string[] Messages;
        public PhoneCommunication(){
            Messages = [];
        }
            public void PromptInfo(){
            string[] messages = {};
            int iterations = -1;
            while (true){
                iterations++;
                System.Console.WriteLine("Prompting the user WITH EMAIL...");
                messages[iterations] = "Message " + iterations;
                if (iterations == 10){
                    break;
                }
            }
            SubmitInfo(messages);
        }
        public void SubmitInfo(string[] messages){
            this.Messages = messages;
            System.Console.WriteLine("Phone Message: " + string.Join(", ", messages));
            //Call ReportBuilder
        }
    }
}
