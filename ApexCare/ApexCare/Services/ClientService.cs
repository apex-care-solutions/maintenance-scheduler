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
            return null;
        }

        public async Task<Request> CreateClientAsync(Request request){
            return null;
        }

        public async Task<Request[]> CreateClientsAsync(Request[] requests){
            return null;
        }

        public async Task<Request> UpdateClientAsync(Request request){
            return null;
        }

        public async Task<Request[]> UpdateClientsAsync(Request[] requests){
            return null;
        }
    }
}