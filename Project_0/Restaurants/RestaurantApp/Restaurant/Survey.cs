using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedSurvey.Web.Models;

namespace RestaurantUI
{
    internal class Survey
    {
        public Vote(User user, Survey survey, Answer answer)
            : this()
        {
            this.User = user;
            this.Survey = survey;
            this.Answer = answer;
        }using System.Data.Entity.Migrations;


namespace AutomatedSurvey.Web.Migrations
    {
        internal sealed class Configuration : RestaurantDL>
        {
            public Configuration()
            {
                AutomaticMigrationsEnable = false;
            }

            protected override void Seed(RestaurantReviews context)
            {
                context.Surveys.AddOrUpdate(
                    survey => new { survey.Id, survey.Title },
                    new Survey { Id = 1, Title = "RestResponse" });

                context.SaveChanges();

                context.Questions.AddOrUpdate(
                    question => new { question.Body, question.Type, question.SurveyId },
                    new reviewQuestion
                    {
                        Body = "Hello. Thanks for taking a survey about your experience. On a scale of 0 to 9 how would you rate our customer service?",
                        Type = QuestionType.Numeric,
                        SurveyId = 1
                    },
                    new reviewQuestion
                    {
                        Body = "On a scale of 0 to 9 how would you rate the Restaurant cleanliness?",
                        Type = QuestionType.Numeric,
                        SurveyId = 1
                    },
                    new reviewQuestion
                    {
                        Body = "On a scale of 0 to 9 how would you rate the Restaurant affordability?",
                        Type = QuestionType.Numeric,
                        SurveyId = 1
                    },
                    new reviewQuestion

                        Body = "On a scale of 0 to 9 how would you rate the Restaurant Accessibility?",
                        Type = QuestionType.Numeric,
                        SurveyId = 1
                    },
                    new reviewQuestion
                    {
                        Body = "In your own words please describe why you chose our establishment above others.",
                        Type = QuestionType.Voice,
                        SurveyId = 1
                    },
                    new reviewQuestion
                    {
                        Body = "On a scale of 0 to 9 how likely are you willing to be a repeat customer?",
                        Type = QuestionType.Numeric,
                        SurveyId = 1
                    });

                        context.SaveChanges();
            }
        }
    

}

