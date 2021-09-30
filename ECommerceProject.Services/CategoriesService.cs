using ECommerceProject.Database;
using ECommerceProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Services
{
    public class CategoriesService
    {
        public Category GetCategoryById(int ID)
        {
            using (var context = new EPContext())
            {
                return context.Categories.Find(ID);
            }
        }
        public List<Category> GetCategory()
        {
            using (var context = new EPContext())
            {
                return context.Categories.ToList();
            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new EPContext())
            {
                context.Categories.Add(category);

                context.SaveChanges();
            }
        }
        public void UpdateCategory(Category category)
        {
            using (var context = new EPContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void deleteCategory(int ID)
        {
            using (var context = new EPContext())
            {
               var category = context.Categories.Find(ID);
                context.Entry(category).State = System.Data.Entity.EntityState.Deleted;

                //context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
