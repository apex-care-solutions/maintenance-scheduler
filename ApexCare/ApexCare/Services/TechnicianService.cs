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
            return null;
        }

        public async Task<Technician[]> GetTechniciansAsync(Expression<Func<Technician, bool>>? filter = null){
            return null;
        }

        public async Task<Technician> CreateTechnicianAsync(Technician Technicians){
            return null;
        }

        public async Task<Technician[]> CreateTechniciansAsync(Technician[] Technicians){
            return null;
        }

        public async Task<Technician> UpdateTechnicianAsync(Technician Technicians){
            return null;
        }

        public async Task<Technician[]> UpdateTechniciansAsync(Technician[] Technicians){
            return null;
        }
    }
}