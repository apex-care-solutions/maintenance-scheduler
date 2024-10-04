using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApexCare.Models;
using ApexCare.Repositories;

namespace ApexCare.BusinessLogic.Services
{
    public class TechnicianService
    {
        private readonly Repository<Technician> TechnicianRepository;

        public TechnicianService(Repository<Technician> TechnicianRepository){
            this.TechnicianRepository = TechnicianRepository;
        }
        public async Task<Technician> GetTechniciansAsync(){
            throw new NotImplementedException();
        }

        public async Task<Technician[]> GetTechniciansAsync(Expression<Func<Technician, bool>>? filter = null){
            throw new NotImplementedException();
        }

        public async Task<Technician> CreateTechnicianAsync(Technician Technicians){
            throw new NotImplementedException();
        }

        public async Task<Technician[]> CreateTechniciansAsync(Technician[] Technicians){
            throw new NotImplementedException();
        }

        public async Task<Technician> UpdateTechnicianAsync(Technician Technicians){
            throw new NotImplementedException();
        }

        public async Task<Technician[]> UpdateTechniciansAsync(Technician[] Technicians){
            throw new NotImplementedException();
        }
    }
}