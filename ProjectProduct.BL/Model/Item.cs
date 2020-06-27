using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.BL.Model
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Item
    {
        #region Properties
        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; }// убираем сет. и сможем указать имя только один раз при создании класса

        /// <summary>
        /// Тип товара. Инструменты, светильники
        /// </summary>
        public ProductType TypeProduct { get; }
        /// <summary>
        /// Количество товара
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Цена за единицу товара
        /// </summary>
        public double CostPerItem { get; }

        /// <summary>
        /// Дата производства
        /// </summary>
        public DateTime ProductionDate { get; }
        #endregion
        /// <summary>
        /// Создать новую позицию
        /// </summary>
        /// <param name="title"> Наименование. </param>
        /// <param name="type"> Тип. </param>
        /// <param name="count"> Количество. </param>
        /// <param name="cost"> Цена за единицу </param>
        /// <param name="dateProduction"> Дата производства </param>
        public Item(string title, 
                    ProductType type, 
                    int count, 
                    double cost, 
                    DateTime dateProduction)
        {
            #region Check input parameters
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException("Поле название не может быть пустым", nameof(title));
            }
            if(type == null)
            {
                throw new ArgumentNullException("Поле тип не может быть пустым", nameof(type));
            }
            if (count < 0)
            {
                throw new ArgumentException("Поле количество не может быть меньше нуля", nameof(count));
            }
            if (cost < 0)
            {
                throw new ArgumentException("Поле цена не может быть меньше нуля", nameof(count));
            }
            if ((dateProduction < DateTime.Parse("01.01.1960")) || (dateProduction > DateTime.Now))
            {
                throw new ArgumentException("Поле дата должна быть больше 1960 года и меньше сегодняшней даты!", nameof(dateProduction));
            }
            #endregion
            Title = title;
            TypeProduct = type;
            Count = count;
            CostPerItem = cost;
            ProductionDate = dateProduction;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
