using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApexCare.Models;
using ApexCare.Repositories;

namespace ApexCare.BusinessLogic.Services
{
    public class ReviewService
    {
        private readonly Repository<Review> ReviewRepository;

        public ReviewService(Repository<Review> ReviewRepository){
            this.ReviewRepository = ReviewRepository;
        }
        public async Task<Review> GetReviewsAsync(){
            throw new NotImplementedException();
        }

        public async Task<Review[]> GetReviewsAsync(Expression<Func<Review, bool>>? filter = null){
            throw new NotImplementedException();
        }

        public async Task<Review> CreateReviewAsync(Review Reviews){
            throw new NotImplementedException();
        }

        public async Task<Review[]> CreateReviewsAsync(Review[] Reviews){
            throw new NotImplementedException();
        }

        public async Task<Review> UpdateReviewAsync(Review Reviews){
            throw new NotImplementedException();
        }

        public async Task<Review[]> UpdateReviewsAsync(Review[] Reviews){
            throw new NotImplementedException();
        }
    }
}