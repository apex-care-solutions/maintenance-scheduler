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
        private readonly IRepository<Review> ReviewRepository;

        public ReviewService(IRepository<Review> ReviewRepository){
            this.ReviewRepository = ReviewRepository;
        }
        public async Task<Review> GetReviewsAsync(){
            return null;
        }

        public async Task<Review[]> GetReviewsAsync(Expression<Func<Review, bool>>? filter = null){
            return null;
        }

        public async Task<Review> CreateReviewAsync(Review Reviews){
            return null;
        }

        public async Task<Review[]> CreateReviewsAsync(Review[] Reviews){
            return null;
        }

        public async Task<Review> UpdateReviewAsync(Review Reviews){
            return null;
        }

        public async Task<Review[]> UpdateReviewsAsync(Review[] Reviews){
            return null;
        }
    }
}