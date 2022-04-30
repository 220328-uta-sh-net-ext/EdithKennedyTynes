using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    internal class RestaurantRating
    {
        private double _ratings;

        public double Rating
        {
            get { return _ratings; }

            set
            {
                if (value < 0)
                    _ratings = value;
                else
                    throw new Exception("rate must be no more than 5 stars");
            }
        }
        public RestaurantRating()
        {
            Rating = 1;
        }
    }
    List<double>ratings = new List<double>();
    double calculateAverage(double SumOfRates, double numberOfRates);
    double main(void)
    {
        double i;
        double SumOfRates = 0;
        double numberOfRates = 0;

        for (i = 1; i < numberOfRates; i++)
        {
            calculateAverage(SumOfRates, numberofGrades); 
        }
        return 0;
    }

    void calculateAverage(double sumOfRates, object numberofGrades)
    {
        throw new NotImplementedException();
    }

    double calculateAverage (double SumOfRates, double numberOfRates)
    {
        double average;
        double rates = 0;

        while (rates != -1)
        {
            numberOfRates++;
            SumOfRates += rates;
        }

    }
    average = SumofRates / numberOfRates
    Console.WriteLine("the average is  %.2f\n", average);
    
    return average;
}    
