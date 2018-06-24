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
        IEnumerable<Country> GetCountry(Func<Country, bool> expression);

        /// <summary>
        /// Get country by ID
        /// </summary>
        /// <param name="countryID">country id</param>
        /// <returns>object country</returns>
        Country GetCountry(int countryID);

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
        Boolean SetCountry(List<Country> models);

        /// <summary>
        /// Update country by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditCountry(Func<Country, bool> expression);

        /// <summary>
        /// Update country by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditCountry(Country modelEdit);

        /// <summary>
        /// Delete country by ID
        /// </summary>
        /// <param name="countryID">country id</param>
        /// <returns>true or false</returns>
        Boolean DeleteCountry(int countryID);

        /// <summary>
        /// Delete country by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteCountry(Func<Country, bool> expression);

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
        IEnumerable<Province> GetProvinces(Func<Province, bool> expression);

        /// <summary>
        /// Get province by ID
        /// </summary>
        /// <param name="provinceID">province id</param>
        /// <returns>object province</returns>
        Province GetProvince(int provinceID);

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
        Boolean SetProvince(List<Province> models);

        /// <summary>
        /// Update province by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditProvince(Func<Province, bool> expression);

        /// <summary>
        /// Update province by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditProvince(Province modelEdit);

        /// <summary>
        /// Delete province by ID
        /// </summary>
        /// <param name="provinceID">province id</param>
        /// <returns>true or false</returns>
        Boolean DeleteProvince(Guid provinceID);

        /// <summary>
        /// Delete province by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteProvince(Func<Province, bool> expression);

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
        IEnumerable<District> GetDistrict(Func<District, bool> expression);

        /// <summary>
        /// Get district by ID
        /// </summary>
        /// <param name="districtID">district id</param>
        /// <returns>object district</returns>
        District GetDistrict(int districtID);

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
        Boolean SetDistrict(List<District> models);

        /// <summary>
        /// Update district by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditDistrict(Func<District, bool> expression);

        /// <summary>
        /// Update district by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditDistrict(District modelEdit);

        /// <summary>
        /// Delete district by ID
        /// </summary>
        /// <param name="districtID">district id</param>
        /// <returns>true or false</returns>
        Boolean DeleteDistrict(Guid districtID);

        /// <summary>
        /// Delete district by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteDistrict(Func<District, bool> expression);

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
        IEnumerable<University> GetUniversity(Func<University, bool> expression);

        /// <summary>
        /// Get university by ID
        /// </summary>
        /// <param name="universityID">university id</param>
        /// <returns>object university</returns>
        University GetUniversity(int universityID);

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
        Boolean SetUniversity(List<University> models);

        /// <summary>
        /// Update university by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditUniversity(Func<University, bool> expression);

        /// <summary>
        /// Update university by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditUniversity(University modelEdit);

        /// <summary>
        /// Delete university by ID
        /// </summary>
        /// <param name="universityID">university id</param>
        /// <returns>true or false</returns>
        Boolean DeleteUniversity(Guid universityID);

        /// <summary>
        /// Delete university by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteUniversity(Func<University, bool> expression);

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
        IEnumerable<Faculty> GetFaculty(Func<Faculty, bool> expression);

        /// <summary>
        /// Get faculty by ID
        /// </summary>
        /// <param name="facultyID">faculty id</param>
        /// <returns>object faculty</returns>
        Faculty GetFaculty(int facultyID);

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
        Boolean SetListFaculty(List<Faculty> models);

        /// <summary>
        /// Update faculty by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditFaculty(Func<Faculty, bool> expression);

        /// <summary>
        /// Update faculty by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditFaculty(Faculty modelEdit);

        /// <summary>
        /// Delete faculty by ID
        /// </summary>
        /// <param name="facultyID">faculty id</param>
        /// <returns>true or false</returns>
        Boolean DeleteFaculty(int facultyID);

        /// <summary>
        /// Delete faculty by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteFaculty(Func<Faculty, bool> expression);

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
        IEnumerable<Grader> GetGrader(Func<Grader, bool> expression);

        /// <summary>
        /// Get grader by ID
        /// </summary>
        /// <param name="graderID">grader id</param>
        /// <returns>object grader</returns>
        Grader GetGrader(int graderID);

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
        Boolean SetGrader(List<Grader> models);

        /// <summary>
        /// Update grader by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditGrader(Func<Grader, bool> expression);

        /// <summary>
        /// Update grader by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditGrader(Grader modelEdit);

        /// <summary>
        /// Delete grader by ID
        /// </summary>
        /// <param name="graderID">grader id</param>
        /// <returns>true or false</returns>
        Boolean DeleteGrader(Guid graderID);

        /// <summary>
        /// Delete grader by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteGrader(Func<Grader, bool> expression);

        #endregion

    }
}
