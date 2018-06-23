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

    class CommonRepositoryImp : ICommonRepository
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        public readonly ILoggingHelper logger =
            QPC.BMS.Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());

        public bool DeleteAllCountries()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllDistricts()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllFaculties()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllGraders()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllProvinces()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllUniversities()
        {
            throw new NotImplementedException();
        }

        public bool DeleteCountryByExpression(Func<Country, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCountryByID(Guid countryID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDistrictByExpression(Func<District, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDistrictByID(Guid districtID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFacultyByExpression(Func<Faculty, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFacultyByID(Guid facultyID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGraderByExpression(Func<Grader, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGraderByID(Guid graderID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProvinceByExpression(Func<Province, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProvinceByID(Guid provinceID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUniversityByExpression(Func<University, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUniversityByID(Guid universityID)
        {
            throw new NotImplementedException();
        }

        public bool EditCountryByExpression(Func<Country, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditCountryByObject(Country modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditDistrictByExpression(Func<District, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditDistrictByObject(District modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditFacultyByExpression(Func<Faculty, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditFacultyByObject(Faculty modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditGraderByExpression(Func<Grader, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditGraderByObject(Grader modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditProvinceByExpression(Func<Province, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditProvinceByObject(Province modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditUniversityByExpression(Func<University, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditUniversityByObject(University modelEdit)
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

        public IEnumerable<Country> GetCountriesByExpression(Func<Country, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Country GetCountryByID(Guid countryID)
        {
            throw new NotImplementedException();
        }

        public District GetDistrictByID(Guid districtID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<District> GetDistrictsByExpression(Func<District, bool> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Faculty> GetFacultiesByExpression(Func<Faculty, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Faculty GetFacultyByID(Guid facultyID)
        {
            throw new NotImplementedException();
        }

        public Grader GetGraderByID(Guid graderID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grader> GetGradersByExpression(Func<Grader, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Province GetProvinceByID(Guid provinceID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> GetProvincesByExpression(Func<Province, bool> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<University> GetUniversitiesByExpression(Func<University, bool> expression)
        {
            throw new NotImplementedException();
        }

        public University GetUniversityByID(Guid universityID)
        {
            throw new NotImplementedException();
        }

        public bool SetCountry(Country model)
        {
            throw new NotImplementedException();
        }

        public bool SetDistrict(District model)
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

        public bool SetListCountries(List<Country> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListDistricts(List<District> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListFaculties(List<Faculty> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListGraders(List<Grader> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListProvinces(List<Province> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListUniversities(List<University> models)
        {
            throw new NotImplementedException();
        }

        public bool SetProvince(Province model)
        {
            throw new NotImplementedException();
        }

        public bool SetUniversity(University model)
        {
            throw new NotImplementedException();
        }
    }
}
