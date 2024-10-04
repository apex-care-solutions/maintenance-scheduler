using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApexCare.Models;
using ApexCare.Repositories;

namespace ApexCare.BusinessLogic.Services
{
    public class PackageService
    {
        private readonly Repository<Package> packageRepository;

        public PackageService(Repository<Package> packageRepository){
            this.packageRepository = packageRepository;
        }
        public async Task<Package> GetPackagesAsync(){
            return null;
        }

        public async Task<Package[]> GetPackagesAsync(Expression<Func<Package, bool>>? filter = null){
            return null;
        }

        public async Task<Package> CreatePackageAsync(Package packages){
            return null;
        }

        public async Task<Package[]> CreatePackagesAsync(Package[] packages){
            return null;
        }

        public async Task<Package> UpdatePackageAsync(Package packages){
            return null;
        }

        public async Task<Package[]> UpdatePackagesAsync(Package[] packages){
            return null;
        }
    }
}