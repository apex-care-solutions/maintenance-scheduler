using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApexCare.Models;
using ApexCare.Repositories;

namespace ApexCare.BusinessLogic.Services
{
    public class RequestService
    {
        private readonly Repository<Request> requestRepository;

        public RequestService(Repository<Request> requestRepository){
            this.requestRepository = requestRepository;
        }
        public static Request RequestBuilder(string[] messages){
            throw new NotImplementedException();
        }

        public async Task<Request> GetRequestsAsync(){
            throw new NotImplementedException();
        }

        public async Task<Request> GetRequestAsync(Expression<Func<Request, bool>>? filter = null){
            throw new NotImplementedException();
        }

        public async Task<Request> CreateRequestAsync(Request request){
            throw new NotImplementedException();
        }

        public async Task<Request[]> CreateRequestsAsync(Request[] requests){
            throw new NotImplementedException();
        }

        public async Task<Request> UpdateRequestAsync(Request request){
            throw new NotImplementedException();
        }

        public async Task<Request[]> UpdateRequestsAsync(Request[] requests){
            throw new NotImplementedException();
        }
    }
}