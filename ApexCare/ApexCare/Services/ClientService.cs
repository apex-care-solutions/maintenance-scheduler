using System.Linq.Expressions;
using ApexCare.Models;
using ApexCare.Repositories;

namespace ApexCare.Services{
    public class ClientService{
        private readonly Repository<Client> clientRepository;

        public ClientService(Repository<Client> clientRepository){
            this.clientRepository = clientRepository;
        }

        public async Task<Request> GetClientsAsync(Expression<Func<Client, bool>>? filter = null){
            throw new NotImplementedException();
        }

        public async Task<Request> CreateClientAsync(Request request){
            throw new NotImplementedException();
        }

        public async Task<Request[]> CreateClientsAsync(Request[] requests){
            throw new NotImplementedException();
        }

        public async Task<Request> UpdateClientAsync(Request request){
            throw new NotImplementedException();
        }

        public async Task<Request[]> UpdateClientsAsync(Request[] requests){
            throw new NotImplementedException();
        }
    }
}