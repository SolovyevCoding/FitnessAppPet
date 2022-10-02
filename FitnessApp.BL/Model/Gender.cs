using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
  /// <summary>
  /// Пол и проверка на null
  /// </summary>
    public class Gender
    {
        public string Name { get; set; }

        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Поле не может быть пустым или null", nameof(name));

            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
