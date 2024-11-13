using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    public class Animal
    {
        // Basic Information
        private string? _name;
        private string? _species;
        private string? _scientificName;
        private string? _classification;
        private double _weight; // in kg
        private double _height; // in cm
        private int _age;
        private string? _gender;
        private bool _isEndangered;

        // Properties with validation and formatting
        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrWhiteSpace(value) ? value.Trim() : throw new ArgumentException("Name cannot be empty");
        }

        public string Species
        {
            get => _species;
            set => _species = !string.IsNullOrWhiteSpace(value) ? value.Trim() : throw new ArgumentException("Species cannot be empty");
        }

        public string ScientificName
        {
            get => _scientificName;
            set => _scientificName = !string.IsNullOrWhiteSpace(value) ? value.Trim() : throw new ArgumentException("Scientific name cannot be empty");
        }

        public string Classification
        {
            get => _classification;
            set => _classification = !string.IsNullOrWhiteSpace(value) ? value.Trim() : throw new ArgumentException("Classification cannot be empty");
        }

        public double Weight
        {
            get => _weight;
            set => _weight = value >= 0 ? value : throw new ArgumentException("Weight must be non-negative");
        }

        public double Height
        {
            get => _height;
            set => _height = value >= 0 ? value : throw new ArgumentException("Height must be non-negative");
        }

        public int Age
        {
            get => _age;
            set => _age = value >= 0 ? value : throw new ArgumentException("Age must be non-negative");
        }

        public string Gender
        {
            get => _gender;
            set => _gender = !string.IsNullOrWhiteSpace(value) ? value.Trim() : throw new ArgumentException("Gender cannot be empty");
        }

        public bool IsEndangered
        {
            get => _isEndangered;
            set => _isEndangered = value;
        }


        // Constructor for basic properties
        public Animal(string name, string species, string scientificName, string classification, string gender)
        {
            Name = name;
            Species = species;
            ScientificName = scientificName;
            Classification = classification;
            Gender = gender;
            Age = 0;
            Weight = 0;
            Height = 0;
            IsEndangered = false;
        }


        /// <summary>
        /// the method is physical measurements
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <exception cref="ArgumentException"></exception>
        public void UpdatePhysicalMeasurements(double weight, double height)
        {
            if (weight < 0 || height < 0)
                throw new ArgumentException("Weight and height must be positive values");

            Weight = weight;
            Height = height;
        }

        /// <summary>
        /// the method to update age
        /// </summary>
        /// <param name="newAge"></param>
        /// <exception cref="ArgumentException"></exception>
        public void UpdateAge(int newAge)
        {
            if (newAge < 0)
                throw new ArgumentException("Age cannot be negative");

            Age = newAge;
        }

        public void SetEndangeredStatus(bool status)
        {
            IsEndangered = status;
        }

        // Basic calculation methods
        public double CalculateBodyMassIndex()
        {
            if (Height <= 0) return 0;
            return (Weight / Math.Pow(Height / 100.0, 2)); // Converting height to meters
        }

        
        public string GetAgeGroup()
        {
            return Age switch
            {
                < 1 => "Infant",
                < 3 => "Young",
                < 7 => "Adult",
                _ => "Senior"
            };
        }


        // Utility Methods

        /// <summary>
        /// this display the  infomation
        /// </summary>
        /// <returns></returns>
        public string GetBasicInfo()
        {
            return $"Name: {Name}\n" +
                   $"Species: {Species}\n" +
                   $"Scientific Name: {ScientificName}\n" +
                   $"Age: {Age} years\n" +
                   $"Weight: {Weight:F1} kg\n" +
                   $"Height: {Height:F1} cm";
        }


    }
}
