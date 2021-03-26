using Kaatsu.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kaatsu.Models
{
    public class customer
    {
        int id;
        string email;
        string password;
        string firstName;
        string surName;
        string gender;
        string birthdate;
        string role;
        string photo;
        string registrationDate;
        int categoryType;
        int height;
        double weight;
        string sportType;
        bool activeLastYear;
        bool trainKaatsu;
        bool sportInj;
        bool accident;
        bool metadises;
        recommendedTrainingProgram TrainingProgram;
        List <recommendedTrainingProgram> recommendedTrainingPrograms;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SurName { get => surName; set => surName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string Role { get => role; set => role = value; }
        public string Photo { get => photo; set => photo = value; }
        public string RegistrationDate { get => registrationDate; set => registrationDate = value; }
        public int CategoryType { get => categoryType; set => categoryType = value; }
        public int Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public string SportType { get => sportType; set => sportType = value; }
        public bool ActiveLastYear { get => activeLastYear; set => activeLastYear = value; }
        public bool TrainKaatsu { get => trainKaatsu; set => trainKaatsu = value; }
        public bool SportInj { get => sportInj; set => sportInj = value; }
        public bool Accident { get => accident; set => accident = value; }
        public bool Metadises { get => metadises; set => metadises = value; }
        public recommendedTrainingProgram TrainingProggram { get => TrainingProgram; set => TrainingProgram = value; }
        public List<recommendedTrainingProgram> RecommendedTrainingPrograms { get => recommendedTrainingPrograms; set => recommendedTrainingPrograms = value; }

        public customer(string email, string password)
        {

            Email = email;
            Password = password;
        }



        public customer(int id)
        {
            Id = id;
            DBServices dbs = new DBServices();
            RecommendedTrainingPrograms = dbs.getRTP(id);
        }



        public customer() { }

        public customer(customer customer)
        {
            Id = customer.Id;
            Email = customer.Email;
            Password = customer.Password;
            FirstName = customer.FirstName;
            SurName = customer.SurName;
            Gender = customer.Gender;
            Birthdate = customer.Birthdate;
            CategoryType = customer.CategoryType;
            Height = customer.Height;
            Weight = customer.Weight;
            SportType = customer.SportType;
            ActiveLastYear = customer.ActiveLastYear;
            TrainKaatsu = customer.TrainKaatsu;
            SportInj = customer.SportInj;
            Accident = customer.Accident;
            Metadises = customer.Metadises;
        }

        public customer(int id, string email, string password, string firstName, string surName, string gender, string birthdate, string role, string photo, string registrationDate, int categoryType, int height, double weight, string sportType, bool activeLastYear, bool trainKaatsu, bool sportInj, bool accident, bool metadises, recommendedTrainingProgram trainingProgram, List<recommendedTrainingProgram> recommendedTrainingPrograms)
        {
            Id = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            SurName = surName;
            Gender = gender;
            Birthdate = birthdate;
            Role = role;
            Photo = photo;
            RegistrationDate = registrationDate;
            CategoryType = categoryType;
            Height = height;
            Weight = weight;
            SportType = sportType;
            ActiveLastYear = activeLastYear;
            TrainKaatsu = trainKaatsu;
            SportInj = sportInj;
            Accident = accident;
            Metadises = metadises;
            TrainingProgram = trainingProgram;
            RecommendedTrainingPrograms = recommendedTrainingPrograms;
        }

        public customer Check()
        {
            DBServices dbs = new DBServices();
            return dbs.checkUser(this);
        }

        public List<recommendedTrainingProgram> getNewRecommendedTrainingProgram() 
        {
          
            DBServices dbs = new DBServices();
            return RecommendedTrainingPrograms = dbs.getRTP(this.id);
        }

        public List<recommendedTrainingProgram> getRecommendedTrainingProgram()
        {
            return RecommendedTrainingPrograms;
        }

        public customer Insert()
        {
            DBServices dbs = new DBServices();
            return dbs.addNewCustomer(this);
        }

        public List<recommendedTrainingProgram> updateCustomerDet()
        {

            DBServices dbs = new DBServices();
            dbs.updateCustomerDet(this);
            return getNewRecommendedTrainingProgram();

        }

        public recommendedTrainingProgram postTrainingP (recommendedTrainingProgram tPC, int id)
        {
            TrainingProgram = new recommendedTrainingProgram(tPC);
            DBServices dbs = new DBServices();
            TrainingProgram.VideoList = dbs.postTPC(TrainingProgram, id);
            return TrainingProgram;
        }
    }
}