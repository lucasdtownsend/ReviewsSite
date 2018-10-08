using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class ReviewRepository : IReviewRepository
    {
        Dictionary<int, Review> allReviews = new Dictionary<int, Review>()
        {
            { 1, new Review() {Id = 1, Title = "The First One"} },
            { 2, new Review() {Id = 2, Title = "The Second One"} },
            { 3, new Review() {Id = 3, Title = "The Third One"} }
        };

        public Review FindById(int Id)
        {
            return allReviews[Id];
        }

        public Dictionary<int, Review> GetAll()
        {
            return allReviews;
        }

    }
}
