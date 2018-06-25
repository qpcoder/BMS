/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Repository.EF;
    using System;
    using System.Collections.Generic;

    class CommonRepositoryImp : BaseRepository, ICommonRepository
    {
        public bool DeleteCountry(int countryID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCountry(Func<Country, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDistrict(Guid districtID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDistrict(Func<District, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFaculty(int facultyID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFaculty(Func<Faculty, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGrader(Guid graderID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGrader(Func<Grader, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProvince(Guid provinceID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProvince(Func<Province, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUniversity(Guid universityID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUniversity(Func<University, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditCountry(Func<Country, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditCountry(Country modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditDistrict(Func<District, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditDistrict(District modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditFaculty(Func<Faculty, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditFaculty(Faculty modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditGrader(Func<Grader, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditGrader(Grader modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditProvince(Func<Province, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditProvince(Province modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditUniversity(Func<University, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditUniversity(University modelEdit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<District> GetAllDistricts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Faculty> GetAllFaculties()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grader> GetAllGraders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> GetAllProvinces()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<University> GetAllUniversities()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetCountry(Func<Country, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Country GetCountry(int countryID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<District> GetDistrict(Func<District, bool> expression)
        {
            throw new NotImplementedException();
        }

        public District GetDistrict(int districtID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Faculty> GetFaculty(Func<Faculty, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Faculty GetFaculty(int facultyID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grader> GetGrader(Func<Grader, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Grader GetGrader(int graderID)
        {
            throw new NotImplementedException();
        }

        public Province GetProvince(int provinceID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> GetProvinces(Func<Province, bool> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<University> GetUniversity(Func<University, bool> expression)
        {
            throw new NotImplementedException();
        }

        public University GetUniversity(int universityID)
        {
            throw new NotImplementedException();
        }

        public bool SetCountry(Country model)
        {
            throw new NotImplementedException();
        }

        public bool SetCountry(List<Country> models)
        {
            throw new NotImplementedException();
        }

        public bool SetDistrict(District model)
        {
            throw new NotImplementedException();
        }

        public bool SetDistrict(List<District> models)
        {
            throw new NotImplementedException();
        }

        public bool SetFaculty(Faculty model)
        {
            throw new NotImplementedException();
        }

        public bool SetGrader(Grader model)
        {
            throw new NotImplementedException();
        }

        public bool SetGrader(List<Grader> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListFaculty(List<Faculty> models)
        {
            throw new NotImplementedException();
        }

        public bool SetProvince(Province model)
        {
            throw new NotImplementedException();
        }

        public bool SetProvince(List<Province> models)
        {
            throw new NotImplementedException();
        }

        public bool SetUniversity(University model)
        {
            throw new NotImplementedException();
        }

        public bool SetUniversity(List<University> models)
        {
            throw new NotImplementedException();
        }
    }
}
