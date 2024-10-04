using ApexCare.BusinessLogic.Communication.Interfaces;

namespace ApexCare.BusinessLogic.Communication{
    public class EmailCommunication : ICommunication{
        private string[] Message;
        public EmailCommunication(){
            Message = new string[] {};
        }
        public void promptInfo(){
            System.Console.WriteLine("Prompting the user...");
        }
        public void submitInfo(string[] message){
            this.Message = message;
            System.Console.WriteLine("Email Message: " + string.Join(", ", message));
        }
    }
}