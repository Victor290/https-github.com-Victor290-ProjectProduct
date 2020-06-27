using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.BL.Model
{
    /// <summary>
    /// Тип продукта
    /// </summary>
    public class ProductType
    {
        /// <summary>
        /// Название типа продукта
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Создать новый тип
        /// </summary>
        /// <param name="title"></param>
        public ProductType(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException("Тип продукта не может быть пустым", nameof(title));
            }

            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
