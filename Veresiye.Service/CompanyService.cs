using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Data;
using Veresiye.Model;

namespace Veresiye.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Company> companyRepository;

        public CompanyService(IUnitOfWork unitOfWork, IRepository<Company>companyRepository)
        {
            this.unitOfWork = unitOfWork;
            this.companyRepository = companyRepository;
        }

        public void Delete(int id)
        {
            var company = companyRepository.Get(id);
            if(company != null)
            {
                companyRepository.Delete(company);
                unitOfWork.SaveChanges();
            }
        }

        public Company Get(int id)
        {
            return companyRepository.Get(id);
        }

        public IEnumerable<Company> GetAll()
        {
            return companyRepository.GetAll();
        }

        public void Insert(Company company)
        {
            companyRepository.Insert(company);
            unitOfWork.SaveChanges();
        }

        public void Update(Company company)
        {
            companyRepository.Update(company);
            unitOfWork.SaveChanges();
        }
    }

    public interface ICompanyService
    {
        void Insert(Company company);
        void Update(Company company);
        void Delete(int id);
        IEnumerable<Company> GetAll();
        Company Get(int id);

    }
}
