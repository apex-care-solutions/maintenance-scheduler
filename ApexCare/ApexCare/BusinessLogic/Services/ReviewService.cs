using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApexCare.BusinessLogic.Services
{
    public class ReviewService
    {
        private List<Review> requests = new List<Rev>();

        public Request createRequest() {
            return new Request();
        }
        public void addRequest() {

        }

        public void removeRequest() {

        }

        public List<Request> getPackages() {
            return requests;
        }
    }
}