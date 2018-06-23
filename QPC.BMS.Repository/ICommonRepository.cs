/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using QPC.BMS.Repository.EF;
    using System;
    using System.Collections.Generic;

    public interface ICommonRepository
    {
        #region Table Country

        /// <summary>
        /// Get all country
        /// </summary>
        /// <returns>List country</returns>
        IEnumerable<Country> GetAllCountries();

        /// <summary>
        /// Get country by lamdar exression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list countries</returns>
        IEnumerable<Country> GetCountriesByExpression(Func<Country, bool> expression);

        /// <summary>
        /// Get country by ID
        /// </summary>
        /// <param name="countryID">country id</param>
        /// <returns>object country</returns>
        Country GetCountryByID(Guid countryID);

        /// <summary>
        /// Insert objcet into database
        /// </summary>
        /// <param name="model">object country</param>
        /// <returns>true or false</returns>
        Boolean SetCountry(Country model);

        /// <summary>
        /// Insert list countries into database
        /// </summary>
        /// <param name="models">list object</param>
        /// <returns>true or false</returns>
        Boolean SetListCountries(List<Country> models);

        /// <summary>
        /// Update country by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditCountryByExpression(Func<Country, bool> expression);

        /// <summary>
        /// Update country by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditCountryByObject(Country modelEdit);

        /// <summary>
        /// Delete country by ID
        /// </summary>
        /// <param name="countryID">country id</param>
        /// <returns>true or false</returns>
        Boolean DeleteCountryByID(Guid countryID);

        /// <summary>
        /// Delete country by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteCountryByExpression(Func<Country, bool> expression);

        /// <summary>
        /// Delete all countries
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllCountries();

        #endregion

        #region Table Province

        /// <summary>
        /// Get all province
        /// </summary>
        /// <returns>List province</returns>
        IEnumerable<Province> GetAllProvinces();

        /// <summary>
        /// Get province by lamdar exression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list provinces</returns>
        IEnumerable<Province> GetProvincesByExpression(Func<Province, bool> expression);

        /// <summary>
        /// Get province by ID
        /// </summary>
        /// <param name="provinceID">province id</param>
        /// <returns>object province</returns>
        Province GetProvinceByID(Guid provinceID);

        /// <summary>
        /// Insert objcet into database
        /// </summary>
        /// <param name="model">object province</param>
        /// <returns>true or false</returns>
        Boolean SetProvince(Province model);

        /// <summary>
        /// Insert list provinces into database
        /// </summary>
        /// <param name="models">list object</param>
        /// <returns>true or false</returns>
        Boolean SetListProvinces(List<Province> models);

        /// <summary>
        /// Update province by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditProvinceByExpression(Func<Province, bool> expression);

        /// <summary>
        /// Update province by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditProvinceByObject(Province modelEdit);

        /// <summary>
        /// Delete province by ID
        /// </summary>
        /// <param name="provinceID">province id</param>
        /// <returns>true or false</returns>
        Boolean DeleteProvinceByID(Guid provinceID);

        /// <summary>
        /// Delete province by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteProvinceByExpression(Func<Province, bool> expression);

        /// <summary>
        /// Delete all provinces
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllProvinces();

        #endregion

        #region Table District

        /// <summary>
        /// Get all district
        /// </summary>
        /// <returns>List district</returns>
        IEnumerable<District> GetAllDistricts();

        /// <summary>
        /// Get district by lamdar exression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list districts</returns>
        IEnumerable<District> GetDistrictsByExpression(Func<District, bool> expression);

        /// <summary>
        /// Get district by ID
        /// </summary>
        /// <param name="districtID">district id</param>
        /// <returns>object district</returns>
        District GetDistrictByID(Guid districtID);

        /// <summary>
        /// Insert objcet into database
        /// </summary>
        /// <param name="model">object district</param>
        /// <returns>true or false</returns>
        Boolean SetDistrict(District model);

        /// <summary>
        /// Insert list districts into database
        /// </summary>
        /// <param name="models">list object</param>
        /// <returns>true or false</returns>
        Boolean SetListDistricts(List<District> models);

        /// <summary>
        /// Update district by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditDistrictByExpression(Func<District, bool> expression);

        /// <summary>
        /// Update district by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditDistrictByObject(District modelEdit);

        /// <summary>
        /// Delete district by ID
        /// </summary>
        /// <param name="districtID">district id</param>
        /// <returns>true or false</returns>
        Boolean DeleteDistrictByID(Guid districtID);

        /// <summary>
        /// Delete district by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteDistrictByExpression(Func<District, bool> expression);

        /// <summary>
        /// Delete all districts
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllDistricts();

        #endregion

        #region Table University

        /// <summary>
        /// Get all universities
        /// </summary>
        /// <returns>List university</returns>
        IEnumerable<University> GetAllUniversities();

        /// <summary>
        /// Get university by lamdar exression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list universities</returns>
        IEnumerable<University> GetUniversitiesByExpression(Func<University, bool> expression);

        /// <summary>
        /// Get university by ID
        /// </summary>
        /// <param name="universityID">university id</param>
        /// <returns>object university</returns>
        University GetUniversityByID(Guid universityID);

        /// <summary>
        /// Insert objcet into database
        /// </summary>
        /// <param name="model">object university</param>
        /// <returns>true or false</returns>
        Boolean SetUniversity(University model);

        /// <summary>
        /// Insert list universities into database
        /// </summary>
        /// <param name="models">list object</param>
        /// <returns>true or false</returns>
        Boolean SetListUniversities(List<University> models);

        /// <summary>
        /// Update university by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditUniversityByExpression(Func<University, bool> expression);

        /// <summary>
        /// Update university by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditUniversityByObject(University modelEdit);

        /// <summary>
        /// Delete university by ID
        /// </summary>
        /// <param name="universityID">university id</param>
        /// <returns>true or false</returns>
        Boolean DeleteUniversityByID(Guid universityID);

        /// <summary>
        /// Delete university by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteUniversityByExpression(Func<University, bool> expression);

        /// <summary>
        /// Delete all universities
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllUniversities();

        #endregion

        #region Table Faculty

        /// <summary>
        /// Get all faculties
        /// </summary>
        /// <returns>List faculty</returns>
        IEnumerable<Faculty> GetAllFaculties();

        /// <summary>
        /// Get faculty by lamdar exression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list faculties</returns>
        IEnumerable<Faculty> GetFacultiesByExpression(Func<Faculty, bool> expression);

        /// <summary>
        /// Get faculty by ID
        /// </summary>
        /// <param name="facultyID">faculty id</param>
        /// <returns>object faculty</returns>
        Faculty GetFacultyByID(Guid facultyID);

        /// <summary>
        /// Insert objcet into database
        /// </summary>
        /// <param name="model">object faculty</param>
        /// <returns>true or false</returns>
        Boolean SetFaculty(Faculty model);

        /// <summary>
        /// Insert list faculties into database
        /// </summary>
        /// <param name="models">list object</param>
        /// <returns>true or false</returns>
        Boolean SetListFaculties(List<Faculty> models);

        /// <summary>
        /// Update faculty by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditFacultyByExpression(Func<Faculty, bool> expression);

        /// <summary>
        /// Update faculty by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditFacultyByObject(Faculty modelEdit);

        /// <summary>
        /// Delete faculty by ID
        /// </summary>
        /// <param name="facultyID">faculty id</param>
        /// <returns>true or false</returns>
        Boolean DeleteFacultyByID(Guid facultyID);

        /// <summary>
        /// Delete faculty by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteFacultyByExpression(Func<Faculty, bool> expression);

        /// <summary>
        /// Delete all faculties
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllFaculties();

        #endregion

        #region Table Grader

        /// <summary>
        /// Get all graders
        /// </summary>
        /// <returns>List grader</returns>
        IEnumerable<Grader> GetAllGraders();

        /// <summary>
        /// Get grader by lamdar exression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list graders</returns>
        IEnumerable<Grader> GetGradersByExpression(Func<Grader, bool> expression);

        /// <summary>
        /// Get grader by ID
        /// </summary>
        /// <param name="graderID">grader id</param>
        /// <returns>object grader</returns>
        Grader GetGraderByID(Guid graderID);

        /// <summary>
        /// Insert objcet into database
        /// </summary>
        /// <param name="model">object grader</param>
        /// <returns>true or false</returns>
        Boolean SetGrader(Grader model);

        /// <summary>
        /// Insert list graders into database
        /// </summary>
        /// <param name="models">list object</param>
        /// <returns>true or false</returns>
        Boolean SetListGraders(List<Grader> models);

        /// <summary>
        /// Update grader by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditGraderByExpression(Func<Grader, bool> expression);

        /// <summary>
        /// Update grader by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditGraderByObject(Grader modelEdit);

        /// <summary>
        /// Delete grader by ID
        /// </summary>
        /// <param name="graderID">grader id</param>
        /// <returns>true or false</returns>
        Boolean DeleteGraderByID(Guid graderID);

        /// <summary>
        /// Delete grader by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteGraderByExpression(Func<Grader, bool> expression);

        /// <summary>
        /// Delete all graders
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllGraders();

        #endregion

    }
}
