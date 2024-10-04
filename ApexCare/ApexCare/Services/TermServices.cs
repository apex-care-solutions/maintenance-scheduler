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
            return null;
        }

        public async Task<Term[]> GetTermsAsync(Expression<Func<Term, bool>>? filter = null){
            return null;
        }

        public async Task<Term> CreateTermAsync(Term Terms){
            return null;
        }

        public async Task<Term[]> CreateTermsAsync(Term[] Terms){
            return null;
        }

        public async Task<Term> UpdateTermAsync(Term Terms){
            return null;
        }

        public async Task<Term[]> UpdateTermsAsync(Term[] Terms){
            return null;
        }
    }
}