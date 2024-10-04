using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApexCare.Models;
using ApexCare.Repositories;

namespace ApexCare.BusinessLogic.Services
{
    public class TermServices
    {
        private readonly Repository<Term> termRepository;

        public TermServices(Repository<Term> termRepository){
            this.termRepository = termRepository;
        }
        public async Task<Term> GetTermsAsync(){
            throw new NotImplementedException();
        }

        public async Task<Term[]> GetTermsAsync(Expression<Func<Term, bool>>? filter = null){
            throw new NotImplementedException();
        }

        public async Task<Term> CreateTermAsync(Term Terms){
            throw new NotImplementedException();
        }

        public async Task<Term[]> CreateTermsAsync(Term[] Terms){
            throw new NotImplementedException();
        }

        public async Task<Term> UpdateTermAsync(Term Terms){
            throw new NotImplementedException();
        }

        public async Task<Term[]> UpdateTermsAsync(Term[] Terms){
            throw new NotImplementedException();
        }
    }
}