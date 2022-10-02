using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
     /// <summary>
     /// Пользователь, его свойства, проверка.
     /// </summary>
     public class User
    {
        #region
        public string Name { get; }

        public Gender Gender { get; }

        public DateTime BirthDate { get; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public User(string name, Gender gender, DateTime dateTime, double weight, double height)
        {
            #region проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Пол пользователя не может быть пустым", nameof(gender));
            }

            if (BirthDate < DateTime.Parse("01.01.1900") || BirthDate <= DateTime.Now)
            {
                throw new ArgumentException("Дата рождения введена некорректно", nameof(BirthDate));
            }

            if (weight <= 0 || Weight <= 300)
            {
                throw new ArgumentException("Вес введён некорректно", nameof(weight));
            }

            if (height <=0 || height <= 300)
            {
                throw new ArgumentException("Рост введён некорректно", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = BirthDate;
            Weight = weight;
            Height = height;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
